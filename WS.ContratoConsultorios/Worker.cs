/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using Bus.Clinica;
using Bus.Utilities;
using Bus.Clinica.Clinica;
using System.Reflection;
using Ent.Sql.ClinicaE.OtrosE;
using WS.ContratoConsultorios.Controlller;
using Bus.AgendaClinica.Clinica;

namespace WS.ContratoConsultorios
{
    public class Worker : BackgroundService
    {
        int Reintento = 0;
        int ReintentoMax = 0;
        int Tiempo = 0;
        string? Reinicio = "";
        string? RutaAccesoEjecutable = "";
        string? RutaLogs = "";
        GeneralContratos oGCC = new GeneralContratos();
        ContratoConsultorio CntlrContratos = new ContratoConsultorio();
        Ent.Sql.ClinicaE.OtrosE.TablasE oTablas = new Ent.Sql.ClinicaE.OtrosE.TablasE();
        List<Ent.Sql.ClinicaE.OtrosE.TablasE> olistTabla = new List<Ent.Sql.ClinicaE.OtrosE.TablasE>();

        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        { _logger = logger; }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                InitialVariable();
                while (!stoppingToken.IsCancellationRequested || Reintento < ReintentoMax)
                {
                    try
                    {
                        if (EstadoServicio())
                        {
                            Bus.AgendaClinica.Clinica.VariablesGlobales.Load_Initial_Synapsis();
                            Reintento = 0;
                            CntlrContratos.ProcesarContratos();
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
                            GrabarLog("Servicio Detenido: " + VarGlobal.NombreServicio, ex.Message.ToString());
                        }
                        else
                        {
                            GrabarLog("Error Servicio:" + VarGlobal.NombreServicio + " - Reintento: " + Reintento + " de " + ReintentoMax, ex.Message.ToString());
                            int milisegundo = 1000 * 60 * Tiempo;
                            await Task.Delay(milisegundo, stoppingToken);
                        }
                    }
                }
            }
            catch (Exception ex)
            { GrabarLog("Servicio Detenido: " + VarGlobal.NombreServicio, ex.Message.ToString()); }
        }
        private void InitialVariable()
        {
            //RutaAccesoEjecutable = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            VarGlobal.RutaInstalacion = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var CurrentDirectory = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(VarGlobal.RutaInstalacion + "\\appsettings.json");
            var configuration = builder.Build();

            ReintentoMax = Convert.ToInt32(configuration["Reinicio:VecesReintentos"]);
            Tiempo = Convert.ToInt32(configuration["Reinicio:Tiempo-Minutos"]);
            Reinicio = configuration["Reinicio:Reinicio"];
            VarGlobal.NombreServicio = configuration["Datos:NombreServicio"];
            VarGlobal.NombreNoteLog = configuration["Rutas:NameLog"];
            VarGlobal.DirrecionLog = configuration["Rutas:RutaLog"];
            ContratoConsultorio.URLApiClinica = configuration["URL:ApiClinica"];
            VarGlobal.LoadConectionString(configuration.GetConnectionString("CnnClinica"), VarGlobal.ListDataBase.clinica);
            VarGlobal.LoadIGV();
            Bus.AgendaClinica.Clinica.VariablesGlobales.Load_Initial_Synapsis();
            GrabarLog("Inicio Servicio", VarGlobal.NombreServicio);
        }

        private bool EstadoServicio()
        {
            oTablas.Codtabla = "WS_ContratoConsultorios";
            oTablas.Orden = 5;
            olistTabla = new Bus.Clinica.Clinica.Tablas().ListaConsulta(oTablas);

            if (olistTabla[0].Estado.ToString() == "A")
            { return true; }
            return false;
        }

        private void GrabarLog(string? pMetodo, string? pMensaje)
        { VarGlobal.Grabar_log(pMensaje, pMetodo); }
    }
}
