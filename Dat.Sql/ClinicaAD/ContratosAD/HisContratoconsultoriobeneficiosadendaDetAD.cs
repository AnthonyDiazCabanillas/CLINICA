/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
1.1         23/10/2024  PBARDALES   REQ 2024-020175 : Alquiler de consultorios se agrega dos campos
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
using Dat.Sql;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultoriobeneficiosadendaDetAD
    {
        private HisContratoconsultoriobeneficiosadendaDetE LlenarEntidad(IDataReader dr,
                                       HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            HisContratoconsultoriobeneficiosadendaDetE oHisContratoconsultoriobeneficiosadendaDetE = new HisContratoconsultoriobeneficiosadendaDetE();
            switch (pHisContratoconsultoriobeneficiosadendaDetE.Orden)
            {
                case 1:
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficio = Convert.ToInt32(dr["ide_beneficio"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.FecInicio = Convert.ToString(dr["fec_inicio"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.FecFin = Convert.ToString(dr["fec_fin"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.DscObservacion = Convert.ToString(dr["dsc_observacion"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda = Convert.ToString(dr["est_beneficiosadenda"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(dr["ide_beneficiosadenda"]);
                    break;
                case 2:
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficio = Convert.ToInt32(dr["ide_beneficio"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.FecInicio = Convert.ToString(dr["fec_inicio"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.FecFin = Convert.ToString(dr["fec_fin"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.DscObservacion = Convert.ToString(dr["dsc_observacion"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda = Convert.ToString(dr["est_beneficiosadenda"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(dr["ide_beneficiosadenda"]);
                    break;
                case 3:
                    oHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(dr["ide_beneficio"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.CntDescuento = Convert.ToInt32(dr["cnt_descuento"]);
                    oHisContratoconsultoriobeneficiosadendaDetE.DscObservacion = Convert.ToString(dr["dsc_observacion"]);
                    // 1.1  INI
                    oHisContratoconsultoriobeneficiosadendaDetE.FecInicio = Convert.ToString(dr["fec_inicio"]); 
                    oHisContratoconsultoriobeneficiosadendaDetE.FecFin = Convert.ToString(dr["fec_fin"]); 
                    //1.1 FIN
                    break;
            }
            return oHisContratoconsultoriobeneficiosadendaDetE;
        }

        public List<HisContratoconsultoriobeneficiosadendaDetE> Sp_HisContratoconsultoriobeneficiosadendaDet_Consulta(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            List<HisContratoconsultoriobeneficiosadendaDetE> oListar = new List<HisContratoconsultoriobeneficiosadendaDetE>();
            HisContratoconsultoriobeneficiosadendaDetE oHisContratoconsultoriobeneficiosadendaDetE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda);
                    cmd.Parameters.AddWithValue("@ide_buscar", pHisContratoconsultoriobeneficiosadendaDetE.IDBuscar);
                    cmd.Parameters.AddWithValue("@buscar", pHisContratoconsultoriobeneficiosadendaDetE.Buscar);
                    cmd.Parameters.AddWithValue("@numerolineas", pHisContratoconsultoriobeneficiosadendaDetE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultoriobeneficiosadendaDetE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultoriobeneficiosadendaDetE = LlenarEntidad(dr, pHisContratoconsultoriobeneficiosadendaDetE);
                        oListar.Add(oHisContratoconsultoriobeneficiosadendaDetE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_HisContratoconsultoriobeneficiosadendaDet_Insert(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficio);
                        cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosadendaDetE.FecInicio);
                        cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosadendaDetE.FecFin);
                        cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosadendaDetE.DscObservacion);
                        cmd.Parameters.AddWithValue("@est_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_beneficiosadenda", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(cmd.Parameters["@ide_beneficiosadenda"].Value);
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

        public int Sp_HisContratoconsultoriobeneficiosadendaDet_Insert_RB(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE, SqlConnection cnn, SqlCommand cmd, SqlTransaction transaction)
        {
            cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_Insert", cnn, transaction);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab);
            cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficio);
            cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosadendaDetE.FecInicio);
            cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosadendaDetE.FecFin);
            cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosadendaDetE.DscObservacion);
            cmd.Parameters.AddWithValue("@est_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda);
            cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_beneficiosadenda", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda.ToString()));

            cmd.ExecuteNonQuery();
            return pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(cmd.Parameters["@ide_beneficiosadenda"].Value);
        }

        public bool Sp_HisContratoconsultoriobeneficiosadendaDet_Update(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficio);
                        cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosadendaDetE.FecInicio);
                        cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosadendaDetE.FecFin);
                        cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosadendaDetE.DscObservacion);
                        cmd.Parameters.AddWithValue("@est_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda);
                        cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda);
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

        public bool Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultoriobeneficiosadendaDetE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisContratoconsultoriobeneficiosadendaDetE.Campo);
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

        public void Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo_RB(HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE, SqlConnection cnn, SqlCommand cmd, SqlTransaction transaction)
        {
            cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo", cnn, transaction);
            //Parametros del Store
            cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab);
            cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda);
            cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultoriobeneficiosadendaDetE.NuevoValor);
            cmd.Parameters.AddWithValue("@campo", pHisContratoconsultoriobeneficiosadendaDetE.Campo);
            cmd.Parameters.AddWithValue("@orden", pHisContratoconsultoriobeneficiosadendaDetE.Orden);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
    }
}