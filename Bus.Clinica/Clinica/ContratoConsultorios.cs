/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using Dat.Sql.ClinicaAD.ContratosAD;
using Dat.Sql.ClinicaAD.OtrosAD;
using Dat.Sql.ClinicaAD.PresotorAD;
using Ent.Sql.ClinicaE.ContratosE;
using Ent.Sql.ClinicaE.PresotorE;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Dat.Sql.ClinicaAD.LiquidacionesAD;
using Ent.Sql.ClinicaE.LiquidacionesE;
using Dat.Sql;
using static Bus.Clinica.Clinica.GeneralContratos;
using Ent.Sql.ClinicaE.MedisynE;
using static Dat.Sql.VariablesGlobales;
using Ent.Sql.ClinicaE.ComprobantesE;
using Ent.Sql.ClinicaE.Sb1SocionegocioE;
using Dat.Sql.ClinicaAD.Sb1SocionegocioAD;
using Dat.Sql.ClinicaAD.ComprobantesAD;
using Dat.Sql.ClinicaAD.MedisynAD;


namespace Bus.Clinica.Clinica
{
    public class GeneralContratos
    {
        //desactivar contratos
        //consultar contratos activos 
        //consultaratencion
        //generarliquidacion

        private bool ValidarComprobante()
        {
            List<TablasE> EstComprobante = new Tablas().ListaConsulta(new TablasE("EFACT_FLAG_GENERAFACTURA", "", 0, 1, 5));
            if (EstComprobante[0].Codigo != "S") { return false; }
            return true;
        }
        public bool ValirdarCardCode(string? pCardCode, int pOrden)
        {
            try
            {
                List<Sb1SocionegocioE> oLista = new Sb1SocionegocioAD().Sp_Sb1Socionegocio_Consulta(new Sb1SocionegocioE(pCardCode, pOrden));
                if (oLista.Count == 0)
                { throw new Exception("CardCode Vacio"); }
                return true;
            }
            catch (Exception ex)
            { throw ex = new Exception(ex.Message); }

        }
        public bool ValidarComprobanteAlqCons()
        {
            List<TablasE> Lista = new Tablas().ListaConsulta(new TablasE("FLAGFACTURA_ATERCEROXALQYFONO", "", 0, 1, 5));
            if (Lista[0].Codigo != "1") { return false; }
            if (!ValidarComprobante()) { return false; }
            Lista = new Tablas().ListaConsulta(new TablasE("EFACT_TIPOCODIGO_BARRAHASH", "", 0, 1, 5));
            if (Lista[0].Codigo != "01" && Lista[0].Codigo != "00") { return false; }
            Lista = new Tablas().ListaConsulta(new TablasE("EFACT_TCI_WS", "", 0, 1, 5));
            if (Lista.Count == 0) { return false; }

            return true;
        }
        public string RegistrarLiquidaciones(string xAtencion, string xCodPresotor)
        {
            string wCodLiquidacion = "";
            Utilitario util = new Utilitario();

            LiquidacionesE objLiquidacionE = new LiquidacionesE(xAtencion, "", "P", 1, wCodLiquidacion);
            if (new LiquidacionesAD().Sp_Liquidaciones_Insert(objLiquidacionE))
            {
                wCodLiquidacion = objLiquidacionE.CodLiquidacion;
                new LiquidacionesAD().Sp_Liquidaciones_Insert(new LiquidacionesE(xAtencion, util.Mid(xCodPresotor, 9), "P", 2, wCodLiquidacion));

                if (!string.IsNullOrEmpty(wCodLiquidacion))
                { new LiquidacionesAD().Sp_LiquidacionesRecalculo_Update(new LiquidacionesE(xAtencion, "P", wCodLiquidacion)); }

            }
            return wCodLiquidacion;
        }
        public void ActualizaPagoDatos(int pIdePagoBot, string pUser)
        {
            new MdsynPagosAD().Sp_MdsynPagos_UpdatexCampo(new MdsynPagosE(pIdePagoBot, pUser, "flg_pago_usado"));
            //new MdsynPagosAD().Sp_MdsynPagos_UpdatexCampo(new MdsynPagosE(pIdePagoBot, "4", "usr_pago_usado"));
            new MdsynPagosAD().Sp_MdsynPagos_UpdatexCampo(new MdsynPagosE(pIdePagoBot, DateTime.Now.ToString("MM/dd/yyy HH:mm:ss"), "fec_pago_usado"));
        }
        public void PagarComprobante(ComprobantesE pComprobante)
        {
            //Sp_Comprobante_Buscando pCodComprobante,"001" =="c"Comprobante se encutra cancelado
            try
            {
                List<ComprobantesE> oLista = new List<ComprobantesE>();
                oLista = new ComprobantesAD().Sp_Comprobante_Buscando(pComprobante);
                if (oLista[0].Estado == "C")
                {
                    //Comprobante generado pagado
                    return;
                }
                new ComprobantesAD().Sp_ComprobanteManuales2_Insert(ref pComprobante);
                pComprobante.Campo = "fechacancelacion";
                pComprobante.NuevoValor = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                new ComprobantesAD().Sp_Comprobante_Update(pComprobante);

                pComprobante.Campo = "estado";
                pComprobante.NuevoValor = "C";
                new ComprobantesAD().Sp_Comprobante_Update(pComprobante);
            }
            catch (Exception ex) { }

        }
        public string RegistroPresotor(string xAtencion, string xPrestacion, int xIDUser, decimal xRentaMensual, string Dim1)
        {
            string wCodPresotor = new PresotorAD().Sp_Presotor_Insert1(new PresotorE(xAtencion, xPrestacion, xIDUser));
            if (!string.IsNullOrEmpty(wCodPresotor))
            {
                new PresotorAD().Sp_Presotor_UpdatexCampo(new PresotorE("valorcorregido", wCodPresotor, xRentaMensual.ToString()));
                new PresotorAD().Sp_Presotor_UpdatexCampo(new PresotorE("fechahoraatencion", wCodPresotor, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")));
                new PresotorxDimensionesAD().Sp_Sb1Presotorxdimension_Insert(new PresotorxDimensionesE(wCodPresotor, "GECA", xIDUser, Dim1));
            }
            return wCodPresotor;
        }
        public double LimiteMonto()
        {
            List<TablasE> ListaLimite = new Tablas().ListaConsulta(new TablasE("SOLICITADNI_MONTOCOMPMAYOR_A", "", 0, 1, 30));
            double MontoLimite = ListaLimite[0].Valor;
            return MontoLimite;
        }
        public string ObtenerAtencion()
        {
            List<TablasE> ListaAtencion = new Tablas().ListaConsulta(new TablasE("ATENCIONCOMPROBANTEMANUAL", "Z", 0, 1, 30));
            string Atencion = ListaAtencion[0].Nombre.ToString();
            return Atencion;
        }
    }

    #region ContratoConsultoriosCab
    public class ContratoConsultoriosCab
    {
        public List<HisContratoconsultorioCabE> Sp_HisContratoconsultorioCab_Consulta(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            { return new HisContratoconsultorioCabAD().Sp_HisContratoconsultorioCab_Consulta(pHisContratoconsultorioCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioCab_Insert(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            { return new HisContratoconsultorioCabAD().Sp_HisContratoconsultorioCab_Insert(pHisContratoconsultorioCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioCab_Update(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            { return new HisContratoconsultorioCabAD().Sp_HisContratoconsultorioCab_Update(pHisContratoconsultorioCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioCab_UpdatexCampo(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            { return new HisContratoconsultorioCabAD().Sp_HisContratoconsultorioCab_UpdatexCampo(pHisContratoconsultorioCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region Calendario del Contrato
    public class CalendarioContrato
    {
        public List<HisContratoconsultoriocalendarioMaeE> ConsultaCalendario(HisContratoconsultoriocalendarioMaeE pHisContratoconsultoriocalendarioMaeE)
        {
            try
            { return new HisContratoconsultoriocalendarioMaeAD().Sp_HisContratoconsultoriocalendarioMae_Consulta(pHisContratoconsultoriocalendarioMaeE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region Beneficios del Contrato
    public class BeneficiosContrato
    {
        public List<HisContratoconsultoriobeneficioMaeE> ConsultaBeneficios(HisContratoconsultoriobeneficioMaeE pHisContratoconsultoriobeneficioMaeE)
        {
            try
            { return new HisContratoconsultoriobeneficioMaeAD().Sp_HisContratoconsultoriocalendarioMae_Consulta(pHisContratoconsultoriobeneficioMaeE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region ContratoxBeneficiosDet
    public class ContratoBeneficiosDet
    {
        public List<HisContratoconsultoriobeneficiosDetE> ConsultarContratoBeneficiosDet(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosDetAD().Sp_HisContratoconsultoriobeneficiosDet_Consulta(pHisContratoconsultoriobeneficiosDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_HisContratoconsultoriobeneficiosDet_Insert(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosDetAD().Sp_HisContratoconsultoriobeneficiosDet_Insert(pHisContratoconsultoriobeneficiosDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_HisContratoconsultoriobeneficiosDet_UpdatexCampo(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosDetAD().Sp_HisContratoconsultoriobeneficiosDet_UpdatexCampo(pHisContratoconsultoriobeneficiosDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region ContratoxConsultorioDet
    public class ContratoConsultorioDet
    {
        public List<HisContratoconsultorioDetE> ConsultarContratoConsultorioDet(HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            try
            { return new HisContratoconsultorioDetAD().Sp_HisContratoconsultorioDet_Consulta(pHisContratoconsultorioDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_HisContratoconsultorioDet_Insert(HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            try
            { return new HisContratoconsultorioDetAD().Sp_HisContratoconsultorioDet_Insert(pHisContratoconsultorioDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioDet_UpdatexCampo(HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            try
            { return new HisContratoconsultorioDetAD().Sp_HisContratoconsultorioDet_UpdatexCampo(pHisContratoconsultorioDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }

    public class Contratos
    {
        public bool RegistrarContrato(HisContratoconsultorioCabE pHisContratoconsultorioCabE,
                                      bool pEstBeneficio,
                                      HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE,
                                      List<HisContratoconsultorioDetE> pListHisContratoconsultorioDetE)
        {
            try
            { return new HisRegistroContrato().RegistrarContrato(pHisContratoconsultorioCabE, pEstBeneficio, pHisContratoconsultoriobeneficiosDetE, pListHisContratoconsultorioDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region Adenda
    public class Adenda
    {
        public bool RegistrarAdenda(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE,
                                      bool pEstBeneficio,
                                      HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE,
                                      List<HisContratoconsultorioadendaDetE> pListHisContratoconsultorioadendaDetE,
                                       HisContratoconsultoriobeneficiosDetE pContratoBeneficiosDetCopy)
        {
            try
            { return new HisRegistroAdenda().RegistrarAdenda(pHisContratoconsultorioadendaCabE, pEstBeneficio, pHisContratoconsultoriobeneficiosadendaDetE, pListHisContratoconsultorioadendaDetE, pContratoBeneficiosDetCopy); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region ContratoAdendaCab
    public class ContraroAdendaCab
    {
        public List<HisContratoconsultorioadendaCabE> Sp_HisContratoconsultorioadendaCab_Consulta(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            { return new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_Consulta(pHisContratoconsultorioadendaCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioadendaCab_Insert(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            { return new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_Insert(pHisContratoconsultorioadendaCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioadendaCab_Update(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            { return new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_Update(pHisContratoconsultorioadendaCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioadendaCab_UpdatexCampo(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            { return new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_UpdatexCampo(pHisContratoconsultorioadendaCabE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region ContratoAdendaDet
    public class ContratoAdendaDet
    {
        public List<HisContratoconsultorioadendaDetE> Sp_HisContratoconsultorioadendaDet_Consulta(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            { return new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_Consulta(pHisContratoconsultorioadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioadendaDet_Insert(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            { return new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_Insert(pHisContratoconsultorioadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioadendaDet_Update(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            { return new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_Update(pHisContratoconsultorioadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioadendaDet_UpdatexCampo(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            { return new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_UpdatexCampo(pHisContratoconsultorioadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region ContratoconsultoriobeneficiosadendaDet
    public class ContratoconsultoriobeneficiosadendaDet
    {
        public List<HisContratoconsultoriobeneficiosadendaDetE> Sp_HisContratoconsultoriobeneficiosadendaDet_Consulta(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_Consulta(pHisContratoconsultoriobeneficiosadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultoriobeneficiosadendaDet_Insert(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_Insert(pHisContratoconsultoriobeneficiosadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultoriobeneficiosadendaDet_Update(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_Update(pHisContratoconsultoriobeneficiosadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            { return new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo(pHisContratoconsultoriobeneficiosadendaDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

    #region DatosPagos
    public class DatosPagosConsultorios
    {
        public List<HisDatospagosconsultoriosE> Sp_HisDatospagosconsultorios_Consulta(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            { return new HisDatospagosconsultoriosAD().Sp_HisDatospagosconsultorios_Consulta(pHisDatospagosconsultoriosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            { return new HisDatospagosconsultoriosAD().Sp_HisDatospagosconsultorios_Insert(pHisDatospagosconsultoriosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisDatospagosconsultorios_Insert(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            { return new HisDatospagosconsultoriosAD().Sp_HisDatospagosconsultorios_Insert(pHisDatospagosconsultoriosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisDatospagosconsultorios_Update(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            { return new HisDatospagosconsultoriosAD().Sp_HisDatospagosconsultorios_Update(pHisDatospagosconsultoriosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisDatospagosconsultorios_UpdatexCampo(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            { return new HisDatospagosconsultoriosAD().Sp_HisDatospagosconsultorios_UpdatexCampo(pHisDatospagosconsultoriosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
    #endregion

}