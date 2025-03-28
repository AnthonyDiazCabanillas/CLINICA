﻿using Ent.Sql.ClinicaE.PacientesE;
using Ent.Sql.ClinicaE.PresotorE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.PresotorAD
{
    public class PresotorAD
    {
        private PresotorE LlenarEntidad(IDataReader dr, PresotorE pPresotorE)
        {
            PresotorE oPresotorE = new PresotorE();
            switch (pPresotorE.Orden)
            {
                case 1:
                    {
                        oPresotorE.CodPresotor = (string) dr["codpresotor"];
                        oPresotorE.CodAtencion = (string) dr["codatencion"];
                        oPresotorE.CodPrestacion = (string) dr["codprestacion"];
                        oPresotorE.Fechahoraatencion = (DateTime) dr["fechahoraatencion"];
                        oPresotorE.Codmedico = (string) dr["codmedico"];
                        oPresotorE.Tipomedico = (string) dr["tipomedico"];
                        oPresotorE.Cargomedico = (string) dr["cargomedico"];
                        oPresotorE.CodLiqPaciente = (string) dr["codliqpaciente"];
                        oPresotorE.CodLiqAseguradora = (string) dr["codliqaseguradora"];
                        oPresotorE.Codliqcontratante = (string) dr["codliqcontratante"];
                        oPresotorE.Valorprestacion = (double) dr["valorprestacion"];
                        oPresotorE.ValorCorregido = (double) dr["valorcorregido"];
                        oPresotorE.Valorgnc = (double) dr["valorgnc"];
                        oPresotorE.Valorcoaseguro = (double) dr["valorcoaseguro"];
                        oPresotorE.Porcentajededucible = (double) dr["porcentajededucible"];
                        oPresotorE.Porcentajecoaseguro = (double) dr["porcentajecoaseguro"];
                        oPresotorE.Descuento = (double) dr["descuento"];
                        oPresotorE.Documento = (string) dr["documento"];
                        oPresotorE.Codpedido = (string) dr["codpedido"];
                        oPresotorE.Deducible = (double) dr["deducible"];
                        oPresotorE.Estado = (string) dr["estado"];
                        oPresotorE.Quiencreoregistro = (string) dr["quiencreoregistro"];
                        oPresotorE.Quienmodificoregistro = (string) dr["quienmodificoregistro"];
                        oPresotorE.Liqtercero = (string) dr["liqtercero"];
                        oPresotorE.Codmedicoenvia = (string) dr["codmedicoenvia"];
                        oPresotorE.Fechallegadocumento = (DateTime) dr["fechallegadocumento"];
                        oPresotorE.Auxiliar = (string) dr["auxiliar"];
                        oPresotorE.Porcentajedescuento = (double) dr["porcentajedescuento"];
                        oPresotorE.Liqterceropaciente = (string) dr["liqterceropaciente"];
                        oPresotorE.Liqtercerocontratante = (string) dr["liqtercerocontratante"];
                        oPresotorE.Codtercero = (string) dr["codtercero"];
                        oPresotorE.Descuentotercero = (double) dr["descuentotercero"];
                        oPresotorE.Codpresotorpadre = (string) dr["codpresotorpadre"];
                        oPresotorE.Quieneliminoregistro = (string) dr["quieneliminoregistro"];
                        oPresotorE.FlgEnviosap = (bool) dr["flg_enviosap"];
                        oPresotorE.FecEnviosap = (DateTime) dr["fec_enviosap"];
                        oPresotorE.IdeDocentrysap = (int) dr["ide_docentrysap"];
                        oPresotorE.FecDocentrysap = (DateTime) dr["fec_docentrysap"];
                        oPresotorE.IdeTablainterSap = (int) dr["ide_tablaintersap"];
                        break;
                    }
                case 2:
                    oPresotorE.CodPresotor = Convert.ToString(dr["codpresotor"]);
                    oPresotorE.CodAtencion = Convert.ToString(dr["codatencion"]);
                    oPresotorE.CodPrestacion = Convert.ToString(dr["codprestacion"]);
                    oPresotorE.Fechahoraatencion = Convert.ToDateTime(dr["fechahoraatencion"]);
                    oPresotorE.Codmedico = Convert.ToString(dr["codmedico"]);
                    oPresotorE.Tipomedico = Convert.ToString(dr["tipomedico"]);
                    oPresotorE.Cargomedico = Convert.ToString(dr["cargomedico"]);
                    oPresotorE.CodLiqPaciente = Convert.ToString(dr["codliqpaciente"]);
                    oPresotorE.CodLiqAseguradora = Convert.ToString(dr["codliqaseguradora"]);
                    oPresotorE.Codliqcontratante = Convert.ToString(dr["codliqcontratante"]);
                    oPresotorE.Valorprestacion = Convert.ToDouble(dr["valorprestacion"]);
                    oPresotorE.ValorCorregido = Convert.ToDouble(dr["valorcorregido"]);
                    oPresotorE.Valorgnc = Convert.ToDouble(dr["valorgnc"]);
                    oPresotorE.Valorcoaseguro = Convert.ToDouble(dr["valorcoaseguro"]);
                    oPresotorE.Porcentajededucible = Convert.ToDouble(dr["porcentajededucible"]);
                    oPresotorE.Porcentajecoaseguro = Convert.ToDouble(dr["porcentajecoaseguro"]);
                    oPresotorE.Descuento = Convert.ToDouble(dr["descuento"]);
                    oPresotorE.Documento = Convert.ToString(dr["documento"]);
                    oPresotorE.Codpedido = Convert.ToString(dr["codpedido"]);
                    oPresotorE.Deducible = Convert.ToDouble(dr["deducible"]);
                    oPresotorE.Estado = Convert.ToString(dr["estado"]);
                    oPresotorE.Quiencreoregistro = Convert.ToString(dr["quiencreoregistro"]);
                    oPresotorE.Quienmodificoregistro = Convert.ToString(dr["quienmodificoregistro"]);
                    oPresotorE.Liqtercero = Convert.ToString(dr["liqtercero"]);
                    oPresotorE.Codmedicoenvia = Convert.ToString(dr["codmedicoenvia"]);
                    oPresotorE.Fechallegadocumento = Convert.ToDateTime(dr["fechallegadocumento"]);
                    oPresotorE.Auxiliar = Convert.ToString(dr["auxiliar"]);
                    oPresotorE.Porcentajedescuento = Convert.ToDouble(dr["porcentajedescuento"]);
                    oPresotorE.Liqterceropaciente = Convert.ToString(dr["liqterceropaciente"]);
                    oPresotorE.Liqtercerocontratante = Convert.ToString(dr["liqtercerocontratante"]);
                    oPresotorE.Codtercero = Convert.ToString(dr["codtercero"]);
                    oPresotorE.Descuentotercero = Convert.ToDouble(dr["descuentotercero"]);
                    oPresotorE.Codpresotorpadre = Convert.ToString(dr["codpresotorpadre"]);
                    oPresotorE.Quieneliminoregistro = Convert.ToString(dr["quieneliminoregistro"]);
                    oPresotorE.FlgEnviosap = Convert.ToBoolean(dr["flg_enviosap"]);
                    oPresotorE.FecEnviosap = Convert.ToDateTime(dr["fec_enviosap"]);
                    oPresotorE.IdeDocentrysap = Convert.ToInt32(dr["ide_docentrysap"]);
                    oPresotorE.FecDocentrysap = Convert.ToDateTime(dr["fec_docentrysap"]);
                    oPresotorE.IdeTablainterSap = Convert.ToInt32(dr["ide_tablaintersap"]);
                    break;
            }
            return oPresotorE;
        }

        public List<PresotorE> Sp_Presotor_Consulta(PresotorE pPresotorE)
        {
            IDataReader dr;
            PresotorE oPresotorE = null/* TODO Change to default(_) if this is not a reference type */;
            List<PresotorE> oListar = new List<PresotorE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Presotor_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@orden", pPresotorE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oPresotorE = LlenarEntidad(dr, pPresotorE);
                            oListar.Add(oPresotorE);
                        }

                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PresotorE> Sp_Presotor_ConsultaV2(PresotorE pPresotorE)
        {
            IDataReader dr;
            PresotorE oPresotorE = null/* TODO Change to default(_) if this is not a reference type */;
            List<PresotorE> oListar = new List<PresotorE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Presotor_ConsultaV2", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codpresotor", pPresotorE.CodPresotor);
                        cmd.Parameters.AddWithValue("@busca", pPresotorE.Buscar);
                        cmd.Parameters.AddWithValue("@campo", pPresotorE.Campo);
                        cmd.Parameters.AddWithValue("@numerofilas", pPresotorE.NumeroFilas);
                        cmd.Parameters.AddWithValue("@orden", pPresotorE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oPresotorE = LlenarEntidad(dr, pPresotorE);
                            oListar.Add(oPresotorE);
                        }

                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool Sp_PresotorPago_Insert(PresotorE pPresotorE)
        {
            bool wResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PresotorPago_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codatencion", pPresotorE.CodAtencion);
                        cmd.Parameters.AddWithValue("@pmontototal", pPresotorE.MontoTotal);
                        cmd.Parameters.AddWithValue("@pcodusuer", pPresotorE.CodUser);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@pcodpresotor", ParameterDirection.InputOutput, SqlDbType.VarChar, 12, pPresotorE.CodPresotor));

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        if (cmd.Parameters["@pcodpresotor"].Value + "" != "")
                        {
                            pPresotorE.CodPresotor = cmd.Parameters["@pcodpresotor"].Value + "";
                            wResult = true;
                        }

                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return wResult;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Presotor_Update(PresotorE pPresotorE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Presotor_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codpresotor", pPresotorE.CodPresotor);
                        cmd.Parameters.AddWithValue("@codatencion", pPresotorE.CodAtencion);
                        cmd.Parameters.AddWithValue("@codprestacion", pPresotorE.CodPrestacion);
                        cmd.Parameters.AddWithValue("@fechahoraatencion", pPresotorE.Fechahoraatencion);
                        cmd.Parameters.AddWithValue("@codmedico", pPresotorE.Codmedico);
                        cmd.Parameters.AddWithValue("@tipomedico", pPresotorE.Tipomedico);
                        cmd.Parameters.AddWithValue("@cargomedico", pPresotorE.Cargomedico);
                        cmd.Parameters.AddWithValue("@codliqpaciente", pPresotorE.CodLiqPaciente);
                        cmd.Parameters.AddWithValue("@codliqaseguradora", pPresotorE.CodLiqAseguradora);
                        cmd.Parameters.AddWithValue("@codliqcontratante", pPresotorE.Codliqcontratante);
                        cmd.Parameters.AddWithValue("@valorprestacion", pPresotorE.Valorprestacion);
                        cmd.Parameters.AddWithValue("@valorcorregido", pPresotorE.ValorCorregido);
                        cmd.Parameters.AddWithValue("@valorgnc", pPresotorE.Valorgnc);
                        cmd.Parameters.AddWithValue("@valorcoaseguro", pPresotorE.Valorcoaseguro);
                        cmd.Parameters.AddWithValue("@porcentajededucible", pPresotorE.Porcentajededucible);
                        cmd.Parameters.AddWithValue("@porcentajecoaseguro", pPresotorE.Porcentajecoaseguro);
                        cmd.Parameters.AddWithValue("@descuento", pPresotorE.Descuento);
                        cmd.Parameters.AddWithValue("@documento", pPresotorE.Documento);
                        cmd.Parameters.AddWithValue("@codpedido", pPresotorE.Codpedido);
                        cmd.Parameters.AddWithValue("@deducible", pPresotorE.Deducible);
                        cmd.Parameters.AddWithValue("@estado", pPresotorE.Estado);
                        cmd.Parameters.AddWithValue("@quiencreoregistro", pPresotorE.Quiencreoregistro);
                        cmd.Parameters.AddWithValue("@quienmodificoregistro", pPresotorE.Quienmodificoregistro);
                        cmd.Parameters.AddWithValue("@liqtercero", pPresotorE.Liqtercero);
                        cmd.Parameters.AddWithValue("@codmedicoenvia", pPresotorE.Codmedicoenvia);
                        cmd.Parameters.AddWithValue("@fechallegadocumento", pPresotorE.Fechallegadocumento);
                        cmd.Parameters.AddWithValue("@auxiliar", pPresotorE.Auxiliar);
                        cmd.Parameters.AddWithValue("@porcentajedescuento", pPresotorE.Porcentajedescuento);
                        cmd.Parameters.AddWithValue("@liqterceropaciente", pPresotorE.Liqterceropaciente);
                        cmd.Parameters.AddWithValue("@liqtercerocontratante", pPresotorE.Liqtercerocontratante);
                        cmd.Parameters.AddWithValue("@codtercero", pPresotorE.Codtercero);
                        cmd.Parameters.AddWithValue("@descuentotercero", pPresotorE.Descuentotercero);
                        cmd.Parameters.AddWithValue("@codpresotorpadre", pPresotorE.Codpresotorpadre);
                        cmd.Parameters.AddWithValue("@quieneliminoregistro", pPresotorE.Quieneliminoregistro);
                        cmd.Parameters.AddWithValue("@flg_enviosap", pPresotorE.FlgEnviosap);
                        cmd.Parameters.AddWithValue("@fec_enviosap", pPresotorE.FecEnviosap);
                        cmd.Parameters.AddWithValue("@ide_docentrysap", pPresotorE.IdeDocentrysap);
                        cmd.Parameters.AddWithValue("@fec_docentrysap", pPresotorE.FecDocentrysap);
                        cmd.Parameters.AddWithValue("@ide_tablaintersap", pPresotorE.IdeTablainterSap);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Sp_Presotor_Insert1(PresotorE pPresotorE)
        {
            bool wResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Presotor_Insert1", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codatencion", pPresotorE.CodAtencion);
                        cmd.Parameters.AddWithValue("@codprestacion", pPresotorE.CodPrestacion);
                        cmd.Parameters.AddWithValue("@codusuario", pPresotorE.CodUser);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codpresotor", ParameterDirection.InputOutput, SqlDbType.VarChar, 12, pPresotorE.CodPresotor));

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        if (cmd.Parameters["@codpresotor"].Value + "" != "")
                        {
                            pPresotorE.CodPresotor = cmd.Parameters["@codpresotor"].Value + "";
                            wResult = true;
                        }

                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión

                        return pPresotorE.CodPresotor;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Presotor_UpdatexCampo(PresotorE pPresotorE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Presotor_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@campo", pPresotorE.Campo);
                        cmd.Parameters.AddWithValue("@codigo", pPresotorE.CodPresotor);
                        cmd.Parameters.AddWithValue("@nuevovalor", pPresotorE.NuevoValor);

                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cnn.Close();
                        cmd.Dispose();
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
