/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ent.Sql;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Ent.Sql.ClinicaE.ContratosE;
using Dat.Sql;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultorioCabAD
    {
        private HisContratoconsultorioCabE LlenarEntidad(IDataReader dr,
                                       HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            HisContratoconsultorioCabE oHisContratoconsultorioCabE = new HisContratoconsultorioCabE();
            switch (pHisContratoconsultorioCabE.Orden)
            {
                case 1:
                    oHisContratoconsultorioCabE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    oHisContratoconsultorioCabE.TipPago = Convert.ToString(dr["tip_pago"]);
                    oHisContratoconsultorioCabE.TipComprobante = Convert.ToString(dr["tip_comprobante"]);
                    oHisContratoconsultorioCabE.FacturaEmpresa = Convert.ToString(dr["factura_empresa"]);
                    oHisContratoconsultorioCabE.NumFactura = Convert.ToString(dr["num_factura"]);
                    oHisContratoconsultorioCabE.TipMoneda = Convert.ToString(dr["tip_moneda"]);
                    oHisContratoconsultorioCabE.IdeSede = Convert.ToInt32(dr["ide_sede"]);
                    oHisContratoconsultorioCabE.IdeTorre = Convert.ToInt32(dr["ide_torre"]);
                    oHisContratoconsultorioCabE.Piso = Convert.ToInt32(dr["piso"]);
                    oHisContratoconsultorioCabE.FecInicioContrato = Convert.ToString(dr["fec_inicio_contrato"]);
                    oHisContratoconsultorioCabE.FecFinContrato = Convert.ToString(dr["fec_fin_contrato"]);
                    oHisContratoconsultorioCabE.DscObservaciones = Convert.ToString(dr["dsc_observaciones"]);
                    oHisContratoconsultorioCabE.CntRentaMensual = Convert.ToDecimal(dr["cnt_renta_mensual"]);
                    oHisContratoconsultorioCabE.CntTotalHoras = Convert.ToInt32(dr["cnt_total_horas"]);
                    oHisContratoconsultorioCabE.CntPrecioxhora = Convert.ToDecimal(dr["cnt_precioxhora"]);
                    oHisContratoconsultorioCabE.EstContratoConsultorio = Convert.ToString(dr["est_contrato_consultorio"]);
                    oHisContratoconsultorioCabE.IdeUsrRegistra = Convert.ToInt32(dr["ide_usr_registra"]);
                    oHisContratoconsultorioCabE.FecRegistro = Convert.ToString(dr["fec_registro"]);
                    oHisContratoconsultorioCabE.IdeUsrActualiza = Convert.ToInt32(dr["ide_usr_actualiza"]);
                    oHisContratoconsultorioCabE.FecActualiza = Convert.ToString(dr["fec_actualiza"]);
                    oHisContratoconsultorioCabE.BlbArchivoAdjunto = Convert.ToString(dr["blb_archivo_adjunto"]);
                    oHisContratoconsultorioCabE.DscContacto = Convert.ToString(dr["dsc_contacto"]);
                    oHisContratoconsultorioCabE.TelContacto = Convert.ToString(dr["tel_contacto"]);
                    oHisContratoconsultorioCabE.EmailContacto = Convert.ToString(dr["email_contacto"]);
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    break;
                case 2:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioCabE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    oHisContratoconsultorioCabE.NumDocIdeMedico = Convert.ToString(dr["numdocmedico"]);
                    oHisContratoconsultorioCabE.DscMedico = Convert.ToString(dr["medico"]);
                    oHisContratoconsultorioCabE.IdeSede = Convert.ToInt32(dr["ide_sede"]);
                    oHisContratoconsultorioCabE.DscSede = Convert.ToString(dr["sede"]);
                    oHisContratoconsultorioCabE.TipPago = Convert.ToString(dr["tip_pago"]);
                    oHisContratoconsultorioCabE.DscTipPago = Convert.ToString(dr["dsc_tippago"]);
                    oHisContratoconsultorioCabE.EstContratoConsultorio = Convert.ToString(dr["est_contrato_consultorio"]);
                    oHisContratoconsultorioCabE.DscEstContratoConsultorio = Convert.ToString(dr["dsc_estcontrato"]);
                    oHisContratoconsultorioCabE.RentaMensual = Convert.ToString(dr["rentamensual"]);
                    oHisContratoconsultorioCabE.DeudaTotal = Convert.ToDecimal(dr["deudatotal"]);
                    oHisContratoconsultorioCabE.CntComprobantePendientes = Convert.ToInt32(dr["cnt_comprobante_pend"]);
                    break;
                case 3:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioCabE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    oHisContratoconsultorioCabE.CntRentaMensual = Convert.ToDecimal(dr["cnt_renta_mensual"]);
                    oHisContratoconsultorioCabE.TipMoneda = Convert.ToString(dr["tip_moneda"]);
                    oHisContratoconsultorioCabE.DscMoneda = Convert.ToString(dr["dsc_moneda"]);
                    oHisContratoconsultorioCabE.IdeSede = Convert.ToInt32(dr["ide_sede"]);
                    oHisContratoconsultorioCabE.DscSede = Convert.ToString(dr["dsc_sede"]);
                    oHisContratoconsultorioCabE.IdeTorre = Convert.ToInt32(dr["ide_torre"]);
                    oHisContratoconsultorioCabE.DscTorre = Convert.ToString(dr["dsc_torre"]);
                    oHisContratoconsultorioCabE.TipPago = Convert.ToString(dr["tip_pago"]);
                    oHisContratoconsultorioCabE.DscTipPago = Convert.ToString(dr["dsc_pago"]);
                    oHisContratoconsultorioCabE.TipComprobante = Convert.ToString(dr["dsc_comprobantes"]);
                    oHisContratoconsultorioCabE.FecInicioContrato = Convert.ToString(dr["fec_inicio_contrato"]);
                    oHisContratoconsultorioCabE.FecFinContrato = Convert.ToString(dr["fec_fin_contrato"]);
                    oHisContratoconsultorioCabE.CntTotalHoras = Convert.ToInt32(dr["cnt_total_horas"]);
                    oHisContratoconsultorioCabE.EstContratoConsultorio = Convert.ToString(dr["est_contrato_consultorio"]);
                    oHisContratoconsultorioCabE.DscEstContratoConsultorio = Convert.ToString(dr["dsc_est_contrato_consultorio"]);
                    oHisContratoconsultorioCabE.DscObservaciones = Convert.ToString(dr["dsc_observaciones"]);
                    oHisContratoconsultorioCabE.DscContacto = Convert.ToString(dr["dsc_contacto"]);
                    oHisContratoconsultorioCabE.TelContacto = Convert.ToString(dr["tel_contacto"]);
                    oHisContratoconsultorioCabE.EmailContacto = Convert.ToString(dr["email_contacto"]);
                    oHisContratoconsultorioCabE.CntPrecioxhora = Convert.ToDecimal(dr["cnt_precioxhora"]);
                    oHisContratoconsultorioCabE.IdeContratoBeneficio= Convert.ToInt32(dr["ide_benficio"]);
                    oHisContratoconsultorioCabE.DscContratoBeneficio = Convert.ToString(dr["dsc_benficio"]);
                    break;
                case 4:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    break;
                case 5:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioCabE.IdeSede = Convert.ToInt32(dr["ide_sede"]);
                    oHisContratoconsultorioCabE.CntRentaMensual = Convert.ToDecimal(dr["cnt_renta_mensual"]);
                    oHisContratoconsultorioCabE.TipPago = Convert.ToString(dr["tip_pago"]);
                    break;
                case 6:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioCabE.BlbArchivoAdjunto = Convert.ToString(dr["blb_archivo_adjunto"]);
                    break;
                case 7:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioCabE.ComprobantesPendientes = Convert.ToInt32(dr["ComprobantesPendientes"]);
                    break;
                case 8:
                    oHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioCabE.IdeContratoBeneficio = Convert.ToInt32(dr["ide_contratobeneficios"]);
                    oHisContratoconsultorioCabE.CntDescuento = Convert.ToInt32(dr["cnt_descuento"]);
                    oHisContratoconsultorioCabE.CntPrecioxhora = Convert.ToInt32(dr["precioxhora"]);
                    break;
            }
            return oHisContratoconsultorioCabE;
        }

        public List<HisContratoconsultorioCabE> Sp_HisContratoconsultorioCab_Consulta(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            {
                List<HisContratoconsultorioCabE> oListar = new List<HisContratoconsultorioCabE>();
                HisContratoconsultorioCabE oHisContratoconsultorioCabE = null;
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioCab_Consulta", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@idebuscar", pHisContratoconsultorioCabE.IDBuscar);
                        cmd.Parameters.AddWithValue("@busca", pHisContratoconsultorioCabE.Buscar);
                        cmd.Parameters.AddWithValue("@fecinicio", pHisContratoconsultorioCabE.FecInicioContrato);
                        cmd.Parameters.AddWithValue("@fecfin", pHisContratoconsultorioCabE.FecFinContrato);
                        cmd.Parameters.AddWithValue("@numerolineas", pHisContratoconsultorioCabE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioCabE.Orden);
                        cnn.Open();
                        IDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oHisContratoconsultorioCabE = LlenarEntidad(dr, pHisContratoconsultorioCabE);
                            oListar.Add(oHisContratoconsultorioCabE);
                        }
                        dr.Close();
                        cnn.Close();
                    }
                }
                return oListar;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_HisContratoconsultorioCab_Insert(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioCab_Insert", cnn))
                    {

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pHisContratoconsultorioCabE.CodMedico);
                        cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioCabE.TipPago);
                        cmd.Parameters.AddWithValue("@tip_comprobante", pHisContratoconsultorioCabE.TipComprobante);
                        cmd.Parameters.AddWithValue("@factura_empresa", pHisContratoconsultorioCabE.FacturaEmpresa);
                        cmd.Parameters.AddWithValue("@num_factura", pHisContratoconsultorioCabE.NumFactura);
                        cmd.Parameters.AddWithValue("@tip_moneda", pHisContratoconsultorioCabE.TipMoneda);
                        cmd.Parameters.AddWithValue("@ide_sede", pHisContratoconsultorioCabE.IdeSede);
                        cmd.Parameters.AddWithValue("@ide_torre", pHisContratoconsultorioCabE.IdeTorre);
                        cmd.Parameters.AddWithValue("@piso", pHisContratoconsultorioCabE.Piso);
                        cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioCabE.FecInicioContrato);
                        cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioCabE.FecFinContrato);
                        cmd.Parameters.AddWithValue("@dsc_observaciones", pHisContratoconsultorioCabE.DscObservaciones);
                        cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioCabE.CntRentaMensual);
                        cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioCabE.CntTotalHoras);
                        cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioCabE.CntPrecioxhora);
                        cmd.Parameters.AddWithValue("@est_contrato_consultorio", pHisContratoconsultorioCabE.EstContratoConsultorio);
                        cmd.Parameters.AddWithValue("@ide_usr_registra", pHisContratoconsultorioCabE.IdeUsrRegistra);
                        cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioCabE.FecRegistro);
                        cmd.Parameters.AddWithValue("@ide_usr_actualiza", pHisContratoconsultorioCabE.IdeUsrActualiza);
                        cmd.Parameters.AddWithValue("@fec_actualiza", pHisContratoconsultorioCabE.FecActualiza);
                        cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioCabE.BlbArchivoAdjunto);
                        cmd.Parameters.AddWithValue("@dsc_contacto", pHisContratoconsultorioCabE.DscContacto);
                        cmd.Parameters.AddWithValue("@tel_contacto", pHisContratoconsultorioCabE.TelContacto);
                        cmd.Parameters.AddWithValue("@email_contacto", pHisContratoconsultorioCabE.EmailContacto);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_his_contratoconsultorio_cab", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        cmd.ExecuteNonQuery();
                        int exito = Convert.ToInt32(cmd.Parameters["@ide_his_contratoconsultorio_cab"].Value);
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = exito;
                            return true;
                        }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_HisContratoconsultorioCab_Update(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioCab_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pHisContratoconsultorioCabE.CodMedico);
                        cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioCabE.TipPago);
                        cmd.Parameters.AddWithValue("@tip_comprobante", pHisContratoconsultorioCabE.TipComprobante);
                        cmd.Parameters.AddWithValue("@factura_empresa", pHisContratoconsultorioCabE.FacturaEmpresa);
                        cmd.Parameters.AddWithValue("@num_factura", pHisContratoconsultorioCabE.NumFactura);
                        cmd.Parameters.AddWithValue("@tip_moneda", pHisContratoconsultorioCabE.TipMoneda);
                        cmd.Parameters.AddWithValue("@ide_sede", pHisContratoconsultorioCabE.IdeSede);
                        cmd.Parameters.AddWithValue("@ide_torre", pHisContratoconsultorioCabE.IdeTorre);
                        cmd.Parameters.AddWithValue("@piso", pHisContratoconsultorioCabE.Piso);
                        cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioCabE.FecInicioContrato);
                        cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioCabE.FecFinContrato);
                        cmd.Parameters.AddWithValue("@dsc_observaciones", pHisContratoconsultorioCabE.DscObservaciones);
                        cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioCabE.CntRentaMensual);
                        cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioCabE.CntTotalHoras);
                        cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioCabE.CntPrecioxhora);
                        cmd.Parameters.AddWithValue("@est_contrato_consultorio", pHisContratoconsultorioCabE.EstContratoConsultorio);
                        cmd.Parameters.AddWithValue("@ide_usr_registra", pHisContratoconsultorioCabE.IdeUsrRegistra);
                        cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioCabE.FecRegistro);
                        cmd.Parameters.AddWithValue("@ide_usr_actualiza", pHisContratoconsultorioCabE.IdeUsrActualiza);
                        cmd.Parameters.AddWithValue("@fec_actualiza", pHisContratoconsultorioCabE.FecActualiza);
                        cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioCabE.BlbArchivoAdjunto);
                        cmd.Parameters.AddWithValue("@dsc_contacto", pHisContratoconsultorioCabE.DscContacto);
                        cmd.Parameters.AddWithValue("@tel_contacto", pHisContratoconsultorioCabE.TelContacto);
                        cmd.Parameters.AddWithValue("@email_contacto", pHisContratoconsultorioCabE.EmailContacto);
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();

                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_HisContratoconsultorioCab_UpdatexCampo(HisContratoconsultorioCabE pHisContratoconsultorioCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioCab_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioCabE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioCabE.Campo);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}