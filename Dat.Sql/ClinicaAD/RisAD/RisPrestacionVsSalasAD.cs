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
    public class RisPrestacionVsSalasAD
    {
        private RisPrestacionVsSalasE LlenarEntidad(IDataReader dr,
                                  RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            RisPrestacionVsSalasE oRisPrestacionVsSalasE = new RisPrestacionVsSalasE();
            switch (pRisPrestacionVsSalasE.Orden)
            {
                case 1:
                    oRisPrestacionVsSalasE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oRisPrestacionVsSalasE.Codsala = Convert.ToString(dr["codsala"]);
                    oRisPrestacionVsSalasE.Prioridad = Convert.ToInt32(dr["prioridad"]);
                    oRisPrestacionVsSalasE.Estado = Convert.ToString(dr["estado"]);
                    break;
                case 2:
                    oRisPrestacionVsSalasE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oRisPrestacionVsSalasE.Codsala = Convert.ToString(dr["codsala"]);
                    oRisPrestacionVsSalasE.Prioridad = Convert.ToInt32(dr["prioridad"]);
                    oRisPrestacionVsSalasE.Estado = Convert.ToString(dr["estado"]);
                    break;
            }

            return oRisPrestacionVsSalasE;
        }
        public List<RisPrestacionVsSalasE> Sp_RisPrestacionVsSalas_Consulta(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            List<RisPrestacionVsSalasE> oListar = new List<RisPrestacionVsSalasE>();
            RisPrestacionVsSalasE oRisPrestacionVsSalasE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RisPrestacionVsSalas_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@sala", pRisPrestacionVsSalasE.Codsala);
                    cmd.Parameters.AddWithValue("@prestacion", pRisPrestacionVsSalasE.Codprestacion);
                    cmd.Parameters.AddWithValue("@buscar", pRisPrestacionVsSalasE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pRisPrestacionVsSalasE.Campo);
                    cmd.Parameters.AddWithValue("@numerofilas", pRisPrestacionVsSalasE.NumeroFilas);
                    cmd.Parameters.AddWithValue("@orden", pRisPrestacionVsSalasE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisPrestacionVsSalasE = LlenarEntidad(dr, pRisPrestacionVsSalasE);
                        oListar.Add(oRisPrestacionVsSalasE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
        public bool Sp_RisPrestacionVsSalas_Insert(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisPrestacionVsSalas_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codprestacion", pRisPrestacionVsSalasE.Codprestacion);
                        cmd.Parameters.AddWithValue("@codsala", pRisPrestacionVsSalasE.Codsala);
                        cmd.Parameters.AddWithValue("@prioridad", pRisPrestacionVsSalasE.Prioridad);
                        cmd.Parameters.AddWithValue("@estado", pRisPrestacionVsSalasE.Estado);
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

        public bool Sp_RisPrestacionVsSalas_Update(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisPrestacionVsSalas_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codprestacion", pRisPrestacionVsSalasE.Codprestacion);
                        cmd.Parameters.AddWithValue("@codsala", pRisPrestacionVsSalasE.Codsala);
                        cmd.Parameters.AddWithValue("@prioridad", pRisPrestacionVsSalasE.Prioridad);
                        cmd.Parameters.AddWithValue("@estado", pRisPrestacionVsSalasE.Estado);
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

        public bool Sp_RisPrestacionVsSalas_UpdatexCampo(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisPrestacionVsSalas_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisPrestacionVsSalasE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisPrestacionVsSalasE.Campo);
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