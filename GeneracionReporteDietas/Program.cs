/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
    1.0      22/05/2024   CPARRALES       REQ 2024-005448 Mejora de reporte de dietas - Nutrición
********************************************************************************************************************/

using System.Data;
using System.Data.SqlClient;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GeneracionReporteDietas
{
	class Program
	{
		private static IConfiguration _configuration;
		private static ILogger _logger;

		static void Main(string[] args)
		{
			ConfigureServices();
			
			try
			{
				_logger.LogInformation("Inicio del proceso");
				string connectionString = _configuration.GetConnectionString("DefaultConnection");
				string sharedFolderPath = _configuration["SharedFolderPath"];

				var tableHtml = FetchDataFromDatabase(connectionString);
				string shift = DetermineShift();
				var pdfPath = GeneratePdf(tableHtml, sharedFolderPath, shift);
				SendEmailWithPdf(connectionString, pdfPath);
				File.Delete(pdfPath);
				_logger.LogInformation("Fin del proceso");
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Ocurrió un error durante la ejecución del programa.");
			}
		}

		private static string FetchDataFromDatabase(string connectionString)
		{
			string storedProcedure = "Sp_Rce_Obtiene_Dietas";
			var tableHtml = "";

			using (var connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					using (var command = new SqlCommand(storedProcedure, connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						using (var reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								tableHtml += "<tr>";
								for (int i = 0; i < reader.FieldCount; i++)
								{
									if (i == 1) continue;
									tableHtml += "<td>" + reader[i].ToString() + "</td>";
								}
								tableHtml += "</tr>";
							}
						}
					}
				}
				catch (SqlException ex)
				{
					_logger.LogError(ex, "Error al obtener datos de la base de datos.");
					throw;
				}
			}

			return tableHtml;
		}

		private static string GeneratePdf(string tableHtml, string sharedFolderPath, string shift)
		{
			var guid = Guid.NewGuid();
			string pdfPath = Path.Combine(sharedFolderPath, "ReporteDietas" + guid + ".pdf");

			try
			{
				string htmlString = "<html>" +
						"<head>" +
						"    <style>" +
						"        body {" +
						"            width: 290mm;" +
						"            height: 200mm;" +
						"            margin: auto;" +
						"        }" +
						"        table {" +
						"            width: 100%;" +
						"            border-collapse: collapse;" +
						"            table-layout: fixed;" +
						"        }" +
						"        .header {" +
						"            background-color: #22316c;" +
						"            color: white;" +
						"        }" +
						"        th, td {" +
						"            border: 1px solid black;" +
						"            padding: 5px;" +
						"            text-align: left;" +
						"            word-wrap: break-word;" +
						"        }" +
						"        th {" +
						"		     text-align: center;" +
						"		     font-size: 13px;" +
						"        }" +
						"        td {" +
						"		     font-size: 12px;" +
						"        }" +
						"        .table-title {" +
						"            text-align: center;" +
						"            font-size: 18px;" +
						"            margin-top: 20px;" +
						"            margin-bottom: 20px;" +
						"        }" +
						"    </style>" +
						"</head>" +
						"<body>" + 
                        "<div class=\"table-title\">REPORTE DIETÉTICO " + DateTime.Now.ToString("d") + " " + shift + "</div>" +
						"<table>" +
						"    <tr class=\"header\">" +
						"        <th style=\"width: 33px;\">Nº DE HAB</th>" +
						"        <th>APELLIDOS Y NOMBRE DEL PACIENTE</th>" +
						"        <th style=\"width: 70px;\">EDAD (años, meses y días)</th>" +
						"        <th style=\"width: 40px;\">PESO (kg)</th>" +
						"        <th style=\"width: 50px;\">TALLA (cm)</th>" +
						"        <th>DIETA INDICADA + ESPECIFICACIONES</th>" +
						"        <th>ALERGIAS</th>" +
						"        <th>DIAGNÓSTICO MÉDICO</th>" +
						"        <th>MÉDICO QUE PRESCRIBE DIETA</th>" +
                        "        <th>Fecha y Hora de la Prescripción</th>" + //1.0
                         "    </tr>" + tableHtml +
						"</table>" +
						"</body>" +
						"</html>";

				using (PdfWriter writer = new PdfWriter(pdfPath))
				{
					using (PdfDocument pdf = new PdfDocument(writer))
					{
						pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4.Rotate());
						ConverterProperties properties = new ConverterProperties();
						HtmlConverter.ConvertToPdf(htmlString, pdf, properties);
					}
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error al generar el PDF.");
				throw;
			}

			return pdfPath;
		}

		private static void SendEmailWithPdf(string connectionString, string pdfPath)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();
					using (var command = new SqlCommand("Sp_Rce_Envia_Correo_Dietas", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@orden", 2);
						command.Parameters.AddWithValue("@ide_primary", Path.GetFileNameWithoutExtension(pdfPath));
						command.ExecuteNonQuery();
					}
				}
			}
			catch (SqlException ex)
			{
				_logger.LogError(ex, "Error al enviar correo electrónico.");
				throw;
			}
		}

		private static string DetermineShift()
		{
			var currentHour = DateTime.Now.TimeOfDay;
			if (currentHour < new TimeSpan(9, 0, 0))
			{
				return "DESAYUNO";
			}
			else if (currentHour < new TimeSpan(14, 0, 0))
			{
				return "ALMUERZO";
			}
			else
			{
				return "CENA";
			}
		}

		private static void ConfigureServices()
		{
			var appDirectory = AppDomain.CurrentDomain.BaseDirectory;
			var builder = new ConfigurationBuilder()
							   .SetBasePath(appDirectory)
							   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
			_configuration = builder.Build();

			var serviceCollection = new ServiceCollection();
			serviceCollection.AddLogging(configure =>
			{
				configure.AddConfiguration(_configuration.GetSection("Logging"));
				configure.AddConsole();
				var logFilePath = _configuration["Logging:Path"];
				if (!string.IsNullOrEmpty(logFilePath))
				{
					configure.AddProvider(new FileLoggerProvider(logFilePath));
				}
			});

			var serviceProvider = serviceCollection.BuildServiceProvider();
			_logger = serviceProvider.GetService<ILogger<Program>>();
		}
	}
}
