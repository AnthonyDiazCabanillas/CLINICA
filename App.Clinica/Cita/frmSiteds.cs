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
using System.Windows.Forms;
using static Bus.AgendaClinica.Clinica.SitedsWs;
using static Bus.AgendaClinica.Clinica.SynapsisWS.ResponseNotificationOrderApi;
//using static Bus.AgendaClinica;


namespace App.Clinica.Cita
{
    public partial class frmSiteds : Form
    {

        string xSunasa = "";
        string xIAFAS = "";
        string xRuc = "";

        SitedsWs oWsSiteds = new SitedsWs();
        Generales oGenerales = new Generales();

        AsegNombRequest oAsegNombRequest = new AsegNombRequest();
        AsegNombResponse oAsegNomb = new AsegNombResponse();

        AsegCodRequest oAsegCodRequest = new AsegCodRequest();
        AsegCodResponse oAsegCodResponse = new AsegCodResponse();

        NumeroAutorizacionRequest oNumAutorizacionRequest = new NumeroAutorizacionRequest();
        NumeroAutorizacionResponse oNumAutorizacionResp = new NumeroAutorizacionResponse();

        Coberturas_AsegCode oCoberturas = new Coberturas_AsegCode();
        ObservacionRequest oObservacionRequest = new ObservacionRequest();


        FotoRequest oFotoRequest = new FotoRequest();
        CasoTiempoEsperaRequest oCasoTiempoEsperaRequest = new CasoTiempoEsperaRequest();
        CasoExcepcionCarenciaRequest oCasoExcepcionCarenciaRequest = new CasoExcepcionCarenciaRequest();
        CondicionMedicaRequest oCondicionMedicaRequest = new CondicionMedicaRequest();
        DatosAdicionalesRequest oDatosAdicionalesRequest = new DatosAdicionalesRequest();


        CorreoAgenda objCorreoAgenda = new CorreoAgenda();
        AdmisionHospitalariaWs oAdmisionHospitalaria = new AdmisionHospitalariaWs();

        ProcedimientosEspecialesRequest oProcedimientosEspecialesRequest = new ProcedimientosEspecialesRequest();
        string stringJson;
        string[] listaCobertura = new string[4];
        string[] listaIafa = new string[8];


        Utilitario util = new Utilitario();

        MdsynDatosPagosE oMdsynDatosPagosE = new MdsynDatosPagosE();
        string RutaWS_Siteds = "http://200.48.199.90/WSSITEDS/Sistema/";


        bool PuedoPintar = false;
        Pen p = new Pen(Brushes.Black, (float)4.9d);
        Graphics g;
        System.Drawing.Drawing2D.GraphicsPath ph = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Alternate);
        bool Swich = false;
        object x1, y1, x2, y2;




        public frmSiteds()
        {
            InitializeComponent();
        }

        private void frmSiteds_Load(object sender, EventArgs e)
        {

            Dat.Sql.VariablesGlobales.Clinica_AsignaSede();
            xRuc = TxtRUC.Text;
            xSunasa = TxtSUNASA.Text;

            listaCobertura = new string[] { "4100", "4123", "4150", "4153" };
            listaIafa = new string[] { "20001", "20002", "40004", "20005", "40006", "20004", "20029", "40005" };
            //oWsSiteds = new SitedsWs(xRuc, xSunasa, xIAFAS);
            //oGenerales = new Generales(xRuc);

            //LoadConectionString("cnnMedisynOracle", ListDataBase.medisyn);
            //LoadConectionString("CnnClinicaSql", ListDataBase.clinica);
            //LoadConectionString("CnnLogisticaSql", ListDataBase.logistica);


            Bus.AgendaClinica.Clinica.VariablesGlobales.LoadInitialData(); // Cargar los datos iniciales




            //objCorreoAgenda.Load_Initial();
            //objCorreoAgenda.CargarDatosIni();



            var bmp = new Bitmap(this.pctFirma.Size.Width, this.pctFirma.Size.Height);
            pctFirma.Image = bmp;
            g = Graphics.FromImage(this.pctFirma.Image);
            g.Clear(Color.White);

            xSunasa = TxtSUNASA.Text;
            xIAFAS = TxtIAFAS.Text;
            xRuc = TxtRUC.Text;

            //oGenerales = new Generales(xRuc);
            oGenerales.CargarIniObtenerPagosVisaNet();
            oGenerales.CargarIniQR();

            oAdmisionHospitalaria.CargarIniCorreo();

            // OcultarAppTray()
            WindowState = FormWindowState.Minimized;

            this.Text = ". : : Formulario Principal  " + "[" + Bus.Utilities.ConnectionsString.Server + "] : : .";


        }



        private void btnConsultaAsegNom_Click(object sender, EventArgs e)
        {
            //SitedsWs sitedsWs = new SitedsWs();




            xIAFAS = TxtIAFAS.Text;
            TxtRUC_Cod.Text = xRuc;
            TxtSUNASA_Cod.Text = xSunasa;
            TxtIAFAS_Cod.Text = xIAFAS;


            oWsSiteds = new SitedsWs();
            oWsSiteds.AsignaIAFA(xRuc, xSunasa, xIAFAS);

            oAsegNombRequest = new AsegNombRequest(xRuc, xSunasa, xIAFAS);

            oAsegNombRequest.CodTipoDocumentoAfiliado = TxtCodTipoDocumentoAfiliado.Text; // Solo enviar el tipo de documento y numero de documento
            oAsegNombRequest.NumeroDocumentoAfiliado = txtNumeroDocumentoAfiliado.Text; // Documento (Enviar)
            oAsegNombRequest.NombresAfiliado = TxtNombresAfiliado.Text;
            oAsegNombRequest.ApellidoPaternoAfiliado = txtApellidoPaternoAfiliado.Text;
            oAsegNombRequest.ApellidoMaternoAfiliado = txtApellidoMaternoAfiliado.Text;
            oAsegNombRequest.CodEspecialidad = TxtCodEspecialidad.Text;

            stringJson = ConsultaAsegNom(RutaWS_Siteds, oAsegNombRequest);



            List<AsegNombResponse> oListAsegNombResponse = (List<AsegNombResponse>)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(List<AsegNombResponse>));
            gvAsegNom.DataSource = oListAsegNombResponse;

            if (oListAsegNombResponse == null) return;
            oAsegCodRequest = oWsSiteds.mtdAsignarAseguradoCorrecto(oListAsegNombResponse, oAsegNombRequest.NumeroDocumentoAfiliado, true);

            oAsegCodRequest.RUC = oAsegNombRequest.RUC;
            oAsegCodRequest.IAFAS = oAsegNombRequest.IAFAS;
            oAsegCodRequest.SUNASA = oAsegNombRequest.SUNASA;

            //var withBlock = oAsegCodRequest;
            TxtNombresAfiliado_Cod.Text = oAsegCodRequest.NombresAfiliado;
            TxtApellidoPaternoAfiliado_Cod.Text = oAsegCodRequest.ApellidoPaternoAfiliado;
            TxtApellidoMaternoAfiliado_Cod.Text = oAsegCodRequest.ApellidoMaternoAfiliado;
            TxtCodigoAfiliado_Cod.Text = oAsegCodRequest.CodigoAfiliado;
            TxtNumeroDocumentoAfiliado_Cod.Text = oAsegCodRequest.NumeroDocumentoAfiliado;
            TxtCodProducto_Cod.Text = oAsegCodRequest.CodProducto;
            TxtDesProducto_Cod.Text = oAsegCodRequest.DesProducto;
            TxtNumeroPlan_Cod.Text = oAsegCodRequest.NumeroPlan;
            TxtCodTipoDocumentoAfiliado_Cod.Text = oAsegCodRequest.CodTipoDocumentoAfiliado;
            TxtDesProducto_Cod.Text = oAsegCodRequest.DesProducto;
            TxtNumeroPlan_Cod.Text = oAsegCodRequest.NumeroPlan;
            TxtCodTipoDocumentoContratante_Cod.Text = oAsegCodRequest.CodTipoDocumentoContratante;
            TxtNumeroDocumentoContratante_Cod.Text = oAsegCodRequest.NumeroDocumentoContratante;
            TxtNombreContratante_Cod.Text = oAsegCodRequest.NombreContratante;
            TxtCodParentesco_Cod.Text = oAsegCodRequest.CodParentesco;
            TxtTipoCalificadorContratante_Cod.Text = oAsegCodRequest.TipoCalificadorContratante;
            TxtCodEspecialidad_Cod.Text = oAsegCodRequest.CodEspecialidad;

        }

        private void btnAsegCod_Click(object sender, EventArgs e)
        {

            stringJson = ConsultaAsegCod(RutaWS_Siteds, oAsegCodRequest);
            oAsegCodResponse = (AsegCodResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(AsegCodResponse));

            if (oAsegCodResponse == null) return;
            if (oAsegCodResponse.Coberturas == null) return;

            List<DatosAfiliado_AsegCode> lstDatosAfiliado_AsegCode = new List<DatosAfiliado_AsegCode>();
            lstDatosAfiliado_AsegCode.Add(oAsegCodResponse.DatosAfiliado);

            gvAsegCod0.DataSource = lstDatosAfiliado_AsegCode;
            gvAsegCod.DataSource = oAsegCodResponse.Coberturas;
            string TipoAfiliacion = oAsegCodResponse.DatosAfiliado.CodTipoAfiliacion.Substring(0, 1);



            oCoberturas = oAsegCodResponse.Coberturas
                            .Where(x => listaCobertura.Contains(x.CodigoCobertura))
                            .FirstOrDefault();

        }


        private void btnAutorizacion_Click(object sender, EventArgs e)
        {
            if (oCoberturas == null) return;
            if (oCoberturas.CodigoCobertura == null) return;

            oNumAutorizacionRequest = oWsSiteds.fnNumeroAutorizacion(oCoberturas, oAsegCodResponse);
            stringJson = ConsultaNumeroAutorizacion(RutaWS_Siteds, oNumAutorizacionRequest);

            oNumAutorizacionResp = (NumeroAutorizacionResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(NumeroAutorizacionResponse));

            List<NumeroAutorizacionResponse> lstNumeroAutorizacionResponse = new List<NumeroAutorizacionResponse>();
            lstNumeroAutorizacionResponse.Add(oNumAutorizacionResp);
            gvAutorizacion.DataSource = lstNumeroAutorizacionResponse;


            oObservacionRequest = oWsSiteds.fnObservacionRequest(oNumAutorizacionRequest, oAsegCodRequest);
            stringJson = ConsultaObservacion(RutaWS_Siteds, oObservacionRequest);
            ObservacionResponse oObservacionResponse = (ObservacionResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(ObservacionResponse));

            List<ObservacionResponse> lstObservacionResponse = new List<ObservacionResponse>();
            lstObservacionResponse.Add(oObservacionResponse);
            gvObservacion.DataSource = lstObservacionResponse;


            oCasoTiempoEsperaRequest = oWsSiteds.fnCasoTiempoEsperaRequest(oNumAutorizacionRequest, oCoberturas);
            stringJson = CasoTiempoEspera(RutaWS_Siteds, oCasoTiempoEsperaRequest);
            CasoTiempoEsperaResponse oCasoTiempoEsperaResponse = (CasoTiempoEsperaResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(CasoTiempoEsperaResponse));

            List<CasoTiempoEsperaResponse> lstCasoTiempoEsperaResponse = new List<CasoTiempoEsperaResponse>();
            lstCasoTiempoEsperaResponse.Add(oCasoTiempoEsperaResponse);
            gvCasoTiempoEspera.DataSource = lstCasoTiempoEsperaResponse;


            oProcedimientosEspecialesRequest = oWsSiteds.fnConsultaProcedimientosEspecialesRequest(oNumAutorizacionRequest, oCoberturas);
            stringJson = ProcedimientosEspeciales(RutaWS_Siteds, oProcedimientosEspecialesRequest);
            ProcedimientosEspecialesResponse oProcedimientosEspecialesResponse = (ProcedimientosEspecialesResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(ProcedimientosEspecialesResponse));

            List<Procedimiento> lstProcedimiento = new List<Procedimiento>();
            lstProcedimiento.Add(oProcedimientosEspecialesResponse.Procedimiento);
            gvProcedimiento.DataSource = lstProcedimiento;

            gvProcedimientoDetalle.DataSource = oProcedimientosEspecialesResponse.Procedimiento.Detalle;
            gvProcedimientosEspecialesDetalle.DataSource = oProcedimientosEspecialesResponse.Detalle;


        }

        public void mtdCargarDatosCobertura(AsegCodResponse pAsegCodResponse, Coberturas_AsegCode pCoberturas)
        {
            string CodTipoConsultaMedica = "",
                LineasCoberturas = "",
                CodSubTipoCobertura = "",
                CodPoliza = "",
                NumeroPlanPoliza = "",
                CodAseguradora = "",
                CoPagoFijo = "",
                CoPagoVariable = "";

            if (CodTipoConsultaMedica == "A")
            {
                LineasCoberturas = LineasCoberturas + "Descripción del Tipo de Plan: " + pAsegCodResponse.DatosAfiliado.DesTipoPlan + '\r'
                    + "Tipo de Cobertura: " + pCoberturas.Beneficios + '\r'
                    + "CoPagoFijo: " + pCoberturas.DesCopagoFijo + '\r'
                    + "CoPagoVariable: " + pCoberturas.DesCopagoVariable;

                CodSubTipoCobertura = pCoberturas.CodigoSubTipoCobertura;

                if (NumeroPlanPoliza.Length >= 3) // Solo en caso el numero de planpoliza es mayor a 3
                {
                    NumeroPlanPoliza = NumeroPlanPoliza.Substring(NumeroPlanPoliza.Length - 3, 3);
                }

                CodPoliza = CodAseguradora + oAsegCodRequest.NumeroPlan;
            }
            else
            {
                LineasCoberturas = LineasCoberturas + "Descripción del Tipo de Plan: "
                    + "PARTICULAR" + '\r'
                    + "Tipo de Cobertura: " + "Particular" + '\r'
                    + "CoPagoFijo: " + CoPagoFijo + '\r'
                    + "CoPagoVariable: " + CoPagoVariable;

                CodPoliza = CodAseguradora + NumeroPlanPoliza;
            }
        }


        private void gvAsegNom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtSUNASA_TextChanged(object sender, EventArgs e)
        {

        }

        private void gvAsegCod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnProcesarPago_Click(object sender, EventArgs e)
        {
            oGenerales.mtProcesarPagos();
        }

        private void btnCrearDatodPago_Click(object sender, EventArgs e)
        {
            int ide_cita = util.ValInt(txtide_cita.Text);
            if (ide_cita == 0)
            {
                MessageBox.Show("Ingrese Nro de cita");
                return;
            }
            oGenerales.ProcesoPagoPorIdCitaPre(ide_cita);
        }


        private void btnAux01_Click(object sender, EventArgs e)
        {
            txtNumeroDocumentoAfiliado.Text = txtDNICargaDato.Text;
            TxtIAFAS.Text = txtIAFASCargaDato.Text;
        }

        private void btnProcesarPago_Click_1(object sender, EventArgs e)
        {
            ProcesoServicio();
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

                oGenerales.mtProcesarPagos();
                oGenerales.mtConfirmarCitas();
                oGenerales.ObtenerPagosVisaNet();

                // oGenerales.mtProcesarAnulaciones() 'JCAICEDO 21/04/2022 - Ya no se usará este método.
                oGenerales.MtEnvioQrEstacionamiento(); // GLLUNCOR - 15/03/2022 [Se envia el correo del QR de estacionamiento al paciente]
                //CountEnviar = 0;
            }
            catch (Exception ex)
            {
                objCorreoAgenda.GuardarMensajeNotepad(ex.ToString(), "ProcesoServicio");
            }
        }



        private void btnPagarCita_Click(object sender, EventArgs e)
        {
            int ide_cita = util.ValInt(txtide_cita.Text);
            if (ide_cita == 0)
            {
                MessageBox.Show("Ingrese Nro de cita");
                return;
            }
            oGenerales.ProcesoPagoPorIdCitaPost(ide_cita);

            //oMdsynDatosPagosE.DscMensajeRespuesta = txtdsc_mensajerespuesta.Text;
            //oMdsynDatosPagosE.EstPagoExitoso = txtest_pagoexitoso.Text;
            //oMdsynDatosPagosE.TipTarjeta = txttip_tarjeta.Text;
            //oMdsynDatosPagosE.NumTarjeta = txtnum_tarjeta.Text;
            //oMdsynDatosPagosE.Comp_TipoComprobante = txtcod_tipo_comprobante.Text;
            //oMdsynDatosPagosE.Comp_TipDocIdentidad = txttip_doc_identidad.Text;
            //oMdsynDatosPagosE.Comp_RutDocIdentidad = txtdoc_identidad.Text;
            //oMdsynDatosPagosE.Comp_Correo = txtdsc_correo_comprobante.Text;
            //oMdsynDatosPagosE.TransaccionIdNiubiz = txttransaction_id.Text;
            //oMdsynDatosPagosE.IdeCita = util.ValInt(txtide_cita.Text);

            //RespuestaE oRespuesta = new RespuestaE();
            //oRespuesta.Respuesta = new MdsynDatosPagosAD().Sp_MdsynDatosPagos_Cita_Insert(oMdsynDatosPagosE);

            //List<MdsynDatosPagosE> lstMdsynDatosPagosE = new List<MdsynDatosPagosE>();
            //lstMdsynDatosPagosE.Add(oMdsynDatosPagosE);
            //gvDetalleAtencion.DataSource = lstMdsynDatosPagosE;

        }

        private void TxtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnObtenerIafas_Click(object sender, EventArgs e)
        {


            string dni = txtDNICargaDato.Text;
            RetornaIAFASporDni("1", dni);
        }


        private void RetornaIAFASporDni(string tipo_documento, string nro_documento)
        {
            SitedsWs oWsSiteds = new SitedsWs();
            List<AsegCodRequest> lstAsegCodRequest = oWsSiteds.RetornaIAFASporDni(Dat.Sql.VariablesGlobales.ClinicaE, tipo_documento, nro_documento);
            gvDetalleAtencion.DataSource = lstAsegCodRequest;

            //if (oAsegCodResponse.Coberturas == null) return oMdsynDatosPagosE;

            //oCoberturas = oAsegCodResponse.Coberturas
            //     .Where(x => listaCobertura.Contains(x.CodigoCobertura))
            //     .FirstOrDefault();

            //return lstAsegCodResponse;

        }

        private void txttip_doc_identidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdoc_identidad_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnObtenerIafasOptimo_Click(object sender, EventArgs e)
        {
            string dni = txtDNICargaDato.Text;
            RetornaIAFASporDniOptimo("1", dni);

        }

        private void RetornaIAFASporDniOptimo(string tipo_documento, string nro_documento)
        {
            SitedsWs oWsSiteds = new SitedsWs();
            List<AsegCodRequest> lstAsegCodRequest = oWsSiteds.RetornaIAFASporDniParalelo(Dat.Sql.VariablesGlobales.ClinicaE, tipo_documento, nro_documento);
            gvDetalleAtencion.DataSource = lstAsegCodRequest;
            //gvDetalleAtencion.hea
            //if (oAsegCodResponse.Coberturas == null) return oMdsynDatosPagosE;

            //oCoberturas = oAsegCodResponse.Coberturas
            //     .Where(x => listaCobertura.Contains(x.CodigoCobertura))
            //     .FirstOrDefault();

            //return lstAsegCodResponse;

        }

        private void gvDetalleAtencion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = gvDetalleAtencion.Rows[index];
            gvDetalleAtencion.Rows[selectedRow.Index].Selected = true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtide_cita_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gvDetalleAtencion.SelectedRows)
            {
                AsegCodRequest cust = row.DataBoundItem as AsegCodRequest;
                if (cust != null)
                {
                    pVerConsultaAsegCod(cust);
                    return;
                }
            }
        }

        private void pVerConsultaAsegCod(AsegCodRequest oAsegCodRequest)
        {

            stringJson = ConsultaAsegCod(RutaWS_Siteds, oAsegCodRequest);
            oAsegCodResponse = (AsegCodResponse)Newtonsoft.Json.JsonConvert.DeserializeObject(stringJson, typeof(AsegCodResponse));

            if (oAsegCodResponse == null) return;
            if (oAsegCodResponse.Coberturas == null) return;

            List<DatosAfiliado_AsegCode> lstDatosAfiliado_AsegCode = new List<DatosAfiliado_AsegCode>();
            lstDatosAfiliado_AsegCode.Add(oAsegCodResponse.DatosAfiliado);

            dgwAsegCodResponseAfiliado.DataSource = lstDatosAfiliado_AsegCode;
            dgwAsegCodResponseCobertura.DataSource = oAsegCodResponse.Coberturas;

            //string TipoAfiliacion = oAsegCodResponse.DatosAfiliado.CodTipoAfiliacion.Substring(0, 1);
            //oCoberturas = oAsegCodResponse.Coberturas
            //                .Where(x => listaCobertura.Contains(x.CodigoCobertura))
            //                .FirstOrDefault();

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}

