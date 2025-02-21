/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version Fecha         Autor       Requerimiento
 1.0      29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
 1.1      25/11/2024  FPINEDO     REQ 2024-026000: Alquiler de consultorios-Alerta de servicio detenido.
====================================================================================================*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Bus.AgendaClinica.Clinica;
using Bus.Clinica;
using Bus.Clinica.Auditoria;
using Bus.Clinica.Clinica;
using Bus.Utilities;
using Dat.Sql.ClinicaAD.MedisynAD;
using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.ComprobantesE;
using Ent.Sql.ClinicaE.ContratosE;
using Ent.Sql.ClinicaE.MedicosE;
using Ent.Sql.ClinicaE.MedisynE;
using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql.ProveedorE.TCI;
using Newtonsoft.Json;
using RestSharp;
using WS.ContratoConsultorios;
using WsTciComprobantes;
using static System.Runtime.InteropServices.JavaScript.JSType; //1.1 


namespace WS.ContratoConsultorios.Controlller
{
    public class ContratoConsultorio
    {
        public static string URLApiClinica { get; set; } = "";
        public static string Key { get; set; } = "CL&NIC@$@NF3L1P32022..#$";

        GeneralContratos oGCC = new GeneralContratos();
        Generales oGenerales = new Generales();
        double MontoLimite, MontoSinIGV;
        string Atencion = "";
        List<TablasE> oListaDetraccion = new List<TablasE>();
        decimal PorcentajeDetraccion = 0, MontoMinDetraccion;

        public void ProcesarContratos()
        {
            try
            {
                
                oListaDetraccion = new Tablas().ListaConsulta(new TablasE("DETRACCION_MONTO", "", 0, 20, 30));
                PorcentajeDetraccion = 1 + (Convert.ToDecimal(oListaDetraccion[0].Nombre.Replace("%", "")) / 100);
                MontoMinDetraccion = Convert.ToDecimal(oListaDetraccion[0].Valor);

                List<TablasE> oLista = new Tablas().ListaConsulta(new TablasE("WS_ContratoConsultorios", "", 0, 20, 30));
                string? WSEstado = oLista[0].Estado.ToString();
                int DiaGeneraComprobantes = Convert.ToInt32(oLista[0].Valor);
                int DiaActual = Convert.ToInt32(DateTime.Now.ToString("dd"));

                if (WSEstado == "A")
                {
                    CargarVariable();
                    if (DiaGeneraComprobantes == DiaActual)
                    {
                        DesactivarContratos();
                        ActualizarFlgProcesar();
                        ActualizaTipoPago();
                        RegistroDatos();
                        GenerarLinkBot();
                    }
                    EnviarCorreoMedicos();
                    PagarComprobanteDirecto();
                    PagarComprobanteCompensacion();
                    ActualizarEstadoPagoSIC();
                }
                //INI 1.1
                ActualizaciionEstadoServicio();
                //FIN 1.1
            }
            catch (Exception ex)
            { GrabarLog("ProcesarContratos:", "Error:" + ex.Message); }
        }
        //INI 1.1 
        private void ActualizaciionEstadoServicio()
        {
            try
            {
                string? fechaActual=DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                new Tablas().Sp_Tablas_Update(new TablasE("ALQULTIMACONEXION", "01", fechaActual, "nombre"));
            }
            catch (Exception ex)
            { GrabarLog("ActualizaciionEstadoServicio:", "Error:" + ex.Message); }
        }
        //FIN 1.1 
        private void ActualizarEstadoPagoSIC()
        {
            try
            {
                List<HisDatospagosconsultoriosE> oLista = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, "", 0, 11));
                foreach (var Contrato in oLista)
                {
                    ActualizarCampoDatosPagos(Contrato.IdePagocontrato, "5", "Estado");
                    ActualizarCampoDatosPagos(Contrato.IdePagocontrato, "SIC", "origen_pago");
                }
            }
            catch (Exception ex)
            { GrabarLog("ActualizarEstadoPagoSIC:", "Error:" + ex.Message); }
        }

        private void PagarComprobanteCompensacion()
        {
            try
            {
                List<HisDatospagosconsultoriosE> oLista = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, "", 0, 8));
                foreach (var Contrato in oLista)
                { ActualizaEstadoPago(Contrato.IdePagocontrato, "5", "SAP"); }
            }
            catch (Exception ex)
            { GrabarLog("PagarComprobanteCompensacion:", "Error:" + ex.Message); }
        }

        public void CargarVariable()
        {
            MontoLimite = oGCC.LimiteMonto();
            Atencion = oGCC.ObtenerAtencion();
        }
        public void ActualizaTipoPago()
        {
            try
            {
                List<HisContratoconsultorioCabE> oListContratos = new ContratoConsultoriosCab().Sp_HisContratoconsultorioCab_Consulta(new HisContratoconsultorioCabE("", "", "", "", 0, 7));
                foreach (var Contrato in oListContratos)
                {
                    if (Contrato.IdeAdendaCab > 0)
                    { ActualizarCampoAdendaCab(Contrato.IdeAdendaCab, 0, "C", "tip_pago", 1); }
                    else
                    { ActualizaCampoContratoCab(Contrato.IdeHisContratoconsultorioCab, "tip_pago", "C"); }

                }
            }
            catch (Exception ex)
            { GrabarLog("ActualizaTipoPago:", "Error:" + ex.Message); }
        }
        public void DesactivarContratos()
        {
            try
            {
                List<HisContratoconsultorioCabE> oListContratos = new ContratoConsultoriosCab().Sp_HisContratoconsultorioCab_Consulta(new HisContratoconsultorioCabE("", "", "", "", 0, 4));
                for (int i = 0; i < oListContratos.Count; i++)
                {
                    ActualizaCampoContratoCab(oListContratos[i].IdeHisContratoconsultorioCab, "est_contrato_consultorio", "X");
                    ActualizarCampoAdendaCab(0, oListContratos[i].IdeHisContratoconsultorioCab, "X", "est_adenda", 1);
                }
            }
            catch (Exception ex)
            { GrabarLog("DesactivarContratos:", "Error:" + ex.Message); }
        }
        public void ActualizarFlgProcesar()
        {
            try
            {
                List<HisContratoconsultorioCabE> oListContratosActivos = new ContratoConsultoriosCab().Sp_HisContratoconsultorioCab_Consulta(new HisContratoconsultorioCabE("", "1", "", "", 0, 5));
                for (int i = 0; i < oListContratosActivos.Count; i++)
                { ActualizaCampoContratoCab(oListContratosActivos[i].IdeHisContratoconsultorioCab, "flg_Procesado", "0"); }
            }
            catch (Exception ex)
            { GrabarLog("ActualizarFlgProcesar:", "Error:" + ex.Message); }
        }
        public void RegistroDatos()
        {
            try
            {
                HisDatospagosconsultoriosE DatosPagosConsultorios = new HisDatospagosconsultoriosE();
                List<HisContratoconsultorioCabE> oListContratosActivos = new ContratoConsultoriosCab().Sp_HisContratoconsultorioCab_Consulta(new HisContratoconsultorioCabE("", "0", "", "", 0, 5));
                //General comprobante con monto 0 Error
                List<TablasE> Lista = new Tablas().ListaConsulta(new TablasE("ALQFECHAVENCIMIENTO", "", 0, 1, 30));
                string? dia = Lista[0].Valor.ToString();
                DateTime Fecha = DateTime.Now.AddMonths(1);

                foreach (var contratos in oListContratosActivos)
                {
                    try
                    {
                        DatosPagosConsultorios = new HisDatospagosconsultoriosE();
                        if (contratos.IdeAdendaCab != 0)
                        {
                            List<HisContratoconsultorioadendaCabE> oListAdenda = new ContraroAdendaCab().Sp_HisContratoconsultorioadendaCab_Consulta(new HisContratoconsultorioadendaCabE(contratos.IdeAdendaCab, 6));
                            foreach (var Adenda in oListAdenda)
                            { DatosPagosConsultorios.CntRentaMensual += Adenda.CntPrecioxhora * (100 - Adenda.CntDescuento) / 100; }
                        }
                        else
                        {
                            List<HisContratoconsultorioCabE> oListaContrato = new ContratoConsultoriosCab().Sp_HisContratoconsultorioCab_Consulta(new HisContratoconsultorioCabE(contratos.IdeHisContratoconsultorioCab.ToString(), "", "", "", 0, 8));
                            foreach (var Contrato in oListaContrato)
                            {
                                { DatosPagosConsultorios.CntRentaMensual += Contrato.CntPrecioxhora * (100 - Contrato.CntDescuento) / 100; }
                            }
                        }
                        if (DatosPagosConsultorios.CntRentaMensual == 0)
                        {
                            ActualizaCampoContratoCab(contratos.IdeHisContratoconsultorioCab, "flg_Procesado", "1");
                            ActualizaCampoContratoCab(contratos.IdeHisContratoconsultorioCab, "fec_Procesado", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                        }
                        else
                        {
                            DatosPagosConsultorios.IdeHisContratoconsultorioCab = contratos.IdeHisContratoconsultorioCab;
                            DatosPagosConsultorios.IdeAdendaCab = contratos.IdeAdendaCab;
                            DatosPagosConsultorios.MesComprobante = Convert.ToInt32(Fecha.ToString("MM"));
                            DatosPagosConsultorios.AñoComprobante = Convert.ToInt32(Fecha.ToString("yyyy"));
                            DatosPagosConsultorios.CntRentaMensual = Math.Round(DatosPagosConsultorios.CntRentaMensual, 2);
                            DatosPagosConsultorios.IdeSede = contratos.IdeSede;
                            DatosPagosConsultorios.Estado = "0";
                            DatosPagosConsultorios.FecVencimiento = Fecha.ToString("MM") + "/" + dia + "/" + Fecha.ToString("yyyy") + " 23:59:59";
                            DatosPagosConsultorios.FecRegistro = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                            DatosPagosConsultorios.TipPago = contratos.TipPago;

                            if (new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Insert(DatosPagosConsultorios))
                            {
                                ActualizaCampoContratoCab(contratos.IdeHisContratoconsultorioCab, "flg_Procesado", "1");
                                ActualizaCampoContratoCab(contratos.IdeHisContratoconsultorioCab, "fec_Procesado", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                            }
                        }
                    }
                    catch (Exception ex)
                    { GrabarLog("RegistroDatos:", "IdContratoCab:" + contratos.IdeHisContratoconsultorioCab + "-Error:" + ex.Message); }
                }
            }
            catch (Exception ex)
            { GrabarLog("RegistroDatos:", "Error:" + ex.Message); }

        }
        public void GenerarLinkBot()
        {
            try
            { //Estado = "";
                List<TablasE> oListaPrestaciones = new Tablas().ListaConsulta(new TablasE("ALQPRESTACIONES", "", 0, 20, 30));
                List<TablasE> oListaTipPagos = new Tablas().ListaConsulta(new TablasE("ALQFORMAPAGO", "", 0, 20, 30));
                List<TablasE> oListaDimxPrest = new Tablas().ListaConsulta(new TablasE("DIMENSIONXPRESTACION", "", 0, 20, 30));
                List<HisDatospagosconsultoriosE> oListaDatosPagoContratos = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, "", 0, 2));
                foreach (var Contrato in oListaDatosPagoContratos)
                {
                    MdsynPagosE objPagosE = new MdsynPagosE();
                    string? Estado, CodPresotor, CodLiquidacion, CodComprobante;
                    objPagosE.IdePagosBot = Contrato.IdePagosBot;
                    CodPresotor = Contrato.CodPresotor;
                    CodLiquidacion = Contrato.CodLiquidacion;
                    CodComprobante = Contrato.CodComprobante;
                    Estado = Contrato.Estado;
                    int UsrSistema = 4;

                    try
                    {
                        #region Genera Link
                        if (Estado == "0") //Genera Presotor
                        {
                            string? Prestacion = oListaPrestaciones.Where(p => p.Valor == Contrato.IdeSede).Select(p => p.Nombre).FirstOrDefault();
                            string? Dim1 = oListaDimxPrest.Where(p => p.Nombre == Prestacion).Select(p => p.Codigo).FirstOrDefault();
                            CodPresotor = oGCC.RegistroPresotor(Atencion, Prestacion, 4, Convert.ToDecimal(Contrato.CntRentaMensual), Dim1);
                            if (!string.IsNullOrEmpty(CodPresotor))
                            {
                                Estado = "1";
                                ActualizaEstadoPago(Contrato.IdePagocontrato, Estado, CodPresotor);
                            }
                        }
                        if (Estado == "1") //Genera Liquidacion
                        {
                            CodLiquidacion = oGCC.RegistrarLiquidaciones(Atencion, CodPresotor);
                            Contrato.CodLiquidacion = CodLiquidacion;
                            if (!string.IsNullOrEmpty(CodLiquidacion))
                            {
                                Estado = "2";
                                ActualizaEstadoPago(Contrato.IdePagocontrato, Estado, CodLiquidacion);
                            }
                        }
                        if (Estado == "2")//Link de pago 
                        {
                            foreach (var TipPago in oListaTipPagos)
                            {
                                SynapsisWS.ResponseOrderApiResult oResult = new SynapsisWS.ResponseOrderApiResult();
                                objPagosE = new MdsynPagosE();
                                objPagosE.IdePagosBot = 0;

                                if (Contrato.TipPago == TipPago.Codigo && TipPago.Valor == 1) //Generar Link de pago: D - 1 
                                {
                                    objPagosE.CodTipo = "C"; // R=Reserva, F=Farmacio, C=Contratos // cboTipoPago.SelectedValue.ToString();
                                    objPagosE.CodLiquidacion = Contrato.CodLiquidacion;
                                    objPagosE.CntMontoPago = Math.Round(Contrato.CntRentaMensual * (1 + Convert.ToDecimal(VarGlobal.IGV)), 2);

                                    //if (objPagosE.CntMontoPago > MontoMinDetraccion)
                                    //{ objPagosE.CntMontoPago = objPagosE.CntMontoPago * PorcentajeDetraccion; }

                                    VariablesGlobales.ListTipoPagoOrdenBot TipoPago = VariablesGlobales.ListTipoPagoOrdenBot.ContratoConsultorios;
                                    oResult = oGenerales.fnGenerarOrdenPagoBot(objPagosE, TipoPago, UsrSistema);

                                    if (oResult.responseOrderApi.success)
                                    {
                                        Estado = "3";
                                        ActualizaEstadoPago(Contrato.IdePagocontrato, Estado, objPagosE.IdePagosBot.ToString());
                                    }
                                }
                                else if (Contrato.TipPago == TipPago.Codigo && TipPago.Valor == 0)//No generar link de pago: C - 0
                                {
                                    Estado = "3";
                                    ActualizaEstadoPago(Contrato.IdePagocontrato, Estado, objPagosE.IdePagosBot.ToString());
                                }
                            }
                        }
                        #endregion
                        if (Estado == "3") //Genera Comprobante
                        {
                            if (oGCC.ValidarComprobanteAlqCons() && oGCC.ValirdarCardCode(Contrato.CardCode, 4))
                            {
                                List<TablasE> ListaPC = new Tablas().ListaConsulta(new TablasE("ALQPCCOMPROBANTE", "", 0, 1, 30));
                                string? PCHostname = ListaPC[0].Nombre;

                                ComprobantesE Comprobante = new ComprobantesE();
                                Contrato.Operacion = "G";
                                Contrato.VariosTipoPago = "N";
                                Comprobante = CargarDatosGenerar(Contrato);
                                CodComprobante = oGenerales.GenerarComprobante_Alquiler(Comprobante, PCHostname);

                                if (!string.IsNullOrEmpty(CodComprobante))
                                {
                                    Estado = "4";
                                    ActualizaEstadoPago(Contrato.IdePagocontrato, Estado, CodComprobante);
                                    new MdsynPagosAD().Sp_MdsynPagos_UpdatexCampo(new MdsynPagosE(objPagosE.IdePagosBot, CodComprobante, "cod_comprobante"));
                                    new MdsynPagosAD().Sp_MdsynPagos_UpdatexCampo(new MdsynPagosE(objPagosE.IdePagosBot, "4", "usr_pago_usado"));
                                    new MdsynPagosAD().Sp_MdsynPagos_UpdatexCampo(new MdsynPagosE(objPagosE.IdePagosBot, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), "fec_pago_usado"));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    { GrabarLog("GenerarLinkBot:", "IdContratoCab:" + Contrato.IdeHisContratoconsultorioCab + " - Estado:" + Estado + " - Error:" + ex.Message); }
                }
            }
            catch (Exception ex)
            { GrabarLog("GenerarLinkBot:", "Error:" + ex.Message); }
        }

        /// <summary>
        /// EnviarCorreoMedicos
        /// Estado(flg_Correo) = 1: Nuevo Comprobante
        /// Estado(flg_Correo) = 2: Estado de cuenta
        /// Estado(flg_Correo) = 3: Comprobante del mes por vencer
        /// Estado(flg_Correo) = 4: Comprobante Pagado y listo para enviar correo de confirmacion
        /// Estado(flg_Correo) = 5: Corre de confirmacion de pago
        /// Estado(flg_Correo) = 6: Corre de confirmacion de detracciones
        /// </summary>
        public void EnviarCorreoMedicos()
        {
            try
            {
                int OrdenConsulta = 0, OrdenCorreo = 0, Estado = 0;
                List<TablasE> oListaFechas = new Tablas().ListaConsulta(new TablasE("ALQFECHACORREO", "", 0, 20, 30));
                List<TablasE> oListaHora = new Tablas().ListaConsulta(new TablasE("ALQHORACORREO", "", 0, 1, 30));

                int FecNotificar = Convert.ToInt32(oListaFechas.Where(f => f.Nombre == "NOTIFICAR").Select(f => f.Valor).FirstOrDefault());
                int FecRecordatorio = Convert.ToInt32(oListaFechas.Where(f => f.Nombre == "RECORDATORIO").Select(f => f.Valor).FirstOrDefault());
                int FecEstado = Convert.ToInt32(oListaFechas.Where(f => f.Nombre == "ESTADO").Select(f => f.Valor).FirstOrDefault());
                int Hora = Convert.ToInt32(oListaHora[0].Valor);

                //Notica
                if (FecNotificar == Convert.ToInt32(DateTime.Now.ToString("dd")) && Hora <= Convert.ToInt32(DateTime.Now.ToString("HH")))
                { OrdenCorreo = OrdenConsulta = 3; Estado = 1; }
                //Recordatorio
                else if (FecRecordatorio == Convert.ToInt32(DateTime.Now.ToString("dd")) && Hora <= Convert.ToInt32(DateTime.Now.ToString("HH")))
                { OrdenCorreo = OrdenConsulta = 4; Estado = 2; }
                //Estado
                else if (FecEstado == Convert.ToInt32(DateTime.Now.ToString("dd")) && Hora <= Convert.ToInt32(DateTime.Now.ToString("HH")))
                { OrdenCorreo = OrdenConsulta = 5; Estado = 3; }

                if (OrdenCorreo > 0 && OrdenConsulta > 0)
                { CorreoNotificaciones(OrdenConsulta, OrdenCorreo, Estado); }
                CorreoPagoConfirmado();
            }
            catch (Exception ex)
            { GrabarLog("EnviarCorreoMedicos:", "Error:" + ex.Message); }
        }
        public void CorreoNotificaciones(int OrdenConsulta, int OrdenCorreo, int Estado)
        {
            List<HisDatospagosconsultoriosE> oListaEnviarCorreo = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, "", 0, OrdenConsulta));
            foreach (var Contrato in oListaEnviarCorreo)
            {
                try
                {
                    if (OrdenConsulta == 3 && Estado == 1) { Contrato.Buscar = Contrato.IdePagocontrato.ToString(); }
                    else if (OrdenConsulta == 4 && Estado == 2) { Contrato.Buscar = Contrato.CodMedico.ToString(); }
                    else if (OrdenConsulta == 5 && Estado == 3) { Contrato.Buscar = Contrato.IdePagocontrato.ToString(); }

                    if (new EnviaCorreoHis().Sp_HIS_EnvioCorreo(new EnviaCorreoHisE(OrdenCorreo.ToString(), Contrato.Buscar.ToString(), "")))
                    {
                        if (OrdenConsulta == 4 && Estado == 2) /*Busca por el codigo medico*/
                        {
                            List<HisDatospagosconsultoriosE> oLista = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, Contrato.Buscar, 0, 9));
                            foreach (var PagoDatos in oLista)
                            { ActualizarCampoDatosPagos(PagoDatos.IdePagocontrato, Estado.ToString(), "flg_Correo"); }
                        }
                        else
                        { ActualizarCampoDatosPagos(Contrato.IdePagocontrato, Estado.ToString(), "flg_Correo"); }
                    }
                    else
                    { ActualizarCampoDatosPagos(Contrato.IdePagocontrato, "0", "flg_Correo"); }
                }
                catch (Exception ex)
                { GrabarLog("CorreoNotificaciones:", "IdContratoCab" + Contrato.IdeHisContratoconsultorioCab + "Error:" + ex.Message); }
            }
        }
        public void CorreoPagoConfirmado()
        {
            try
            {
                List<HisDatospagosconsultoriosE> oListaEnviarCorreo = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, "", 0, 12));
                foreach (var Contrato in oListaEnviarCorreo)
                {
                    try
                    {
                        CorreoConfirmacionPago(Contrato.IdePagocontrato, Contrato.IdePagosBot, Contrato.CodComprobante);//Correo Medico}
                        if (Contrato.CntRentaMensual > MontoMinDetraccion && Contrato.CodComprobante.Substring(0, 1) == "F")
                        {
                            new EnviaCorreoHis().Sp_HIS_EnvioCorreo(new EnviaCorreoHisE("6", Contrato.IdePagosBot.ToString(), ""));
                            new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Update(new HisDatospagosconsultoriosE(Contrato.IdePagosBot, "6", "flg_Correo"));
                        }
                    }
                    catch (Exception ex)
                    { GrabarLog("CorreoPagoConfirmado:", "IdContratoCab" + Contrato.IdeHisContratoconsultorioCab + "Error:" + ex.Message); }
                }
            }
            catch (Exception ex)
            { GrabarLog("CorreoPagoConfirmado:", "Error:" + ex.Message); }
        }
        public void PagarComprobanteDirecto()
        {
            try
            {
                List<HisDatospagosconsultoriosE> oLista = new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_Consulta(new HisDatospagosconsultoriosE(0, 0, "", 0, 6));
                foreach (var Contratos in oLista)
                {
                    try
                    {
                        Contratos.Operacion = "P";
                        Contratos.VariosTipoPago = "S";
                        ComprobantesE Comprobantes = CargarDatosGenerar(Contratos);
                        oGCC.PagarComprobante(Comprobantes);
                        oGCC.ActualizaPagoDatos(Contratos.IdePagosBot, "4");
                        ActualizaEstadoPago(Contratos.IdePagocontrato, "5", "BOT");
                        new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_UpdatexCampo(new HisDatospagosconsultoriosE(Contratos.IdePagocontrato, "4", "flg_Correo"));
                    }
                    catch (Exception ex)
                    { GrabarLog("PagarComprobanteDirecto:", "IdContratoCab:" + Contratos.IdeHisContratoconsultorioCab + " - Error:" + ex.Message); }
                }
            }
            catch (Exception ex)
            { GrabarLog("PagarComprobanteDirecto:", "Error:" + ex.Message); }
        }
        private void CorreoConfirmacionPago(int pIdePagocontrato, int pIdePagosBot, string pComprobante)
        {
            string RutaCompleta = "";
            try
            {
                string Comprobante = Criptography.EncryptConectionString(pComprobante);
                Comprobante = Uri.EscapeDataString(Comprobante);
                var Client = new RestClient(URLApiClinica + "TCI/API/ObtenerPdfByteTCI?Comprobante=" + Comprobante);
                var Request = new RestRequest();
                Request.AddHeader("Authorization", Criptography.EncryptConectionString(Key));
                Request.Method = Method.Get;
                RestResponse _response = Client.Execute(Request);
                if (_response.ResponseStatus != ResponseStatus.Error)
                {
                    var Response = JsonConvert.DeserializeObject<ObtenerPDF.Response>(_response.Content);
                    if (!Response.Error && Response.ArchivoByte != null)
                    {
                        List<TablasE> oLista = new Tablas().ListaConsulta(new TablasE("RUTA_CORREO", "", 0, 20, 30));
                        RutaCompleta = oLista[0].Nombre + @"\" + Response.NombreArchivo;
                        File.WriteAllBytes(RutaCompleta, Response.ArchivoByte);
                    }
                }
                EnviaCorreoHisE EnviaCorreoHis = new EnviaCorreoHisE("7", pIdePagosBot.ToString(), RutaCompleta);
                new EnviaCorreoHis().Sp_HIS_EnvioCorreo(EnviaCorreoHis);
                if (EnviaCorreoHis.mailitem_id > 0)
                { new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_UpdatexCampo(new HisDatospagosconsultoriosE(pIdePagocontrato, "5", "flg_Correo")); }
                File.Delete(RutaCompleta);
            }
            catch (Exception ex)
            {
                File.Delete(RutaCompleta);
                throw ex = new Exception(ex.Message);
            }
        }
        private void ActualizaEstadoPago(int pIdePagocontrato, string pEstado, string pValor)
        {
            string Campo = "";
            Dictionary<string, string> estadoCampoMapping = new Dictionary<string, string>
            {
                { "1", "cod_presotor" },
                { "2", "cod_liquidacion" },
                { "3", "ide_pagos_bot" },
                { "4", "cod_comprobante" },
                { "5", "origen_pago" },
            };
            if (estadoCampoMapping.TryGetValue(pEstado, out string? campoAsociado)) { Campo = campoAsociado; }
            ActualizarCampoDatosPagos(pIdePagocontrato, pValor, Campo);
            ActualizarCampoDatosPagos(pIdePagocontrato, pEstado, "Estado");
        }
        private void ActualizaCampoContratoCab(int pIdContratoCab, string pCampo, string pValor)
        {
            try
            { new ContratoConsultoriosCab().Sp_HisContratoconsultorioCab_UpdatexCampo(new HisContratoconsultorioCabE(pIdContratoCab, pValor, pCampo)); }
            catch (Exception ex)
            { GrabarLog("ActualizaCampoContratoCab:", "Sp:Sp_HisContratoconsultorioCab_UpdatexCampo - IdePagocontrato:" + pIdContratoCab + ", Campo:" + pCampo + ", Valor:" + pValor + " - Error:" + ex.Message); }
        }
        private void ActualizarCampoAdendaCab(int pIdeAdendaCab, int pIdeHisContratoconsultorioCab, string pNuevoValor, string pCampo, int pOrden)
        {
            try
            { new ContraroAdendaCab().Sp_HisContratoconsultorioadendaCab_UpdatexCampo(new HisContratoconsultorioadendaCabE(pIdeAdendaCab, pIdeHisContratoconsultorioCab, pNuevoValor, pCampo, pOrden)); }
            catch (Exception ex)
            { GrabarLog("ActualizarCampoAdendaCab:", "Sp:Sp_HisContratoconsultorioadendaCab_UpdatexCampo - IdeContratoCab:" + pIdeHisContratoconsultorioCab + " ,IdeAdendaCab:" + pIdeAdendaCab + ", Campo:" + pCampo + ", Valor:" + pNuevoValor + " - Error:" + ex.Message); }
        }
        private ComprobantesE CargarDatosGenerar(HisDatospagosconsultoriosE Contrato)
        {
            ComprobantesE Comprobante = new ComprobantesE();
            Comprobante.CodComprobante = Contrato.CodComprobante;
            Comprobante.CodLiquidacion = Contrato.CodLiquidacion;
            Comprobante.FlgElectronico = true;
            Comprobante.TipoComprobante = Contrato.TipComprobante;
            Comprobante.Monto = Math.Round(Convert.ToDouble(Contrato.CntRentaMensual));
            Comprobante.ANombreDeQuien = Contrato.ANombreDeQuien;
            Comprobante.Ruc = Contrato.Ruc;
            Comprobante.Moneda = Contrato.TipMoneda;
            Comprobante.Tipoimpresion = Contrato.TipoImpresion;
            Comprobante.Flagdolares = Contrato.TipMoneda == "S" ? "N" : "S";
            Comprobante.FechaEmision = DateTime.Now;
            Comprobante.Operacion = Contrato.Operacion;
            Comprobante.VariosTipoPago = Contrato.VariosTipoPago;
            Comprobante.Tipodecambio = Contrato.TipCambio;
            Comprobante.CodEmpresa = Contrato.Empresa;
            Comprobante.CodTerminal = Contrato.CodTerminal;
            Comprobante.Cardcode = Contrato.CardCode;
            Comprobante.Codmedicotercero = Contrato.CodMedico;
            Comprobante.Direccion = Contrato.Direccion;
            Comprobante.Tipdocidentidad = Contrato.TipDocIdentidad;
            Comprobante.Docidentidad = Contrato.DocIdentidad;
            Comprobante.CodTipoFactura = Contrato.CodTipoFactura;
            Comprobante.Concepto = Contrato.Concepto;
            Comprobante.TipoPago = Contrato.TipPago;
            Comprobante.NombreEntidad = Contrato.Entidad;
            Comprobante.NumeroEntidad = Contrato.NumeroEntidad;
            Comprobante.EmailMedico = Contrato.Email_Medico;
            return Comprobante;
        }
        private void ActualizarCampoDatosPagos(int pId, string pNuevoValor, string pCampo)
        {
            try
            { new DatosPagosConsultorios().Sp_HisDatospagosconsultorios_UpdatexCampo(new HisDatospagosconsultoriosE(pId, pNuevoValor, pCampo)); }
            catch (Exception ex)
            { GrabarLog("ActualizarCampoDatosPagos:", "Sp:Sp_HisDatospagosconsultorios_UpdatexCampo - IdePagocontrato:" + pId + ", Campo:" + pCampo + ", Valor:" + pNuevoValor + " - Error:" + ex.Message); }
        }
        private void GrabarLog(string? pMetodo, string? pMensaje)
        { VarGlobal.Grabar_log(pMensaje, pMetodo); }
    }
}
