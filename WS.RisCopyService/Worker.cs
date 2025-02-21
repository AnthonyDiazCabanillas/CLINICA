using Microsoft.Extensions.Configuration;
using Bus.Clinica;
using Bus.RisClinica.RisClinica;
using System.Xml.Schema;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using Bus.Clinica.Clinica;
using System.ServiceProcess;
using System.Diagnostics.Contracts;

namespace WS.RisCopyService
{
    public class Worker : BackgroundService
    {

        int Reintento = 0;
        int ReintentoMax = 0;
        int Tiempo = 0;
        string Reinicio = "";
        string NombreServicio = "";
        string RutaAccesoEjecutable = "";
        Ent.Sql.ClinicaE.OtrosE.TablasE oTablas = new Ent.Sql.ClinicaE.OtrosE.TablasE();
        List<Ent.Sql.ClinicaE.OtrosE.TablasE> olistTabla = new List<Ent.Sql.ClinicaE.OtrosE.TablasE>();

        private readonly ILogger<Worker> _logger;
        GeneralesRisCopyService oGRCS = new GeneralesRisCopyService();

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                oGRCS.GrabarLog("--Inicio Servicio--", "");
                VariablesGenerales();
                while (!stoppingToken.IsCancellationRequested || Reintento < ReintentoMax)
                {
                    try
                    {
                        oTablas.Codtabla = "RIS_PACS_SQL";
                        oTablas.Orden = 5;
                        olistTabla = new Bus.Clinica.Clinica.Tablas().ListaConsulta(oTablas);

                        if (olistTabla[0].Estado == "A")
                        {
                            Reintento = 0;
                            oGRCS.CopiarRis();
                            oGRCS.FormatearXMLAgendamiento();
                            oGRCS.CopiarRISCompletado();
                            oGRCS.FormatearXMLCompletado();
                            oGRCS.CopiarPDF();
                            await Task.Delay(1000, stoppingToken);
                        }
                    }
                    catch (Exception ex)
                    {
                        Reintento++;
                        if (ReintentoMax <= Reintento)
                        {
                            var cts = new CancellationTokenSource();
                            cts.Cancel();
                            stoppingToken = cts.Token;
                            oGRCS.GrabarLog("Servicio Detenido: " + NombreServicio, ex.Message.ToString());
                        }
                        else
                        {
                            oGRCS.GrabarLog("Error Servicio:" + NombreServicio + " - Reintento: " + Reintento + " de " + ReintentoMax, ex.Message.ToString());
                            int milisegundo = 1000 * 60 * Tiempo;
                            await Task.Delay(milisegundo, stoppingToken);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oGRCS.GrabarLog("Servicio Detenido: " + NombreServicio, ex.Message.ToString());
            }

        }
        public void VariablesGenerales()
        {
            RutaAccesoEjecutable = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var CurrentDirectory = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(RutaAccesoEjecutable + "\\appsettings.json");
            var configuration = builder.Build();

            ReintentoMax = Convert.ToInt32(configuration["Reinicio:VecesReintentos"]);
            Tiempo = Convert.ToInt32(configuration["Reinicio:Tiempo-Minutos"]);
            Reinicio = configuration["Reinicio:Reinicio"];
            NombreServicio = configuration["Reinicio:NombreServicio"];

            VarGlobal.LoadConectionString(configuration.GetConnectionString("CnnClinica"), VarGlobal.ListDataBase.clinica);
            VarGlobal.LoadConectionString(configuration.GetConnectionString("CnnRisClinica"), VarGlobal.ListDataBase.risclinica);

            oGRCS.GrabarLog("Inicio Servicio", NombreServicio);
        }
    }
}