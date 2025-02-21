//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             06/09/2024     HVIDAL      REQ 2024-010468 IMAGENES DEL VUEMOTION
//    1.1			  20/12/2024     HVIDAL       REQ 2024-021955 NEONATOLOGIA
//****************************************************************************************
using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class TablasAD
    {
        private TablasE LlenarEntidad(IDataReader dr, TablasE pTablasE)
        {
            TablasE oTablasE = new TablasE();
            switch (pTablasE.Orden)
            {
                case -1:
                case 0:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] is DBNull ? 0 : (double)dr["valor"];//IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }
                case 1:
                    {
                        oTablasE.Codigo = Convert.ToString(dr["codigo"] + "").Trim();
                        oTablasE.Nombre = Convert.ToString(dr["nombre"] + "").Trim();
                        break;
                    }
                case 4:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] is DBNull ? 0 : (double)dr["valor"];//IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }
                //INI 1.0
                case 11:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] is DBNull ? 0 : (double)dr["valor"];//IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }
                //FIN 1.0
                case 18:
                case 5:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = ((string)dr["codigo"]).Trim();
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] is DBNull ? 0 : (double)dr["valor"];//IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }


                case 7:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] is DBNull ? 0 : (double)dr["valor"]; //IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }

                case 8:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] is DBNull ? 0 : (double)dr["valor"]; //IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }

                case 9:
                    {
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        break;
                    }

                case 16:
                    {
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["codtabla"];
                        break;
                    }

                case 19:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] != System.DBNull.Value ? (double)dr["valor"] : 0; //IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }

                case 26:
                    {
                        oTablasE.Codtabla = (string)dr["codtabla"];
                        oTablasE.Codigo = (string)dr["codigo"];
                        oTablasE.Nombre = (string)dr["nombre"];
                        oTablasE.Valor = dr["valor"] != System.DBNull.Value ? (double)dr["valor"] : 0; //IIf(IsDBNull(dr("valor")), 0, dr("valor"];
                        oTablasE.Estado = (string)dr["estado"];
                        break;
                    }
                case 29:
                case 30:
                    {
                        oTablasE.Codtabla = Convert.ToString(dr["codtabla"] + "").Trim();
                        oTablasE.Codigo = Convert.ToString(dr["codigo"] + "").Trim();
                        oTablasE.Nombre = Convert.ToString(dr["nombre"] + "").Trim();
                        oTablasE.Valor = double.TryParse(dr["valor"]?.ToString(), out double valorConvertido) ? valorConvertido : 0.0;
                        oTablasE.Estado = Convert.ToString(dr["estado"] + "").Trim();
                        break;
                    }
                //INI 1.1
                case 33:
                    {
                        oTablasE.Nombre = Convert.ToString(dr["nombre"] + "").Trim();
                        break;
                    }
                //FIN 1.1
            }
            return oTablasE;
        }


        public List<TablasE> Sp_Tablas_ConsultaV2(TablasE pTablasE)
        {
            List<TablasE> oListar = new List<TablasE>();
            TablasE oTablasE = new TablasE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Tablas_ConsultaV2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pTablasE.Orden);
                    cmd.Parameters.AddWithValue("@buscar", pTablasE.Buscar);
                    cmd.Parameters.AddWithValue("@nro_filas", pTablasE.NumeroLineas);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oTablasE = LlenarEntidad(dr, pTablasE);
                        oListar.Add(oTablasE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public TablasE Sp_Tablas_ConsultaEntidad(TablasE pTablasE)
        {
            IDataReader dr;
            TablasE oTablasE = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Tablas_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codtabla", pTablasE.Codtabla);
                        cmd.Parameters.AddWithValue("@buscar", pTablasE.Buscar);
                        cmd.Parameters.AddWithValue("@key", pTablasE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pTablasE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pTablasE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                            oTablasE = LlenarEntidad(dr, pTablasE);

                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oTablasE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase Sp_Tablas_Consulta: " + ex.Message);
            }
        }

        public List<TablasE> Sp_Tablas_Consulta(TablasE pTablasE)
        {
            IDataReader dr;
            TablasE oTablasE = null/* TODO Change to default(_) if this is not a reference type */;
            List<TablasE> oListar = new List<TablasE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Tablas_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codtabla", pTablasE.Codtabla);
                        cmd.Parameters.AddWithValue("@buscar", pTablasE.Buscar);
                        cmd.Parameters.AddWithValue("@key", pTablasE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pTablasE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pTablasE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();

                        if (pTablasE.RegistroBlanco == true)
                            oListar.Add(new TablasE());

                        while (dr.Read())
                        {
                            oTablasE = LlenarEntidad(dr, pTablasE);
                            oListar.Add(oTablasE);
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
                    throw new Exception("Clase Sp_Tablas_Consulta: " + ex.Message);
            }
        }

        public bool Sp_Tablas_Update(TablasE pTablasE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Tablas_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codigotabla", pTablasE.Codtabla);
                        cmd.Parameters.AddWithValue("@codigo", pTablasE.Codigo);
                        cmd.Parameters.AddWithValue("@nuevovalor", pTablasE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pTablasE.Campo);

                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///         ''' Devuelve el estado del RisPacs
        ///         ''' </summary>
        ///         ''' <param name="pTablasE">Enviar en el @buscar el codigo a buscar, también mandamos por defecto el valor -1 al orden.</param>
        ///         ''' <returns></returns>
        public List<TablasE> Sp_Ris_Consulta_RisPacs(TablasE pTablasE)
        {
            IDataReader dr;
            TablasE oTablasE = null/* TODO Change to default(_) if this is not a reference type */;
            List<TablasE> oListar = new List<TablasE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_Consulta_RisPacs", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pTablasE.Buscar);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oTablasE = LlenarEntidad(dr, pTablasE);
                            oListar.Add(oTablasE);
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
                throw new Exception("Clase Sp_Ris_Consulta_RisPacs: " + ex.Message);
            }
        }



    }
}
