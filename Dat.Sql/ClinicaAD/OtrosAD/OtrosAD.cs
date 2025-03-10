﻿using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class OtrosAD
    {
        private OtrosE LlenarEntidad(IDataReader dr, OtrosE pOtrosE)
        {
            OtrosE objOtrosE = new OtrosE();
            switch (pOtrosE.Orden)
            {
                case "0":
                    {
                        break;
                    }
            }

            return objOtrosE;
        }

        public bool Sp_Intervalo_Fechas(ref OtrosE pOtrosE)
        {
            OtrosE objOtrosE = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Intervalo_Fechas", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@fechainicio", pOtrosE.FechaInicio);
                        cmd.Parameters.AddWithValue("@intervalo", pOtrosE.Intervalo);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@fechafin", ParameterDirection.Output, SqlDbType.Char, 10, pOtrosE.FechaFin));
                        cnn.Open();

                        cmd.ExecuteNonQuery();
                        pOtrosE.FechaFin = (string)cmd.Parameters["@fechafin"].Value;

                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public bool Sp_CapturarTarifaAtencion(OtrosE pOtrosE)
        {
            OtrosE objOtrosE = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_CapturarTarifaAtencion", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codatencion", pOtrosE.CodAtencion);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@tarifa", ParameterDirection.Output, SqlDbType.Char, 2, pOtrosE.Tarifa));
                        cnn.Open();

                        cmd.ExecuteNonQuery();
                        pOtrosE.Tarifa = (string)cmd.Parameters["@tarifa"].Value;
                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public DataSet Sp_Correlativo_Consulta()
        {
            OtrosE objOtrosE = null/* TODO Change to default(_) if this is not a reference type */;
            DataSet oDataSet = new DataSet();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Correlativo_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cnn.Open();
                        SqlDataAdapter oda = new SqlDataAdapter(cmd);
                        oda.Fill(oDataSet);

                        oda.Dispose(); // Se liberan todos los recursos del Adapter
                        cmd.Dispose(); // Se liberan todos los recursos del Command
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return oDataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CorrelativoE Sp_Correlativo_Consulta_PC(CorrelativoE pCorrelativoE)
        {
            IDataReader dr;
            CorrelativoE oCorrelativo = new CorrelativoE();/* TODO Change to default(_) if this is not a reference type */;
            List<CorrelativoE> oListar = new List<CorrelativoE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Correlativo_Consulta_PC", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@hostname", pCorrelativoE.PCHostname);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oCorrelativo.Boleta = Convert.ToString(dr["Boleta"] + "");
                            oCorrelativo.Factura = Convert.ToString(dr["Factura"] + "");
                            oCorrelativo.CreditoB = Convert.ToString(dr["CreditoB"] + "");
                            oCorrelativo.DebitoB = Convert.ToString(dr["DebitoB"] + "");
                            oCorrelativo.DebitoF = Convert.ToString(dr["DebitoF"] + "");
                            oCorrelativo.Guia = Convert.ToString(dr["Guia"] + "");
                            oCorrelativo.Garantia = Convert.ToString(dr["Garantia"] + "");
                            oCorrelativo.GarantiaManual = Convert.ToString(dr["garantiamanual"] + "");

                            oCorrelativo.FlgElectronicof = Convert.ToBoolean(dr["flg_electronicof"].ToString() == "" ? false : true);
                            oCorrelativo.flg_electronicob = Convert.ToBoolean(dr["flg_electronicob"].ToString() == "" ? false : true);
                            oCorrelativo.flg_electronicocb = Convert.ToBoolean(dr["flg_electronicocb"].ToString() == "" ? false : true);
                            oCorrelativo.flg_electronicocf = Convert.ToBoolean(dr["flg_electronicocf"].ToString() == "" ? false : true);
                            oCorrelativo.flg_electronicodb = Convert.ToBoolean(dr["flg_electronicodb"].ToString() == "" ? false : true);
                            oCorrelativo.flg_electronicodf = Convert.ToBoolean(dr["flg_electronicodf"].ToString() == "" ? false : true);
                            oCorrelativo.flg_otorgarf = Convert.ToBoolean(dr["flg_otorgarf"].ToString() == "1" ? true : true);
                            oCorrelativo.flg_otorgarb = Convert.ToBoolean(dr["flg_otorgarb"].ToString() == "1" ? true: true);
                            oCorrelativo.flg_otorgarcb = Convert.ToBoolean(dr["flg_otorgarcb"].ToString() == "0" ? false : true);
                            oCorrelativo.flg_otorgarcf = Convert.ToBoolean(dr["flg_otorgarcf"].ToString() == "0" ? false : true);
                            oCorrelativo.flg_otorgardb = Convert.ToBoolean(dr["flg_otorgardb"].ToString() == "0" ? false : true);
                            oCorrelativo.flg_otorgardf = Convert.ToBoolean(dr["flg_otorgardf"].ToString() == "0" ? false : true);
                            oCorrelativo.flg_electronico = Convert.ToBoolean(dr["flg_electronico"].ToString() == "S" ? true:false);
                            oCorrelativo.generar_e = Convert.ToBoolean(dr["generar_e"].ToString() == "S" ? true : false);

                        }
                        dr.Close();
                        cnn.Close();

                        return oCorrelativo;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Sp_Ris_EvaluaAtencion(string pCodAtencion, string pCodPrestacion, string pCodLocal, int pOrden)
        {
            OtrosE objOtrosE = null/* TODO Change to default(_) if this is not a reference type */;
            // Dim oDataTable As New DataTable
            int i = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_EvaluaAtencion", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codatencion", pCodAtencion);
                        cmd.Parameters.AddWithValue("@codprestacion", pCodPrestacion);
                        cmd.Parameters.AddWithValue("@codlocal", pCodLocal);
                        cmd.Parameters.AddWithValue("@orden", pOrden);
                        cnn.Open();

                        i = cmd.ExecuteNonQuery();

                        cmd.Dispose(); // Se liberan todos los recursos del Command
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return (int)cmd.Parameters[0].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet Sp_Genericos_Consulta(string pBuscar, int pKey, int pNumeroLineas, int pOrden)
        {
            DataSet oDataSet = new DataSet();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Genericos_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pBuscar);
                        cmd.Parameters.AddWithValue("@key", pKey);
                        cmd.Parameters.AddWithValue("@numerolineas", pNumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pOrden);

                        cnn.Open();
                        SqlDataAdapter oda = new SqlDataAdapter(cmd);
                        oda.Fill(oDataSet);

                        oda.Dispose();
                        cmd.Dispose(); // Se liberan todos los recursos del Command
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return oDataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
