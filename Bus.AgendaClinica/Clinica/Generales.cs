/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
 1.1           20/09/2024  HVIDAL      REQ 2024-018539: Mejora QR cuando el FileServer no esta disponible
====================================================================================================*/
using Dat.Sql;
using Dat.Sql.ClinicaAD.ComprobantesAD;
using Dat.Sql.ClinicaAD.HospitalAD;
using Dat.Sql.ClinicaAD.LiquidacionesAD;
using Dat.Sql.ClinicaAD.MedisynAD;
using Dat.Sql.ClinicaAD.OtrosAD;
using Dat.Sql.ClinicaAD.PacientesAD;
using Dat.Sql.ClinicaAD.PagosCuentaAD;
using Dat.Sql.ClinicaAD.PresotorAD;
using Dat.Sql.ClinicaAD.SitedsAD;
using Ent.Sql.ClinicaE.ComprobantesE;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.LiquidacionesE;
using Ent.Sql.ClinicaE.MedisynE;
using Ent.Sql.ClinicaE.OtrosE;
//    Ent.Sql.ClinicaE.OtrosE
using Ent.Sql.ClinicaE.PacientesE;
using Ent.Sql.ClinicaE.PagosCuentaE;
using Ent.Sql.ClinicaE.PresotorE;
using Ent.Sql.ClinicaE.SitedsE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WsTciComprobantes;
using static Bus.AgendaClinica.Clinica.SitedsWs;
using static Bus.AgendaClinica.Clinica.VariablesGlobales;
using Bus.Utilities;
using System.Collections;
using Microsoft.VisualBasic;
using Bus.Clinica.Clinica;
using Ent.Sql.ClinicaE.ContratosE;
using System.Diagnostics;
using Bus.Clinica;
using static Bus.AgendaClinica.Clinica.SynapsisWS.ResponseNotificationOrderApi;
using System.Runtime.Intrinsics.X86;
using Ent.Sql.ProveedorE.TCI;
using Ent.Sql.CitaE.SedeE;

namespace Bus.AgendaClinica.Clinica
{
    public class Generales
    {

        General funcGeneral = new General();
        ////Bus.Utilities.General util = new Bus.Utilities.General();
        Utilitario util = new Utilitario();


        #region PROPIEDADES
        // Propiedades de la Sunasa
        string CodSunasa = "";
        string CodIAFAS = "";
        string CodRuc = "20100162742";
        //string RutaPDFSiteds = "";

        List<TablasE> oLTablas = new List<TablasE>();

        // Datos Propios Obtenidos de Clinica
        string DscNombresPaciente = "";
        string Sexo = ""; // Este valor se obtiene de pacientes
        DateTime FechaNacimiento = new DateTime(1900, 01, 01);
        string CardCode = "";
        string TipDocumento = "";
        string DocIdentidad = "";
        string DscCorreo = "";
        string CodEmpresa = "001";
        string TipoAtencion = "";
        string CodSede = "";
        string Direccion = "";
        string TipParentesco = "";
        DateTime FechaCita;
        string EstConsultaMedica = "P";
        string NombrePaciente = "";
        string ApPaternoPaciente = "";
        string ApMaternoPaciente = "";

        string CodPaciente = "";
        string DscNombresTitular = "";
        string CodMedico = "";
        string CodEspecialidad = "";
        string CodPoliza = "";
        string NumeroPlanPoliza = "";
        string CodAseguradora = "";
        string DscAseguradora = "";
        string CodCia = ""; // Este dato estaba en pantalla
        string CodigoAutorizacion = "";
        string Tarifa = ""; // Este valor se obtiene al capturar la tarifa (metodo: Sp_CapturarTarifaAtencion)
        string Observaciones = "";
        string CodAsegurado = "";
        string TipoAfiliacion = "";
        string TipoPago = "T"; // E-Efectivo, T-Tarjeta, ..,
        string CodCobertura = "";
        string CoPagoFijo = "";
        string CoPagoVariable = "";
        int IdeDatosPagos = 0;
        string TipMoneda = "";
        string CodNombreEntidad = "Nro Operación";
        string NumEntidad = "001";
        string TipProductoAseguradora = "";
        string NumDocEmpresa = "";
        string TipDocEmpresa = "";

        string Comprobante_CodTipoComprobante = "";
        string Comprobante_TipDocIdentidad = "";
        string Comprobante_RutDocIdentidad = "";
        string Comprobante_DscCorreoComprobante = "";
        string Comprobante_NombresComprobante = "";

        string LineasCoberturas = "";

        string CodAtencion = "";
        string CodLiquidacion = "";

        string CodSubTipoCobertura = "";

        int EstProcesoAtencion = 0;

        // Parametros por Defecto
        string CodPresotor = "";
        string CorrelativoSerieBoleta = "";
        string CorrelativoSerieFactura = "";
        string CorrelativoSerieNotaCreditoBoleta = "";
        string CorrelativoSerieNotaCreditoFactura = "";
        bool FlgElectronico = false;
        bool FlgGenerarE = false;
        string FlgOtorgarBoleta = "0";
        string FlgOtorgarFactura = "0";
        string FlgOtorgarNotaCredito = "0";
        string CodTipoConsultaMedica = "A";

        string CodComprobante = "";
        string xEnviarASunat = "";
        string xUrlWsTCI = "http://egestor.ubl21.efacturacion.pe/WS_TCI/Service.asmx";
        string RutaWS_Siteds = "http://200.48.199.90/WSSITEDS/Sistema/";
        #endregion



        #region PROPIEDADES SITEDS
        SitedsWs oWsSiteds;

        AsegNombRequest oAsegNombRequest = new AsegNombRequest();
        ObservacionRequest oObservacionRequest = new ObservacionRequest();
        AsegCodRequest oAsegCodRequest = new AsegCodRequest();
        NumeroAutorizacionRequest oNumAutorizacionRequest = new NumeroAutorizacionRequest();

        // Dim oFotoRequest As New FotoRequest
        CasoTiempoEsperaRequest oCasoTiempoEsperaRequest = new CasoTiempoEsperaRequest();
        ProcedimientosEspecialesRequest oProcedimientosEspecialesRequest = new ProcedimientosEspecialesRequest();
        AsegNombResponse oAsegNomb = new AsegNombResponse();

        DatosGeneralesE oDatosGenerales = new DatosGeneralesE();
        Coberturas_AcredE oCoberturas_Acred = new Coberturas_AcredE();
        ExcepCarenciaE oExcepCarencia = new ExcepCarenciaE();
        ProcedimientosE oProcedimientos = new ProcedimientosE();
        ProductoE oProducto = new ProductoE();
        SubTipoCoberturaE oSubTipoCobertura = new SubTipoCoberturaE();
        #endregion

        #region Propiedades
        private string VisaNet_Ws_Url = "https://apiprod.vnforapps.com";
        private string VisaNet_ApiKeyAutorizacion_App = "Basic bWJlbml0ZXNAY2xpbmljYXNhbmZlbGlwZS5jb206P3MzM0VtLVo=";
        private string VisaNet_ApiKeyAutorizacion_Web = "";
        private string VisaNet_merchantId_App = "650166373";
        private string VisaNet_merchantId_Web = "650166372";

        private string VisaNet_ApiAutorizacion = "";

        private string RutaGuardarQR = "";
        private string UrlQR = "";
        #endregion



        #region Sp_MdsynAmReserva_Consulta
        //public List<MdsynAmReservaE> Sp_MdsynAmReserva_Consulta(MdsynAmReservaE pMdsynAmReservaE)
        //{
        //    var oList = new List<MdsynAmReservaE>();
        //    oList = new MdsynAmReservaAD().Sp_MdsynAmReserva_Consulta(pMdsynAmReservaE);
        //    return oList;
        //}
        public List<MdsynAmReservaE> Sp_Mdsyn_Cita_Consulta(MdsynAmReservaE pMdsynAmReservaE)
        {
            var oList = new List<MdsynAmReservaE>();
            oList = new MdsynAmReservaAD().Sp_Mdsyn_Cita_Consulta(pMdsynAmReservaE);
            return oList;
        }

        public async Task<List<MdsynAmReservaE>> Sp_Mdsyn_Cita_Consulta_Async(MdsynAmReservaE pMdsynAmReservaE)
        {
            var oList = new List<MdsynAmReservaE>();
            oList = await Task.Run(() => new MdsynAmReservaAD().Sp_Mdsyn_Cita_Consulta(pMdsynAmReservaE));
            return oList;
        }


        #endregion


        public void MtEnvioQrEstacionamiento()
        {
            try
            {
                var oList = new List<MdsynAmReservaE>();
                //oList = new MdsynAmReservaAD().Sp_MdsynAmReserva_Consulta(new MdsynAmReservaE(0, 0, "", "", "", "", "", "", 11));
                oList = new MdsynAmReservaAD().Sp_Mdsyn_Cita_Consulta(new MdsynAmReservaE(0, 0, "", "", "", "", "", "", "11"));
                var oMdsynAmReservaE = new MdsynAmReservaE();

                for (int index = 0, loopTo = oList.Count - 1; index <= loopTo; index++)
                {
                    oMdsynAmReservaE = new MdsynAmReservaE();
                    oMdsynAmReservaE = oList[index];
                    oMdsynAmReservaE.DscNombreQR = DateTime.Now.ToString("yyyyMMddHHmmss") + Guid.NewGuid().ToString().Substring(1, 10) + oMdsynAmReservaE.CodAtencion + ".jpg";
                    oMdsynAmReservaE.DscPathQr = RutaGuardarQR + oMdsynAmReservaE.DscNombreQR;

                    byte[] imgQR = Bus.Utilities.QR.QR_(oMdsynAmReservaE.DscQr);
                    bool EsExito = GrabaQREnCarpeta(oMdsynAmReservaE.DscNombreQR, imgQR);//Hvidal

                    if (EsExito)
                    {
                        //Se envia el nombre del archivo QR y desde este mismo store se envia el correo.
                        //new MdsynAmReservaAD().Sp_MdsynAmReserva_UpdatexCampo(new MdsynAmReservaE(oMdsynAmReservaE.IdeReserva, oMdsynAmReservaE.DscNombreQR, "dsc_nombre_qr", 0));
                        //HVIDAL 15/02/2024
                        if (oMdsynAmReservaE.IDCita == 0)
                        {
                            var oHospital = new Hospital();
                            var pHospitalQR = new HospitalE.HospitalQR();
                            pHospitalQR.codatencion = oMdsynAmReservaE.CodAtencion;
                            pHospitalQR.dsc_nombre_qr = oMdsynAmReservaE.DscNombreQR;
                            //Se actualiza el nombre del archivo QR y desde este mismo store se envia el correo.
                            oHospital.Sp_hospitalqr_Actualizar(pHospitalQR);
                        }
                        else
                        {
                            new MdsynAmReservaAD().Sp_Mdsyn_Cita_UpdatexCampo(new MdsynAmReservaE(oMdsynAmReservaE.IDCita, oMdsynAmReservaE.DscNombreQR, "dsc_nombre_qr", 0));
                        }
                        //HVIDAL 15/02/2024
                    }
                    //INI 1.1 HVIDAL
                    else
                    {
                        new CorreoAgenda().GuardarMensajeNotepad("No se puedo conectar al recurso compartido del QR", "MtEnvioQrEstacionamiento_GenerarQR");
                    }
                    //FIN 1.1
                }
            }
            catch (Exception ex)
            {
                Guardar_Error_BaseDatos(ex.ToString(), "Enviar Correo Qr Estacionamiento");
            }
            new TablasAD().Sp_Tablas_Update(new TablasE("MEDISYN_FECHA_QR", "01", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), "nombre"));
        }

        //HVIDAL - GrabaQREnCarpeta 15/02/2024
        public bool GrabaQREnCarpeta(string DscNombreQR, byte[] imgQR)
        {
            // Especifica la ruta de red y el nombre del archivo en la ubicación de destino.
            string rutaDeRed = pValorCodigoTabla("RUTAFOTOQR", "02");  //@"\\servidor\compartido\carpeta_destino";
                                                                       //string nombreArchivo = pMedicoObsAuxE.NombreFoto; //"archivo.txt";
            string nombreArchivo = DscNombreQR;
            string archivoCompleto = Path.Combine(rutaDeRed, nombreArchivo);
            string username = VariablesGlobales.UserRedQR;//string username = pValorCodigoTabla("RUTAFOTOQR", "03");
            string password = VariablesGlobales.ClaveRedQR;//string password = pValorCodigoTabla("RUTAFOTOQR", "04");
            //INI 1.1
            bool EsExito = false;
            //FIN 1.1

            // Ejecuta el comando 'net use' para conectar al recurso compartido
            var netUseProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net",
                    Arguments = $@"use {rutaDeRed} /user:{username} {password}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            netUseProcess.Start();
            netUseProcess.WaitForExit();

            if (netUseProcess.ExitCode == 0)
            {
                try
                {
                    // Puedes copiar los datos al recurso compartido en red
                    System.IO.File.WriteAllBytes(archivoCompleto, imgQR);
                    //INI 1.1
                    EsExito = true;
                    //FIN 1.1
                }
                catch (Exception ex)
                {
                    //INI 1.1
                    new CorreoAgenda().GuardarMensajeNotepad(ex.Message, "Error al escribir los datos en el archivo remoto");
                    //FIN 1.1
                }
                finally
                {
                    // Desconecta el recurso compartido en red
                    var netUseDeleteProcess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "net",
                            Arguments = $@"use {rutaDeRed} /delete",
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };

                    netUseDeleteProcess.Start();
                    netUseDeleteProcess.WaitForExit();
                }
            }
            //INI 1.1
            return EsExito;
            //FIN 1.1
        }

        //mBardales - pValorCodigoTabla - INICIO - 15/01/2024
        private string pValorCodigoTabla(string tabla, string codigo)
        {
            string resultado = "";
            List<TablasE> oList;
            oList = new TablasAD().Sp_Tablas_Consulta(new TablasE(tabla, codigo, 50, 1, -1));
            if (oList.Count >= 1) resultado = oList[0].Nombre.Trim();
            return resultado;
        }
        //mBardales - pValorCodigoTabla - FIN - 15/01/2024


        #region ObtenerPagosVisaNet
        public async Task ObtenerPagosVisaNetAsync()
        {
            await Task.Run(() => ObtenerPagosVisaNet()).ConfigureAwait(false);
        }

        public void ObtenerPagosVisaNet()
        {
            try
            {
                var oList = new List<MdsynDatosPagosE>();
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 10)); // Mobile
                if (oList.Count != 0)
                {
                    VisaNet_ApiAutorizacion = fnObtenerAutorizacionApi(VisaNet_ApiKeyAutorizacion_App);
                    ObtenerPagosPorPlataforma(oList, VisaNet_merchantId_App);
                }

                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 11)); // Web
                if (oList.Count != 0)
                {
                    VisaNet_ApiAutorizacion = fnObtenerAutorizacionApi(VisaNet_ApiKeyAutorizacion_Web);
                    ObtenerPagosPorPlataforma(oList, VisaNet_merchantId_Web);
                }
            }
            catch (Exception ex)
            {
                VisaNet_ApiAutorizacion = "";
                Guardar_Error_BaseDatos(ex.ToString(), "ObtenerPagosVisaNet");
            }
            new TablasAD().Sp_Tablas_Update(new TablasE("MEDISYN_FECHA_OBTENER_PAGOVISA", "01", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), "nombre"));
        }
        #endregion

        #region fnObtenerAutorizacionApi
        private string fnObtenerAutorizacionApi(string VisaNet_ApiKeyAutorizacion)
        {
            return Json.MethodSignature(Json.MethodJson.POST, VisaNet_Ws_Url + "/api.security/v1/security", "", true,
                new Json.Parameters("Authorization", VisaNet_ApiKeyAutorizacion, Json.TipoFormat.Header));
        }
        #endregion


        #region ObtenerPagosPorPlataforma
        private void ObtenerPagosPorPlataforma(List<MdsynDatosPagosE> oList, string VisaNet_merchantId)
        {
            string rpta = "";
            string jsonBody = "";

            string QueryType = "purchase";
            string identifier = "";

            var objVenta = new ResponseConsultaVentaRealizadaVisaNet();
            string EstPagoExitoso = "";

            try
            {
                for (int i = 0, loopTo = oList.Count - 1; i <= loopTo; i++)
                {
                    identifier = oList[i].NroOperacion.ToString();
                    rpta = Json.MethodSignature(Json.MethodJson.GET, VisaNet_Ws_Url + ("/api.authorization/v3/retrieve/" + QueryType + "/" + VisaNet_merchantId + "/" + identifier + ""), jsonBody, true, new Json.Parameters("accept", "application/json", Json.TipoFormat.Header), new Json.Parameters("Authorization", VisaNet_ApiAutorizacion, Json.TipoFormat.Header));

                    objVenta = new ResponseConsultaVentaRealizadaVisaNet();
                    objVenta = (ResponseConsultaVentaRealizadaVisaNet)Newtonsoft.Json.JsonConvert.DeserializeObject(rpta, typeof(ResponseConsultaVentaRealizadaVisaNet));

                    if (objVenta != null)
                    {
                        EstPagoExitoso = fnObtenerEstadoPagoExitoso(objVenta);
                        if (EstPagoExitoso != "X")
                        {
                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Update_V2(new MdsynDatosPagosE(oList[i].IdeDatospagos, "", "", "", "", 2, objVenta.dataMap.STATUS + "-Servicio", EstPagoExitoso, objVenta.dataMap.BRAND, objVenta.dataMap.CARD, "", rpta));
                        }
                        else
                        {
                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Update_V2(new MdsynDatosPagosE(oList[i].IdeDatospagos, "", "", "", "", 2, "Servicio", EstPagoExitoso, "", "", "", rpta));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                VisaNet_ApiAutorizacion = "";
                Guardar_Error_BaseDatos("Nro Operación:" + identifier + "<br/>" +
                                        "Codigo Comercio - Portal: " + VisaNet_merchantId + " - " + (VisaNet_merchantId == VisaNet_merchantId_App ? "App" : "Web") + "<br/>" +
                                        "Rpta: " + rpta + "<br/>" +
                                        "Descripción: " + ex.ToString(), "ObtenerPagosPorPlataforma");
            }

        }
        #endregion



        #region fnObtenerEstadoPagoExitoso
        private string fnObtenerEstadoPagoExitoso(ResponseConsultaVentaRealizadaVisaNet objVentaRealizada)
        {
            string xResult = "";

            if (objVentaRealizada.errorCode == 400)
            {
                xResult = "X";
            }
            else if (objVentaRealizada.order.actionCode == "000")
            {
                xResult = "S";
            }
            else
            {
                xResult = "N";
            }

            return xResult;
        }
        #endregion




        #region mtConfirmarCitas

        public async Task mtConfirmarCitasAsync()
        {
            await Task.Run(() => mtConfirmarCitas()).ConfigureAwait(false);
        }

        public RespuestaE mtConfirmarCitas()
        {
            var oRespuestaE = new RespuestaE();
            var oMdsynAmReservaE = new MdsynAmReservaE();
            var oList = new List<MdsynAmReservaE>();

            oList = new MdsynAmReservaAD().Sp_Mdsyn_Cita_Consulta(new MdsynAmReservaE(0, 0, "", "", "", "", "", "", "7"));
            for (int i = 0, loopTo = oList.Count - 1; i <= loopTo; i++)
            {
                oMdsynAmReservaE = new MdsynAmReservaE();

                oMdsynAmReservaE = oList[i];

                if (oMdsynAmReservaE.CodAtencion != "")
                {
                    new MdsynAmReservaAD().Sp_PresotorAmbulatorio_Insert(oMdsynAmReservaE);

                    oMdsynAmReservaE.NuevoValor = CodUser;
                    oMdsynAmReservaE.Campo = "usr_recepcion";
                    new MdsynAmReservaAD().Sp_Mdsyn_Cita_UpdatexCampo(oMdsynAmReservaE);
                }
                else
                {
                    Guardar_Error_BaseDatos("Id. Reserva: " + oMdsynAmReservaE.IdeReserva.ToString() + " no tiene atención, revisar.", "mtConfirmarCitas");
                }
            }

            new TablasAD().Sp_Tablas_Update(new TablasE("MEDISYN_FECHA_PROC_RECEPCION", "01", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), "nombre"));

            return oRespuestaE;
        }
        #endregion



        #region mtProcesarPagosPre
        public void mtProcesoPagoPre()
        {
            var oList = new List<MdsynDatosPagosE>();
            int i = 0;
            string msg_error = "";
            try
            {
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 110));
                var loopTo = oList.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    ProcesoPagoPorIdCitaPre(oList[i].IdeCita);
                }
            }
            catch (Exception ex)
            {
                msg_error = " Id Pago: " + i.ToString() + "<br/>" + "Message: " + ex.Message + "<br/> StackTrace: " + ex.StackTrace + "<br/>";

                Guardar_Error_BaseDatos(msg_error, "        public void mtPreProcesoPago()\r\n");
            }
        }

        public async Task mtProcesoPagoPreAsync()
        {
            var oList = new List<MdsynDatosPagosE>();
            int i = 0;
            string msg_error = "";
            try
            {
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 110));
                var loopTo = oList.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    await Task.Run(() => ProcesoPagoPorIdCitaPre(oList[i].IdeCita)).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                msg_error = " Id Pago: " + i.ToString() + "<br/>" + "Message: " + ex.Message + "<br/> StackTrace: " + ex.StackTrace + "<br/>";

                Guardar_Error_BaseDatos(msg_error, "        public void mtPreProcesoPago()\r\n");
            }
        }




        public string ProcesoPagoPorIdCitaPre(int ide_cita)
        {
            try
            {
                //string iafa, string tipo_documento, string nro_documento
                string Resultado = "";
                MdsynDatosPagosE oMdsynDatosPagosE = new MdsynDatosPagosE();
                MdsynDatosPagosE oMdsynDatosPagosE_base = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_ConsultaBase(ide_cita, 105);

                if (oMdsynDatosPagosE_base.IdeCita == 0) return "La cita ya fue procesada";
                if (oMdsynDatosPagosE_base.CodCobertura == "") return "No tiene datos de cobertura";
                if (oMdsynDatosPagosE_base.Error != "") return oMdsynDatosPagosE_base.Error;


                oMdsynDatosPagosE.CodCobertura = oMdsynDatosPagosE_base.CodCobertura;
                //oMdsynDatosPagosE.CoPagovariable = util.ValDecimal(oCoberturas.CodCopagoVariable);
                oMdsynDatosPagosE.TipMoneda = "Soles"; // traer de S10 oCoberturas.DesTipoMoneda;


                oMdsynDatosPagosE.CodAsegurado = oMdsynDatosPagosE_base.CodAsegurado;
                oMdsynDatosPagosE.TipPrt = oMdsynDatosPagosE_base.TipPrt;
                oMdsynDatosPagosE.TipParentesco = oMdsynDatosPagosE_base.TipParentesco;
                oMdsynDatosPagosE.NroPlan = oMdsynDatosPagosE_base.NroPlan;
                oMdsynDatosPagosE.TipDocempresa = oMdsynDatosPagosE_base.TipDocempresa; ;
                oMdsynDatosPagosE.NumDocempresa = oMdsynDatosPagosE_base.NumDocempresa;

                oMdsynDatosPagosE.TipDocumento = oMdsynDatosPagosE_base.TipDocumento; // oAsegCodResponse.DatosAfiliado.CodTipoDocumentoAfiliado;
                oMdsynDatosPagosE.NumDocumento = oMdsynDatosPagosE_base.NumDocumento; // oAsegCodResponse.DatosAfiliado.NumeroDocumentoAfiliado;
                oMdsynDatosPagosE.FecNacimiento = oMdsynDatosPagosE_base.FecNacimiento;
                oMdsynDatosPagosE.FecIniciovigencia = oMdsynDatosPagosE_base.FecIniciovigencia;
                oMdsynDatosPagosE.FecAfilicacion = oMdsynDatosPagosE_base.FecAfilicacion;


                oMdsynDatosPagosE.CoPagofijo = oMdsynDatosPagosE_base.CoPagofijo;// util.ValDecimal(oCoberturas.CodCopagoFijo);
                oMdsynDatosPagosE.IdeCita = oMdsynDatosPagosE_base.IdeCita; // ide_cita
                oMdsynDatosPagosE.TipAtencion = oMdsynDatosPagosE_base.TipAtencion;
                oMdsynDatosPagosE.CodPaciente = oMdsynDatosPagosE_base.CodPaciente;
                oMdsynDatosPagosE.CodPacienteTitular = oMdsynDatosPagosE_base.CodPacienteTitular;
                oMdsynDatosPagosE.CodIAFAS = oMdsynDatosPagosE_base.CodIAFAS;
                oMdsynDatosPagosE.CodAseguradora = oMdsynDatosPagosE_base.CodAseguradora;
                oMdsynDatosPagosE.CodSede = oMdsynDatosPagosE_base.CodSede;
                oMdsynDatosPagosE.DscSede = oMdsynDatosPagosE_base.DscSede;
                oMdsynDatosPagosE.CodSunasa = oMdsynDatosPagosE_base.CodSunasa;
                oMdsynDatosPagosE.CodMedico = oMdsynDatosPagosE_base.CodMedico;
                oMdsynDatosPagosE.CodEspecialidad = oMdsynDatosPagosE_base.CodEspecialidad;
                oMdsynDatosPagosE.TipoEnvio = oMdsynDatosPagosE_base.TipoEnvio;
                oMdsynDatosPagosE.FecCita = oMdsynDatosPagosE_base.FecCita;

                oMdsynDatosPagosE.CodProfMedico = "";
                oMdsynDatosPagosE.CodEspecialidadMedisyn = "";
                oMdsynDatosPagosE.NroOperacion = "";
                oMdsynDatosPagosE.DscMensajeRespuesta = "";
                oMdsynDatosPagosE.EstPagoExitoso = "";
                oMdsynDatosPagosE.FecRegistro = DateTime.Now;
                oMdsynDatosPagosE.TipTarjeta = "";
                oMdsynDatosPagosE.NumTarjeta = "";
                oMdsynDatosPagosE.FlgProcesoAtencion = "";
                oMdsynDatosPagosE.FecProcesoAtencion = DateTime.Now.Date.ToString();
                oMdsynDatosPagosE.CodAtencion = "";
                oMdsynDatosPagosE.CodLiquidacion = "";
                oMdsynDatosPagosE.CodComprobante = "";
                oMdsynDatosPagosE.CodNota = "";
                oMdsynDatosPagosE.NumAutorizacionSiteds = "";
                oMdsynDatosPagosE.FlgRecepcion = "";
                oMdsynDatosPagosE.FlgAnulacion = "";
                oMdsynDatosPagosE.FecProcesoAnulacion = DateTime.Now;
                oMdsynDatosPagosE.FecAnulado = DateTime.Now;
                oMdsynDatosPagosE.EstProcesoAtencion = 0;
                oMdsynDatosPagosE.Comp_DscTabla = "P";

                bool lswResultado = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Insert(oMdsynDatosPagosE);
                Resultado = lswResultado == true ? "Ok" : "No se proceso";

                return Resultado;
            }
            catch (Exception ex)
            {
                return "No se proceso: " + ex.Message;
            }
        }

        public string ProcesoPagoPorIdCitaPre_SITEDS(int ide_cita)
        {
            try
            {

                //string iafa, string tipo_documento, string nro_documento
                string Resultado = "No Proceso";
                MdsynDatosPagosE oMdsynDatosPagosE_base = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_ConsultaBase(ide_cita, 105);

                if (oMdsynDatosPagosE_base.IdeCita == 0) return "La cita ya fue procesada";
                if (oMdsynDatosPagosE_base.CodCobertura == "") return "No tiene datos de cobertura";
                if (oMdsynDatosPagosE_base.Error != "") return oMdsynDatosPagosE_base.Error;


                MdsynDatosPagosE oMdsynDatosPagosE = new MdsynDatosPagosE();
                Coberturas_AsegCode oCoberturas = new Coberturas_AsegCode();
                string stringJson;
                AsegCodResponse oAsegCodResponse = new AsegCodResponse();

                oWsSiteds = new SitedsWs();
                oWsSiteds.AsignaIAFA(oMdsynDatosPagosE_base.RucSunasa, oMdsynDatosPagosE_base.CodSunasa, oMdsynDatosPagosE_base.CodIAFAS);

                oAsegNombRequest = new AsegNombRequest(oMdsynDatosPagosE_base.RucSunasa, oMdsynDatosPagosE_base.CodSunasa, oMdsynDatosPagosE_base.CodIAFAS);
                oAsegNombRequest.CodTipoDocumentoAfiliado = oMdsynDatosPagosE_base.TipoDocumento.ToString();
                oAsegNombRequest.NumeroDocumentoAfiliado = oMdsynDatosPagosE_base.NumDocumento;

                stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);
                List<AsegNombResponse> oListAsegNombResponse = (List<AsegNombResponse>)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(List<AsegNombResponse>));

                oAsegCodRequest = oWsSiteds.mtdAsignarAseguradoCorrecto(oListAsegNombResponse, oAsegNombRequest.NumeroDocumentoAfiliado, true);
                oAsegCodRequest.RUC = oAsegNombRequest.RUC;
                oAsegCodRequest.IAFAS = oAsegNombRequest.IAFAS;
                oAsegCodRequest.SUNASA = oAsegNombRequest.SUNASA;

                stringJson = ConsultaAsegCod(RutaWS_Siteds, oAsegCodRequest);
                oAsegCodResponse = (AsegCodResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(AsegCodResponse));

                if (oAsegCodResponse.Coberturas != null)
                {
                    oCoberturas = oAsegCodResponse.Coberturas
                        .Where(x => x.CodigoCobertura == oMdsynDatosPagosE_base.CodCobertura)
                        .FirstOrDefault();


                    if (oCoberturas != null)
                    {
                        oMdsynDatosPagosE.CodCobertura = oCoberturas.CodigoCobertura;
                        oMdsynDatosPagosE.CoPagovariable = util.ValDecimal(oCoberturas.CodCopagoVariable);
                        oMdsynDatosPagosE.TipMoneda = oCoberturas.DesTipoMoneda;


                        oMdsynDatosPagosE.CodAsegurado = oAsegCodRequest.CodigoAfiliado;
                        oMdsynDatosPagosE.TipPrt = oAsegCodRequest.CodProducto;
                        oMdsynDatosPagosE.TipParentesco = oAsegCodRequest.CodParentesco;
                        oMdsynDatosPagosE.NroPlan = oAsegCodRequest.NumeroPlan;
                        oMdsynDatosPagosE.TipDocempresa = oAsegCodRequest.CodTipoDocumentoContratante; ;
                        oMdsynDatosPagosE.NumDocempresa = oAsegCodRequest.NumeroDocumentoContratante;

                        oMdsynDatosPagosE.TipDocumento = oAsegCodResponse.DatosAfiliado.CodTipoDocumentoAfiliado;
                        oMdsynDatosPagosE.NumDocumento = oAsegCodResponse.DatosAfiliado.NumeroDocumentoAfiliado;
                        oMdsynDatosPagosE.FecNacimiento = util.ValFecha(oAsegCodResponse.DatosAfiliado.FechaNacimiento);
                        oMdsynDatosPagosE.FecIniciovigencia = util.ValFecha(oAsegCodResponse.DatosAfiliado.FechaInicioVigencia);
                        oMdsynDatosPagosE.FecAfilicacion = util.ValFecha(oAsegCodResponse.DatosAfiliado.FechaAfiliacion);


                        oMdsynDatosPagosE.CoPagofijo = oMdsynDatosPagosE_base.CoPagofijo;// util.ValDecimal(oCoberturas.CodCopagoFijo);
                        oMdsynDatosPagosE.IdeCita = oMdsynDatosPagosE_base.IdeCita; // ide_cita
                        oMdsynDatosPagosE.TipAtencion = oMdsynDatosPagosE_base.TipAtencion;
                        oMdsynDatosPagosE.CodPaciente = oMdsynDatosPagosE_base.CodPaciente;
                        oMdsynDatosPagosE.CodPacienteTitular = oMdsynDatosPagosE_base.CodPacienteTitular;
                        oMdsynDatosPagosE.CodIAFAS = oMdsynDatosPagosE_base.CodIAFAS;
                        oMdsynDatosPagosE.CodAseguradora = oMdsynDatosPagosE_base.CodAseguradora;
                        oMdsynDatosPagosE.CodSede = oMdsynDatosPagosE_base.CodSede;
                        oMdsynDatosPagosE.CodSunasa = oMdsynDatosPagosE_base.CodSunasa;
                        oMdsynDatosPagosE.CodMedico = oMdsynDatosPagosE_base.CodMedico;
                        oMdsynDatosPagosE.CodEspecialidad = oMdsynDatosPagosE_base.CodEspecialidad;
                        oMdsynDatosPagosE.TipoEnvio = oMdsynDatosPagosE_base.TipoEnvio;
                        oMdsynDatosPagosE.FecCita = oMdsynDatosPagosE_base.FecCita;

                        oMdsynDatosPagosE.CodProfMedico = "";
                        oMdsynDatosPagosE.CodEspecialidadMedisyn = "";
                        oMdsynDatosPagosE.NroOperacion = "";
                        oMdsynDatosPagosE.DscMensajeRespuesta = "";
                        oMdsynDatosPagosE.EstPagoExitoso = "";
                        oMdsynDatosPagosE.FecRegistro = DateTime.Now;
                        oMdsynDatosPagosE.TipTarjeta = "";
                        oMdsynDatosPagosE.NumTarjeta = "";
                        oMdsynDatosPagosE.FlgProcesoAtencion = "";
                        oMdsynDatosPagosE.FecProcesoAtencion = DateTime.Now.Date.ToString();
                        oMdsynDatosPagosE.CodAtencion = "";
                        oMdsynDatosPagosE.CodLiquidacion = "";
                        oMdsynDatosPagosE.CodComprobante = "";
                        oMdsynDatosPagosE.CodNota = "";
                        oMdsynDatosPagosE.NumAutorizacionSiteds = "";
                        oMdsynDatosPagosE.FlgRecepcion = "";
                        oMdsynDatosPagosE.FlgAnulacion = "";
                        oMdsynDatosPagosE.FecProcesoAnulacion = DateTime.Now;
                        oMdsynDatosPagosE.FecAnulado = DateTime.Now;
                        oMdsynDatosPagosE.EstProcesoAtencion = 0;
                        oMdsynDatosPagosE.Comp_DscTabla = "P";

                        bool lswResultado = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Insert(oMdsynDatosPagosE);
                        Resultado = lswResultado == true ? "Ok" : "No se proceso";
                    }
                }

                return Resultado;
            }
            catch (Exception ex)
            {
                return "No se proceso: " + ex.Message;
            }
        }





        #endregion

        #region mtProcesarPagosPost
        public void mtProcesoPagoPost()
        {
            var oList = new List<MdsynDatosPagosE>();
            int i = 0;
            string msg_error = "";
            try
            {
                //throw new Exception("El store \"Sp_Correlativo_Consulta\" no está devolviendo la serie de la boleta/factura/nota de crédito para usar en el servicio " + Strings.Chr(13));
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 111));
                var loopTo = oList.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    ProcesoPagoPorIdCitaPost(oList[i].IdeCita);
                }
            }
            catch (Exception ex)
            {
                msg_error = " Id Pago: " + i.ToString() + "<br/>" + "Message: " + ex.Message + "<br/> StackTrace: " + ex.StackTrace + "<br/>";

                Guardar_Error_BaseDatos(msg_error, "        public void mtPreProcesoPago()\r\n");
            }
        }

        public async Task mtProcesoPagoPostAsync()
        {
            var oList = new List<MdsynDatosPagosE>();
            int i = 0;
            string msg_error = "";
            try
            {
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 111));
                var loopTo = oList.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    await Task.Run(() => ProcesoPagoPorIdCitaPost(oList[i].IdeCita)).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                msg_error = " Id Pago: " + i.ToString() + "<br/>" + "Message: " + ex.Message + "<br/> StackTrace: " + ex.StackTrace + "<br/>";

                Guardar_Error_BaseDatos(msg_error, "        public void mtPreProcesoPago()\r\n");
            }
        }



        public string ProcesoPagoPorIdCitaPost(int ide_cita)
        {
            try
            {
                //string iafa, string tipo_documento, string nro_documento
                string stringJson;
                string Resultado = "";
                bool lswResultado = false;
                AsegCodResponse oAsegCodResponse = new AsegCodResponse();
                MdsynDatosPagosE oMdsynDatosPagosE = new MdsynDatosPagosE();
                Coberturas_AsegCode oCoberturas = new Coberturas_AsegCode();

                MdsynDatosPagosE oMdsynDatosPagosE_base = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_ConsultaBase(ide_cita, 112);

                if (oMdsynDatosPagosE_base.IdeCita == 0) return "Especifique una cita válida";
                //if (oMdsynDatosPagosE_base.CodCobertura == "") return "No tiene datos de cobertura";
                if (oMdsynDatosPagosE_base.Error != "") return oMdsynDatosPagosE_base.Error;

                oMdsynDatosPagosE.IdeCita = oMdsynDatosPagosE_base.IdeCita;
                oMdsynDatosPagosE.DscMensajeRespuesta = oMdsynDatosPagosE_base.DscMensajeRespuesta;
                oMdsynDatosPagosE.EstPagoExitoso = oMdsynDatosPagosE_base.EstPagoExitoso;
                oMdsynDatosPagosE.TipTarjeta = oMdsynDatosPagosE_base.TipTarjeta;
                oMdsynDatosPagosE.NumTarjeta = oMdsynDatosPagosE_base.NumTarjeta;
                oMdsynDatosPagosE.Comp_TipoComprobante = oMdsynDatosPagosE_base.Comp_TipoComprobante;
                oMdsynDatosPagosE.Comp_TipDocIdentidad = oMdsynDatosPagosE_base.Comp_TipDocIdentidad;
                oMdsynDatosPagosE.Comp_RutDocIdentidad = oMdsynDatosPagosE_base.Comp_RutDocIdentidad;
                oMdsynDatosPagosE.Comp_Correo = oMdsynDatosPagosE_base.Comp_Correo;
                oMdsynDatosPagosE.TransaccionIdNiubiz = oMdsynDatosPagosE_base.TransaccionIdNiubiz;
                oMdsynDatosPagosE.Comp_DscTabla = oMdsynDatosPagosE_base.Comp_DscTabla;


                oMdsynDatosPagosE.CodCobertura = oMdsynDatosPagosE_base.CodCobertura;
                oMdsynDatosPagosE.TipMoneda = oMdsynDatosPagosE_base.TipMoneda; // traer de S10 oCoberturas.DesTipoMoneda;

                oMdsynDatosPagosE.CodAsegurado = oMdsynDatosPagosE_base.CodAsegurado;
                oMdsynDatosPagosE.TipPrt = oMdsynDatosPagosE_base.TipPrt;
                oMdsynDatosPagosE.TipParentesco = oMdsynDatosPagosE_base.TipParentesco;
                oMdsynDatosPagosE.NroPlan = oMdsynDatosPagosE_base.NroPlan;
                oMdsynDatosPagosE.TipDocempresa = oMdsynDatosPagosE_base.TipDocempresa; ;
                oMdsynDatosPagosE.NumDocempresa = oMdsynDatosPagosE_base.NumDocempresa;

                oMdsynDatosPagosE.TipDocumento = oMdsynDatosPagosE_base.TipDocumento; // oAsegCodResponse.DatosAfiliado.CodTipoDocumentoAfiliado;
                oMdsynDatosPagosE.NumDocumento = oMdsynDatosPagosE_base.NumDocumento; // oAsegCodResponse.DatosAfiliado.NumeroDocumentoAfiliado;
                oMdsynDatosPagosE.FecNacimiento = oMdsynDatosPagosE_base.FecNacimiento;
                oMdsynDatosPagosE.FecIniciovigencia = oMdsynDatosPagosE_base.FecIniciovigencia;
                oMdsynDatosPagosE.FecAfilicacion = oMdsynDatosPagosE_base.FecAfilicacion;

                oMdsynDatosPagosE.RucSunasa = oMdsynDatosPagosE_base.RucSunasa;
                oMdsynDatosPagosE.CodSunasa = oMdsynDatosPagosE_base.CodSunasa;
                oMdsynDatosPagosE.CodIAFAS = oMdsynDatosPagosE_base.CodIAFAS;

                oMdsynDatosPagosE.NumAutorizacionSiteds = oMdsynDatosPagosE_base.NumAutorizacionSiteds;

                //if (oMdsynDatosPagosE.CodAsegurado == "") ProcesoPagoPorIdCitaPost_SITEDS(oMdsynDatosPagosE);
                if (oMdsynDatosPagosE.CodAsegurado != "")
                {
                    lswResultado = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Insert(oMdsynDatosPagosE);
                    Resultado = lswResultado == true ? "Ok" : "No se proceso";
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                return "No se proceso: " + ex.Message;
            }
        }


        public string ProcesoPagoPorIdCitaPost_SITEDS(MdsynDatosPagosE pMdsynDatosPagosE)
        {
            try
            {

                string Resultado = "No Proceso";

                MdsynDatosPagosE oMdsynDatosPagosE = new MdsynDatosPagosE();
                Coberturas_AsegCode oCoberturas = new Coberturas_AsegCode();
                string stringJson;
                AsegCodResponse oAsegCodResponse = new AsegCodResponse();

                oWsSiteds = new SitedsWs();
                oWsSiteds.AsignaIAFA(pMdsynDatosPagosE.RucSunasa, pMdsynDatosPagosE.CodSunasa, pMdsynDatosPagosE.CodIAFAS);

                oAsegNombRequest = new AsegNombRequest(pMdsynDatosPagosE.RucSunasa, pMdsynDatosPagosE.CodSunasa, pMdsynDatosPagosE.CodIAFAS);
                oAsegNombRequest.CodTipoDocumentoAfiliado = "0"; pMdsynDatosPagosE.TipoDocumento.ToString();
                oAsegNombRequest.NumeroDocumentoAfiliado = pMdsynDatosPagosE.NumDocumento;

                stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);
                List<AsegNombResponse> oListAsegNombResponse = (List<AsegNombResponse>)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(List<AsegNombResponse>));

                oAsegCodRequest = oWsSiteds.mtdAsignarAseguradoCorrecto(oListAsegNombResponse, oAsegNombRequest.NumeroDocumentoAfiliado, true);
                oAsegCodRequest.RUC = oAsegNombRequest.RUC;
                oAsegCodRequest.IAFAS = oAsegNombRequest.IAFAS;
                oAsegCodRequest.SUNASA = oAsegNombRequest.SUNASA;

                stringJson = ConsultaAsegCod(RutaWS_Siteds, oAsegCodRequest);
                oAsegCodResponse = (AsegCodResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(AsegCodResponse));

                if (oAsegCodResponse.Coberturas != null)
                {
                    oCoberturas = oAsegCodResponse.Coberturas
                        .Where(x => x.CodigoCobertura == pMdsynDatosPagosE.CodCobertura)
                        .FirstOrDefault();

                    if (oCoberturas != null)
                    {
                        pMdsynDatosPagosE.TipMoneda = oCoberturas.DesTipoMoneda;

                        pMdsynDatosPagosE.CodAsegurado = oAsegCodRequest.CodigoAfiliado;
                        pMdsynDatosPagosE.TipPrt = oAsegCodRequest.CodProducto;
                        pMdsynDatosPagosE.TipParentesco = oAsegCodRequest.CodParentesco;
                        pMdsynDatosPagosE.NroPlan = oAsegCodRequest.NumeroPlan;
                        pMdsynDatosPagosE.TipDocempresa = oAsegCodRequest.CodTipoDocumentoContratante; ;
                        pMdsynDatosPagosE.NumDocempresa = oAsegCodRequest.NumeroDocumentoContratante;

                        pMdsynDatosPagosE.FecNacimiento = util.ValFecha(oAsegCodResponse.DatosAfiliado.FechaNacimiento);
                        pMdsynDatosPagosE.FecIniciovigencia = util.ValFecha(oAsegCodResponse.DatosAfiliado.FechaInicioVigencia);
                        pMdsynDatosPagosE.FecAfilicacion = util.ValFecha(oAsegCodResponse.DatosAfiliado.FechaAfiliacion);

                    }
                }

                return Resultado;
            }
            catch (Exception ex)
            {
                return "No se proceso: " + ex.Message;
            }
        }




        #endregion

        #region mtProcesarPagos

        public async Task mtProcesarPagosAsyn()
        {
            await Task.Run(() => mtProcesarPagos()).ConfigureAwait(false);
        }

        public void mtProcesarPagos()
        {
            //RutaWS_Siteds = "http://200.48.199.90/WSSITEDS/Sistema/"; 


            var oList = new List<MdsynDatosPagosE>();
            string stringJson = "";
            int i;
            string msg_error = "";
            oWsSiteds = new SitedsWs();


            try
            {
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 2));
                var loopTo = oList.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    mtDatosPaciente(oList[i]);

                    do
                    {
                        try
                        {
                            CrearCiaContratante(); // Creará la contratante (cia) en caso sea necesario.
                            if (CodCia == "")
                                break; // En caso no se haya creado la contratante salir del bucle

                            if (EstProcesoAtencion == 0) // Si el estado es "0", significa que debemos crear la atención.
                            {
                                if (CodTipoConsultaMedica == "A")
                                {
                                    oAsegNombRequest = new AsegNombRequest(CodRuc, CodSunasa, CodIAFAS, TipDocumento, DocIdentidad);
                                    oWsSiteds.AsignaIAFA(CodRuc, CodSunasa, CodIAFAS);

                                    //oWsSiteds.xIAFAS = xIAFAS;
                                    //oWsSiteds.xSunasa = xSunasa;

                                    stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);

                                    if (stringJson == "[]")
                                    {
                                        oAsegNombRequest.ApellidoPaternoAfiliado = ApPaternoPaciente;
                                        oAsegNombRequest.ApellidoMaternoAfiliado = ApMaternoPaciente;
                                        oAsegNombRequest.NombresAfiliado = NombrePaciente;
                                        oAsegNombRequest.CodTipoDocumentoAfiliado = "";
                                        oAsegNombRequest.NumeroDocumentoAfiliado = "";
                                        stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);
                                    }

                                    List<AsegNombResponse> oListAsegNombResponse = (List<AsegNombResponse>)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(List<AsegNombResponse>));
                                    mtdAsignarAseguradoCorrecto(oListAsegNombResponse); // Asignamos el "oAsegCodRequest" en el método "mtdAsignarAseguradoCorrecto"
                                    stringJson = "";

                                    // Verificamos si se logró encontrar algún registro dentro de la atención.
                                    if (!(oAsegCodRequest == null))
                                    {
                                        stringJson = ConsultaAsegCod(RutaWS_Siteds, oAsegCodRequest);
                                        AsegCodResponse oAsegCodResponse = (AsegCodResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(AsegCodResponse));
                                        var oCoberturas = new Coberturas_AsegCode();

                                        TipoAfiliacion = oAsegCodResponse.DatosAfiliado.CodTipoAfiliacion.Substring(0, 1);
                                        for (int j = 0, loopTo1 = oAsegCodResponse.Coberturas.Count - 1; j <= loopTo1; j++)
                                        {
                                            try
                                            {
                                                if ((oAsegCodResponse.DatosAfiliado.NumeroPlan == NumeroPlanPoliza | oAsegCodResponse.DatosAfiliado.NumeroPlan == NumeroPlanPoliza) == false)
                                                {
                                                    NumeroPlanPoliza = oAsegCodResponse.DatosAfiliado.NumeroPlan;
                                                }
                                            }
                                            catch (Exception ex)
                                            {

                                            }

                                            oCoberturas = oAsegCodResponse.Coberturas[j];
                                            if (CodCobertura.Trim() == "")
                                            {
                                                msg_error = "Método: mtProcesarPagos <br/>" + "No se ingreso el código de cobertura, por favor revisar. <br/>" + " Id Pago: " + IdeDatosPagos.ToString() + "<br/>";
                                                Bus.AgendaClinica.Clinica.VariablesGlobales.Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                                break;
                                            }

                                            if (oCoberturas.CodigoCobertura == CodCobertura)
                                            {
                                                oNumAutorizacionRequest = oWsSiteds.fnNumeroAutorizacion(oCoberturas, oAsegCodResponse);

                                                string JsonBodyAutorizacion = Newtonsoft.Json.JsonConvert.SerializeObject(oNumAutorizacionRequest);

                                                NumeroAutorizacionResponse NumAutorizacionResp = default;

                                                try
                                                {
                                                    if (EstProcesoAtencion >= 1)
                                                    {
                                                        NumAutorizacionResp = new NumeroAutorizacionResponse();
                                                        CodigoAutorizacion = "0x";
                                                    }
                                                    else
                                                    {
                                                        stringJson = ConsultaNumeroAutorizacion(RutaWS_Siteds, oNumAutorizacionRequest);

                                                        NumAutorizacionResp = (NumeroAutorizacionResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(NumeroAutorizacionResponse));
                                                        CodigoAutorizacion = NumAutorizacionResp.NumeroAutorizacion;

                                                        if (CodigoAutorizacion == "")
                                                        {
                                                            throw new Exception(stringJson);
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    msg_error = ex.Message + "<br/>" + ex.StackTrace + "<br/>" + stringJson + "<br/>" + "Json Input: " + Newtonsoft.Json.JsonConvert.SerializeObject(oNumAutorizacionRequest);

                                                    Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                                    break;
                                                }

                                                // Cargamos datos de las coberturas que sirven para la creación de la atención.
                                                mtdCargarDatosCobertura(oAsegCodResponse, oCoberturas);

                                                if (!(NumAutorizacionResp == null) & !string.IsNullOrEmpty((CodigoAutorizacion.Trim())))
                                                {
                                                    if (EstProcesoAtencion == 0) // Si el estado del proceso es "0", significa que se debe crear la atención. Antes de crear la atención, generamos el documento de autorización.
                                                    {
                                                        if (NumAutorizacionResp.NumeroAutorizacion != "")
                                                        {
                                                            oObservacionRequest = oWsSiteds.fnObservacionRequest(oNumAutorizacionRequest, oAsegCodRequest);
                                                            stringJson = ConsultaObservacion(RutaWS_Siteds, oObservacionRequest);
                                                            ObservacionResponse oObservacionResponse = (ObservacionResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(ObservacionResponse));

                                                            oCasoTiempoEsperaRequest = oWsSiteds.fnCasoTiempoEsperaRequest(oNumAutorizacionRequest, oCoberturas);
                                                            stringJson = CasoTiempoEspera(RutaWS_Siteds, oCasoTiempoEsperaRequest);
                                                            CasoTiempoEsperaResponse oCasoTiempoEsperaResponse = (CasoTiempoEsperaResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(CasoTiempoEsperaResponse));

                                                            oProcedimientosEspecialesRequest = oWsSiteds.fnConsultaProcedimientosEspecialesRequest(oNumAutorizacionRequest, oCoberturas);
                                                            stringJson = ProcedimientosEspeciales(RutaWS_Siteds, oProcedimientosEspecialesRequest);
                                                            ProcedimientosEspecialesResponse oProcedimientosEspecialesResponse = (ProcedimientosEspecialesResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(ProcedimientosEspecialesResponse));

                                                            if (GrabarDatosGenerales(oAsegCodResponse, oNumAutorizacionRequest) == true) // DATOS GENERALES
                                                            {
                                                                GrabarCoberturas(oCoberturas_Acred, oCoberturas); // COBERTURAS 'TMACASSI ENVIAR OBJETO DE COBERTURA ACRED
                                                                GrabarProcedimientos(oDatosGenerales, oCoberturas_Acred); // PROCEDIMIENTOS
                                                                GrabarExcepcionCarencia(oDatosGenerales, oCoberturas_Acred);  // EXCEPCIÓN DE CARENCIA
                                                            }

                                                            CrearAtencion(ref CodAtencion, "A", CodPaciente, CodSede);
                                                            if (CodAtencion.Trim() != "")
                                                            {
                                                                var DocumentoAutorizacion = Convert.FromBase64String(NumAutorizacionResp.Documento);
                                                                new s10_LogDocumentoAutorizacionAD().Sp_S10LogDocumentoAutorizacion_Insert(new s10_LogDocumentoAutorizacionE(IdeDatosPagos, CodigoAutorizacion, DocumentoAutorizacion));
                                                                EstProcesoAtencion += 1;
                                                                new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodAtencion, "cod_atencion", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                                                new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodigoAutorizacion, "num_autorizacionsiteds", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                                            }
                                                        }
                                                        else
                                                        {
                                                            msg_error = "No se pudo procesar la autorización del pago porque no se obtuvo la autorización" + "<br/>" + " Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Mensaje Autorización: " + NumAutorizacionResp.Documento + "<br/>";

                                                            Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                                        }
                                                    }

                                                    if (EstProcesoAtencion == 0)
                                                    {

                                                    }
                                                }
                                                else
                                                {
                                                    msg_error = "No se pudo procesar la autorización del pago porque no se obtuvo la autorización" + "<br/>" + " Id Pago: " + IdeDatosPagos.ToString() + "<br/>";
                                                    Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                                }
                                                break; // Salir del for, este sirve para buscar la cobertura correcta.
                                            }
                                        }
                                    }
                                    else
                                    {
                                        msg_error = "No se encontró coincidencia de los datos del paciente con lo encontrado en Siteds." + "<br/>" + "Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Cod. Paciente: " + CodPaciente + "<br/>" + "Dni: " + DocIdentidad + "<br/>";

                                        Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Obtener Datos del Siteds");
                                    }
                                }
                                else if (CodTipoConsultaMedica == "P")
                                {
                                    // Cargamos datos de las coberturas que sirven para la creación de la atención.
                                    mtdCargarDatosCobertura(new AsegCodResponse(), new Coberturas_AsegCode());

                                    CrearAtencion(ref CodAtencion, "J", CodPaciente, CodSede);
                                    if (CodAtencion.Trim() != "")
                                    {
                                        EstProcesoAtencion += 1;
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodAtencion, "cod_atencion", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, "", "num_autorizacionsiteds", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                    }
                                }
                            }

                            // ----------------------------------------
                            if (double.Parse(CoPagoFijo) != 0d & CodTipoConsultaMedica == "A") // Solo crear el Pago a Cuenta y el comprobante en caso el paciente tenga algo que pagar.
                            {
                                if (EstProcesoAtencion == 1) // Si el estado es "1", significa que se creo la atención y se debe crear la el pago a cuenta
                                {
                                    CrearPagoaCuenta(CodAtencion, double.Parse(CoPagoFijo), ref CodLiquidacion);
                                    if (CodLiquidacion.Trim() != "")
                                    {
                                        EstProcesoAtencion += 1;
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodLiquidacion, "cod_liquidacion", IdeDatosPagos)); // Actualizamos el cod. de la liquidacion en caso se haya generado
                                    }
                                }

                                // 10/08/2020 - Desactivamos hasta que la facturación electrónica vuelva a funcionar
                                if (EstProcesoAtencion == 2) // Si el estado es "2", significa que debemos generar el comprobante.
                                {
                                    try
                                    {
                                        if (Comprobante_CodTipoComprobante == "F")
                                        {
                                            var oAgendaCitas = new AgendaCitas();
                                            oAgendaCitas.RegistrarClienteRuc(Comprobante_CodTipoComprobante, Comprobante_RutDocIdentidad, Comprobante_DscCorreoComprobante);
                                        }
                                        GenerarComprobante(Comprobante_CodTipoComprobante, CodLiquidacion, CoPagoFijo, TipMoneda.Substring(0, 1));
                                    }
                                    catch (Exception ex)
                                    {
                                        msg_error = "Source: " + ex.Source + "<br/>" + "Message: Error al generar el comprobante.<br/>" + ex.Message + "<br/>" + "Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "" + ex.ToString();

                                        Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Generar comprobante");
                                    }

                                    if (CodComprobante.Trim() != "")
                                    {
                                        EstProcesoAtencion += 1;
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodComprobante, "cod_comprobante", IdeDatosPagos)); // Actualizamos el cod. de comprobante en caso se haya generado
                                    }
                                }

                                if (EstProcesoAtencion == 3) // Si el estado es "3", significa que debemos crear el pago del comprobante
                                {
                                    PagarComprobante(CodComprobante, CodLiquidacion, Comprobante_CodTipoComprobante, double.Parse(CoPagoFijo), TipMoneda.Substring(0, 1));
                                    EstProcesoAtencion += 1;
                                }
                            }

                            // Validar que el Cod. Atención, el copago fijo sea "0" y sea asegurado.
                            // Vaidar que tenga atención, liquidación, comprobante, tenga algo que pagar el paciente y sea asegurado.
                            // Validar que el Cod. Atención y sea particular.
                            if ((EstProcesoAtencion == 1 && CodAtencion != "" && decimal.Parse(CoPagoFijo) == 0 && CodTipoConsultaMedica == "A") ||
                                    (EstProcesoAtencion == 4 && CodAtencion != "" && CodLiquidacion != "" && CodComprobante != "" && decimal.Parse(CoPagoFijo) > 0 && CodTipoConsultaMedica == "A") ||
                                    (EstProcesoAtencion == 1 && CodAtencion != "" && CodTipoConsultaMedica == "P"))
                            {
                                ActualizarDatosPagosConfirmacion(); // Se actualizaran los datos una vez completado el proceso.
                                new HospitalAD().Sp_Hospital_Update(new HospitalE(CodAtencion, "est_consulta_medica", EstConsultaMedica));
                            }

                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, EstProcesoAtencion.ToString(), "est_proceso_atencion", IdeDatosPagos));
                        }

                        // ----------------------------------------

                        catch (Exception ex)
                        {
                            string xMsgEnt = "";

                            xMsgEnt = Newtonsoft.Json.JsonConvert.SerializeObject(oAsegNombRequest);

                            msg_error = "Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Message: " + ex.ToString() + "<br/><br/>" + "Método del Siteds: ConsultaAsegNom <br/>" + "Datos de Entidades: <br/>" + xMsgEnt;


                            Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos");
                        }
                    }
                    while (false);

                    LimpiarVariables();
                }

                new TablasAD().Sp_Tablas_Update(new TablasE("MEDISYN_FECHA_PROCESO_PAGOS", "01", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), "nombre"));
            }
            catch (Exception ex)
            {
                msg_error = " Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Message: " + ex.Message + "<br/> StackTrace: " + ex.StackTrace + "<br/>";

                Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos");
            }
        }




        public void mtProcesarPagos_SinSiteds()
        {
            //RutaWS_Siteds = "http://200.48.199.90/WSSITEDS/Sistema/"; 


            var oList = new List<MdsynDatosPagosE>();
            string stringJson = "";
            int i;
            string msg_error = "";
            oWsSiteds = new SitedsWs();


            try
            {
                oList = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Consulta(new MdsynDatosPagosE("", "", "", 0, 2));
                var loopTo = oList.Count - 1;
                for (i = 0; i <= loopTo; i++)
                {
                    mtDatosPaciente(oList[i]);

                    do
                    {
                        try
                        {
                            CrearCiaContratante(); // Creará la contratante (cia) en caso sea necesario.
                            if (CodCia == "")
                                break; // En caso no se haya creado la contratante salir del bucle

                            if (EstProcesoAtencion == 0) // Si el estado es "0", significa que debemos crear la atención.
                            {
                                if (CodTipoConsultaMedica == "A")
                                {

                                    ///////////////////////////////////////////////////
                                    //TipoAfiliacion = TipoAfiliacion;
                                    //NumeroPlanPoliza = NumeroPlanPoliza;
                                    //CodigoAutorizacion = CodigoAutorizacion;

                                    if (CodigoAutorizacion.Trim() != "" && NumeroPlanPoliza.Trim() != "" && TipoAfiliacion.Trim() != "")
                                    {

                                        // Aqui debe llenar la tablas intermedias
                                        // FALTA FALTA FALTA FALTA

                                        CrearAtencion(ref CodAtencion, "A", CodPaciente, CodSede);
                                        if (CodAtencion.Trim() != "")
                                        {
                                            //var DocumentoAutorizacion = Convert.FromBase64String(NumAutorizacionResp.Documento);
                                            //new s10_LogDocumentoAutorizacionAD().Sp_S10LogDocumentoAutorizacion_Insert(new s10_LogDocumentoAutorizacionE(IdeDatosPagos, CodigoAutorizacion, DocumentoAutorizacion));
                                            EstProcesoAtencion += 1;
                                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodAtencion, "cod_atencion", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodigoAutorizacion, "num_autorizacionsiteds", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                        }
                                    }













                                    //oAsegNombRequest = new AsegNombRequest(CodRuc, CodSunasa, CodIAFAS, TipDocumento, DocIdentidad);
                                    //oWsSiteds.AsignaIAFA(CodRuc, CodSunasa, CodIAFAS);

                                    //stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);

                                    //if (stringJson == "[]")
                                    //{
                                    //    oAsegNombRequest.ApellidoPaternoAfiliado = ApPaternoPaciente;
                                    //    oAsegNombRequest.ApellidoMaternoAfiliado = ApMaternoPaciente;
                                    //    oAsegNombRequest.NombresAfiliado = NombrePaciente;
                                    //    oAsegNombRequest.CodTipoDocumentoAfiliado = "";
                                    //    oAsegNombRequest.NumeroDocumentoAfiliado = "";
                                    //    stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);
                                    //}

                                    //List<AsegNombResponse> oListAsegNombResponse = (List<AsegNombResponse>)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(List<AsegNombResponse>));
                                    //mtdAsignarAseguradoCorrecto(oListAsegNombResponse); // Asignamos el "oAsegCodRequest" en el método "mtdAsignarAseguradoCorrecto"
                                    //stringJson = "";

                                    //// Verificamos si se logró encontrar algún registro dentro de la atención.
                                    //if (!(oAsegCodRequest == null))
                                    //{
                                    //    stringJson = ConsultaAsegCod(RutaWS_Siteds, oAsegCodRequest);
                                    //    AsegCodResponse oAsegCodResponse = (AsegCodResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(AsegCodResponse));
                                    //    var oCoberturas = new Coberturas_AsegCode();

                                    //    TipoAfiliacion = oAsegCodResponse.DatosAfiliado.CodTipoAfiliacion.Substring(0, 1);



                                    //    for (int j = 0, loopTo1 = oAsegCodResponse.Coberturas.Count - 1; j <= loopTo1; j++)
                                    //    {
                                    //        try
                                    //        {
                                    //            if ((oAsegCodResponse.DatosAfiliado.NumeroPlan == NumeroPlanPoliza | oAsegCodResponse.DatosAfiliado.NumeroPlan == NumeroPlanPoliza) == false)
                                    //            {
                                    //                NumeroPlanPoliza = oAsegCodResponse.DatosAfiliado.NumeroPlan;
                                    //            }
                                    //        }
                                    //        catch (Exception ex)
                                    //        {

                                    //        }

                                    //        oCoberturas = oAsegCodResponse.Coberturas[j];
                                    //        if (CodCobertura.Trim() == "")
                                    //        {
                                    //            msg_error = "Método: mtProcesarPagos <br/>" + "No se ingreso el código de cobertura, por favor revisar. <br/>" + " Id Pago: " + IdeDatosPagos.ToString() + "<br/>";
                                    //            Bus.AgendaClinica.Clinica.VariablesGlobales.Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                    //            break;
                                    //        }

                                    //        if (oCoberturas.CodigoCobertura == CodCobertura)
                                    //        {
                                    //            oNumAutorizacionRequest = oWsSiteds.fnNumeroAutorizacion(oCoberturas, oAsegCodResponse);

                                    //            string JsonBodyAutorizacion = Newtonsoft.Json.JsonConvert.SerializeObject(oNumAutorizacionRequest);

                                    //            NumeroAutorizacionResponse NumAutorizacionResp = default;

                                    //            try
                                    //            {
                                    //                if (EstProcesoAtencion >= 1)
                                    //                {
                                    //                    NumAutorizacionResp = new NumeroAutorizacionResponse();
                                    //                    CodigoAutorizacion = "0x";
                                    //                }
                                    //                else
                                    //                {
                                    //                    stringJson = ConsultaNumeroAutorizacion(RutaWS_Siteds, oNumAutorizacionRequest);

                                    //                    NumAutorizacionResp = (NumeroAutorizacionResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(NumeroAutorizacionResponse));
                                    //                    CodigoAutorizacion = NumAutorizacionResp.NumeroAutorizacion;

                                    //                    if (CodigoAutorizacion == "")
                                    //                    {
                                    //                        throw new Exception(stringJson);
                                    //                    }
                                    //                }
                                    //            }
                                    //            catch (Exception ex)
                                    //            {
                                    //                msg_error = ex.Message + "<br/>" + ex.StackTrace + "<br/>" + stringJson + "<br/>" + "Json Input: " + Newtonsoft.Json.JsonConvert.SerializeObject(oNumAutorizacionRequest);

                                    //                Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                    //                break;
                                    //            }

                                    //            // Cargamos datos de las coberturas que sirven para la creación de la atención.
                                    //            mtdCargarDatosCobertura(oAsegCodResponse, oCoberturas);

                                    //            if (!(NumAutorizacionResp == null) & !string.IsNullOrEmpty((CodigoAutorizacion.Trim())))
                                    //            {
                                    //                if (EstProcesoAtencion == 0) // Si el estado del proceso es "0", significa que se debe crear la atención. Antes de crear la atención, generamos el documento de autorización.
                                    //                {
                                    //                    if (NumAutorizacionResp.NumeroAutorizacion != "")
                                    //                    {
                                    //                        oObservacionRequest = oWsSiteds.fnObservacionRequest(oNumAutorizacionRequest, oAsegCodRequest);
                                    //                        stringJson = ConsultaObservacion(RutaWS_Siteds, oObservacionRequest);
                                    //                        ObservacionResponse oObservacionResponse = (ObservacionResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(ObservacionResponse));

                                    //                        oCasoTiempoEsperaRequest = oWsSiteds.fnCasoTiempoEsperaRequest(oNumAutorizacionRequest, oCoberturas);
                                    //                        stringJson = CasoTiempoEspera(RutaWS_Siteds, oCasoTiempoEsperaRequest);
                                    //                        CasoTiempoEsperaResponse oCasoTiempoEsperaResponse = (CasoTiempoEsperaResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(CasoTiempoEsperaResponse));

                                    //                        oProcedimientosEspecialesRequest = oWsSiteds.fnConsultaProcedimientosEspecialesRequest(oNumAutorizacionRequest, oCoberturas);
                                    //                        stringJson = ProcedimientosEspeciales(RutaWS_Siteds, oProcedimientosEspecialesRequest);
                                    //                        ProcedimientosEspecialesResponse oProcedimientosEspecialesResponse = (ProcedimientosEspecialesResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(ProcedimientosEspecialesResponse));

                                    //                        if (GrabarDatosGenerales(oAsegCodResponse, oNumAutorizacionRequest) == true) // DATOS GENERALES
                                    //                        {
                                    //                            GrabarCoberturas(oCoberturas_Acred, oCoberturas); // COBERTURAS 'TMACASSI ENVIAR OBJETO DE COBERTURA ACRED
                                    //                            GrabarProcedimientos(oDatosGenerales, oCoberturas_Acred); // PROCEDIMIENTOS
                                    //                            GrabarExcepcionCarencia(oDatosGenerales, oCoberturas_Acred);  // EXCEPCIÓN DE CARENCIA
                                    //                        }



                                    //                        CrearAtencion(ref CodAtencion, "A", CodPaciente, CodSede);
                                    //                        if (CodAtencion.Trim() != "")
                                    //                        {
                                    //                            var DocumentoAutorizacion = Convert.FromBase64String(NumAutorizacionResp.Documento);
                                    //                            new s10_LogDocumentoAutorizacionAD().Sp_S10LogDocumentoAutorizacion_Insert(new s10_LogDocumentoAutorizacionE(IdeDatosPagos, CodigoAutorizacion, DocumentoAutorizacion));
                                    //                            EstProcesoAtencion += 1;
                                    //                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodAtencion, "cod_atencion", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                    //                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodigoAutorizacion, "num_autorizacionsiteds", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                    //                        }



                                    //                    }
                                    //                    else
                                    //                    {
                                    //                        msg_error = "No se pudo procesar la autorización del pago porque no se obtuvo la autorización" + "<br/>" + " Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Mensaje Autorización: " + NumAutorizacionResp.Documento + "<br/>";

                                    //                        Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                    //                    }
                                    //                }

                                    //                if (EstProcesoAtencion == 0)
                                    //                {

                                    //                }
                                    //            }
                                    //            else
                                    //            {
                                    //                msg_error = "No se pudo procesar la autorización del pago porque no se obtuvo la autorización" + "<br/>" + " Id Pago: " + IdeDatosPagos.ToString() + "<br/>";
                                    //                Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Número de Autorización");
                                    //            }
                                    //            break; // Salir del for, este sirve para buscar la cobertura correcta.
                                    //        }
                                    //    }



                                    //}
                                    //else
                                    //{
                                    //    msg_error = "No se encontró coincidencia de los datos del paciente con lo encontrado en Siteds." + "<br/>" + "Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Cod. Paciente: " + CodPaciente + "<br/>" + "Dni: " + DocIdentidad + "<br/>";

                                    //    Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Obtener Datos del Siteds");
                                    //}























                                }
                                else if (CodTipoConsultaMedica == "P")
                                {
                                    // Cargamos datos de las coberturas que sirven para la creación de la atención.
                                    mtdCargarDatosCobertura(new AsegCodResponse(), new Coberturas_AsegCode());

                                    CrearAtencion(ref CodAtencion, "J", CodPaciente, CodSede);
                                    if (CodAtencion.Trim() != "")
                                    {
                                        EstProcesoAtencion += 1;
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodAtencion, "cod_atencion", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, "", "num_autorizacionsiteds", IdeDatosPagos)); // Actualizamos el cod. de la atención en caso se haya generado
                                    }
                                }
                            }

                            // ----------------------------------------
                            if (double.Parse(CoPagoFijo) != 0d & CodTipoConsultaMedica == "A") // Solo crear el Pago a Cuenta y el comprobante en caso el paciente tenga algo que pagar.
                            {
                                if (EstProcesoAtencion == 1) // Si el estado es "1", significa que se creo la atención y se debe crear la el pago a cuenta
                                {
                                    CrearPagoaCuenta(CodAtencion, double.Parse(CoPagoFijo), ref CodLiquidacion);
                                    if (CodLiquidacion.Trim() != "")
                                    {
                                        EstProcesoAtencion += 1;
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodLiquidacion, "cod_liquidacion", IdeDatosPagos)); // Actualizamos el cod. de la liquidacion en caso se haya generado
                                    }
                                }

                                // 10/08/2020 - Desactivamos hasta que la facturación electrónica vuelva a funcionar
                                if (EstProcesoAtencion == 2) // Si el estado es "2", significa que debemos generar el comprobante.
                                {
                                    try
                                    {
                                        if (Comprobante_CodTipoComprobante == "F")
                                        {
                                            var oAgendaCitas = new AgendaCitas();
                                            oAgendaCitas.RegistrarClienteRuc(Comprobante_CodTipoComprobante, Comprobante_RutDocIdentidad, Comprobante_DscCorreoComprobante);
                                        }
                                        GenerarComprobante(Comprobante_CodTipoComprobante, CodLiquidacion, CoPagoFijo, TipMoneda.Substring(0, 1));
                                    }
                                    catch (Exception ex)
                                    {
                                        msg_error = "Source: " + ex.Source + "<br/>" + "Message: Error al generar el comprobante.<br/>" + ex.Message + "<br/>" + "Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "" + ex.ToString();

                                        Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos - Generar comprobante");
                                    }

                                    if (CodComprobante.Trim() != "")
                                    {
                                        EstProcesoAtencion += 1;
                                        new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, CodComprobante, "cod_comprobante", IdeDatosPagos)); // Actualizamos el cod. de comprobante en caso se haya generado
                                    }
                                }

                                if (EstProcesoAtencion == 3) // Si el estado es "3", significa que debemos crear el pago del comprobante
                                {
                                    PagarComprobante(CodComprobante, CodLiquidacion, Comprobante_CodTipoComprobante, double.Parse(CoPagoFijo), TipMoneda.Substring(0, 1));
                                    EstProcesoAtencion += 1;
                                }
                            }

                            // Validar que el Cod. Atención, el copago fijo sea "0" y sea asegurado.
                            // Vaidar que tenga atención, liquidación, comprobante, tenga algo que pagar el paciente y sea asegurado.
                            // Validar que el Cod. Atención y sea particular.
                            if ((EstProcesoAtencion == 1 && CodAtencion != "" && decimal.Parse(CoPagoFijo) == 0 && CodTipoConsultaMedica == "A") ||
                                    (EstProcesoAtencion == 4 && CodAtencion != "" && CodLiquidacion != "" && CodComprobante != "" && decimal.Parse(CoPagoFijo) > 0 && CodTipoConsultaMedica == "A") ||
                                    (EstProcesoAtencion == 1 && CodAtencion != "" && CodTipoConsultaMedica == "P"))
                            {
                                ActualizarDatosPagosConfirmacion(); // Se actualizaran los datos una vez completado el proceso.
                                new HospitalAD().Sp_Hospital_Update(new HospitalE(CodAtencion, "est_consulta_medica", EstConsultaMedica));
                            }

                            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_UpdatexCampo(new MdsynDatosPagosE(0, EstProcesoAtencion.ToString(), "est_proceso_atencion", IdeDatosPagos));
                        }

                        // ----------------------------------------

                        catch (Exception ex)
                        {
                            string xMsgEnt = "";

                            xMsgEnt = Newtonsoft.Json.JsonConvert.SerializeObject(oAsegNombRequest);

                            msg_error = "Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Message: " + ex.ToString() + "<br/><br/>" + "Método del Siteds: ConsultaAsegNom <br/>" + "Datos de Entidades: <br/>" + xMsgEnt;


                            Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos");
                        }
                    }
                    while (false);

                    LimpiarVariables();
                }

                new TablasAD().Sp_Tablas_Update(new TablasE("MEDISYN_FECHA_PROCESO_PAGOS", "01", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), "nombre"));
            }
            catch (Exception ex)
            {
                msg_error = " Id Pago: " + IdeDatosPagos.ToString() + "<br/>" + "Message: " + ex.Message + "<br/> StackTrace: " + ex.StackTrace + "<br/>";

                Guardar_Error_BaseDatos(msg_error, "mtProcesarPagos");
            }
        }









        #endregion

        #region mtDatosPaciente
        private void mtDatosPaciente(MdsynDatosPagosE pMdsynDatosPagosE)
        {

            CodPaciente = pMdsynDatosPagosE.CodPaciente;
            DscNombresTitular = pMdsynDatosPagosE.NombresPacienteTitular;
            CodMedico = pMdsynDatosPagosE.CodMedico;
            CodEspecialidad = pMdsynDatosPagosE.CodEspecialidad;
            // xCodPoliza = pMdsynDatosPagosE.NroPlan 
            NumeroPlanPoliza = pMdsynDatosPagosE.NroPlan;
            CodAseguradora = pMdsynDatosPagosE.CodAseguradora;
            DscAseguradora = pMdsynDatosPagosE.DscAseguradora;
            CodCia = pMdsynDatosPagosE.CodCia;
            Observaciones = pMdsynDatosPagosE.DscObservaciones;
            CodAsegurado = pMdsynDatosPagosE.CodAsegurado;
            TipoAfiliacion = ""; // pMdsynDatosPagosE.tipa
            TipoPago = "T"; // E-Efectivo, T-Tarjeta
            DscNombresPaciente = pMdsynDatosPagosE.NombresPacientes;
            Sexo = pMdsynDatosPagosE.Sexo;
            FechaNacimiento = pMdsynDatosPagosE.FecNacimiento;
            CardCode = pMdsynDatosPagosE.CardCode;
            TipDocumento = pMdsynDatosPagosE.TipDocumento;
            DocIdentidad = pMdsynDatosPagosE.NumDocumento.Trim();
            DscCorreo = pMdsynDatosPagosE.DscCorreo.Trim();
            // Si viene indicando que la serie es 2, significa que es para JM, 1 es CM.
            CodSede = pMdsynDatosPagosE.CodSede == "2" ? "0" : pMdsynDatosPagosE.CodSede;
            CodCobertura = pMdsynDatosPagosE.CodCobertura;
            CoPagoFijo = pMdsynDatosPagosE.CoPagofijo.ToString();
            CoPagoVariable = pMdsynDatosPagosE.CoPagovariable.ToString();
            IdeDatosPagos = pMdsynDatosPagosE.IdeDatospagos;
            Direccion = pMdsynDatosPagosE.Direccion;
            TipMoneda = pMdsynDatosPagosE.TipMoneda;


            //CodRuc = pMdsynDatosPagosE.RucSunasa; // Siempre se carga desde la consulta 
            CodSunasa = pMdsynDatosPagosE.CodSunasa; // Siempre se carga desde la consulta el Cod. Sunasa (codigo de la sede).
            CodIAFAS = pMdsynDatosPagosE.CodIAFAS; // Siempre se carga desde la consulta el Cod. Iafas (codigo de la aseguradora).


            CodNombreEntidad = pMdsynDatosPagosE.CodEntidad;
            NumEntidad = pMdsynDatosPagosE.NroOperacion;
            TipParentesco = pMdsynDatosPagosE.TipParentesco;
            // xCodigoAutorizacion = pMdsynDatosPagosE.CodigoAutorizacion
            FechaCita = (pMdsynDatosPagosE.FecCita);
            EstProcesoAtencion = pMdsynDatosPagosE.EstProcesoAtencion;

            CodAtencion = pMdsynDatosPagosE.CodAtencion;
            CodComprobante = pMdsynDatosPagosE.CodComprobante;
            CodLiquidacion = pMdsynDatosPagosE.CodLiquidacion;
            EstConsultaMedica = pMdsynDatosPagosE.EstConsultaMedica;

            NombrePaciente = pMdsynDatosPagosE.NombrePaciente;
            ApPaternoPaciente = pMdsynDatosPagosE.ApPaternoPaciente;
            ApMaternoPaciente = pMdsynDatosPagosE.ApMaternoPaciente;

            Comprobante_CodTipoComprobante = pMdsynDatosPagosE.Comp_TipoComprobante;
            Comprobante_TipDocIdentidad = pMdsynDatosPagosE.Comp_TipDocIdentidad;
            Comprobante_RutDocIdentidad = pMdsynDatosPagosE.Comp_RutDocIdentidad;
            Comprobante_DscCorreoComprobante = pMdsynDatosPagosE.Comp_Correo;
            Comprobante_NombresComprobante = pMdsynDatosPagosE.NombresComprobante;

            TipProductoAseguradora = pMdsynDatosPagosE.TipPrt;
            NumDocEmpresa = pMdsynDatosPagosE.NumDocempresa; // Documento de empresa contratante
            TipDocEmpresa = pMdsynDatosPagosE.TipDocempresa; // Tipo de documento de empresa contratante

            CodTipoConsultaMedica = pMdsynDatosPagosE.CodTipoConsultaMedica;

            CodigoAutorizacion = pMdsynDatosPagosE.CodigoAutorizacion;
            TipoAfiliacion = pMdsynDatosPagosE.TipoAfiliacion;


        }
        #endregion

        #region CrearCiaContratante
        private void CrearCiaContratante()
        {
            if (CodCia == "") // Verificamos si tenemos el codcia
            {
                var objCiasE = new CiasE();
                var oResponseRuc = new Utilities.Apis.ResponseRuc();
                var oCiasAD = new CiasAD();

                if (TipDocEmpresa == "8")
                {
                    oResponseRuc = new Utilities.Apis().GetRuc(NumDocEmpresa);
                    if (oResponseRuc.ruc == NumDocEmpresa)
                    {
                        using (var xTrans = new TransactionScope())
                        {
                            try
                            {
                                oCiasAD.Sp_Cias_Insert(objCiasE);

                                oResponseRuc.nombre_o_razon_social = oResponseRuc.nombre_o_razon_social.Substring(0, oResponseRuc.nombre_o_razon_social.Length >= 60 ? 60 : oResponseRuc.nombre_o_razon_social.Length);
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, oResponseRuc.nombre_o_razon_social, "nombre"));

                                oResponseRuc.direccion = oResponseRuc.direccion.Substring(0, oResponseRuc.direccion.Length >= 60 ? 60 : oResponseRuc.direccion.Length);
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, oResponseRuc.direccion, "direccion"));

                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, oResponseRuc.ruc, "ruc"));

                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "telefono"));
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "contacto"));
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "correo"));
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "dsc_appaterno"));
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "dsc_apmaterno"));
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "dsc_segundonombre"));
                                oCiasAD.Sp_Cias_Update(new CiasE(objCiasE.Codcia, "", "dsc_primernombre"));

                                CodCia = objCiasE.Codcia;
                                xTrans.Complete();
                            }
                            catch (Exception ex)
                            {
                                xTrans.Dispose();
                            }

                        }
                    }
                    else
                    {
                        // call Guardar_Error_BaseDatos("No se pudo crear la contratante, revisar", "Crear cia contratante")
                    }
                }
            }
        }
        #endregion


        #region mtdAsignarAseguradoCorrecto
        /// <summary>
        /// Asignar al paciente los datos del asegurado correctamente, por defecto solo será para los activos.
        /// </summary>
        /// <param name="oListAsegNombResponse"></param>
        /// <param name="SoloActivos"></param>
        public void mtdAsignarAseguradoCorrecto(List<AsegNombResponse> oListAsegNombResponse, bool SoloActivos = true)
        {
            oAsegCodRequest = null;

            for (int j = 0, loopTo = oListAsegNombResponse.Count - 1; j <= loopTo; j++)
            {
                oAsegNomb = new AsegNombResponse();
                oAsegNomb = oListAsegNombResponse[j];

                // Verificamos que el paciente sea el correcto.
                if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa)
                {
                    oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                    break;
                }
                else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == "1" & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa & oAsegNomb.ApellidoPaternoAfiliado == ApPaternoPaciente & oAsegNomb.ApellidoMaternoAfiliado == ApMaternoPaciente)
                {
                    oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                    break;
                }
                else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa)
                {
                    oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                    NumeroPlanPoliza = "";
                    break;
                }
                else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora & CodIAFAS == "40005")
                {
                    oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                    break;
                }
            }

            // En caso no encontremos al paciente con el número de contratante correcto, permitimos sin contratante.
            if (oAsegCodRequest == null)
            {
                for (int j = 0, loopTo1 = oListAsegNombResponse.Count - 1; j <= loopTo1; j++)
                {
                    oAsegNomb = new AsegNombResponse();
                    oAsegNomb = oListAsegNombResponse[j];

                    // Verificamos que el paciente sea el correcto.
                    if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora)
                    {
                        oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                        break;
                    }
                    else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == "1" & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.ApellidoPaternoAfiliado == ApPaternoPaciente & oAsegNomb.ApellidoMaternoAfiliado == ApMaternoPaciente)
                    {
                        oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                        break;
                    }
                    else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.CodEstado == "1" & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa)
                    {
                        oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                        NumeroPlanPoliza = "";
                        break;
                    }
                }
            }

            if (SoloActivos == false) // Obtener datos de aseguradora en caso en caso no necesitemos obtener solo los activos.
            {
                if (oAsegCodRequest == null)
                {
                    for (int j = 0, loopTo2 = oListAsegNombResponse.Count - 1; j <= loopTo2; j++)
                    {
                        oAsegNomb = new AsegNombResponse();
                        oAsegNomb = oListAsegNombResponse[j];

                        // Verificamos que el paciente sea el correcto.
                        if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa)
                        {
                            oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                            break;
                        }
                        else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.ApellidoPaternoAfiliado == ApPaternoPaciente & oAsegNomb.ApellidoMaternoAfiliado == ApMaternoPaciente & oAsegNomb.NumeroDocumentoAfiliado == "1" & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa)
                        {
                            oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                            break;
                        }
                        else if (oAsegNomb.CodigoAfiliado == CodAsegurado & oAsegNomb.NumeroDocumentoAfiliado == DocIdentidad & oAsegNomb.CodProducto == TipProductoAseguradora & oAsegNomb.NumeroDocumentoContratante == NumDocEmpresa)
                        {
                            oAsegCodRequest = oWsSiteds.fnAsegCod(oAsegNomb);
                            NumeroPlanPoliza = "";
                            break;

                        }
                    }
                }
            }
        }
        #endregion







        #region mtdCargarDatosCobertura
        public void mtdCargarDatosCobertura(AsegCodResponse pAsegCodResponse, Coberturas_AsegCode pCoberturas)
        {

            if (CodTipoConsultaMedica == "A")
            {
                LineasCoberturas = LineasCoberturas + "Descripción del Tipo de Plan: " + pAsegCodResponse.DatosAfiliado.DesTipoPlan + '\r' + "Tipo de Cobertura: " + pCoberturas.Beneficios + '\r' + "CoPagoFijo: " + pCoberturas.DesCopagoFijo + '\r' + "CoPagoVariable: " + pCoberturas.DesCopagoVariable;

                CodSubTipoCobertura = pCoberturas.CodigoSubTipoCobertura;

                if (NumeroPlanPoliza.Length >= 3) // Solo en caso el numero de planpoliza es mayor a 3
                {
                    NumeroPlanPoliza = NumeroPlanPoliza.Substring(NumeroPlanPoliza.Length - 3, 3);
                }

                CodPoliza = CodAseguradora + oAsegCodRequest.NumeroPlan;
            }
            else
            {
                LineasCoberturas = LineasCoberturas + "Descripción del Tipo de Plan: " + "PARTICULAR" + '\r' + "Tipo de Cobertura: " + "Particular" + '\r' + "CoPagoFijo: " + CoPagoFijo + '\r' + "CoPagoVariable: " + CoPagoVariable;

                CodPoliza = CodAseguradora + NumeroPlanPoliza;
            }
        }
        #endregion



        #region GrabarDatosGenerales
        private bool GrabarDatosGenerales(AsegCodResponse pAsegCodResponse, NumeroAutorizacionRequest pNumAutorizacionRequest, string fAutoDate = "", string dAutoTime = "")
        {
            bool xResult = false;
            string codigo = "";

            // Se modifica para que la aseguradora RIMAC Seguros y Reaseguros ingrese con el código del iafas "40007". 22/02/2021
            if (CodIAFAS == "20001" & CodAseguradora == "0013")
            {
                oDatosGenerales.cIafasCode = "40007";
            }
            else
            {
                oDatosGenerales.cIafasCode = oAsegCodRequest.IAFAS;
            }

            oDatosGenerales.cAsegCode = oAsegCodRequest.CodigoAfiliado;
            oDatosGenerales.cAutoCode = CodigoAutorizacion;
            oDatosGenerales.fAutoDate = DateTime.Now.ToString("dd/MM/yyyy");
            oDatosGenerales.dAutoTime = DateTime.Now.ToString("HH:mm");
            // oDatosGenerales.fAutoDate = fAutoDate 'Date.Now.ToString("dd/MM/yyyy")
            // oDatosGenerales.dAutoTime = dAutoTime 'Date.Now.ToString("HH:mm")

            oDatosGenerales.cIpressCode = oAsegCodRequest.SUNASA;
            oDatosGenerales.dIpressRuc = oAsegCodRequest.RUC;
            oDatosGenerales.apAsegApat = oAsegCodRequest.ApellidoPaternoAfiliado;
            oDatosGenerales.apAsegAmat = oAsegCodRequest.ApellidoMaternoAfiliado;
            oDatosGenerales.nAsegName = oAsegCodRequest.NombresAfiliado;
            oDatosGenerales.apTituApat = pAsegCodResponse.DatosAfiliado.ApellidoMaternoTitular;
            oDatosGenerales.apTituAmat = pAsegCodResponse.DatosAfiliado.ApellidoMaternoTitular;
            oDatosGenerales.nTituName = pAsegCodResponse.DatosAfiliado.NombresTitular;
            oDatosGenerales.fNacmDate = pAsegCodResponse.DatosAfiliado.CodFechaNacimiento;
            oDatosGenerales.nEdadNum = int.Parse(pAsegCodResponse.DatosAfiliado.Edad);
            oDatosGenerales.cGeCode = pAsegCodResponse.DatosAfiliado.CodGenero;
            oDatosGenerales.cTituCode = pAsegCodResponse.DatosAfiliado.CodigoTitular;
            oDatosGenerales.cTipoPlan = pAsegCodResponse.DatosAfiliado.CodTipoPlan;
            oDatosGenerales.dCntrRuc = pAsegCodResponse.DatosAfiliado.NumeroDocumentoContratante;
            oDatosGenerales.dCntrName = pAsegCodResponse.DatosAfiliado.NombreContratante;
            oDatosGenerales.fIniVigDate = pAsegCodResponse.DatosAfiliado.FechaInicioVigencia;
            oDatosGenerales.fFinVigDate = pAsegCodResponse.DatosAfiliado.CodFechaFinVigencia;
            oDatosGenerales.fInclDate = pAsegCodResponse.DatosAfiliado.FechaAfiliacion;

            oDatosGenerales.cFiliaCode = pAsegCodResponse.DatosAfiliado.CodParentesco; // pNumAutorizacionRequest.CodTipoAfiliacion
            oDatosGenerales.cDniCode = pAsegCodResponse.DatosAfiliado.CodTipoDocumentoAfiliado;
            oDatosGenerales.nCntrNumb = pAsegCodResponse.DatosAfiliado.NumeroContrato;
            oDatosGenerales.cMoneCode = pAsegCodResponse.DatosAfiliado.CodMoneda;
            oDatosGenerales.cEstaCode = pAsegCodResponse.DatosAfiliado.CodEstado;
            oDatosGenerales.cAfiCode = pAsegCodResponse.DatosAfiliado.CodTipoAfiliacion;
            oDatosGenerales.cSedeCode = "";
            oDatosGenerales.dCarnNumb = "";
            oDatosGenerales.dObserva = "";
            oDatosGenerales.dFotoRuta = "";
            oDatosGenerales.nAsegPlan = pAsegCodResponse.DatosAfiliado.NumeroPlan;
            oDatosGenerales.nDniTitular = pAsegCodResponse.DatosAfiliado.NumeroDocumentoTitular;
            oDatosGenerales.cDniTitular = pAsegCodResponse.DatosAfiliado.CodTipoDocumentoTitular;
            oDatosGenerales.nPoliza = pAsegCodResponse.DatosAfiliado.NumeroPlan;
            oDatosGenerales.cCntrTipoDoc = pAsegCodResponse.DatosAfiliado.CodTipoDocumentoContratante;
            oDatosGenerales.nDniName = pAsegCodResponse.DatosAfiliado.NumeroDocumentoAfiliado;
            oDatosGenerales.dLogSusalud = "";
            oDatosGenerales.cEsCivil = pAsegCodResponse.DatosAfiliado.CodEstadoCivil;
            oDatosGenerales.nCertificado = pAsegCodResponse.DatosAfiliado.NumeroCertificado;
            oDatosGenerales.nCodSeguridad = "";
            oDatosGenerales.cIafasCodeCia = "";
            oDatosGenerales.dCondEspeciales = pNumAutorizacionRequest.CondicionesEspeciales;
            oDatosGenerales.cRenIpress = oAsegCodRequest.SUNASA;

            codigo = new Generales().InsertarDatosGenerales(oDatosGenerales);
            if (!string.IsNullOrEmpty(codigo))
                xResult = true;

            return xResult;
        }
        #endregion


        #region InsertarDatosGenerales
        public string InsertarDatosGenerales(DatosGeneralesE objDatosGenerales)
        {
            string codigo = "";
            bool xResult = false;
            try
            {
                codigo = new DatosGeneralesAD().Sp_DatosGenerales_Insert(ref objDatosGenerales);
            }
            catch (Exception ex)
            {
                codigo = "";
            }

            return codigo;
        }
        #endregion




        #region GrabarCoberturas
        private void GrabarCoberturas(Coberturas_AcredE pCobertura_Acred, Coberturas_AsegCode pCoberturas)
        {
            // Se modifica para que la aseguradora RIMAC Seguros y Reaseguros ingrese con el código del iafas "40007". 22/02/2021
            if (CodIAFAS == "20001" & CodAseguradora == "0013")
            {
                oCoberturas_Acred.cIafasCode = "40007";
            }
            else
            {
                oCoberturas_Acred.cIafasCode = oDatosGenerales.cIafasCode;
            }

            oCoberturas_Acred.cAsegCode = oDatosGenerales.cAsegCode;
            oCoberturas_Acred.cAutoCode = oDatosGenerales.cAutoCode;
            oCoberturas_Acred.cCoberCode = pCoberturas.CodigoTipoCobertura;  // TxtNumeroCobertura_Espera.Text
            oCoberturas_Acred.cSubTipoCober = pCoberturas.CodigoSubTipoCobertura; // TxtCodSubTipoCobertura_Aut.Text
            oCoberturas_Acred.nSubTipoCober = pCoberturas.Beneficios; // oCoberturas.nSubTipoCober 'TxtCodTipoCobertura_Aut.Text
            oCoberturas_Acred.cIndiProCode = pCobertura_Acred.cIndiProCode; // ""
            oCoberturas_Acred.nCopgFijo = double.Parse(oNumAutorizacionRequest.CodCopagoFijo); // TxtCodCopagoFijo_Aut.Text
            oCoberturas_Acred.cMoneCode = oDatosGenerales.cMoneCode;
            oCoberturas_Acred.cCalifServCode = oNumAutorizacionRequest.CodCalificacionServicio;  // TxtCodCalificacionServicio_Aut.Text
            oCoberturas_Acred.nCopgVari = double.Parse(oNumAutorizacionRequest.CodCopagoVariable);  // TxtCodCopagoVariable_Aut.Text
            oCoberturas_Acred.dBeneficioMax = oNumAutorizacionRequest.BeneficioMaximoInicial;  // TxtBeneficioMaximoInicial_Aut.Text
            oCoberturas_Acred.fFeCarDate = oNumAutorizacionRequest.CodFechaFinCarencia;  // TxtCodFechaFinCarencia_Aut.Text
            oCoberturas_Acred.fEsperDate = oNumAutorizacionRequest.CodFechaFinCarencia;
            oCoberturas_Acred.cFlagCarta = pCobertura_Acred.cFlagCarta;
            oCoberturas_Acred.cProdCode = oNumAutorizacionRequest.CodProducto;
            oCoberturas_Acred.cEspeCode = oNumAutorizacionRequest.CodEspecialidad;  // TxtCodEspecialidad_Cod.Text
            oCoberturas_Acred.dIpssHost = pCobertura_Acred.dIpssHost;
            oCoberturas_Acred.cOrigenAte = pCobertura_Acred.cOrigenAte;
            oCoberturas_Acred.cAccidentes = pCobertura_Acred.cAccidentes;
            oCoberturas_Acred.cTiDeclaracion = pCobertura_Acred.cTiDeclaracion;
            oCoberturas_Acred.dObserva = oDatosGenerales.dObserva;
            oCoberturas_Acred.dComercName = pCobertura_Acred.dComercName;
            oCoberturas_Acred.fAccidentes = pCobertura_Acred.fAccidentes;
            oCoberturas_Acred.fOrigenAten = pCobertura_Acred.fOrigenAten;
            oCoberturas_Acred.cUserCode = pCobertura_Acred.cUserCode;
            oCoberturas_Acred.nUserName = pCobertura_Acred.nUserName;
            oCoberturas_Acred.cFlagCGCode = pCobertura_Acred.cFlagCGCode;
            oCoberturas_Acred.dFlagCGName = pCobertura_Acred.dFlagCGName;
            oCoberturas_Acred.cIndiRestriCode = oNumAutorizacionRequest.CodIndicadorRestriccion;  // TxtCodIndicadorRestriccion_Aut.Text
            oCoberturas_Acred.dObsCarencia = "";
            // cod_relat = New Generales().InsertarDatosCoberturas(oCoberturas_Acred)
            new Generales().InsertarDatosCoberturas(oCoberturas_Acred);
        }

        #region InsertarDatosCoberturas
        public string InsertarDatosCoberturas(Coberturas_AcredE objCoberturas)
        {
            string codigo = "";
            bool xResult = false;

            try
            {
                codigo = new Coberturas_AcredAD().Sp_Coberturas_Acred_Insert(ref objCoberturas);
            }
            catch (Exception ex)
            {
                codigo = "";
            }

            return codigo;
        }
        #endregion

        #endregion

        #region GrabarProcedimientos
        private void GrabarProcedimientos(DatosGeneralesE pDatosGenerales, Coberturas_AcredE pCoberturas_Acred)
        {

            // Se modifica para que la aseguradora RIMAC Seguros y Reaseguros ingrese con el código del iafas "40007". 22/02/2021
            if (CodIAFAS == "20001" & CodAseguradora == "0013")
            {
                oProcedimientos.cIafasCode = "40007";
            }
            else
            {
                oProcedimientos.cIafasCode = pDatosGenerales.cIafasCode;
            }

            oProcedimientos.cAsegCode = pDatosGenerales.cAsegCode;
            oProcedimientos.cAutoCode = pDatosGenerales.cAutoCode;
            oProcedimientos.cCoberCode = oCoberturas_Acred.cCoberCode;
            oProcedimientos.cSubtipoCober = oCoberturas_Acred.cSubTipoCober;
            oProcedimientos.cItem = "1"; // dr("cItem")
            oProcedimientos.cTipoProcInt = ""; // dr("cTipoProcInt")
            oProcedimientos.nTipoProcName = oCoberturas_Acred.nSubTipoCober; // dr("nTipoProcName")
            oProcedimientos.cGeCode = pDatosGenerales.cGeCode;
            oProcedimientos.nCopgFijo = oCoberturas_Acred.nCopgFijo;
            oProcedimientos.nCopgVari = oCoberturas_Acred.nCopgVari; // oProcedimientosEspecialesResponse.Detalle.CodCopagoVariable 'oCoberturas_Acred.nCopgVari
            oProcedimientos.nFrecNumb = 0; // null; // encontrar el campo q almacene este valor
            oProcedimientos.nDiasCant = 0; // null; // encontrar el campo q almacene este valor
            oProcedimientos.dObserProc = "";
            // cod_relat = New Generales().InsertarProcedimientos(oProcedimientos)
            new Generales().InsertarProcedimientos(oProcedimientos);
        }
        #endregion

        #region InsertarDatosProcedimientos
        public string InsertarProcedimientos(ProcedimientosE objProcedimientos)
        {
            string codigo = "";
            bool xResult = false;

            try
            {
                codigo = new ProcedimientosAD().Sp_Procedimientos_Insert(ref objProcedimientos);
            }
            catch (Exception ex)
            {
                codigo = "";
            }

            return codigo;
        }
        #endregion



        #region GrabarExcepcionCarencia
        private void GrabarExcepcionCarencia(DatosGeneralesE pDatosGenerales, Coberturas_AcredE pCoberturas_Acred)
        {

            // Se modifica para que la aseguradora RIMAC Seguros y Reaseguros ingrese con el código del iafas "40007". 22/02/2021
            if (CodIAFAS == "20001" & CodAseguradora == "0013")
            {
                oExcepCarencia.cIafasCode = "40007";
            }
            else
            {
                oExcepCarencia.cIafasCode = pDatosGenerales.cIafasCode;
            }

            oExcepCarencia.cAsegCode = pDatosGenerales.cAsegCode;
            oExcepCarencia.cAutoCode = pDatosGenerales.cAutoCode;
            oExcepCarencia.cCoberCode = pCoberturas_Acred.cCoberCode;
            oExcepCarencia.cSubtipoCober = pCoberturas_Acred.cSubTipoCober;
            oExcepCarencia.cItem = oProcedimientos.cItem;
            oExcepCarencia.cDxExcepCaren = "";
            oExcepCarencia.nDxExcepCaren = "";
            oExcepCarencia.dObsExcepCaren = "";


            new Generales().InsertarDatosExpCarencia(oExcepCarencia);
        }
        #endregion

        #region InsertarDatosExpCarencia
        public string InsertarDatosExpCarencia(ExcepCarenciaE objCarencia)
        {
            string codigo = "";
            bool xResult = false;

            try
            {
                codigo = new ExcepCarenciaAD().Sp_ExcepCarencia_Insert(ref objCarencia);
            }
            catch (Exception ex)
            {
                codigo = "";
            }

            return codigo;
        }
        #endregion


        #region CrearAtencion
        public bool CrearAtencion(ref string pCodAtencion, string pTipoAtencion, string pCodPaciente, string pCodSede)
        {
            var oOtrosE = new OtrosE(pCodAtencion, Tarifa);

            try
            {
                var objHospitalE = new HospitalE();
                string wTen = CodTipoConsultaMedica == "A" ? "1" : "0"; // En caso la atención asegurado es "1", caso sea particular es "0".
                bool xPacienteAsegurado = CodTipoConsultaMedica == "A" ? true : false; // Por defecto el paciente si es asegurado, este modulo solo consedera pacientes asegurados.

                objHospitalE = new HospitalE(pCodAtencion, pCodPaciente, pTipoAtencion, CodUser, pCodSede);

                // Validar Cobertura
                int xError = new HospitalvalidarAD().Sp_HospitalValidarCobertura_Consulta(new HospitalValidarE("A", CodAseguradora, CodCobertura));
                if (xError != 0)
                {
                    throw new Exception("El tipo de atención no corresponde con la cobertura.");
                }

                string FechaFin = "";
                string FechaInicio = "";
                oOtrosE.FechaInicio = FechaCita.ToString("MM/dd/yyyy HH:mm");
                // oOtrosE.FechaInicio = Now.ToString("MM/dd/yyyy HH:mm")
                oOtrosE.Intervalo = CodTipoConsultaMedica == "A" ? 7 : 1;
                // oOtrosE.Intervalo = 90
                new OtrosAD().Sp_Intervalo_Fechas(ref oOtrosE);
                FechaFin = oOtrosE.FechaFin;
                FechaInicio = oOtrosE.FechaInicio;

                using (var Trans = new TransactionScope())
                {
                    try
                    {
                        // I.27/02/2020 - Para crear la atención. Actualizamos el estado del paciente por sí talvez lo anularon.
                        new PacientesAD().Sp_Pacientes_Update(new PacientesE(pCodPaciente, "estado", "A"));

                        new HospitalAD().Sp_Hospital_Insert_App(objHospitalE);
                        pCodAtencion = objHospitalE.CodAtencion;

                        if (!string.IsNullOrEmpty(pCodAtencion))
                        {
                            // INICIO - GRABAR POLIZA
                            var oConsultapolizasE = new ConsultaPolizasE();
                            oConsultapolizasE.Codatencion = pCodAtencion;
                            oConsultapolizasE.Linea = LineasCoberturas; // "Coberturas: " + Chr(13) + Chr(10) 'Agregar el contenido de la Aseguradora.
                            new ConsultaPolizasAD().Sp_ConsultaPolizas_InsertV2(ref oConsultapolizasE);
                            if (oConsultapolizasE.Idconsulta == 0)
                            {
                                throw new Exception("Sp_ConsultaPolizas_InsertV2: No se inserto la consultapolizas.");
                            }
                            // FIN - GRABAR POLIZAR

                            // GRABAR DATOS DE MEDICO
                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "codmedico", CodMedico));
                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "tipomedico", "T"));
                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "codespecialidad", CodEspecialidad));

                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "codpoliza", CodPoliza));
                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "codcia", CodCia));

                            if (CodTipoConsultaMedica == "A") // Solo para aseguradoras
                            {
                                new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "planpoliza", NumeroPlanPoliza));
                            }
                            else // Solo para particulares
                            {
                                new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "planpoliza", "C"));
                            }

                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "titular", DscNombresTitular));
                            // Verificamos si tiene valor en el codigo de autorización.
                            if (CodigoAutorizacion != "")
                            {
                                new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "numerodocumentoatencion", CodigoAutorizacion));
                                new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "tipodocumentoatencion", "01")); // OK - Se envia así
                            }

                            // Ingresar asegurado en caso se necesite.
                            // If xPacienteAsegurado = True Then
                            new AseguradosAD().Sp_Asegurados_Insert(new AseguradosE(pCodAtencion));

                            oOtrosE = new OtrosE(pCodAtencion, Tarifa);
                            new OtrosAD().Sp_CapturarTarifaAtencion(oOtrosE);
                            Tarifa = oOtrosE.Tarifa;
                            GrabarAsegurados(pCodAtencion);
                            GrabarCoberturaPoliza(pCodAtencion); // REVISAR EL TEMA DE LAS COBERTURAS DE POLIZAS.
                                                                 // End If

                            new HospitalAD().Sp_Hospital_Update(new HospitalE(pCodAtencion, "ten", wTen));
                        }

                        new HospitalAD().Sp_Hospital_Update(new HospitalE(CodAtencion, "fechainicio", FechaInicio)); // Agregar a fecha de inicio el dia del paciente
                        new HospitalAD().Sp_Hospital_Update(new HospitalE(CodAtencion, "fechafin", FechaFin));
                        // F.27/02/2020 - Para crear la atención. Actualizamos el estado del paciente por sí talvez lo anularon.

                        // If RTrim(xCodigoAutorizacion) <> "" Then
                        // RegistrarExclusiones wCodAtencion, xCodigoAutorizacion, CStr(xCodAsegurado), xCodigoAseguradora
                        // End If

                        Trans.Complete();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Trans.Dispose();
                        throw new Exception("Método: CrearAtención." + ('\r') + ex.Message + ('\r') + "StackTrace: " + ex.StackTrace + ('\r') + ex.Source);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                LimpiarVariables();
                throw new Exception("Método: CrearAtención." + ('\r') + ex.Message + ('\r') + "StackTrace: " + ex.StackTrace + ('\r') + ex.Source);
                return false;
            }
        }
        #endregion

        #region GrabarAsegurados
        private void GrabarAsegurados(string pCodAtencion)
        {
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "poliza", util.Mid(CodPoliza, 1, 16)));
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "codtarifa", Tarifa));

            if (CodTipoConsultaMedica == "A")
            {
                new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "planpoliza", util.Mid(NumeroPlanPoliza, 1, 4))); //    Strings.Mid(NumeroPlanPoliza, 1, 4)));
            }
            else // Solo para particulares
            {
                new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "planpoliza", "C"));
            }

            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "numerodiasatencion", "7"));
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "nombres", DscNombresPaciente));
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "sexo", Sexo));

            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "fechanacimiento", FechaNacimiento.ToString("MM/dd/yyyy")));
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "observaciones", Observaciones));
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "codigoaseguradoexterno", CodAsegurado));


            string DscTipoAfiliacion = "";
            switch (int.Parse(TipoAfiliacion))
            {
                case 1:
                    {
                        DscTipoAfiliacion = "REGULAR";
                        break;
                    }
                case 2:
                    {
                        DscTipoAfiliacion = "SCTR";
                        break;
                    }
                case 3:
                    {
                        DscTipoAfiliacion = "POTESTATIVO (INDEPENDIENTE)";
                        break;
                    }
                case 4:
                    {
                        DscTipoAfiliacion = "SCTR INDEPENDIENTE";
                        break;
                    }
                case 5:
                    {
                        DscTipoAfiliacion = "COMPLEMENTARIO";
                        break;
                    }

                default:
                    {
                        DscTipoAfiliacion = "REGULAR";
                        break;
                    }
            }

            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "tiposeguroexterno", util.Substring(DscTipoAfiliacion, 0, 1)));
            new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "codparentesco", TipParentesco));

            switch (CodAseguradora)
            {
                case var @case when @case == gAsegPacifico:
                case var case1 when case1 == gAsegPacificoVida:
                case var case2 when case2 == gAsegPacificoEps:
                    {
                        new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "codproducto", TipProductoAseguradora));
                        break;
                    }
                case var case3 when case3 == gAsegRimac:
                case var case4 when case4 == gAsegRimacEps:
                    {
                        // Call New AseguradosAD().Sp_Asegurados_Update(New AseguradosE(pCodAtencion, "codparentesco", ""))

                        new AseguradosAD().Sp_Asegurados_Update(new AseguradosE(pCodAtencion, "codproducto", TipProductoAseguradora));
                        break;
                    }
            }
        }
        #endregion


        #region GrabarCoberturaPoliza
        public void GrabarCoberturaPoliza(string pCodAtencion, string pTipoPaciente = "ASEGURADO")
        {
            string wTipoCobertura;
            string wIGV = "S";

            try
            {
                // COPAGOFIJO
                wTipoCobertura = "02"; // Revisar si es el tipo de cobertura correcto.
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Insert(new CoberturaPolizaE(pCodAtencion, wTipoCobertura));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "tipomonto", "M"));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "moneda", TipMoneda.Substring(0, 1)));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "igv", wIGV));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "estado", "A"));

                if (CodTipoConsultaMedica == "A") // Solo grabar estos datos en caso el paciente pase su cita como asegurado
                {
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "monto", CoPagoFijo));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "nombre", "CONSULTA AMBULATORIA"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "codcobertura", CodCobertura.Substring(0, 1)));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSubTipoCobertura", CodSubTipoCobertura));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSitedsVs", "10"));
                }
                else // Si es particular grabar siteds 
                {
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "igv", "N"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "monto", "0"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "nombre", "ATENCION PARTICULAR"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSitedsVs", "0"));
                }


                // COPAGOVARIABLE
                wTipoCobertura = "03"; // Revisar si es el tipo de cobertura correcto.
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Insert(new CoberturaPolizaE(pCodAtencion, wTipoCobertura));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "tipomonto", "P"));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "moneda", ""));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "igv", ""));
                new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "estado", "A"));

                if (CodTipoConsultaMedica == "A") // Solo grabar estos datos en caso el paciente pase su cita como asegurado
                {
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "nombre", "CONSULTA AMBULATORIA"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "monto", (100d - double.Parse(CoPagoVariable)).ToString()));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "codcobertura", util.Substring(CodCobertura, 0, 1)));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSubTipoCobertura", CodSubTipoCobertura));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSitedsVs", "10"));
                }
                else
                {
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "igv", "N"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "monto", CoPagoVariable.ToString()));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "nombre", "ATENCION PARTICULAR"));
                    new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSitedsVs", "0"));
                }

                // Solo en caso sea Sanitas, grabar los otros datos
                if (CodIAFAS == "20005")
                {
                    List<CoberturaPolizaE> oListCobPoliza;
                    var oCoberturaPolizaE = new CoberturaPolizaE();
                    oListCobPoliza = new CoberturaPolizaAD().Sp_CoberturaPolizaColsanitas_Consulta(new CoberturaPolizaE(pCodAtencion, util.Substring(CodCobertura, 0, 1)));

                    for (int i = 0, loopTo = oListCobPoliza.Count - 1; i <= loopTo; i++)
                    {
                        oCoberturaPolizaE = new CoberturaPolizaE();
                        oCoberturaPolizaE = oListCobPoliza[i];

                        wTipoCobertura = oCoberturaPolizaE.TipoCobertura; // Revisar si es el tipo de cobertura correcto.
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Insert(new CoberturaPolizaE(pCodAtencion, wTipoCobertura));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "nombre", oCoberturaPolizaE.Nombre));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "tipomonto", oCoberturaPolizaE.Tipomonto == "%" ? "P" : oCoberturaPolizaE.Tipomonto));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "monto", oCoberturaPolizaE.Monto.ToString()));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "moneda", oCoberturaPolizaE.Moneda));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "igv", oCoberturaPolizaE.Igv));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "estado", oCoberturaPolizaE.Estado));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "codcobertura", oCoberturaPolizaE.CodCobertura));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "codbeneficio", oCoberturaPolizaE.Codbeneficio));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSubTipoCobertura", CodSubTipoCobertura));
                        new CoberturaPolizaAD().Sp_CoberturaPoliza_Update(new CoberturaPolizaE(pCodAtencion, wTipoCobertura, "cSitedsVs", "10"));
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Método: GrabarCoberturaPoliza." + ('\r') + ex.ToString() + ('\r') + "<br/>Source: " + ex.Source + "<br/><br/>ERROR: " + ex.Message + "<br/>LINE: " + ex.Message);
            }
        }
        #endregion

        #region LimpiarVariables
        public void LimpiarVariables()
        {
            DscNombresPaciente = "";
            Sexo = "";
            FechaNacimiento = new DateTime(1900, 01, 01);
            CardCode = "";
            TipDocumento = "";
            DocIdentidad = "";
            DscCorreo = "";
            CodEmpresa = "001";
            TipoAtencion = "A";
            CodSede = "";
            Direccion = "";
            TipParentesco = "";

            CodAtencion = "";
            CodLiquidacion = "";

            CodPaciente = "";
            DscNombresTitular = "";
            CodMedico = "";
            CodEspecialidad = "";
            CodPoliza = "";
            NumeroPlanPoliza = "";
            CodAseguradora = "";
            DscAseguradora = "";
            CodCia = "";
            CodigoAutorizacion = "";
            Tarifa = "";
            Observaciones = "";
            CodAsegurado = "";
            TipoAfiliacion = "";
            TipoPago = "T";
            CodCobertura = "";
            CoPagoFijo = "0";
            CoPagoVariable = "0";
            IdeDatosPagos = 0;
            TipMoneda = "";
            CodNombreEntidad = ""; // Nro Operación
            NumEntidad = ""; // 001
            EstConsultaMedica = "P";

            CodPresotor = "";
            CorrelativoSerieBoleta = "";
            CorrelativoSerieFactura = "";
            CorrelativoSerieNotaCreditoBoleta = "";
            FlgElectronico = false;
            FlgGenerarE = false;
            FlgOtorgarBoleta = "false";
            FlgOtorgarFactura = "false";
            FlgOtorgarNotaCredito = "false";

            CodSubTipoCobertura = "";
            LineasCoberturas = "";
            EstProcesoAtencion = 0;
        }
        #endregion


        // Install-Package Microsoft.VisualBasic

        #region CrearPagoaCuenta
        public bool CrearPagoaCuenta(string pCodAtencion, double pMontoTotal, ref string pCodLiquidacion)
        {
            var objPresotorE = new PresotorE();
            var objLiquidacionE = new LiquidacionesE();
            var objPagosaCuentaMovE = new PagosaCuentaMovE();

            bool xResult = false;
            string xCodLiquidacion = "";
            double MontoSubTotal = 0d;

            MontoSubTotal = CalcularSubTotal(pMontoTotal);

            using (var Trans = new TransactionScope())
            {
                try
                {
                    objPresotorE = new PresotorE(pCodAtencion, MontoSubTotal, util.ValInt(CodUser), CodPresotor);
                    if (new PresotorAD().Sp_PresotorPago_Insert(objPresotorE) == true)
                    {
                        CodPresotor = objPresotorE.CodPresotor;

                        objLiquidacionE = new LiquidacionesE(pCodAtencion, "", "P", 1, xCodLiquidacion);
                        if (new LiquidacionesAD().Sp_Liquidaciones_Insert(objLiquidacionE) == true) // GENERAR LIQUIDACION AUTOMATICA
                        {
                            xCodLiquidacion = objLiquidacionE.CodLiquidacion;
                            pCodLiquidacion = xCodLiquidacion;
                            //new LiquidacionesAD().Sp_Liquidaciones_Insert(new LiquidacionesE(pCodAtencion, Strings.Mid(CodPresotor, 9), "P", 2, xCodLiquidacion));
                            new LiquidacionesAD().Sp_Liquidaciones_Insert(new LiquidacionesE(pCodAtencion, util.Mid(CodPresotor, 9), "P", 2, xCodLiquidacion));

                            objPagosaCuentaMovE = new PagosaCuentaMovE("02", MontoSubTotal, CodPresotor);
                            new PagosacuentaMovAD().Sp_PagoaCuentaMov_Insert(objPagosaCuentaMovE);

                            objLiquidacionE = new LiquidacionesE(pCodAtencion, "P", xCodLiquidacion);
                            new LiquidacionesAD().Sp_LiquidacionesRecalculo_Update(objLiquidacionE);

                            xResult = true;
                        }
                    }

                    Trans.Complete();
                }
                catch (Exception ex)
                {
                    Trans.Dispose();
                    xResult = false;
                }
            }

            return xResult;
        }

        private double CalcularSubTotal(double pMontoTotal)
        {
            double wIGV;
            double vIgv;
            var STotal = default(double);
            double wTotal;
            if (!string.IsNullOrEmpty((pMontoTotal.ToString())))
            {
                wTotal = pMontoTotal;
                wIGV = IGV / 100 + 1;
                if (wTotal > 0d)
                {
                    //STotal = Conversions.ToDouble(Strings.Mid(Strings.Format(wTotal / wIGV, "#.###"), 1, Strings.Len(Strings.Format(wTotal / wIGV, "#.###")) - 1));
                    STotal = wTotal / wIGV;

                    vIgv = Math.Round(wTotal - STotal, 2);
                    // txtIGV.Text = zClase.Round(vIgv, 2)
                    wIGV = Math.Round(vIgv, 2);
                }
            }
            return STotal;
        }
        #endregion

        #region GenerarComprobante_Alquiler
        //public string GenerarComprobante_Alquiler(string? pTipoComprobante, string? pCodLiquidacion, string? pMonto, string? pMoneda, string? pPCHostname)
        public string GenerarComprobante_Alquiler(ComprobantesE pComprobantesE, string? pPCHostname)
        {
            var objComprobanteE = new ComprobantesE();
            bool xResult = false;
            string xTipoDocumentoComprobante;
            string wOtorgarTci = "";
            string wTipoImpresion = "";
            bool wChkGratuito = false;
            string ExisteComprobante = "";
            string EstadoLiquidacion = "";
            string TipoDocumentoComp = "";

            var xResultadox = new RespuestaComprobanteTCI();

            do
            {
                try
                {
                    //CargarSerieCorrelativo(); // Cargar y Validar series y correlativos de los comprobantes.
                    //CorrelativoE Correlativo = new OtrosAD().Sp_Correlativo_Consulta_PC(new CorrelativoE(pPCHostname));

                    // INICIO - CARGAR DATOS PARA GENERAR EL COMPROBANTE
                    var oListLiq = new List<LiquidacionesE>();
                    oListLiq = new LiquidacionesAD().Sp_Liquidaciones_Consulta(new LiquidacionesE(pComprobantesE.CodLiquidacion));
                    if (oListLiq.Count >= 1)
                    {
                        wTipoImpresion = oListLiq[0].Tipoimpresion == "" ? "1" : oListLiq[0].Tipoimpresion; // Si es tipo de impresión 8, es un paquete. Este servicio no soporta paquetes.
                        wChkGratuito = oListLiq[0].FlgGratuito;
                        ExisteComprobante = oListLiq[0].Codcomprobante;
                        EstadoLiquidacion = oListLiq[0].Estado;
                        CodComprobante = oListLiq[0].Codcomprobante;

                        if (!string.IsNullOrEmpty(ExisteComprobante))
                            throw new Exception("Ya existe el comprobante de la liquidación: " + pComprobantesE.CodLiquidacion);
                        if (string.IsNullOrEmpty(EstadoLiquidacion) | EstadoLiquidacion != "G")
                            throw new Exception("Verifique estado de la liquidación \"(" + EstadoLiquidacion + ")\" : " + pComprobantesE.CodLiquidacion);

                        if (oListLiq[0].Pagagnc == "S")
                        { new LiquidacionesAD().Sp_Liquidaciones_Update(new LiquidacionesE(pComprobantesE.CodLiquidacion, "", "", "", 0, "pagagnc", "N")); }
                    }
                    // FIN - CARGAR DATOS PARA GENERAR EL COMPROBANTE

                    string TipoCompTCI = "";
                    CargarIniFacturacionElectronica(pComprobantesE.TipoComprobante, ref TipoCompTCI);

                    using (var Trans = new TransactionScope())
                    {
                        objComprobanteE = pComprobantesE;
                        new ComprobantesAD().Sp_ComprobanteManual_EFACT_Insert_Host(ref objComprobanteE, pPCHostname);

                        if (objComprobanteE.CodComprobante == "") // Verificamos que efectivamente devuelva el codigo del comprobante.
                        {
                            Trans.Dispose();
                            return objComprobanteE.CodComprobante;
                        }
                        else
                        {
                            CodComprobante = objComprobanteE.CodComprobante;
                            xTipoDocumentoComprobante = util.Left(CodComprobante, 1);
                            var flgOtorgar = new Serie().Sp_Serie_Consulta(new SerieE(CodComprobante, 1, 0)).Select(serie => serie.FlgOtorgar).FirstOrDefault().ToString();

                            // Asignar los valores según el tipo de comprobante
                            if (xTipoDocumentoComprobante == "B")
                            { FlgOtorgarBoleta = flgOtorgar; }
                            else if (xTipoDocumentoComprobante == "F")
                            { FlgOtorgarFactura = flgOtorgar; }

                            // Determinar el valor de wOtorgarTci
                            wOtorgarTci = xTipoDocumentoComprobante == "B" ? FlgOtorgarBoleta : FlgOtorgarFactura;

                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "codmedicotercero", CodEmpresa, pComprobantesE.Codmedicotercero)); // Se obtiene del Store: Sp_Liquidaciones_Consulta
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "flg_gratuito", CodEmpresa, wChkGratuito.ToString())); // Se obtiene del Store: Sp_Liquidaciones_Consulta
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "flg_credito", CodEmpresa, "1"));
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "codtipofactura", CodEmpresa, pComprobantesE.CodTipoFactura)); //02 - JM, 03 - 
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "tipofactura", CodEmpresa, pComprobantesE.Concepto));
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "detraccion", CodEmpresa, ""));

                            if (pComprobantesE.Tipdocidentidad == "0") //si tiene DNI
                            {
                                new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "tipdocidentidad", CodEmpresa, pComprobantesE.Tipdocidentidad));
                                new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "docidentidad", CodEmpresa, pComprobantesE.Docidentidad));
                            }
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "cardcode", CodEmpresa, pComprobantesE.Cardcode));

                            byte[] miBytevacio = { };
                            new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "correo", pComprobantesE.EmailMedico, "", miBytevacio)); // OK
                            new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "tipoafectacionigv", "", "", miBytevacio)); // OK

                            if (1 == 1) // SI ES ELECTRÓNICO, PONER CONDICIÓN EN CASO SE NECESITE.
                            {
                                if (xEnviarASunat != "S" & xEnviarASunat != "N")
                                {
                                    Trans.Dispose();
                                    return objComprobanteE.CodComprobante;
                                    throw new Exception("Error en el flag que indica si se envia a SUNAT");
                                    break;
                                }

                                if (util.Left(CodComprobante, 1) == "B")
                                {
                                    xResultadox = EnviarComprobanteTCI(TipoDocumento.Boleta, wOtorgarTci, CodComprobante, xEnviarASunat, "C");
                                }
                                else if (util.Left(CodComprobante, 1) == "F")
                                {
                                    xResultadox = EnviarComprobanteTCI(TipoDocumento.Factura, wOtorgarTci, CodComprobante, xEnviarASunat, "C");
                                }

                                if (xResultadox.ErroresComprobantes == ErroresComprobantesTCI.Correcto)
                                {
                                    Trans.Complete();
                                }
                                else
                                {
                                    CodComprobante = "";
                                    Trans.Dispose();
                                }
                            }
                        }
                    }
                    if (xResultadox.ErroresComprobantes == ErroresComprobantesTCI.Correcto)
                    {
                        byte[] miBytevacio = { }; ;
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "fecha_registro_rpta", "", "", miBytevacio));
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "tipo_otorgamiento", wOtorgarTci, "", miBytevacio));
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "xml_registro", "", xResultadox.RespuestaXML, miBytevacio));

                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "observacion_registro", "verdadero", "", miBytevacio));
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "codigobarra", "", "", xResultadox.CodigoBarra));

                        xResult = true;
                    }
                    else
                    {
                        throw new Exception("Cod. Atención: " + CodAtencion + "<br/>Cod. Paciente: " + CodPaciente + "<br/>Tipo de Error: " + xResultadox.ErroresComprobantes.ToString());
                    }
                }
                catch (Exception ex)
                {
                    CodComprobante = "";
                    throw new Exception("Cod. Comprobante: " + CodComprobante + "<br/>" + ex.ToString());
                }
            }
            while (false);

            return objComprobanteE.CodComprobante;
        }
        #endregion

        #region GenerarComprobantes
        public bool GenerarComprobante(string pTipoComprobante, string pCodLiquidacion, string pMonto, string pMoneda)
        {
            var objComprobanteE = new ComprobantesE();
            bool xResult = false;
            string xTipoDocumentoComprobante;
            string wOtorgarTci = "";
            string wTipoImpresion = "";
            bool wChkGratuito = false;
            string ExisteComprobante = "";
            string EstadoLiquidacion = "";
            string TipoDocumentoComp = "";

            var xResultadox = new RespuestaComprobanteTCI();

            do
            {
                try
                {
                    CargarSerieCorrelativo(); // Cargar y Validar series y correlativos de los comprobantes.

                    // INICIO - CARGAR DATOS PARA GENERAR EL COMPROBANTE
                    var oListLiq = new List<LiquidacionesE>();
                    oListLiq = new LiquidacionesAD().Sp_Liquidaciones_Consulta(new LiquidacionesE(pCodLiquidacion));
                    if (oListLiq.Count >= 1)
                    {
                        wTipoImpresion = oListLiq[0].Tipoimpresion == "" ? "1" : oListLiq[0].Tipoimpresion; // Si es tipo de impresión 8, es un paquete. Este servicio no soporta paquetes.
                        wChkGratuito = oListLiq[0].FlgGratuito;
                        ExisteComprobante = oListLiq[0].Codcomprobante;
                        EstadoLiquidacion = oListLiq[0].Estado;
                        CodComprobante = oListLiq[0].Codcomprobante;

                        if (!string.IsNullOrEmpty(ExisteComprobante))
                            throw new Exception("Ya existe el comprobante de la liquidación: " + pCodLiquidacion);
                        if (string.IsNullOrEmpty(EstadoLiquidacion) | EstadoLiquidacion != "G")
                            throw new Exception("Verifique estado de la liquidación \"(" + EstadoLiquidacion + ")\" : " + pCodLiquidacion);

                        if (oListLiq[0].Pagagnc == "S")
                        {
                            new LiquidacionesAD().Sp_Liquidaciones_Update(new LiquidacionesE(pCodLiquidacion, "", "", "", 0, "pagagnc", "N"));
                        }
                    }
                    // FIN - CARGAR DATOS PARA GENERAR EL COMPROBANTE

                    if (pMoneda != "S")
                    {
                        // 'pMonto=tipo
                    }

                    string TipoCompTCI = "";
                    CargarIniFacturacionElectronica(pTipoComprobante, ref TipoCompTCI);

                    using (var Trans = new TransactionScope())
                    {
                        objComprobanteE = CargarDataComprobante(pTipoComprobante, pCodLiquidacion, pMonto, pMoneda); // Cargar los datos del comprobante para el insert
                        new ComprobantesAD().Sp_Comprobante_Insert(ref objComprobanteE);

                        if (objComprobanteE.CodComprobante == "") // Verificamos que efectivamente devuelva el codigo del comprobante.
                        {
                            Trans.Dispose();
                            return false;
                        }
                        else
                        {
                            CodComprobante = objComprobanteE.CodComprobante;
                            xTipoDocumentoComprobante = util.Left(CodComprobante, 1);
                            wOtorgarTci = util.Left(CodComprobante, 1) == "B" ? FlgOtorgarBoleta : FlgOtorgarFactura;

                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "tipoimpresion", CodEmpresa, wTipoImpresion)); // Se obtiene del Store: Sp_Liquidaciones_Consulta
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "codturno", CodEmpresa, "0")); // OK
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "cardcode", CodEmpresa, CardCode));
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "flg_gratuito", CodEmpresa, wChkGratuito.ToString())); // Se obtiene del Store: Sp_Liquidaciones_Consulta
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "flg_credito", CodEmpresa, "0"));

                            if (1 == 2) // Si es comprobante a Personal CSF
                            {
                                new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "codtipofactura", CodEmpresa, "TipoPersonal"));
                                new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "codpersonal", CodEmpresa, "CodPersonal"));
                            }

                            if (TipDocumento == "1")
                            {
                                TipoDocumentoComp = 0.ToString();
                            }

                            if (pTipoComprobante == "B")
                            {
                                if (TipDocumento == "1") // Si tiene Dni
                                {
                                    new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "tipdocidentidad", CodEmpresa, Comprobante_TipDocIdentidad)); // TipoDocumentoComp'OK
                                    new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "docidentidad", CodEmpresa, Comprobante_RutDocIdentidad)); // OK
                                }
                            }
                            else
                            {

                            }
                            byte[] miBytevacio = { };


                            new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "correo", Comprobante_DscCorreoComprobante, "", miBytevacio)); // OK
                            new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "tipoafectacionigv", "", "", miBytevacio)); // OK
                            new ComprobantesAD().Sp_Comprobante_Update(new ComprobantesE(CodComprobante, "detraccion", CodEmpresa, "")); // OK

                            if (1 == 1) // SI ES ELECTRÓNICO, PONER CONDICIÓN EN CASO SE NECESITE.
                            {
                                if (xEnviarASunat != "S" & xEnviarASunat != "N")
                                {
                                    Trans.Dispose();
                                    return false;
                                    throw new Exception("Error en el flag que indica si se envia a SUNAT");
                                    break;
                                }

                                if (util.Left(CodComprobante, 1) == "B")
                                {
                                    xResultadox = EnviarComprobanteTCI(TipoDocumento.Boleta, wOtorgarTci, CodComprobante, xEnviarASunat, "C");
                                }
                                else if (util.Left(CodComprobante, 1) == "F")
                                {
                                    xResultadox = EnviarComprobanteTCI(TipoDocumento.Factura, wOtorgarTci, CodComprobante, xEnviarASunat, "C");
                                }

                                if (xResultadox.ErroresComprobantes == ErroresComprobantesTCI.Correcto)
                                {
                                    Trans.Complete();
                                }
                                else
                                {
                                    CodComprobante = "";
                                    Trans.Dispose();
                                }
                            }
                        }
                    }
                    if (xResultadox.ErroresComprobantes == ErroresComprobantesTCI.Correcto)
                    {
                        byte[] miBytevacio = { }; ;
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "fecha_registro_rpta", "", "", miBytevacio));
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "tipo_otorgamiento", wOtorgarTci, "", miBytevacio));
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "xml_registro", "", xResultadox.RespuestaXML, miBytevacio));

                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "observacion_registro", "verdadero", "", miBytevacio));
                        new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Update(new ComprobantesElectronicosE(CodComprobante, "codigobarra", "", "", xResultadox.CodigoBarra));

                        xResult = true;
                    }
                    else
                    {
                        throw new Exception("Cod. Atención: " + CodAtencion + "<br/>Cod. Paciente: " + CodPaciente + "<br/>Tipo de Error: " + xResultadox.ErroresComprobantes.ToString());
                    }
                }
                catch (Exception ex)
                {
                    CodComprobante = "";
                    throw new Exception("Cod. Comprobante: " + CodComprobante + "<br/>" + ex.ToString());
                }
            }
            while (false);

            return xResult;
        }
        #endregion

        #region RespuestaComprobanteTCI
        public partial class RespuestaComprobanteTCI
        {
            public ErroresComprobantesTCI ErroresComprobantes { get; set; }
            public string Respuesta { get; set; }
            public byte[] CodigoBarra { get; set; } = Array.Empty<byte>();
            public string RespuestaXML { get; set; }

            public RespuestaComprobanteTCI()
            {

            }

            public RespuestaComprobanteTCI(ErroresComprobantesTCI pErroresComprobantes, string pRespuesta)
            {

                Respuesta = pRespuesta;
                ErroresComprobantes = pErroresComprobantes;
            }
        }
        #endregion


        #region ErroresComprobantesTCI
        public enum ErroresComprobantesTCI
        {
            Correcto = 0,
            DetalleNegativo = -1,
            ComprobanteNoExiste_NoHayDetalle = -2,
            ErrorConstruirXML = -3,
            ErrorStored = -4,
            Otros = -10
        }
        #endregion



        #region CargarSerieCorrelativo
        public void CargarSerieCorrelativo()
        {
            try
            {
                var oDsCorrelativo = new DataSet();
                oDsCorrelativo = new OtrosAD().Sp_Correlativo_Consulta();
                if (oDsCorrelativo.Tables.Count >= 1)
                {
                    CorrelativoSerieBoleta = oDsCorrelativo.Tables[0].Rows[0]["Boleta"] + "";

                    CorrelativoSerieFactura = oDsCorrelativo.Tables[0].Rows[0]["Factura"] + "";
                    CorrelativoSerieNotaCreditoBoleta = oDsCorrelativo.Tables[0].Rows[0]["CreditoB"] + "";
                    CorrelativoSerieNotaCreditoFactura = oDsCorrelativo.Tables[0].Rows[0]["CreditoF"] + "";
                    FlgElectronico = oDsCorrelativo.Tables[0].Rows[0]["flg_electronico"] == "S" ? true : false;
                    FlgGenerarE = oDsCorrelativo.Tables[0].Rows[0]["generar_e"] == "S" ? true : false;
                    FlgOtorgarBoleta = oDsCorrelativo.Tables[0].Rows[0]["flg_otorgarb"].ToString(); // IIf(oDsCorrelativo.Tables(0).Rows(0).Item("flg_otorgarf") = "1", "1", False)
                    FlgOtorgarBoleta = oDsCorrelativo.Tables[0].Rows[0]["flg_otorgarb"].ToString(); // IIf(oDsCorrelativo.Tables(0).Rows(0).Item("flg_otorgarf") = "1", "1", False)
                    FlgOtorgarFactura = oDsCorrelativo.Tables[0].Rows[0]["flg_otorgarf"].ToString(); // IIf(oDsCorrelativo.Tables(0).Rows(0).Item("flg_otorgarb") = "1", True, False)
                    FlgOtorgarNotaCredito = oDsCorrelativo.Tables[0].Rows[0]["flg_otorgarcb"].ToString(); // IIf(oDsCorrelativo.Tables(0).Rows(0).Item("flg_otorgarcb") = "1", True, False)

                    if (util.Left(CorrelativoSerieBoleta, 1) == "B" & CorrelativoSerieBoleta.Trim().Length != 11)
                        throw new Exception("El servicio (App de Pagos) no tiene serie de Boleta"); // Validación
                    if (util.Left(CorrelativoSerieFactura, 1) == "F" & CorrelativoSerieFactura.Trim().Length != 11)
                        throw new Exception("El servicio (App de Pagos) no tiene serie de Factura"); // Validación
                    if (util.Left(CorrelativoSerieNotaCreditoBoleta, 1) == "C" & CorrelativoSerieNotaCreditoBoleta.Trim().Length != 11)
                        throw new Exception("El servicio (App de Pagos) no tiene serie de Notas de Crédito Boleta"); // Validación
                    if (util.Left(CorrelativoSerieNotaCreditoFactura, 1) == "C" & CorrelativoSerieNotaCreditoFactura.Trim().Length != 11)
                        throw new Exception("El servicio (App de Pagos) no tiene serie de Notas de Crédito Factura"); // Validación

                    oDsCorrelativo.Dispose();
                    oDsCorrelativo = default;
                }
                else
                {
                    throw new Exception("El store \"Sp_Correlativo_Consulta\" no está devolviendo la serie de la boleta/factura/nota de crédito para usar en el servicio " + ('\r')); //+ global::My.Computer.Name) ; ; ; // ;  ;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion



        #region CargarIniFacturacionElectronica
        //public void CargarIniFacturacionElectronica(string pTipoDocumentoComprobante, ref string pTipoCompTCI)
        //{
        //    // Validar Envio Flag Sunat
        //    oLTablas = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_FLAG_ENVIAASUNAT", "", 0, 0, 7));
        //    if (oLTablas.Count >= 1)
        //    {
        //        if (oLTablas[0].Codigo == "")
        //        {
        //            throw new Exception("Error en el parametro de EFACT_FLAG_ENVIAASUNAT, está vacio");
        //        }
        //        else
        //        {
        //            xEnviarASunat = (oLTablas[0].Codigo + "").Trim();
        //            if (oLTablas.Count == 2)
        //                xUrlWsTCI = oLTablas[1].Nombre;
        //        } // Devuelve la URL del Services de Tisal en caso este habilitado
        //    }

        public void CargarIniFacturacionElectronica(string pTipoDocumentoComprobante, ref string pTipoCompTCI)
        {
            // Validar Envio Flag Sunat
            oLTablas = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_FLAG_ENVIAASUNAT", "", 0, 0, 7));
            if (oLTablas.Count >= 1)
            {
                if (oLTablas[0].Codigo == "")
                {
                    throw new Exception("Error en el parametro de EFACT_FLAG_ENVIAASUNAT, está vacio");
                }
                else
                {
                    xEnviarASunat = (oLTablas[0].Codigo + "").Trim();
                    //if (oLTablas.Count == 2)
                    //    xUrlWsTCI = oLTablas[1].Nombre;
                    if (xEnviarASunat == "S")
                    { xUrlWsTCI = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_TCI_WS", "", 0, 0, 29)).FirstOrDefault(item => item.Estado == "A")?.Nombre ?? "http://egestor.ubl21.efacturacion.pe/WS_TCI/Service.asmx"; }
                } // Devuelve la URL del Services de Tisal en caso este habilitado
            }
            List<TablasE> oList;
            oList = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_TIPOCOMP_FORCALL_WS_TCI", pTipoDocumentoComprobante, 50, 1, -1));
            if (oList.Count >= 1)
                pTipoCompTCI = oList[0].Nombre.Trim();

            if (string.IsNullOrEmpty((DscCorreo.Trim()))) // Verificar correo
            {
                oList = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_CORREOENVIOCOMPROBANTE", "01", 50, 1, -1));
                if (oList.Count >= 1)
                    DscCorreo = oList[0].Nombre.Trim();
            }
        }
        #endregion

        #region CargarDataComprobante
        private ComprobantesE CargarDataComprobante(string pTipoComprobante, string pCodLiquidacion, string pMonto, string pMoneda, string pOperacion = "G", string pTipoPago = "", string pCodNombreEntidad = "", string pNumeroEntidad = "", string pCodTerminal = "", string pCodComprobante = "")
        {
            var objComprobanteE = new ComprobantesE();

            string xRuc = "";
            string CodTerminal = "282";
            string NumeroEntidad = "02";
            string CodNombreEntidad = "Nro Operación";


            pCodTerminal = pCodTerminal == "000" ? "282" : pCodTerminal; //jrra esta linea debe eliminarse


            // xMoneda As String = pMoneda 'S-Soles, D-Dolares

            // pTipoPago = T - Tarjeta.
            // pCodNombreEntidad = 02 - Visa, se invoca de la tabla: tablas.
            // pNumeroEntidad = Nro. Operación Tarjeta
            // CodTerminal = 282

            objComprobanteE.TipoComprobante = pTipoComprobante;
            objComprobanteE.CodLiquidacion = pCodLiquidacion;
            objComprobanteE.Monto = pOperacion == "G" ? CalcularSubTotal(double.Parse(pMonto)) : double.Parse(pMonto);
            objComprobanteE.ANombreDeQuien = Comprobante_NombresComprobante;
            objComprobanteE.Ruc = Comprobante_RutDocIdentidad; // Comprobante_CodTipoComprobante == "F" ? Comprobante_RutDocIdentidad : ""; // xRuc
            objComprobanteE.Direccion = Direccion;
            objComprobanteE.TipoPago = pTipoPago;
            objComprobanteE.NombreEntidad = pCodNombreEntidad;
            objComprobanteE.NombreEntidad = pCodNombreEntidad;
            objComprobanteE.NumeroEntidad = pNumeroEntidad;
            objComprobanteE.Operacion = pOperacion; // G -> Generado; P: Pagado
            objComprobanteE.VariosTipoPago = "N";
            objComprobanteE.CodComprobante = "";
            objComprobanteE.Moneda = pMoneda;
            objComprobanteE.CodEmpresa = CodEmpresa;
            objComprobanteE.CodTipoFactura = "";
            objComprobanteE.CodTerminal = pCodTerminal;
            objComprobanteE.CodComprobante = pCodComprobante;

            return objComprobanteE;
        }
        #endregion

        #region Obtener PDF TCI
        public ObtenerPDF.Response ObtenerComprobantePDF(ObtenerPDF.Requests pObtenerPDF)
        {

            ObtenerPDF.Response oObtenerPDFResultado = new ObtenerPDF.Response();
            try
            {
                List<TablasE> oTablas = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_FLAG_ENVIAASUNAT", "", 0, 0, 29));
                if (oTablas.Count > 0)
                { pObtenerPDF.EnviarSunat = oTablas.Any(item => item.Codigo == "S"); }

                if (pObtenerPDF.EnviarSunat)
                {
                    //xUrlWsTCI = "http://192.168.22.180/WS_TCI/Service.asmx";
                    xUrlWsTCI = new TablasAD().Sp_Tablas_Consulta(new TablasE("EFACT_TCI_WS", "", 0, 0, 29)).FirstOrDefault(item => item.Estado == "A")?.Nombre ?? "http://egestor.ubl21.efacturacion.pe/WS_TCI/Service.asmx";

                    OpenConfigWebServicesTci(xUrlWsTCI);
                    using (var oWsComprobante = new WSComprobanteSoapClient(BindingTci, EndPoint))
                    {
                        List<TablasE> oLista = new List<TablasE>();
                        TablasE oRUC = new TablasE();
                        oLista = new Tablas().Sp_Tablas_Consulta(new TablasE("EFACT_PARAMETROSWSTCI", "", 0, 0, 29));
                        if (oLista.Count > 0)
                        { oRUC = oLista.FirstOrDefault(item => item.Codigo == "RUC"); }

                        List<ComprobantesElectronicosE> oListaComprobantesElectronicos = new List<ComprobantesElectronicosE>();
                        oListaComprobantesElectronicos = new ComprobantesElectronicos().ComprobantesElectronicos_Consulta(new ComprobantesElectronicosE(pObtenerPDF.Comprobante, 7));

                        if (oListaComprobantesElectronicos.Count == 1)
                        {
                            ENPeticion oENPeticion = new ENPeticion();
                            oENPeticion.Ruc = oRUC.Nombre;
                            oENPeticion.Serie = pObtenerPDF.Comprobante.Substring(0, 4);
                            oENPeticion.Numero = Convert.ToInt32(pObtenerPDF.Comprobante.Substring(4)).ToString();
                            oENPeticion.TipoComprobante = oListaComprobantesElectronicos[0].TipoComprobanteSunat;//pTipoDocumento;
                            oENPeticion.IndicadorComprobante = 1;

                            Obtener_PDFRequest pObtenerPDFRequest = new Obtener_PDFRequest();
                            pObtenerPDFRequest.oENPeticion = oENPeticion;
                            pObtenerPDFRequest.Cadena = "";

                            var respuestaPDF = oWsComprobante.Obtener_PDFAsync(pObtenerPDFRequest).Result;
                            if (string.IsNullOrEmpty(respuestaPDF.Cadena))
                            { oObtenerPDFResultado = new ObtenerPDF.Response(respuestaPDF.Obtener_PDFResult.ArchivoPDF, respuestaPDF.Obtener_PDFResult.NombrePDF, false, "Exito"); }
                            else
                            { oObtenerPDFResultado = new ObtenerPDF.Response(true, respuestaPDF.Cadena); }
                        }
                        else
                        { oObtenerPDFResultado = new ObtenerPDF.Response(true, "Comprobante no encontrado en CLINICA"); }
                    }
                }
                else
                { oObtenerPDFResultado = new ObtenerPDF.Response(true, "Servicio Inactivo"); }
            }
            catch (Exception ex)
            { oObtenerPDFResultado = new ObtenerPDF.Response(true, ex.Message); }

            return oObtenerPDFResultado;
        }
        #endregion

        #region Enviar Comprobante TCI
        public RespuestaComprobanteTCI EnviarComprobanteTCI(TipoDocumento pTipoDocumento, string pOtorgarTci, string pCodComprobante, string pEnviarSunat = "N", string pSistema = "C")
        {
            string XML_General = @"<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                      <soap:Body>
                        <Registrar xmlns=""http://tempuri.org/"">
                          <oGeneral>";

            var xResult = new RespuestaComprobanteTCI(ErroresComprobantesTCI.Otros, "");

            string wTotal_valorventa;
            string wTotal_precioventa;

            do
            {
                try
                {
                    string TextoGratuito = "TRANSFERENCIA GRATUITA DE UN BIEN Y/O SERVICIO PRESTADO GRATUITAMENTE";
                    var objTablasE = new TablasE();
                    string wNota2 = "";

                    var oGeneral = new General();
                    var oENComprobante = new ENComprobante();
                    var oENEmpresa = new ENEmpresa();
                    var oListError = Array.Empty<ENErrorComunicacion>();

                    var oListComprobanteElectronicoXML = new List<ComprobanteElectronicoXMLCabE>();
                    var oComprobElecXMLCabE = new ComprobanteElectronicoXMLCabE();

                    var xCodigoBarras = Array.Empty<byte>();
                    int wTipoCodigoTCI = 0;

                    int i = 0;

                    objTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("EFACT_TIPOCODIGO_BARRAHASH", "01", 50, 1, -1));
                    wTipoCodigoTCI = int.Parse(objTablasE.Valor.ToString()); // 0: Codigo Barras, 1: Codigo Hash

                    if (pSistema == "C")
                    {
                        if (util.Left(pCodComprobante, 1) == "B" | util.Left(pCodComprobante, 1) == "F")
                        {
                            oListComprobanteElectronicoXML = new ComprobantesElectronicosAD().Sp_ComprobantesElectronicosCSF_XML_Cab(new ComprobantesElectronicosE(pCodComprobante));
                        }
                        else if (util.Left(pCodComprobante, 1) == "C")
                        {
                            oListComprobanteElectronicoXML = new ComprobantesElectronicosAD().Sp_NotaElectronicaCSF_XML(new ComprobantesElectronicosE(pCodComprobante, "001"));
                        }
                    }
                    else if (pSistema == "L")
                    {
                        if (util.Left(pCodComprobante, 1) == "B" | util.Left(pCodComprobante, 1) == "F")
                        {
                            oListComprobanteElectronicoXML = new ComprobantesElectronicosAD().Sp_ComprobantesElectronicosLOG_XML_Cab(new ComprobantesElectronicosE(pCodComprobante));
                        }
                        else if (util.Left(pCodComprobante, 1) == "C")
                        {
                            oListComprobanteElectronicoXML = new ComprobantesElectronicosAD().Sp_NotaElectronicaLOG_XML(new ComprobantesElectronicosE(pCodComprobante));
                        }
                    }


                    // I.Validaciones al construir el Web Services
                    if (oListComprobanteElectronicoXML.Count == 0)
                    {
                        xResult.ErroresComprobantes = ErroresComprobantesTCI.ComprobanteNoExiste_NoHayDetalle;
                        break;
                    }
                    else if (oComprobElecXMLCabE.Cuadre == "N01") // En caso existe algún negativo en el detalle
                    {
                        xResult.ErroresComprobantes = ErroresComprobantesTCI.DetalleNegativo;
                        break;
                    }
                    // F.Validaciones al construir el Web Services

                    oComprobElecXMLCabE = oListComprobanteElectronicoXML[0];

                    #region XML_1 - COMPROBANTE MONTOS ADICIONALES OBLIGATORIOS ENComprobanteMontosAdicionalesObligatorios
                    var oComprobanteMontosAdicionalesObligatorios = new ENComprobanteMontosAdicionalesObligatorios[3];
                    i = 0;
                    oComprobanteMontosAdicionalesObligatorios[i] = new ENComprobanteMontosAdicionalesObligatorios();
                    oComprobanteMontosAdicionalesObligatorios[i].Codigo = "1001";
                    oComprobanteMontosAdicionalesObligatorios[i].Monto = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.C_MontoAfecto).ToString("########.00"));

                    i = 1;
                    oComprobanteMontosAdicionalesObligatorios[i] = new ENComprobanteMontosAdicionalesObligatorios();
                    oComprobanteMontosAdicionalesObligatorios[i].Codigo = "1002";
                    oComprobanteMontosAdicionalesObligatorios[i].Monto = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.C_MontoInafecto).ToString("########.00"));

                    i = 2;
                    oComprobanteMontosAdicionalesObligatorios[i] = new ENComprobanteMontosAdicionalesObligatorios();
                    oComprobanteMontosAdicionalesObligatorios[i].Codigo = "1003";
                    oComprobanteMontosAdicionalesObligatorios[i].Monto = 0;

                    oENComprobante.ComprobanteMontosAdicionalesObligatorios = oComprobanteMontosAdicionalesObligatorios;
                    #endregion

                    wTotal_valorventa = decimal.Parse(oComprobElecXMLCabE.TotalValorVenta).ToString("########.00");
                    wTotal_precioventa = decimal.Parse(oComprobElecXMLCabE.TotalPrecioVenta).ToString("########.00");

                    if (oComprobElecXMLCabE.FlgGratuito == "1")
                    {
                        wTotal_valorventa = "0.00";
                        wTotal_precioventa = "0.00";
                    }

                    #region XML_11 - ENComprobanteMontosAdicionalesOtros
                    var oENComprobanteMontosAdicionalesOtros = new ENComprobanteMontosAdicionalesOtros();
                    if (oComprobElecXMLCabE.FlgGratuito == "1" & (util.Left(pCodComprobante, 1) == "B" | (util.Left(pCodComprobante, 1) == "F")))
                    {
                        oENComprobanteMontosAdicionalesOtros.Codigo = "1004";
                        oENComprobanteMontosAdicionalesOtros.Monto = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.C_MontoGratuito).ToString("########.00"));
                        oGeneral.oENComprobante.ComprobanteMontosAdicionalesOtros[0] = oENComprobanteMontosAdicionalesOtros;
                    }
                    #endregion

                    #region XML_2 - COMPROBANTE IMPUESTOS - oENComprobanteImpuestos
                    var oENComprobanteImpuestos = new ENComprobanteImpuestos[1];
                    oENComprobanteImpuestos[0] = new ENComprobanteImpuestos();
                    oENComprobanteImpuestos[0].ImporteTributo = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.C_MontoIgv).ToString("########.00")); // "8.1"
                    oENComprobanteImpuestos[0].ImporteExplicito = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.C_MontoIgv).ToString("########.00")); // "8.1"
                    oENComprobanteImpuestos[0].CodigoTributo = oComprobElecXMLCabE.CodTributo;  // "1000" 'OK
                    oENComprobanteImpuestos[0].DesTributo = oComprobElecXMLCabE.DesTributo; // "IGV" 'OK
                    oENComprobanteImpuestos[0].CodigoUN = oComprobElecXMLCabE.CodUN; // "VAT" 'OK

                    oENComprobante.ComprobanteImpuestos = oENComprobanteImpuestos;
                    #endregion

                    #region XML_3 - SALUD
                    var oENSalud = new ENSalud();
                    oENSalud.Concepto = oComprobElecXMLCabE.Concepto.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENSalud.OAM = oComprobElecXMLCabE.CodAtencion;
                    oENSalud.Historia = oComprobElecXMLCabE.CodPaciente;
                    oENSalud.Paciente = oComprobElecXMLCabE.NombrePaciente.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENSalud.Titular = oComprobElecXMLCabE.NombreTitular.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENSalud.Empresa = pSistema == "C" ? oComprobElecXMLCabE.NombreCia.Replace("<![CDATA[", "").Replace("]]>", "").Trim() : "";
                    oENSalud.Poliza = pSistema == "C" ? oComprobElecXMLCabE.CodPoliza.Trim() : "";
                    oENSalud.Codigo = pSistema == "C" ? oComprobElecXMLCabE.Ciuu : oComprobElecXMLCabE.CodVenta; // ""

                    if (pSistema == "C")
                    {
                        oENSalud.Liquidacion = oComprobElecXMLCabE.CodLiquidacion; // "0004037383"
                        oENSalud.Habitacion = oComprobElecXMLCabE.Cama; // ""
                    }
                    else if (pSistema == "L")
                    {
                        oENSalud.Coaseguro = oComprobElecXMLCabE.PorcentajeCoAseguro;
                    }

                    oENComprobante.Salud = oENSalud;
                    #endregion

                    #region XML_4 - Texto ENTexto
                    var oENTexto = new ENTexto[1];
                    oENTexto[0] = new ENTexto();
                    oENTexto[0].Texto1 = oComprobElecXMLCabE.Texto1.Trim();
                    oENComprobante.Texto = oENTexto;
                    #endregion

                    #region XML_5 - SUCURSAL ENSucursal
                    var oENSucursal = new ENSucursal[1];
                    oENSucursal[0] = new ENSucursal();
                    oENSucursal[0].Direccion = oComprobElecXMLCabE.SucDireccion.Trim();
                    oENComprobante.Sucursal = oENSucursal;
                    #endregion

                    #region XML_6 - COMPROBANTES PROPIEDADES - ENComprobantePropiedadesAdicionales
                    if (oComprobElecXMLCabE.FlgGratuito == "1" & (util.Left(pCodComprobante, 1) == "B" | util.Left(pCodComprobante, 1) == "F"))
                    {
                        var oENComprobantePropiedadesAdicionales = new ENComprobantePropiedadesAdicionales();
                        oENComprobantePropiedadesAdicionales.Codigo = "1002";
                        oENComprobantePropiedadesAdicionales.Valor = TextoGratuito;
                        oENComprobante.ComprobantePropiedadesAdicionales[0] = oENComprobantePropiedadesAdicionales;
                    }

                    if (util.Left(pCodComprobante, 1) == "F" & double.Parse(oComprobElecXMLCabE.DetraccionMonto) > 0d & pSistema == "C")
                    {
                        //var oENComprobantePropiedadesAdicionales = new ENComprobantePropiedadesAdicionales();
                        //int j = oGeneral.oENComprobante.ComprobantePropiedadesAdicionales.Count();
                        //oENComprobantePropiedadesAdicionales.Codigo = "2006";
                        //oENComprobantePropiedadesAdicionales.Valor = "Operación sujeta a detracción";
                        //oENComprobante.ComprobantePropiedadesAdicionales[j] = oENComprobantePropiedadesAdicionales;

                        var oENComprobantePropiedadesAdicionales = new ENComprobantePropiedadesAdicionales[1];
                        oENComprobantePropiedadesAdicionales[0] = new ENComprobantePropiedadesAdicionales();
                        oENComprobantePropiedadesAdicionales[0].Codigo = "2006";
                        oENComprobantePropiedadesAdicionales[0].Valor = "Operación sujeta a detracción";
                        oENComprobante.ComprobantePropiedadesAdicionales = oENComprobantePropiedadesAdicionales;
                    }
                    #endregion

                    #region XML_7 - oENEmpresa
                    oENEmpresa.CodigoTipoDocumento = oComprobElecXMLCabE.EmpresaTipoDocIdentidad;
                    oENEmpresa.Ruc = oComprobElecXMLCabE.EmpresaRuc;
                    oENEmpresa.RazonSocial = oComprobElecXMLCabE.EmpresaNombre.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENEmpresa.CodDistrito = oComprobElecXMLCabE.CodDistrito;
                    oENEmpresa.Calle = oComprobElecXMLCabE.EmpresaDireccion.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENEmpresa.Telefono = oComprobElecXMLCabE.EmpresaTelefono.Trim();
                    oENEmpresa.CodPais = "PE";
                    oENEmpresa.CodigoEstablecimientoSUNAT = oComprobElecXMLCabE.CodigoEstabSUNAT;

                    oGeneral.oENEmpresa = oENEmpresa;
                    #endregion

                    #region XML_8 - ENComprobanteNotaDocRef
                    if (util.Left(pCodComprobante, 1) == "C" | util.Left(pCodComprobante, 1) == "D")
                    {
                        var oENComprobanteNotaDocRef = new ENComprobanteNotaDocRef();
                        oENComprobanteNotaDocRef.Serie = util.Substring(oComprobElecXMLCabE.RefCodComprobanteE, 0, 4);
                        oENComprobanteNotaDocRef.Numero = util.Substring(oComprobElecXMLCabE.RefCodComprobanteE, 4, 20);
                        oENComprobanteNotaDocRef.TipoComprobante = oComprobElecXMLCabE.RefTipoCompSunat;
                        oENComprobanteNotaDocRef.FechaDocRef = DateTime.Parse(oComprobElecXMLCabE.RefFechaEmision).ToString("yyyy-MM-dd");

                        //oENComprobante.ComprobanteNotaCreditoDocRef = Array.Resize(oENComprobante.ComprobanteNotaCreditoDocRef, 0);
                        oENComprobante.ComprobanteNotaCreditoDocRef[0] = oENComprobanteNotaDocRef;
                    }
                    #endregion

                    #region XML_9 - ENComprobanteMotivoDocumento
                    if (util.Left(pCodComprobante, 1) == "C" | util.Left(pCodComprobante, 1) == "D")
                    {
                        var oENComprobanteMotivoDocumento = new ENComprobanteMotivoDocumento();
                        var oENComprobanteMotivoDocumentoSustento = new ENComprobanteMotivoDocumentoSustento();

                        oENComprobanteMotivoDocumentoSustento.Sustento = oComprobElecXMLCabE.C_MotivoNota.Replace("<![CDATA[", "").Replace("]]>", "").Trim();

                        oENComprobanteMotivoDocumento.SerieDocRef = util.Substring(oComprobElecXMLCabE.RefCodComprobanteE, 0, 4);
                        oENComprobanteMotivoDocumento.NumeroDocRef = util.Substring(oComprobElecXMLCabE.RefCodComprobanteE, 4, 20);
                        oENComprobanteMotivoDocumento.CodigoMotivoEmision = oComprobElecXMLCabE.C_CodMotivo_Sunat.Trim();
                        ;

                        oENComprobanteMotivoDocumento.Sustentos[0] = oENComprobanteMotivoDocumentoSustento;

                        oENComprobante.ComprobanteMotivosDocumentos[0] = oENComprobanteMotivoDocumento;
                    }
                    #endregion

                    #region XML_10 / XML_10_3
                    var oENBienesServicios = new ENBienesServicios();
                    oENBienesServicios.Codigo = "2003";
                    oENBienesServicios.Valor = oComprobElecXMLCabE.CodTipoDetraccion; // wAdoEfac("cod_tipodetraccion").Value

                    var oENDetraccion = new ENDetraccion();
                    var oENPorcentaje = new ENPorcentaje();
                    var oENMonto = new ENMonto();
                    var oENNumeroCuenta = new ENNumeroCuenta();

                    oENPorcentaje.Codigo = "2003";
                    oENPorcentaje.Valor = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.DetraccionPorc).ToString("########.00"));

                    oENMonto.Codigo = "2003";
                    oENMonto.Valor = decimal.Parse(oComprobElecXMLCabE.DetraccionMonto);

                    oENNumeroCuenta.CodigoFormaPago = oComprobElecXMLCabE.FormaPago;
                    oENNumeroCuenta.Codigo = "3001";
                    oENNumeroCuenta.Valor = oComprobElecXMLCabE.DetraccionNroCuenta;
                    ;
                    oENDetraccion.Porcentaje = new ENPorcentaje[1];

                    oENDetraccion.Porcentaje[0] = oENPorcentaje;
                    ;
                    oENDetraccion.Monto = new ENMonto[1];
                    oENDetraccion.Monto[0] = oENMonto;
                    ;
                    oENDetraccion.NumeroCuenta = new ENNumeroCuenta[1];
                    oENDetraccion.NumeroCuenta[0] = oENNumeroCuenta;

                    oENDetraccion.BienesServicios = new ENBienesServicios[1];
                    oENDetraccion.BienesServicios[0] = oENBienesServicios;
                    if (util.Left(pCodComprobante, 1) == "F" & double.Parse(oComprobElecXMLCabE.DetraccionMonto) > 0d & pSistema == "C")
                    {
                        oENComprobante.Detraccion = new ENDetraccion[1];
                        oENComprobante.Detraccion[0] = oENDetraccion;
                    }
                    #endregion

                    var oENMontosTotales = new ENMontosTotales();
                    // <I-TMACASSI> 12/02/2019 Montos Totales - Gravado / GRATUITO
                    if ((util.Left(pCodComprobante, 1) == "F" | util.Left(pCodComprobante, 1) == "B" | util.Left(pCodComprobante, 1) == "C" | util.Left(pCodComprobante, 1) == "D") & oComprobElecXMLCabE.FlgGratuito == "1")
                    {

                        // oENComprobante.MontosTotales.Gratuito
                        var oENGratuito = new ENGratuito();
                        var oENGratuitoImpuesto = new ENGratuitoImpuesto();

                        oENGratuitoImpuesto.Base = double.Parse(double.Parse(oComprobElecXMLCabE.C_MontoGratuito).ToString("########.00"));
                        oENGratuitoImpuesto.ValorImpuesto = double.Parse(double.Parse(oComprobElecXMLCabE.MtgValorImpuesto).ToString("########.00"));

                        oENGratuito.Total = double.Parse(double.Parse(oComprobElecXMLCabE.C_MontoGratuito).ToString("########.00"));
                        oENGratuito.GratuitoImpuesto = oENGratuitoImpuesto;

                        oENMontosTotales.Gratuito = oENGratuito;
                    }
                    else if ((util.Left(pCodComprobante, 1) == "F" | util.Left(pCodComprobante, 1) == "B" | util.Left(pCodComprobante, 1) == "C" | util.Left(pCodComprobante, 1) == "D") & double.Parse(oComprobElecXMLCabE.C_MontoInafecto) > 0d)
                    {
                        var oENInafecto = new ENInafecto();
                        oENInafecto.Total = double.Parse(double.Parse(oComprobElecXMLCabE.C_MontoInafecto).ToString("########.00"));
                        oENMontosTotales.Inafecto = oENInafecto;
                    }
                    else
                    {
                        var oENGravado = new ENGravado();
                        var oENGravadoIGV = new ENGravadoIGV();
                        oENGravadoIGV.Base = double.Parse(double.Parse(oComprobElecXMLCabE.MtgBase).ToString("########.00"));
                        oENGravadoIGV.ValorImpuesto = double.Parse(double.Parse(oComprobElecXMLCabE.MtgValorImpuesto).ToString("########.00"));
                        oENGravadoIGV.Porcentaje = double.Parse(double.Parse(oComprobElecXMLCabE.MtgPorcentaje).ToString("########.00"));

                        oENGravado.Total = double.Parse(double.Parse(oComprobElecXMLCabE.MtTotal).ToString("########.00"));
                        oENGravado.GravadoIGV = oENGravadoIGV;
                        oENMontosTotales.Gravado = oENGravado;
                    }
                    // <F-TMACASSI> 12/02/2019
                    oENComprobante.MontosTotales = oENMontosTotales;

                    #region XML_ENComprobante - oENComprobante
                    oENComprobante.TipoPlantilla = oComprobElecXMLCabE.TipoPlantilla;
                    oENComprobante.TipoComprobante = oComprobElecXMLCabE.TipoCompSunat;
                    oENComprobante.Serie = util.Substring(oComprobElecXMLCabE.CodComprobanteE, 0, 4);
                    oENComprobante.Numero = util.Substring(oComprobElecXMLCabE.CodComprobanteE, 5, 8);
                    oENComprobante.FechaEmision = DateTime.Parse(DateTime.Parse(oComprobElecXMLCabE.FechaEmision).ToString("yyyy-MM-dd"));
                    oENComprobante.ImporteTotal = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.C_MontoNeto).ToString("########.00"));
                    oENComprobante.RazonSocial = oComprobElecXMLCabE.ANombreDe.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENComprobante.VersionUbl = oComprobElecXMLCabE.VsUbl;
                    oENComprobante.TipoOperacion = oComprobElecXMLCabE.TipoOperacion;
                    oENComprobante.HoraEmision = oComprobElecXMLCabE.HoraEmision;
                    oENComprobante.TotalImpuesto = double.Parse(oComprobElecXMLCabE.TotalImpuesto);
                    oENComprobante.TotalValorVenta = double.Parse(wTotal_valorventa);
                    oENComprobante.TotalPrecioVenta = double.Parse(wTotal_precioventa);

                    // ----------------------------------------------------------------------------------------------------
                    // ----------------------------------------------------------------------------------------------------
                    var oENFormaPagoSunat = new ENFormaPagoSunat();

                    oENFormaPagoSunat.TipoFormaPago = oComprobElecXMLCabE.Sunat_Tipo_FormaPago;

                    if (oENFormaPagoSunat.TipoFormaPago == "2")
                    {
                        oENFormaPagoSunat.MontoPendientePago = decimal.Parse(oComprobElecXMLCabE.Sunat_Monto_PendientePago);

                        var oENCuotaPago = new ENCuotaPago();
                        oENCuotaPago.FechaPago = oComprobElecXMLCabE.Sunat_Cuota_Fecha;
                        oENCuotaPago.Monto = decimal.Parse(oComprobElecXMLCabE.Sunat_Cuota_Monto);

                        //Array.Resize(ref oENFormaPagoSunat.CuotaPago, 1);
                        oENFormaPagoSunat.CuotaPago = new ENCuotaPago[1];
                        oENFormaPagoSunat.CuotaPago[0] = oENCuotaPago;
                    }

                    // oENComprobante.TipoOperacion = oComprobElecXMLCabE.TipoOperacion
                    // oENComprobante.HoraEmision = oComprobElecXMLCabE.HoraEmision
                    // oENComprobante.TotalImpuesto = oComprobElecXMLCabE.TotalImpuesto
                    // oENComprobante.TotalValorVenta = oComprobElecXMLCabE.TotalValorVenta
                    // oENComprobante.TotalPrecioVenta = oComprobElecXMLCabE.TotalPrecioVenta
                    oENComprobante.FormaPagoSunat = oENFormaPagoSunat;
                    oENComprobante.VersionUbl = oComprobElecXMLCabE.VsUbl;

                    // ---------------------------------------------------------------------------------------------------
                    // ---------------------------------------------------------------------------------------------------

                    if (oComprobElecXMLCabE.C_Moneda == "S")
                    {
                        oENComprobante.Moneda = "PEN";
                    }
                    else if (oComprobElecXMLCabE.C_Moneda == "D")
                    {
                        oENComprobante.Moneda = "USD";
                    }

                    var oENReceptor = new ENReceptor[1];
                    oENReceptor[0] = new ENReceptor();
                    oENReceptor[0].Calle = oComprobElecXMLCabE.Direccion.Replace("<![CDATA[", "").Replace("]]>", "").Trim();
                    oENComprobante.Receptor = oENReceptor;

                    oENComprobante.TipoDocumentoIdentidad = oComprobElecXMLCabE.TipDocIdentidadSunat;
                    oENComprobante.Ruc = oComprobElecXMLCabE.RucSunat.Trim();
                    oENComprobante.CorreoElectronico = oComprobElecXMLCabE.ReceptorCorreo.Trim();

                    oENComprobante.Glosa = oComprobElecXMLCabE.Observaciones.Trim();
                    #endregion

                    #region COMPROBANTE DETALLE - ENComprobanteDetalleImpuestos
                    var oComprobanteDetalleImpuestos = new ENComprobanteDetalleImpuestos[0];
                    var oENComprobanteDetalle = new ENComprobanteDetalle[0];
                    var DescuentoCargoDetalle = new ENDescuentoCargoDetalle[0];
                    var wImpMontoBase = default(double);
                    var wImpTasaAplicada = default(decimal);
                    var wMontoTotal = default(double);
                    string wMontoTotalIncIgv = "";
                    string wImpuestoTotal;
                    string wD_montobase = "";
                    string wMontoDescuentoIncIgv = "";

                    var loopTo = oListComprobanteElectronicoXML.Count - 1;
                    for (i = 0; i <= loopTo; i++)
                    {
                        oComprobElecXMLCabE = new ComprobanteElectronicoXMLCabE();
                        oComprobElecXMLCabE = oListComprobanteElectronicoXML[i];

                        // Inicio - Solo para Logistica
                        string wValorVentaUnitarioIncIgv = "";
                        string wdTotalCondsctoigv = "";
                        wValorVentaUnitarioIncIgv = oComprobElecXMLCabE.D_VentaUnitario_ConIgv;
                        wdTotalCondsctoigv = oComprobElecXMLCabE.D_Total_ConDsctoIGV;
                        wImpuestoTotal = oComprobElecXMLCabE.D_MontoIgv;
                        wD_montobase = oComprobElecXMLCabE.D_MontoBase;
                        wMontoDescuentoIncIgv = oComprobElecXMLCabE.D_Dscto_ConIGV;

                        if (decimal.Parse(oComprobElecXMLCabE.PorcentajeCoAseguro) > 0 & (util.Left(pCodComprobante, 1) == "F" | util.Left(pCodComprobante, 1) == "B"))
                        {
                            wValorVentaUnitarioIncIgv = wValorVentaUnitarioIncIgv; // '10/06/2019
                        }
                        else
                        {
                            wValorVentaUnitarioIncIgv = wdTotalCondsctoigv;
                        } // '10/06/2019
                          // Fin - Solo para Logistica

                        if (pSistema == "C")
                        {
                            wImpMontoBase = double.Parse(double.Parse(oComprobElecXMLCabE.D_VentaUnitario_SinIgv).ToString("########.00"));
                            wImpTasaAplicada = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.PorcentajeImpuesto).ToString("########.00"));
                            wMontoTotal = double.Parse(double.Parse(oComprobElecXMLCabE.D_Total_SinIgv).ToString("########.00"));
                            wMontoTotalIncIgv = double.Parse(oComprobElecXMLCabE.D_Total_ConIgv).ToString("########.00");

                            if (oComprobElecXMLCabE.FlgGratuito == "1")
                            {
                                wImpMontoBase = double.Parse(double.Parse(oComprobElecXMLCabE.MtgBase).ToString("########.00"));
                                wImpTasaAplicada = decimal.Parse(wImpTasaAplicada.ToString("########.00"));
                                wMontoTotal = double.Parse(double.Parse(oComprobElecXMLCabE.D_Total_ConIgv).ToString("########.00"));
                            }
                            else if (double.Parse(oComprobElecXMLCabE.C_MontoInafecto) > 0d)
                            {
                                wImpMontoBase = double.Parse(double.Parse(oComprobElecXMLCabE.C_MontoInafecto).ToString("########.00"));
                                wImpTasaAplicada = decimal.Parse(decimal.Parse("0.00").ToString("########.00")); // TMACASSI 13/02/2019
                                wMontoTotalIncIgv = 0.ToString();
                            }
                        }
                        else if (pSistema == "L")
                        {
                            string wCodigoDescuento;
                            string wNota;
                            string wImpGratuito = "";

                            wImpMontoBase = double.Parse(double.Parse(oComprobElecXMLCabE.D_VentaUnitario_SinIgv).ToString("########.00"));
                            wImpTasaAplicada = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.PorcentajeImpuesto).ToString("########.00"));
                            wMontoTotal = double.Parse(double.Parse(oComprobElecXMLCabE.D_Total_SinIgv).ToString("########.00"));
                            wMontoTotalIncIgv = decimal.Parse(oComprobElecXMLCabE.D_Total_ConIgv).ToString("########.00");
                            wMontoTotalIncIgv = decimal.Parse(oComprobElecXMLCabE.D_Total_ConIgv).ToString("########.00");

                            if (oComprobElecXMLCabE.FlgGratuito == "1")
                            {
                                wImpMontoBase = double.Parse(double.Parse(oComprobElecXMLCabE.D_Total_ConIgv).ToString("########.00"));
                                wImpTasaAplicada = decimal.Parse(wImpTasaAplicada.ToString("########.00"));
                                wMontoTotal = double.Parse(double.Parse(oComprobElecXMLCabE.D_Total_ConIgv).ToString("########.00"));
                                wMontoTotalIncIgv = 0.ToString();
                                wImpuestoTotal = 0.ToString();
                                wImpGratuito = "1";
                            }
                            else if (double.Parse(oComprobElecXMLCabE.C_MontoInafecto) > 0d)
                            {
                                wImpMontoBase = double.Parse(double.Parse(oComprobElecXMLCabE.C_MontoInafecto).ToString("########.00"));
                                wImpTasaAplicada = decimal.Parse(decimal.Parse("0.00").ToString("########.00")); // TMACASSI 13/02/2019
                                wMontoTotalIncIgv = 0.ToString();
                                wImpGratuito = "0";
                            }

                            // ------
                            wCodigoDescuento = "00";
                            if (wImpGratuito == "0") // AGARCIA.25/06/2016 se agrega - Se envía Dcto solo a F,B,NC normales; no aplica a gratuitos.
                            {
                                if (double.Parse(oComprobElecXMLCabE.D_Dscto_Unitario) > 0d)
                                {
                                    wNota = double.Parse(oComprobElecXMLCabE.D_Dscto_SinIGV).ToString("########.00");
                                    wNota2 = double.Parse(oComprobElecXMLCabE.D_Dscto_ConIGV).ToString("########.00");

                                    wD_montobase = oComprobElecXMLCabE.D_Dscto_MontoBase;
                                    if (double.Parse(oComprobElecXMLCabE.PorcentajeCoAseguro) > 0d & (util.Left(pCodComprobante, 1) == "F" | util.Left(pCodComprobante, 1) == "B"))
                                    {
                                        wValorVentaUnitarioIncIgv = wValorVentaUnitarioIncIgv; // '10/06/2019
                                    }
                                    else
                                    {
                                        wValorVentaUnitarioIncIgv = wdTotalCondsctoigv;
                                    } // '10/06/2019

                                    DescuentoCargoDetalle = new ENDescuentoCargoDetalle[i + 1];
                                    DescuentoCargoDetalle[i] = new ENDescuentoCargoDetalle();

                                    DescuentoCargoDetalle[i].Monto = decimal.Parse(wNota);
                                    DescuentoCargoDetalle[i].Descripcion = "DESCUENTO A";
                                    DescuentoCargoDetalle[i].Indicador = 0;
                                    DescuentoCargoDetalle[i].Porcentaje = decimal.Parse(oComprobElecXMLCabE.D_PorcDctoPlan);
                                    DescuentoCargoDetalle[i].CodigoAplicado = wCodigoDescuento;
                                    DescuentoCargoDetalle[i].MontoBase = double.Parse(wD_montobase);
                                }
                                else
                                {
                                    wMontoDescuentoIncIgv = "0.00";
                                    wNota2 = (decimal.Parse("0.00").ToString("########.00"));
                                }
                            }

                            if (wImpGratuito == "0")
                            {
                                // XML_DescuentoIncIgv = "<DescuentoIncIgv>" & wMontoDescuentoIncIgv & "</DescuentoIncIgv>" & Chr(10)
                                // oENComprobanteDetalle(0).DescuentoIncIgv = wMontoDescuentoIncIgv
                            }
                        }

                        Array.Resize(ref oComprobanteDetalleImpuestos, 1);
                        oComprobanteDetalleImpuestos[0] = new ENComprobanteDetalleImpuestos();
                        oComprobanteDetalleImpuestos[0].ImporteTributo = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.D_MontoIgv).ToString("########.00"));
                        oComprobanteDetalleImpuestos[0].ImporteExplicito = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.D_MontoIgv).ToString("########.00"));
                        oComprobanteDetalleImpuestos[0].AfectacionIGV = oComprobElecXMLCabE.D_AfectacionIgv;
                        oComprobanteDetalleImpuestos[0].CodigoTributo = oComprobElecXMLCabE.CodTributo;
                        oComprobanteDetalleImpuestos[0].DesTributo = oComprobElecXMLCabE.DesTributo;
                        oComprobanteDetalleImpuestos[0].CodigoUN = oComprobElecXMLCabE.CodUN;
                        oComprobanteDetalleImpuestos[0].ImpGratuito = int.Parse(oComprobElecXMLCabE.FlgGratuito); // 0 '0: Es gratuito, 1: Gratuito.
                        oComprobanteDetalleImpuestos[0].MontoBase = wImpMontoBase;
                        oComprobanteDetalleImpuestos[0].TasaAplicada = double.Parse(wImpTasaAplicada.ToString());

                        Array.Resize(ref oENComprobanteDetalle, i + 1);
                        oENComprobanteDetalle[i] = new ENComprobanteDetalle();
                        oENComprobanteDetalle[i].Item = i + 1;
                        oENComprobanteDetalle[i].UnidadComercial = oComprobElecXMLCabE.D_Unidad;
                        oENComprobanteDetalle[i].Descripcion = pSistema == "C" ? oComprobElecXMLCabE.D_NombreGrupo : oComprobElecXMLCabE.NombreProducto.Trim();
                        oENComprobanteDetalle[i].Cantidad = decimal.Parse(oComprobElecXMLCabE.D_Cant_Sunat);
                        oENComprobanteDetalle[i].ValorVentaUnitario = decimal.Parse(decimal.Parse(oComprobElecXMLCabE.D_VentaUnitario_SinIgv).ToString("########.00"));
                        oENComprobanteDetalle[i].ValorVentaUnitarioIncIgv = pSistema == "C" ? decimal.Parse(decimal.Parse(oComprobElecXMLCabE.D_VentaUnitario_ConIgv).ToString("########.00")) : decimal.Parse(wValorVentaUnitarioIncIgv);
                        oENComprobanteDetalle[i].Total = pSistema == "C" ? decimal.Parse(decimal.Parse(oComprobElecXMLCabE.D_Total_SinIgv).ToString("########.00")) : decimal.Parse(wMontoTotal.ToString());
                        oENComprobanteDetalle[i].PrecioVentaItem = double.Parse(wMontoTotalIncIgv);
                        oENComprobanteDetalle[i].Determinante = oComprobElecXMLCabE.D_Determinante;
                        oENComprobanteDetalle[i].CodigoTipoPrecio = oComprobElecXMLCabE.D_CodigoTipoPrecio;
                        oENComprobanteDetalle[i].ComprobanteDetalleImpuestos = oComprobanteDetalleImpuestos;
                        oENComprobanteDetalle[i].UnidadMedidaEmisor = "";

                        if (pSistema == "L")
                        {
                            oENComprobanteDetalle[i].Nota = wNota2;
                            oENComprobanteDetalle[i].CodigoProductoSunat = oComprobElecXMLCabE.CodProductoSUNAT;
                        }

                        oENComprobanteDetalle[i].ImpuestoTotal = pSistema == "C" ? double.Parse(oComprobElecXMLCabE.D_MontoIgv) : double.Parse(wImpuestoTotal);
                    }

                    oENComprobante.ComprobanteDetalle = oENComprobanteDetalle;
                    #endregion

                    oGeneral.oENComprobante = oENComprobante;

                    string stringxml = "";
                    using (var stringWriter = new StringWriter())
                    {
                        var serializer = new System.Xml.Serialization.XmlSerializer(oGeneral.GetType());
                        serializer.Serialize(stringWriter, oGeneral);
                        stringxml = stringWriter.ToString();
                    }

                    int iniXml = 0;
                    int finXml = 0;

                    iniXml = stringxml.IndexOf("<oENComprobante");
                    finXml = stringxml.LastIndexOf("</General>");

                    XML_General = "";
                    XML_General = XML_General + "<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ";
                    XML_General = XML_General + " xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">" + '\n' + "<soap:Body>" + '\n' + "<Registrar xmlns=\"http://tempuri.org/\">" + '\n' + "<oGeneral>" + '\n' + stringxml.Substring(iniXml, finXml - iniXml) + '\n' + "</oGeneral>" + '\n' + "<oTipoComprobante>" + oComprobElecXMLCabE.TipoCompTci + "</oTipoComprobante>" + '\n' + "<Cadena></Cadena>" + '\n' + "<TipoCodigo>" + wTipoCodigoTCI.ToString() + "</TipoCodigo>" + '\n' + "<CogigoBarras></CogigoBarras>" + '\n' + "<CogigoHash></CogigoHash>" + '\n' + "<Otorgar>" + pOtorgarTci + "</Otorgar>" + '\n' + "<IdComprobanteCliente>0</IdComprobanteCliente>" + '\n' + "</Registrar>" + '\n' + "</soap:Body>" + '\n' + "</soap:Envelope>";

                    if (pEnviarSunat == "S") // Solo en caso que no se envie.
                    {
                        oListError = new ENErrorComunicacion[1];
                        oListError[0] = new ENErrorComunicacion();

                        bool wResult = false;
                        string Cadena = "";
                        OpenConfigWebServicesTci(xUrlWsTCI);
                        using (var oWsComprobante = new WSComprobanteSoapClient(BindingTci, EndPoint))
                        {
                            //jrra  oWsComprobante.Registrar  

                            RegistrarRequest registrarRequest = new RegistrarRequest();

                            registrarRequest.oGeneral = oGeneral;
                            registrarRequest.oTipoComprobante = pTipoDocumento;
                            registrarRequest.Cadena = Cadena;
                            registrarRequest.TipoCodigo = wTipoCodigoTCI;
                            registrarRequest.CodigoBarras = xCodigoBarras;
                            registrarRequest.CodigoHash = "";
                            registrarRequest.ListaError = oListError;
                            registrarRequest.IdComprobanteCliente = 0;
                            registrarRequest.Otorgar = pOtorgarTci;

                            string codigoHash = "";
                            //wResult = oWsComprobante.RegistrarAsync(oGeneral, pTipoDocumento, Cadena, wTipoCodigoTCI, xCodigoBarras, "", oListError, 0, pOtorgarTci);
                            //wResult = await oWsComprobante.RegistrarAsync(registrarRequest);

                            //var wResult2_ = Task.Run(async () => await oWsComprobante.RegistrarAsync(registrarRequest));
                            var wResult2_ = oWsComprobante.RegistrarAsync(registrarRequest).Result;

                            wResult = wResult2_.RegistrarResult;
                            Cadena = wResult2_.Cadena; // jrra
                            xCodigoBarras = wResult2_.CodigoBarras;
                            codigoHash = wResult2_.CodigoHash;
                            oListError = wResult2_.ListaError;

                            CloseConfigWebServicesTci();
                        }

                        if (wResult == true)
                        {
                            xResult.CodigoBarra = xCodigoBarras;
                            xResult.ErroresComprobantes = ErroresComprobantesTCI.Correcto;
                        }
                        else if (oListError[0].DescripcionError + "" != "")
                        {
                            xResult.ErroresComprobantes = ErroresComprobantesTCI.Otros;
                            xResult.Respuesta = "oENErrorComunicacion: " + oListError[0].DescripcionError;
                        }
                        else
                        {
                            xResult.ErroresComprobantes = ErroresComprobantesTCI.Otros;
                            xResult.Respuesta = "oENErrorComunicacion: " + Cadena;
                        }
                    }
                    else if (pEnviarSunat == "N")
                    {
                        xResult.ErroresComprobantes = ErroresComprobantesTCI.Correcto;
                    }

                    xResult.RespuestaXML = XML_General;
                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message + ex.Source);
                }
            }
            while (false);

            return xResult;
        }
        #endregion

        #region PagarComprobante
        public bool PagarComprobante(string pCodComprobante, string pCodLiquidacion, string pTipoComprobante, double pMonto, string pMoneda)
        {
            bool xResult = false;
            string xTipoPago = "TARJETA";
            try
            {
                var oList = new List<ComprobantesE>();
                var oComprobantesE = new ComprobantesE();
                string CodTipoFactura = "";
                var objComprobanteE = new ComprobantesE();

                var objCuadreCaja = new CuadreCajaE();

                using (var Trans = new TransactionScope())
                {
                    objComprobanteE = CargarDataComprobante(pTipoComprobante, pCodLiquidacion, pMonto.ToString(), pMoneda, "P", "T", CodNombreEntidad, NumEntidad, "", pCodComprobante); // Cargar los datos del comprobante para el insert
                    new ComprobantesAD().Sp_Comprobante_Insert(ref objComprobanteE);
                    if (objComprobanteE.CodComprobante != "")
                    {
                        string queryString = "";
                        // 1463 - CACERES ESPINOZA NEREYDA PILAR (Se coloca por defecto el usuario de pilar para el cuadredecaja)

                        objCuadreCaja.CodComprobante = objComprobanteE.CodComprobante;
                        xResult = new CuadreCajaAD().Sp_CuadreCajaOnline_Update(ref objCuadreCaja);
                        //queryString = "update cuadredecaja set codcentro = '" + CentroCosto + "', usuario = '" + "1463" + "'  where documento = '" + pCodComprobante + "'";
                        //xResult = Dat.Sql.VariablesGlobales.ExecuteQueryString(queryString);
                        if (xResult == true)
                        {
                            Trans.Complete();
                        }
                        else
                        {
                            Trans.Dispose();
                        }
                    }
                    else
                    {
                        Trans.Dispose();
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return xResult;
        }
        #endregion

        #region ActualizarDatosPagosConfirmacion
        public void ActualizarDatosPagosConfirmacion()
        {
            var oMdsynDPagosUpdateE = new MdsynDatosPagosE();
            oMdsynDPagosUpdateE.IdeDatospagos = IdeDatosPagos;
            oMdsynDPagosUpdateE.CodAtencion = CodAtencion;
            oMdsynDPagosUpdateE.CodComprobante = CodComprobante;
            oMdsynDPagosUpdateE.CodigoAutorizacion = CodigoAutorizacion;
            oMdsynDPagosUpdateE.CodLiquidacion = CodLiquidacion;
            new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Update(oMdsynDPagosUpdateE);
        }
        #endregion


        #region fnGenerarOrdenPagoBot
        public SynapsisWS.ResponseOrderApiResult fnGenerarOrdenPagoBot(MdsynPagosE objPagosE, ListTipoPagoOrdenBot TipoPago, int UsrSistema)
        {
            bool result = false;
            var oResult = new SynapsisWS.ResponseOrderApiResult();
            var oList = new List<MdsynPagosE>();

            using (var xTrans = new TransactionScope())
            {
                result = new MdsynPagosAD().Sp_MdsynPagos_Cita_Insert(objPagosE);

                if (result == true)
                {
                    if (TipoPago == ListTipoPagoOrdenBot.Reserva)
                    {
                        oList = new MdsynPagosAD().Sp_MdsynPagos_Cita_Consulta(new MdsynPagosE(objPagosE.IdePagosBot, "", 0, 0, "", "", 0, "1"));
                    }
                    else if (TipoPago == ListTipoPagoOrdenBot.Farmacia)
                    {
                        oList = new MdsynPagosAD().Sp_MdsynPagos_Cita_Consulta(new MdsynPagosE(objPagosE.IdePagosBot, "", 0, 0, "", "", 0, "2"));
                    }
                    else if (TipoPago == ListTipoPagoOrdenBot.ContratoConsultorios)
                    {
                        oList = new MdsynPagosAD().Sp_MdsynPagos_Cita_Consulta(new MdsynPagosE(objPagosE.IdePagosBot, "", 0, 0, "", "", 0, "7"));
                    }

                    if (oList.Count != 0)
                    {
                        oResult = new SynapsisWS().GenerateOrderApiBot(oList[0]);

                        if (oResult.responseOrderApi.success == true)
                        {
                            var withBlock = oResult.responseOrderApi.data.order;
                            new MdsynPagosAD().Sp_MdsynPagos_Cita_Update(new MdsynPagosE(oResult.responseOrderApi.data.order.number, "", objPagosE.IdCita, "", "", 0, oResult.responseOrderApi.data.order.uniqueIdentifier, "S", UsrSistema, oResult.jsonBody, "", "", "", "", "", "update_orden_pago"));

                            if (TipoPago == ListTipoPagoOrdenBot.Reserva)
                            { new MdsynAmReservaAD().Sp_Mdsyn_Cita_Update(new MdsynAmReservaE(objPagosE.IdCita, 0, "", "", "", "", "", "", DateTime.Now, "", objPagosE.CntMontoPago, "B", "update_tipo_pago", 0, "")); }
                            else if (TipoPago == ListTipoPagoOrdenBot.ContratoConsultorios)
                            { }
                            xTrans.Complete();
                        }
                        else
                        {
                            xTrans.Dispose();
                        }
                    }
                }
                else
                {
                    xTrans.Dispose();
                }
            }

            return oResult;
        }

        #endregion


        #region CargarIniObtenerPagosVisaNet
        public void CargarIniObtenerPagosVisaNet()
        {
            var oTablasE = new TablasE();

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_VISANET_URL", "01", 0, 0, 8));
            VisaNet_Ws_Url = oTablasE.Nombre;

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_VISANET_AUTHORIZATION", "01", 0, 0, 8));
            VisaNet_ApiKeyAutorizacion_App = oTablasE.Nombre;

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_VISANET_MERCHANTID", "01", 0, 0, 8));
            VisaNet_merchantId_App = oTablasE.Nombre;

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_VISANET_MERCHANTID_WEB", "01", 0, 0, 8));
            VisaNet_merchantId_Web = oTablasE.Nombre;

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_VISANET_AUTHORIZA_WEB", "01", 0, 0, 8));
            VisaNet_ApiKeyAutorizacion_Web = oTablasE.Nombre;

        }


        public void CargarIniQR()
        {
            var oTablasE = new TablasE();

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_RUTA_QR_ESTACIONAMIENT", "01", 0, 0, 8));
            RutaGuardarQR = oTablasE.Nombre;

            oTablasE = new TablasAD().Sp_Tablas_ConsultaEntidad(new TablasE("MEDISYN_URL_QR_ESTACIONAMIENTO", "01", 0, 0, 8));
            UrlQR = oTablasE.Nombre;
        }



        #endregion



        #region ResponseConsultaVentaRealizadaVisaNet
        /// <summary>
        /// Respuesta de la consulta de la venta realizada de visa
        /// </summary>
        public partial class ResponseConsultaVentaRealizadaVisaNet
        {
            public int errorCode { get; set; }
            public string errorMessage { get; set; }

            public Header header { get; set; }
            public Fulfillment fulfillment { get; set; }
            public Order order { get; set; }
            public Datamap dataMap { get; set; }
        }

        public partial class Header
        {
            public string ecoreTransactionUUID { get; set; }
            public long ecoreTransactionDate { get; set; }
            public int millis { get; set; }
        }

        public partial class Fulfillment
        {
            public string channel { get; set; }
            public string merchantId { get; set; }
            public string terminalId { get; set; }
            public string captureType { get; set; }
            public bool countable { get; set; }
            public bool fastPayment { get; set; }
            public string signature { get; set; }
        }

        public partial class Order
        {
            public string purchaseNumber { get; set; }
            public float amount { get; set; }
            public string currency { get; set; }
            public float authorizedAmount { get; set; }
            public string authorizationCode { get; set; }
            public string actionCode { get; set; }
            public string status { get; set; }
            public string traceNumber { get; set; }
            public string transactionDate { get; set; }
            public string transactionId { get; set; }
        }

        public partial class Datamap
        {
            public string ORIGINAL_DATETIME { get; set; }
            public string CURRENCY { get; set; }
            public string TRANSACTION_DATE { get; set; }
            public string TERMINAL { get; set; }
            public string ACTION_CODE { get; set; }
            public string TRACE_NUMBER { get; set; }
            public string BIN { get; set; }
            public string ECI_DESCRIPTION { get; set; }
            public string ECI { get; set; }
            public string MERCHANT { get; set; }
            public string CARD { get; set; }
            public string BRAND { get; set; }
            public string STATUS { get; set; }
            public string ADQUIRENTE { get; set; }
            public string ACTION_DESCRIPTION { get; set; }
            public string ID_UNICO { get; set; }
            public string AMOUNT { get; set; }
            public string PROCESS_CODE { get; set; }
            public string TRANSACTION_ID { get; set; }
            public string AUTHORIZATION_CODE { get; set; }
        }
        #endregion





    }




}






