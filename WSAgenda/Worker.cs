using Bus.AgendaClinica.Clinica;
using Dat.Sql;
using Dat.Sql.CitaAD.SedeAD;
using Dat.Sql.ClinicaAD.MedisynAD;
using Ent.Sql.CitaE.SedeE;
using Ent.Sql.ClinicaE.MedisynE;
using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using static Bus.AgendaClinica.Clinica.SitedsWs;
using static Bus.AgendaClinica.Clinica.SynapsisWS.ResponseNotificationOrderApi;
using VariablesGlobales = Bus.AgendaClinica.Clinica.VariablesGlobales;
//using static Bus.AgendaClinica;


namespace WSAgenda
{

    public class Worker : BackgroundService
    {

        AdmisionHospitalariaWs oAdmisionHospitalaria = new AdmisionHospitalariaWs();
        Generales oGenerales = new Generales();
        CorreoAgenda objCorreoAgenda = new CorreoAgenda();

        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        //protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    var timer = new PeriodicTimer(TimeSpan.FromSeconds(4));
        //    Bus.AgendaClinica.Clinica.VariablesGlobales.LoadInitialData();
        //    objCorreoAgenda.CargarDatosIni();
        //    while (await timer.WaitForNextTickAsync(stoppingToken))
        //    {
        //        _logger.LogInformation("Procesando : {time}", DateTimeOffset.Now);

        //        ProcesoServicio01(stoppingToken);
        //        ProcesoServicio02(stoppingToken);
        //    }
        //}

        public async Task ProcesoServicio01(CancellationToken stoppingToken)
        { ProcesoCreaCita(); }

        public async Task ProcesoServicio02(CancellationToken stoppingToken)
        { ProcesoServicio(); }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //var timer = new PeriodicTimer(TimeSpan.FromSeconds(4));
            try
            {
                VariablesGlobales.Grabar_log("Inicia Sistema", VariablesGlobales.NombreServicio);
                while (!stoppingToken.IsCancellationRequested)
                {
                    VariablesGlobales.LoadInitialData();
                    objCorreoAgenda.CargarDatosIni();

                    ProcesoCreaCita();
                    ProcesoServicio();
                    await Task.Delay(1000, stoppingToken);
                }
            }
            catch (Exception ex)
            { VariablesGlobales.Grabar_log("Fin Sistema - Error " + ex.ToString(), VariablesGlobales.NombreServicio); }
        }

        public void ProcesoCreaCita()
        {
            try
            {
                oGenerales.mtProcesoPagoPre();
                oGenerales.mtProcesoPagoPost();
            }
            catch (Exception ex)
            {
                objCorreoAgenda.GuardarMensajeNotepad(ex.ToString(), "ProcesoServicio");
            }
        }

        public async Task ProcesoCreaCitaAsync()
        {
            try
            {
                await Task.WhenAll(
                    oGenerales.mtProcesoPagoPreAsync(),
                    oGenerales.mtProcesoPagoPostAsync()
                );
            }
            catch (Exception ex)
            {
                objCorreoAgenda.GuardarMensajeNotepad(ex.ToString(), "ProcesoServicio");
            }
        }


        public void ProcesoServicio()
        {
            try
            {
                //////objCorreoAgenda.ServicioEnvioCorreoPaciente();
                oAdmisionHospitalaria.MtEnviarCorreosDocumentosPacientes();

                //CountEnviar += 1;
                //if (CountEnviar < 3)
                //    return;
                //oGenerales.mtProcesarPagos();
                oGenerales.mtProcesarPagos();
                oGenerales.mtConfirmarCitas();
                oGenerales.ObtenerPagosVisaNet();

                // oGenerales.mtProcesarAnulaciones() 'JCAICEDO 21/04/2022 - Ya no se usará este método.
                oGenerales.MtEnvioQrEstacionamiento(); // GLLUNCOR - 15/03/2022 [Se envia el correo del QR de estacionamiento al paciente]
            }
            catch (Exception ex)
            {
                objCorreoAgenda.GuardarMensajeNotepad(ex.ToString(), "ProcesoServicio");
            }
        }

        public async Task ProcesoServicioAsync()
        {
            try
            {
                await Task.WhenAll(

                //////objCorreoAgenda.ServicioEnvioCorreoPaciente();
                oAdmisionHospitalaria.MtEnviarCorreosDocumentosPacientesAsync(),
                oGenerales.mtProcesarPagosAsyn(),
                oGenerales.mtConfirmarCitasAsync(),
                oGenerales.ObtenerPagosVisaNetAsync()

                // oGenerales.mtProcesarAnulaciones() 'JCAICEDO 21/04/2022 - Ya no se usará este método.
                //oGenerales.MtEnvioQrEstacionamiento(); // GLLUNCOR - 15/03/2022 [Se envia el correo del QR de estacionamiento al paciente]
                //CountEnviar = 0;

                );



            }
            catch (Exception ex)
            {
                objCorreoAgenda.GuardarMensajeNotepad(ex.ToString(), "ProcesoServicio");
            }
        }




    }
}

public class MiServicio
{
    public string LogName { get; set; }
    public string SourceName { get; set; }

}