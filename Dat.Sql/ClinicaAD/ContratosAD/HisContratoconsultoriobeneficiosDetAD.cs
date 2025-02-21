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

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Dat.Sql;
using Ent.Sql.ClinicaE.ContratosE;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultoriobeneficiosDetAD
    {
        private HisContratoconsultoriobeneficiosDetE LlenarEntidad(IDataReader dr,
                                       HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            HisContratoconsultoriobeneficiosDetE oHisContratoconsultoriobeneficiosDetE = new HisContratoconsultoriobeneficiosDetE();
            switch (pHisContratoconsultoriobeneficiosDetE.Orden)
            {
                case 1:
                case 2:
                    oHisContratoconsultoriobeneficiosDetE.IDContratoConsultorioCab = Convert.ToInt32(dr["ide_contratoconsultorio_cab"]);
                    oHisContratoconsultoriobeneficiosDetE.IDBeneficio = Convert.ToInt32(dr["ide_beneficio"]);
                    oHisContratoconsultoriobeneficiosDetE.FechaInicio = Convert.ToString(dr["fec_inicio"]);
                    oHisContratoconsultoriobeneficiosDetE.FechaFin = Convert.ToString(dr["fec_fin"]);
                    oHisContratoconsultoriobeneficiosDetE.DscObservacion = Convert.ToString(dr["dsc_observacion"]);
                    oHisContratoconsultoriobeneficiosDetE.EstContratoBeneficios = Convert.ToString(dr["est_contratobeneficios"]);
                    oHisContratoconsultoriobeneficiosDetE.IDContratoConsultorioCab = Convert.ToInt32(dr["ide_contratobeneficios"]);
                    break;
            }

            return oHisContratoconsultoriobeneficiosDetE;
        }

        public List<HisContratoconsultoriobeneficiosDetE> Sp_HisContratoconsultoriobeneficiosDet_Consulta(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            List<HisContratoconsultoriobeneficiosDetE> oListar = new List<HisContratoconsultoriobeneficiosDetE>();
            HisContratoconsultoriobeneficiosDetE oHisContratoconsultoriobeneficiosDetE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosDet_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@idbuscar", pHisContratoconsultoriobeneficiosDetE.IDBuscar);
                    cmd.Parameters.AddWithValue("@buscar", pHisContratoconsultoriobeneficiosDetE.Buscar);
                    cmd.Parameters.AddWithValue("@numerolineas", pHisContratoconsultoriobeneficiosDetE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultoriobeneficiosDetE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultoriobeneficiosDetE = LlenarEntidad(dr, pHisContratoconsultoriobeneficiosDetE);
                        oListar.Add(oHisContratoconsultoriobeneficiosDetE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_HisContratoconsultoriobeneficiosDet_Insert(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosDet_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", pHisContratoconsultoriobeneficiosDetE.IDContratoConsultorioCab);
                        cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosDetE.IDBeneficio);
                        cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosDetE.FechaInicio);
                        cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosDetE.FechaFin);
                        cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosDetE.DscObservacion);
                        cmd.Parameters.AddWithValue("@est_contratobeneficios", pHisContratoconsultoriobeneficiosDetE.EstContratoBeneficios);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_contratobeneficios", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        cmd.ExecuteNonQuery();
                        int exito = Convert.ToInt32(cmd.Parameters["@ide_contratobeneficios"].Value);
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios = exito;
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


        public bool Sp_HisContratoconsultoriobeneficiosDet_Update(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosDet_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", pHisContratoconsultoriobeneficiosDetE.IDContratoConsultorioCab);
                        cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosDetE.IDBeneficio);
                        cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosDetE.FechaInicio);
                        cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosDetE.FechaInicio);
                        cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosDetE.DscObservacion);
                        cmd.Parameters.AddWithValue("@est_contratobeneficios", pHisContratoconsultoriobeneficiosDetE.EstContratoBeneficios);
                        cmd.Parameters.AddWithValue("@ide_contratobeneficios", pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios);
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

        public bool Sp_HisContratoconsultoriobeneficiosDet_UpdatexCampo(HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosDet_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_contratobeneficios", pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultoriobeneficiosDetE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisContratoconsultoriobeneficiosDetE.Campo);
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