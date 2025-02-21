//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 Tarea para envió de documentos digitalizados
//****************************************************************************************
using System.Data;
using System.Data.SqlClient;
using Ent.Sql.ClinicaE.HospitalE;
using WsEnvioDocumentoDigitalizacion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Dat.Sql.ClinicaAD.HospitalDocAD;
using Ent.Sql.ClinicaE.HospitalDocE;
using Dat.Sql;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Security.Policy;
using Ent.Sql.ClinicaE.OtrosE;
using Dat.Sql.ClinicaAD.OtrosAD;
using static Ent.Sql.ClinicaE.OtrosE.CitaAgendaE;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Ent.Sql.ClinicaE.EspecialidadesE;
using static WsEnvioDocumentoDigitalizacion.ResultadoEnvio;
using Dat.Sql.ClinicaAD.RisAD;

namespace WsEnvioDocumentoDigitalizacion
{
    class Program
    {
        private static IConfiguration _configuration;
        private static ILogger _logger;
        private static string UrlToken;
        private static string UrlEnvioDoc;
        private static int TiempoDefecto;

        public class ServiciosSettings
        {
            public string UrlToken { get; set; }
            public string UrlEnvioDoc { get; set; }
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

        static TokenRequest ObtenerCredenciales()
        {
            var pTokenRequest = new TokenRequest();
            var pTablas = new TablasE("TOKENAPISCANFLOW", "", 1, 5, -1);
            var LTablas = new TablasAD().Sp_Tablas_Consulta(pTablas);

            pTokenRequest.username = LTablas[0].Nombre.ToString();
            pTokenRequest.password = LTablas[1].Nombre.ToString();
            
            UrlToken = LTablas[2].Nombre.ToString();
            UrlEnvioDoc = LTablas[3].Nombre.ToString();
            TiempoDefecto = Convert.ToInt32(LTablas[4].Nombre);
            return pTokenRequest;
        }

        static List<ResultadoEnvio> AgruparInfo(List<HospitalE.ListarEnvioDoc> LHospitalDoc)
        {
            var LResultadoEnvio = new List<ResultadoEnvio>();
            
            foreach (var info in LHospitalDoc)
            {
                var oDocumentos = new ResultadoEnvio.Documento();
                oDocumentos.idDocumento = info.id_documento;
                oDocumentos.idTipoDocumento = info.idTipoDocumento;
                oDocumentos.nombre = info.nombreDocumento;
                oDocumentos.archivo = info.base64_documento;
                oDocumentos.extencion = info.extension;
                oDocumentos.eliminar = info.eliminar;

                var oAtenciones = new ResultadoEnvio.Atencion();
                oAtenciones.numero = info.codatencion;
                oAtenciones.idTipoAtencion = info.idTipoAtencion;
                oAtenciones.tipoAtencion = info.tipoAtencion;
                oAtenciones.sede = info.Sede;
                oAtenciones.nombreMedico = info.nombreMedico;
                oAtenciones.especialidadMedico = info.especialidadMedico;
                oAtenciones.fechaAtencion = info.fechainicio;
                oAtenciones.documento = oDocumentos;

                var oResultadoEnvio = new ResultadoEnvio();
                oResultadoEnvio.numero = info.numero;
                oResultadoEnvio.numeroHistoriaClinca = info.numeroHC;
                oResultadoEnvio.nombrePaciente = info.nombrePaciente;
                oResultadoEnvio.apellidosdelPaciente = info.apellidosPaciente;
                oResultadoEnvio.atencion = oAtenciones;

                LResultadoEnvio.Add(oResultadoEnvio);
            }

            return LResultadoEnvio;
        }

        static async Task<TokenResponse> ObtenerTokenAsync()
        {
            var pTokenRequest = ObtenerCredenciales();
            var pTokenResponse = new TokenResponse();

            string jsonData = JsonConvert.SerializeObject(pTokenRequest);

            using (var client = new HttpClient())
            {
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(UrlToken, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    pTokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseString);
                }
            }
            return pTokenResponse;
        }

        static async Task<ResponseApiScanFlow> EnviarDocumentoAsync(string jsonData, string token, int numDocumento)
        {
            var oResponseApiScanFlow = new ResponseApiScanFlow();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.Timeout = TimeSpan.FromSeconds(TiempoDefecto);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(UrlEnvioDoc, content);
                var responseString = await response.Content.ReadAsStringAsync();

                oResponseApiScanFlow.CodRespuesta = Convert.ToInt32(response.StatusCode);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    oResponseApiScanFlow.esEnviado = true;
                    return oResponseApiScanFlow;
                }
                else
                {
                    oResponseApiScanFlow.esEnviado = false;
                    return oResponseApiScanFlow;
                }
            }
        }

        static bool ActualizarDocumento(int id_documento, bool EsExitoso)
        {
            string Exito = (EsExitoso == true) ? "1" : "0"; 
            var pDoc = new HospitalDocE(id_documento, "", null, "flg_enviodigital");
            bool Esctualizado = new HospitalDocAD().Sp_HospitalDoc_UpdatexCampo(pDoc);

            var pDocExitoso = new HospitalDocE(id_documento, Exito, null, "flg_envioexitoso");
            Esctualizado = new HospitalDocAD().Sp_HospitalDoc_UpdatexCampo(pDocExitoso);
            return Esctualizado;
        }

        static void EnviarCorreo(string cuerpo)
        {
            string asunto = "Digitalización - Error con el servicio";
            var oCorreoE = new CorreoE(asunto, cuerpo);
            new SisCorreoAD().Sp_CorreoDigitalizacion(oCorreoE);
        }

        static async Task Main(string[] args)
        {
            try
            {
                ConfigureServices();

                _logger.LogInformation("Inicio del proceso");
                VariablesGlobales.CnnClinica = _configuration.GetConnectionString("DefaultConnection");

                int contadorTotal = 0;
                bool hayMasRegistros = true;
                Dictionary<int, int> intentosFallidos = new Dictionary<int, int>();
                
                //Bucle hasta que no haya más registros por procesar
                while (hayMasRegistros)
                {
                    int orden = 1;
                    var LHospitalDoc = await new HospitalDocAD().ListarEnvioDocAsync(orden);
                    if (LHospitalDoc.Count == 0)
                    {
                        hayMasRegistros = false;
                        break;
                    }

                    // Agrupado por documento y atención (Formato Api ScanFlow)
                    var LInfoAgrupada = AgruparInfo(LHospitalDoc);
                    var oTokenResponse = await ObtenerTokenAsync();

                    if (oTokenResponse.token == null)
                    {
                        hayMasRegistros = false;
                        string MensajeError = "No se pudo general el token, verificar la cuenta de acceso y/o endpoint del proveedor ScanFlow - Digitalización";
                        EnviarCorreo(MensajeError);
                        _logger.LogWarning(MensajeError);
                        break;
                    }

                    // Recorrer info agrupada y enviar al API ScanFlow
                    int contador = 0;
                    foreach (var info in LInfoAgrupada)
                    {
                        var numDocumento = info.atencion.documento.idDocumento;
                        var jsonEnvio = JsonConvert.SerializeObject(info);

                        // Verificar si el documento ha fallado 3 veces
                        if (intentosFallidos.ContainsKey(numDocumento) && intentosFallidos[numDocumento] >= 3)
                        {
                            string MensajeError = "El documento con ID " + numDocumento.ToString() + " falló 3 veces y no se volverá a intentar.";
                            EnviarCorreo(MensajeError);
                            _logger.LogWarning(MensajeError);
                            continue;
                        }

                        // Intentar enviar el documento
                        var oResponse = await EnviarDocumentoAsync(jsonEnvio, oTokenResponse.token, numDocumento);

                        if (oResponse.esEnviado)
                        {
                            contador++;
                            ActualizarDocumento(info.atencion.documento.idDocumento, oResponse.esEnviado);
                            if (intentosFallidos.ContainsKey(numDocumento))
                            {
                                intentosFallidos.Remove(numDocumento);
                            }
                        }
                        else
                        {
                            if (oResponse.CodRespuesta == 404)
                            {
                                hayMasRegistros = false;
                                string MensajeError = "Error: "+oResponse.CodRespuesta.ToString()+" EndPoint no disponible verificar el Api de ApiScanFlow";
                                EnviarCorreo(MensajeError);
                                _logger.LogWarning(MensajeError);
                                break;
                            }

                            // Incrementar el contador de fallos para el documento
                            if (intentosFallidos.ContainsKey(numDocumento))
                            {
                                intentosFallidos[numDocumento]++;
                            }
                            else
                            {
                                intentosFallidos[numDocumento] = 1;
                            }

                            // Registrar en log si el documento falla 3 veces
                            if (intentosFallidos[numDocumento] == 3)
                            {
                                ActualizarDocumento(info.atencion.documento.idDocumento, oResponse.esEnviado);
                                _logger.LogWarning($"El documento con ID {numDocumento} falló 3 veces.");
                            }
                        }
                    }

                    contadorTotal += contador;
                    _logger.LogInformation($"Procesados {contador} documentos en esta pasada. Total enviados hasta ahora: {contadorTotal}");
                }

                //Enviar los documentos que no lograron tener exito
                int contadorNew = 0;
                int ordenRechazado = 2;
                var LHospitalDocRechazado = await new HospitalDocAD().ListarEnvioDocAsync(ordenRechazado);
                if (LHospitalDocRechazado.Count > 0)
                {
                    // Agrupado por documento y atención (Formato Api ScanFlow)
                    var LInfoAgrupada = AgruparInfo(LHospitalDocRechazado);
                    var oTokenResponse = await ObtenerTokenAsync();

                    if (oTokenResponse.token != null)
                    {
                        foreach (var info in LInfoAgrupada)
                        {
                            var numDocumento = info.atencion.documento.idDocumento;
                            var jsonEnvio = JsonConvert.SerializeObject(info);
                            var oResponse = await EnviarDocumentoAsync(jsonEnvio, oTokenResponse.token, numDocumento);

                            if (oResponse.esEnviado)
                            {
                                contadorNew++;
                                ActualizarDocumento(info.atencion.documento.idDocumento, oResponse.esEnviado);
                            }
                        }
                    }
                }

                contadorTotal += contadorNew;
                _logger.LogInformation($"Envio documentos fallidos: Procesados {contadorNew} documentos en esta pasada. Total enviados hasta ahora: {contadorTotal}");
                _logger.LogInformation($"Fin del proceso: Se enviaron {contadorTotal} documentos en total.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error durante la ejecución del programa.");
            }
        }

        public class ResponseApiScanFlow
        {
            public bool esEnviado { get; set; }
            public int CodRespuesta { get; set; }
        }

    }
}
