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
    public class RisAgendamientoAmbulatorioAD
    {
        private RisAgendamientoAmbulatorioE LlenarEntidad(IDataReader dr, RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            RisAgendamientoAmbulatorioE oRisAgendamientoAmbulatorioE = new RisAgendamientoAmbulatorioE();
            switch (pRisAgendamientoAmbulatorioE.Orden)
            {
                case 1:
                    oRisAgendamientoAmbulatorioE.CodrisAmbulatorio = Convert.ToInt32(dr["codris_ambulatorio"]);
                    oRisAgendamientoAmbulatorioE.Codpaciente = Convert.ToString(dr["codpaciente"]);
                    oRisAgendamientoAmbulatorioE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oRisAgendamientoAmbulatorioE.Nombre = Convert.ToString(dr["nombre"]);
                    oRisAgendamientoAmbulatorioE.SpsId = Convert.ToString(dr["sps_id"]);
                    oRisAgendamientoAmbulatorioE.SequenceId = Convert.ToString(dr["sequence_id"]);
                    oRisAgendamientoAmbulatorioE.PacsSpsId = Convert.ToString(dr["pacs_sps_id"]);
                    oRisAgendamientoAmbulatorioE.StartDatetime = Convert.ToString(dr["start_datetime"]);
                    oRisAgendamientoAmbulatorioE.Codsala = Convert.ToString(dr["codsala"]);
                    oRisAgendamientoAmbulatorioE.Status = Convert.ToString(dr["status"]);
                    oRisAgendamientoAmbulatorioE.Codpresotor = Convert.ToString(dr["codpresotor"]);
                    oRisAgendamientoAmbulatorioE.Estado = Convert.ToString(dr["estado"]);
                    oRisAgendamientoAmbulatorioE.IdeRecetadet = Convert.ToString(dr["ide_recetadet"]);
                    oRisAgendamientoAmbulatorioE.StatusKey = Convert.ToString(dr["status_key"]);
                    oRisAgendamientoAmbulatorioE.FlgPagado = Convert.ToString(dr["flg_pagado"]);
                    oRisAgendamientoAmbulatorioE.CodrisAgendamiento = Convert.ToInt32(dr["codris_agendamiento"]);
                    break;
                case 2:
                    oRisAgendamientoAmbulatorioE.CodrisAmbulatorio = Convert.ToInt32(dr["codris_ambulatorio"]);
                    oRisAgendamientoAmbulatorioE.Codpaciente = Convert.ToString(dr["codpaciente"]);
                    oRisAgendamientoAmbulatorioE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oRisAgendamientoAmbulatorioE.Nombre = Convert.ToString(dr["nombre"]);
                    oRisAgendamientoAmbulatorioE.SpsId = Convert.ToString(dr["sps_id"]);
                    oRisAgendamientoAmbulatorioE.SequenceId = Convert.ToString(dr["sequence_id"]);
                    oRisAgendamientoAmbulatorioE.PacsSpsId = Convert.ToString(dr["pacs_sps_id"]);
                    oRisAgendamientoAmbulatorioE.StartDatetime = Convert.ToString(dr["start_datetime"]);
                    oRisAgendamientoAmbulatorioE.Codsala = Convert.ToString(dr["codsala"]);
                    oRisAgendamientoAmbulatorioE.Status = Convert.ToString(dr["status"]);
                    oRisAgendamientoAmbulatorioE.Codpresotor = Convert.ToString(dr["codpresotor"]);
                    oRisAgendamientoAmbulatorioE.Estado = Convert.ToString(dr["estado"]);
                    oRisAgendamientoAmbulatorioE.IdeRecetadet = Convert.ToString(dr["ide_recetadet"]);
                    oRisAgendamientoAmbulatorioE.StatusKey = Convert.ToString(dr["status_key"]);
                    oRisAgendamientoAmbulatorioE.FlgPagado = Convert.ToString(dr["flg_pagado"]);
                    oRisAgendamientoAmbulatorioE.CodrisAgendamiento = Convert.ToInt32(dr["codris_agendamiento"]);
                    break;
            }

            return oRisAgendamientoAmbulatorioE;
        }

        public List<RisAgendamientoAmbulatorioE> Sp_RisAgendamientoAmbulatorio_Consulta(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            List<RisAgendamientoAmbulatorioE> oListar = new List<RisAgendamientoAmbulatorioE>();
            RisAgendamientoAmbulatorioE oRisAgendamientoAmbulatorioE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RisAgendamientoAmbulatorio_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@sps_id", pRisAgendamientoAmbulatorioE.SpsId);
                    cmd.Parameters.AddWithValue("@buscar", pRisAgendamientoAmbulatorioE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pRisAgendamientoAmbulatorioE.Campo);
                    cmd.Parameters.AddWithValue("@numerofilas", pRisAgendamientoAmbulatorioE.NumeroFilas);
                    cmd.Parameters.AddWithValue("@orden", pRisAgendamientoAmbulatorioE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisAgendamientoAmbulatorioE = LlenarEntidad(dr, pRisAgendamientoAmbulatorioE);
                        oListar.Add(oRisAgendamientoAmbulatorioE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_RisAgendamientoAmbulatorio_Insert(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisAgendamientoAmbulatorio_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_ambulatorio", pRisAgendamientoAmbulatorioE.CodrisAmbulatorio);
                        cmd.Parameters.AddWithValue("@codpaciente", pRisAgendamientoAmbulatorioE.Codpaciente);
                        cmd.Parameters.AddWithValue("@codprestacion", pRisAgendamientoAmbulatorioE.Codprestacion);
                        cmd.Parameters.AddWithValue("@nombre", pRisAgendamientoAmbulatorioE.Nombre);
                        cmd.Parameters.AddWithValue("@sps_id", pRisAgendamientoAmbulatorioE.SpsId);
                        cmd.Parameters.AddWithValue("@sequence_id", pRisAgendamientoAmbulatorioE.SequenceId);
                        cmd.Parameters.AddWithValue("@pacs_sps_id", pRisAgendamientoAmbulatorioE.PacsSpsId);
                        cmd.Parameters.AddWithValue("@start_datetime", pRisAgendamientoAmbulatorioE.StartDatetime);
                        cmd.Parameters.AddWithValue("@codsala", pRisAgendamientoAmbulatorioE.Codsala);
                        cmd.Parameters.AddWithValue("@status", pRisAgendamientoAmbulatorioE.Status);
                        cmd.Parameters.AddWithValue("@codpresotor", pRisAgendamientoAmbulatorioE.Codpresotor);
                        cmd.Parameters.AddWithValue("@estado", pRisAgendamientoAmbulatorioE.Estado);
                        cmd.Parameters.AddWithValue("@ide_recetadet", pRisAgendamientoAmbulatorioE.IdeRecetadet);
                        cmd.Parameters.AddWithValue("@status_key", pRisAgendamientoAmbulatorioE.StatusKey);
                        cmd.Parameters.AddWithValue("@flg_pagado", pRisAgendamientoAmbulatorioE.FlgPagado);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codris_agendamiento", ParameterDirection.InputOutput, SqlDbType.Int, 8, pRisAgendamientoAmbulatorioE.CodrisAgendamiento.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pRisAgendamientoAmbulatorioE.CodrisAgendamiento = Convert.ToInt32(cmd.Parameters["@codris_agendamiento"].Value);
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


        public bool Sp_RisAgendamientoAmbulatorio_Update(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisAgendamientoAmbulatorio_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_ambulatorio", pRisAgendamientoAmbulatorioE.CodrisAmbulatorio);
                        cmd.Parameters.AddWithValue("@codpaciente", pRisAgendamientoAmbulatorioE.Codpaciente);
                        cmd.Parameters.AddWithValue("@codprestacion", pRisAgendamientoAmbulatorioE.Codprestacion);
                        cmd.Parameters.AddWithValue("@nombre", pRisAgendamientoAmbulatorioE.Nombre);
                        cmd.Parameters.AddWithValue("@sps_id", pRisAgendamientoAmbulatorioE.SpsId);
                        cmd.Parameters.AddWithValue("@sequence_id", pRisAgendamientoAmbulatorioE.SequenceId);
                        cmd.Parameters.AddWithValue("@pacs_sps_id", pRisAgendamientoAmbulatorioE.PacsSpsId);
                        cmd.Parameters.AddWithValue("@start_datetime", pRisAgendamientoAmbulatorioE.StartDatetime);
                        cmd.Parameters.AddWithValue("@codsala", pRisAgendamientoAmbulatorioE.Codsala);
                        cmd.Parameters.AddWithValue("@status", pRisAgendamientoAmbulatorioE.Status);
                        cmd.Parameters.AddWithValue("@codpresotor", pRisAgendamientoAmbulatorioE.Codpresotor);
                        cmd.Parameters.AddWithValue("@estado", pRisAgendamientoAmbulatorioE.Estado);
                        cmd.Parameters.AddWithValue("@ide_recetadet", pRisAgendamientoAmbulatorioE.IdeRecetadet);
                        cmd.Parameters.AddWithValue("@status_key", pRisAgendamientoAmbulatorioE.StatusKey);
                        cmd.Parameters.AddWithValue("@flg_pagado", pRisAgendamientoAmbulatorioE.FlgPagado);
                        cmd.Parameters.AddWithValue("@codris_agendamiento", pRisAgendamientoAmbulatorioE.CodrisAgendamiento);
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


        public bool Sp_RisAgendamientoAmbulatorio_UpdatexCampo(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisAgendamientoAmbulatorio_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_agendamiento", pRisAgendamientoAmbulatorioE.CodrisAgendamiento);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisAgendamientoAmbulatorioE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisAgendamientoAmbulatorioE.Campo);
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

        public bool Sp_RisAgendamientoAmbulatorio_Cancela(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_AgendamientoAmbulatorio_Cancela", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@sps_id", pRisAgendamientoAmbulatorioE.SpsId);
                        cmd.Parameters.AddWithValue("@status_key", pRisAgendamientoAmbulatorioE.StatusKey);
                        cmd.Parameters.AddWithValue("@cod_presotor", pRisAgendamientoAmbulatorioE.Codpresotor);
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
        public bool Sp_RisAgendamientoAmbulatorio_Actualiza(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_AgendamientoAmbulatorio_Actualiza", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@sala", pRisAgendamientoAmbulatorioE.Codsala);
                        cmd.Parameters.AddWithValue("@fecha", pRisAgendamientoAmbulatorioE.StartDatetime);
                        cmd.Parameters.AddWithValue("@version", pRisAgendamientoAmbulatorioE.Version);
                        cmd.Parameters.AddWithValue("@sps_id", pRisAgendamientoAmbulatorioE.SpsId);
                        cmd.Parameters.AddWithValue("@statusKey", pRisAgendamientoAmbulatorioE.StatusKey);
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

        //RisAgendamientoAmbulatorio Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo
        public bool Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_AgendamientoAmbulatorio_CancelaPorTiempo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
    