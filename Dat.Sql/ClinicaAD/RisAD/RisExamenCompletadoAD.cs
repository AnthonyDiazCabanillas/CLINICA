using Ent.Sql.ClinicaE.RisE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RisAD
{
    public class RisExamenCompletadoAD
    {
        private RisExamenCompletadoE LlenarEntidad(IDataReader dr,
                                       RisExamenCompletadoE pRisExamenCompletadoE)
        {
            RisExamenCompletadoE oRisExamenCompletadoE = new RisExamenCompletadoE();
            switch (pRisExamenCompletadoE.Orden)
            {
                case 1:
                    oRisExamenCompletadoE.CodrisCompletado = Convert.ToInt32(dr["codris_completado"]);
                    oRisExamenCompletadoE.Fecha = Convert.ToString(dr["fecha"]);
                    oRisExamenCompletadoE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oRisExamenCompletadoE.Nombre = Convert.ToString(dr["nombre"]);
                    oRisExamenCompletadoE.SpsId = Convert.ToString(dr["sps_id"]);
                    oRisExamenCompletadoE.SequenceId = Convert.ToString(dr["sequence_id"]);
                    oRisExamenCompletadoE.PacsSpsId = Convert.ToString(dr["pacs_sps_id"]);
                    oRisExamenCompletadoE.Codsala = Convert.ToString(dr["codsala"]);
                    oRisExamenCompletadoE.Status = Convert.ToString(dr["status"]);
                    oRisExamenCompletadoE.Codpresotor = Convert.ToString(dr["codpresotor"]);
                    oRisExamenCompletadoE.Estado = Convert.ToString(dr["estado"]);
                    oRisExamenCompletadoE.CodrisExamenrealizado = Convert.ToInt32(dr["codris_examenrealizado"]);
                    break;
            }

            return oRisExamenCompletadoE;
        }

        public List<RisExamenCompletadoE> Sp_RisExamenCompletado_Consulta(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            List<RisExamenCompletadoE> oListar = new List<RisExamenCompletadoE>();
            RisExamenCompletadoE oRisExamenCompletadoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RisExamenCompletado_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@codris_examenrealizado", pRisExamenCompletadoE.CodrisExamenrealizado);
                    cmd.Parameters.AddWithValue("@orden", pRisExamenCompletadoE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisExamenCompletadoE = LlenarEntidad(dr, pRisExamenCompletadoE);
                        oListar.Add(oRisExamenCompletadoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_RisExamenCompletado_Insert(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisExamenCompletado_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_completado", pRisExamenCompletadoE.CodrisCompletado);
                        cmd.Parameters.AddWithValue("@fecha", pRisExamenCompletadoE.Fecha);
                        cmd.Parameters.AddWithValue("@codprestacion", pRisExamenCompletadoE.Codprestacion);
                        cmd.Parameters.AddWithValue("@nombre", pRisExamenCompletadoE.Nombre);
                        cmd.Parameters.AddWithValue("@sps_id", pRisExamenCompletadoE.SpsId);
                        cmd.Parameters.AddWithValue("@sequence_id", pRisExamenCompletadoE.SequenceId);
                        cmd.Parameters.AddWithValue("@pacs_sps_id", pRisExamenCompletadoE.PacsSpsId);
                        cmd.Parameters.AddWithValue("@codsala", pRisExamenCompletadoE.Codsala);
                        cmd.Parameters.AddWithValue("@status", pRisExamenCompletadoE.Status);
                        cmd.Parameters.AddWithValue("@codpresotor", pRisExamenCompletadoE.Codpresotor);
                        cmd.Parameters.AddWithValue("@estado", pRisExamenCompletadoE.Estado);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codris_examenrealizado", ParameterDirection.InputOutput, SqlDbType.Int, 8, pRisExamenCompletadoE.CodrisExamenrealizado.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pRisExamenCompletadoE.CodrisExamenrealizado = Convert.ToInt32(cmd.Parameters["@codris_examenrealizado"].Value);
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


        public bool Sp_RisExamenCompletado_Update(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisExamenCompletado_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_completado", pRisExamenCompletadoE.CodrisCompletado);
                        cmd.Parameters.AddWithValue("@fecha", pRisExamenCompletadoE.Fecha);
                        cmd.Parameters.AddWithValue("@codprestacion", pRisExamenCompletadoE.Codprestacion);
                        cmd.Parameters.AddWithValue("@nombre", pRisExamenCompletadoE.Nombre);
                        cmd.Parameters.AddWithValue("@sps_id", pRisExamenCompletadoE.SpsId);
                        cmd.Parameters.AddWithValue("@sequence_id", pRisExamenCompletadoE.SequenceId);
                        cmd.Parameters.AddWithValue("@pacs_sps_id", pRisExamenCompletadoE.PacsSpsId);
                        cmd.Parameters.AddWithValue("@codsala", pRisExamenCompletadoE.Codsala);
                        cmd.Parameters.AddWithValue("@status", pRisExamenCompletadoE.Status);
                        cmd.Parameters.AddWithValue("@codpresotor", pRisExamenCompletadoE.Codpresotor);
                        cmd.Parameters.AddWithValue("@estado", pRisExamenCompletadoE.Estado);
                        cmd.Parameters.AddWithValue("@codris_examenrealizado", pRisExamenCompletadoE.CodrisExamenrealizado);
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


        public bool Sp_RisExamenCompletado_UpdatexCampo(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisExamenCompletado_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_examenrealizado", pRisExamenCompletadoE.CodrisExamenrealizado);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisExamenCompletadoE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisExamenCompletadoE.Campo);
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