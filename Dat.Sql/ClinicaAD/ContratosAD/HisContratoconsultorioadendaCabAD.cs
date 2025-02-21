/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
1.1         23/10/2024   PBARDALES REQ 2024-020175   SE COMENTO LINEA
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Ent.Sql.ClinicaE.ContratosE;
using System.Transactions;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultorioadendaCabAD
    {
        //Cadena de Conexión para el Acceso a la BD
        private HisContratoconsultorioadendaCabE LlenarEntidad(IDataReader dr,
                                       HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            HisContratoconsultorioadendaCabE oHisContratoconsultorioadendaCabE = new HisContratoconsultorioadendaCabE();
            switch (pHisContratoconsultorioadendaCabE.Orden)
            {
                case 1:
                    oHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioadendaCabE.TipPago = Convert.ToString(dr["tip_pago"]);
                    oHisContratoconsultorioadendaCabE.FecInicioContrato = Convert.ToString(dr["fec_inicio_contrato"]);
                    oHisContratoconsultorioadendaCabE.FecFinContrato = Convert.ToString(dr["fec_fin_contrato"]);
                    oHisContratoconsultorioadendaCabE.DsObservaciones = Convert.ToString(dr["ds_observaciones"]);
                    oHisContratoconsultorioadendaCabE.CntRentaMensual = Convert.ToDecimal(dr["cnt_renta_mensual"]);
                    oHisContratoconsultorioadendaCabE.CntTotalHoras = Convert.ToInt32(dr["cnt_total_horas"]);
                    oHisContratoconsultorioadendaCabE.CntPrecioxhora = Convert.ToDecimal(dr["cnt_precioxhora"]);
                    oHisContratoconsultorioadendaCabE.EstContrato = Convert.ToString(dr["est_adenda"]);
                    oHisContratoconsultorioadendaCabE.EstAdenda = Convert.ToString(dr["est_adenda"]);
                    oHisContratoconsultorioadendaCabE.FecRegistro = Convert.ToString(dr["fec_registro"]);
                    oHisContratoconsultorioadendaCabE.UsrRegistra = Convert.ToInt32(dr["usr_registra"]);
                    oHisContratoconsultorioadendaCabE.FecActualizacion = Convert.ToString(dr["fec_actualizacion"]);
                    oHisContratoconsultorioadendaCabE.UsrActualizacion = Convert.ToInt32(dr["usr_actualizacion"]);
                    oHisContratoconsultorioadendaCabE.BlbArchivoAdjunto = Convert.ToString(dr["blb_archivo_adjunto"]);
                    break;
                case 2:
                case 4:
                    oHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioadendaCabE.TipPago = Convert.ToString(dr["tip_pago"]);
                    oHisContratoconsultorioadendaCabE.FecInicioContrato = Convert.ToString(dr["fec_inicio_contrato"]);
                    oHisContratoconsultorioadendaCabE.FecFinContrato = Convert.ToString(dr["fec_fin_contrato"]);
                    oHisContratoconsultorioadendaCabE.DsObservaciones = Convert.ToString(dr["ds_observaciones"]);
                    oHisContratoconsultorioadendaCabE.CntRentaMensual = Convert.ToDecimal(dr["cnt_renta_mensual"]);
                    oHisContratoconsultorioadendaCabE.CntTotalHoras = Convert.ToInt32(dr["cnt_total_horas"]);
                    oHisContratoconsultorioadendaCabE.CntPrecioxhora = Convert.ToDecimal(dr["cnt_precioxhora"]);
                    oHisContratoconsultorioadendaCabE.EstContrato = Convert.ToString(dr["est_contrato"]);
                    oHisContratoconsultorioadendaCabE.EstAdenda = Convert.ToString(dr["est_adenda"]);
                    oHisContratoconsultorioadendaCabE.FecRegistro = Convert.ToString(dr["fec_registro"]);
                    oHisContratoconsultorioadendaCabE.UsrRegistra = Convert.ToInt32(dr["usr_registra"]);
                    oHisContratoconsultorioadendaCabE.DscUsrRegistra = Convert.ToString(dr["dsc_usr_registra"]);
                    oHisContratoconsultorioadendaCabE.FecActualizacion = Convert.ToString(dr["fec_actualizacion"]);
                    oHisContratoconsultorioadendaCabE.UsrActualizacion = Convert.ToInt32(dr["usr_actualizacion"]);
                    oHisContratoconsultorioadendaCabE.EstContrato = Convert.ToString(dr["est_contrato"]);
                   // oHisContratoconsultorioadendaCabE.tip_comprobante = Convert.ToString(dr["tip_comprobante"]);  //1.2
                    break;
                case 3:
                    oHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioadendaCabE.IDCalendario = Convert.ToInt32(dr["ide_calendario"]);
                    break;
                case 5:
                    oHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisContratoconsultorioadendaCabE.BlbArchivoAdjunto = Convert.ToString(dr["blb_archivo_adjunto"]);
                    break;
                case 6:
                    oHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaCabE.IdeBeneficioAdenda = Convert.ToInt32(dr["ide_beneficiosadenda"]);
                    oHisContratoconsultorioadendaCabE.CntDescuento = Convert.ToInt32(dr["cnt_descuento"]);
                    oHisContratoconsultorioadendaCabE.CntPrecioxhora = Convert.ToInt32(dr["precioxhora"]);
                    break;
            }

            return oHisContratoconsultorioadendaCabE;
        }

        public List<HisContratoconsultorioadendaCabE> Sp_HisContratoconsultorioadendaCab_Consulta(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            List<HisContratoconsultorioadendaCabE> oListar = new List<HisContratoconsultorioadendaCabE>();
            HisContratoconsultorioadendaCabE oHisContratoconsultorioadendaCabE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@idbuscar", pHisContratoconsultorioadendaCabE.IDBuscar);
                    cmd.Parameters.AddWithValue("@buscar", pHisContratoconsultorioadendaCabE.Buscar);
                    cmd.Parameters.AddWithValue("@numerolineas", pHisContratoconsultorioadendaCabE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioadendaCabE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultorioadendaCabE = LlenarEntidad(dr, pHisContratoconsultorioadendaCabE);
                        oListar.Add(oHisContratoconsultorioadendaCabE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_HisContratoconsultorioadendaCab_Insert(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaCabE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
                        cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioadendaCabE.TipPago);
                        cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioadendaCabE.FecInicioContrato);
                        cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioadendaCabE.FecFinContrato);
                        cmd.Parameters.AddWithValue("@ds_observaciones", pHisContratoconsultorioadendaCabE.DsObservaciones);
                        cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioadendaCabE.CntRentaMensual);
                        cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioadendaCabE.CntTotalHoras);
                        cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioadendaCabE.CntPrecioxhora);
                        cmd.Parameters.AddWithValue("@est_contrato", pHisContratoconsultorioadendaCabE.EstContrato);
                        cmd.Parameters.AddWithValue("@est_adenda", pHisContratoconsultorioadendaCabE.EstAdenda);
                        cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioadendaCabE.FecRegistro);
                        cmd.Parameters.AddWithValue("@usr_registra", pHisContratoconsultorioadendaCabE.UsrRegistra);
                        cmd.Parameters.AddWithValue("@fec_actualizacion", pHisContratoconsultorioadendaCabE.FecActualizacion);
                        cmd.Parameters.AddWithValue("@usr_actualizacion", pHisContratoconsultorioadendaCabE.UsrActualizacion);
                        cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioadendaCabE.BlbArchivoAdjunto);
                       // cmd.Parameters.AddWithValue("@tip_comprobante", pHisContratoconsultorioadendaCabE.EstTipoComprob);  //1.1 INI

                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public int Sp_HisContratoconsultorioadendaCab_Insert_RB(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE, SqlConnection cnn, SqlCommand cmd, SqlTransaction transaction)
        {
            cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_Insert", cnn, transaction);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //Parametros del Store
            cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
            cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioadendaCabE.TipPago);
            cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioadendaCabE.FecInicioContrato);
            cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioadendaCabE.FecFinContrato);
            cmd.Parameters.AddWithValue("@ds_observaciones", pHisContratoconsultorioadendaCabE.DsObservaciones);
            cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioadendaCabE.CntRentaMensual);
            cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioadendaCabE.CntTotalHoras);
            cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioadendaCabE.CntPrecioxhora);
            cmd.Parameters.AddWithValue("@est_contrato", pHisContratoconsultorioadendaCabE.EstContrato);
            cmd.Parameters.AddWithValue("@est_adenda", pHisContratoconsultorioadendaCabE.EstAdenda);
            cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioadendaCabE.FecRegistro);
            cmd.Parameters.AddWithValue("@usr_registra", pHisContratoconsultorioadendaCabE.UsrRegistra);
            cmd.Parameters.AddWithValue("@fec_actualizacion", pHisContratoconsultorioadendaCabE.FecActualizacion);
            cmd.Parameters.AddWithValue("@usr_actualizacion", pHisContratoconsultorioadendaCabE.UsrActualizacion);
            cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioadendaCabE.BlbArchivoAdjunto);
           // cmd.Parameters.AddWithValue("@tip_comprobante", pHisContratoconsultorioadendaCabE.EstTipoComprob);  //1.1 INI

            cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_adenda_cab", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultorioadendaCabE.IdeAdendaCab.ToString()));
            //Ejecutamos el Query
            cmd.ExecuteNonQuery();
            pHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(cmd.Parameters["@ide_adenda_cab"].Value);
            return pHisContratoconsultorioadendaCabE.IdeAdendaCab;
        }
        public bool Sp_HisContratoconsultorioadendaCab_Update(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaCabE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
                        cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioadendaCabE.TipPago);
                        cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioadendaCabE.FecInicioContrato);
                        cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioadendaCabE.FecFinContrato);
                        cmd.Parameters.AddWithValue("@ds_observaciones", pHisContratoconsultorioadendaCabE.DsObservaciones);
                        cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioadendaCabE.CntRentaMensual);
                        cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioadendaCabE.CntTotalHoras);
                        cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioadendaCabE.CntPrecioxhora);
                        cmd.Parameters.AddWithValue("@est_adenda", pHisContratoconsultorioadendaCabE.EstAdenda);
                        cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioadendaCabE.FecRegistro);
                        cmd.Parameters.AddWithValue("@usr_registra", pHisContratoconsultorioadendaCabE.UsrRegistra);
                        cmd.Parameters.AddWithValue("@fec_actualizacion", pHisContratoconsultorioadendaCabE.FecActualizacion);
                        cmd.Parameters.AddWithValue("@usr_actualizacion", pHisContratoconsultorioadendaCabE.UsrActualizacion);
                        cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioadendaCabE.BlbArchivoAdjunto);
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

        public bool Sp_HisContratoconsultorioadendaCab_UpdatexCampo(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaCabE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioadendaCabE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioadendaCabE.Campo);
                        cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioadendaCabE.Orden);
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

        public void Sp_HisContratoconsultorioadendaCab_UpdatexCampo_RB(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE, SqlConnection cnn, SqlCommand cmd, SqlTransaction transaction)
        {
            cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_UpdatexCampo", cnn, transaction);
            //Parametros del Store
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaCabE.IdeAdendaCab);
            cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
            cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioadendaCabE.NuevoValor);
            cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioadendaCabE.Campo);
            cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioadendaCabE.Orden);
            cmd.ExecuteNonQuery();
        }
    }
}