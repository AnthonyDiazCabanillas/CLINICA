using Ent.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Dat.Sql 
{
    public class PrestacionesClinicaAD
    {
        static string USP_PRESTACIONES_CONSULTA = "usp_Prestaciones_ConsultaData";
        static string USP_PRESTACIONES_REGISTRO = "usp_Prestaciones_RegistrarData";

        public async Task<ResultadoTransactionE<PrestacionesClinicaE>> Listado_Prestaciones(PrestacionBusqE obj) 
        {
            ResultadoTransactionE<PrestacionesClinicaE> resultado = new ResultadoTransactionE<PrestacionesClinicaE> ();
            List<PrestacionesClinicaE> Listado = new List<PrestacionesClinicaE>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                cnn.Open ();
                using (SqlCommand cmd = new SqlCommand(USP_PRESTACIONES_CONSULTA, cnn)) 
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@orden", obj.orden);
                        cmd.Parameters.AddWithValue("@codprestacion", obj.codprestacion);
                        cmd.Parameters.AddWithValue("@codtarifa", obj.codtarifa);
                        cmd.Parameters.AddWithValue("@busq", obj.busq);
                        cmd.Parameters.AddWithValue("@flglimit", obj.flglimit);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                PrestacionesClinicaE objprestacion = new PrestacionesClinicaE();
                                objprestacion.codprestacion = reader["codprestacion"].ToString().Trim();
                                objprestacion.prestacion = reader["nombre"].ToString().Trim();
                                Listado.Add(objprestacion);
                            }
                        }
                        resultado.IdRegistro = 0;
                        resultado.Mensaje = "Ok";
                        resultado.DataList = Listado;

                    }
                    catch (Exception ex)
                    {
                        resultado.IdRegistro = -1;
                        resultado.Mensaje = ex.Message;
                    }
                    finally 
                    { 
                        cnn.Close();
                    }
                }
            }
            return resultado;
        }

        public async Task<ResultadoTransactionE<TarifaClinicaE>> Listado_Tarifario(PrestacionBusqE obj) 
        {
            ResultadoTransactionE<TarifaClinicaE> resultado = new ResultadoTransactionE<TarifaClinicaE>();
            List<TarifaClinicaE> Listado = new List<TarifaClinicaE>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica)) 
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(USP_PRESTACIONES_CONSULTA, cnn)) 
                {
                    try 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@orden", obj.orden);
                        cmd.Parameters.AddWithValue("@codprestacion", obj.codprestacion);
                        cmd.Parameters.AddWithValue("@codtarifa", obj.codtarifa);
                        cmd.Parameters.AddWithValue("@busq", obj.busq);
                        cmd.Parameters.AddWithValue("@flglimit", obj.flglimit);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                        {
                            while (reader.Read()) 
                            {
                                TarifaClinicaE objtarifa = new TarifaClinicaE();
                                objtarifa.codtarifa = reader["codtarifa"].ToString();
                                objtarifa.tarifa = reader["nombre"].ToString();
                                objtarifa.peso = Convert.ToDouble(reader["peso"].ToString());
                                Listado.Add(objtarifa);
                            }
                        }

                        resultado.IdRegistro = 0;
                        resultado.Mensaje = "Ok";
                        resultado.DataList = Listado;
                    }
                    catch (Exception ex)
                    {
                        resultado.IdRegistro = -1;
                        resultado.Mensaje = ex.Message;
                    }
                    finally 
                    {
                        cnn.Close();
                    }
                }
                return resultado;
            }
        }

        public async Task<ResultadoTransactionE<PrestacionesClinicaE>> Listado_PrestacionTarifario(PrestacionBusqE obj) 
        {
            ResultadoTransactionE<PrestacionesClinicaE> resultado = new ResultadoTransactionE<PrestacionesClinicaE>();
            List<PrestacionesClinicaE> _listprestacion = new List<PrestacionesClinicaE>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica)) 
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(USP_PRESTACIONES_CONSULTA, cnn)) 
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@orden", obj.orden);
                        cmd.Parameters.AddWithValue("@codprestacion", obj.codprestacion);
                        cmd.Parameters.AddWithValue("@codtarifa", obj.codtarifa);
                        cmd.Parameters.AddWithValue("@busq", obj.busq);
                        cmd.Parameters.AddWithValue("@flglimit", obj.flglimit);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            int itemdata = 0;
                            while (reader.Read()) 
                            {
                                itemdata++;
                                PrestacionesClinicaE objprestacion = new PrestacionesClinicaE();
                                objprestacion.Item = itemdata; 
                                objprestacion.codperiodo = reader["codperiodo"].ToString();
                                objprestacion.codprestacion = reader["codprestacion"].ToString();
                                objprestacion.prestacion = reader["prestacion"].ToString();
                                objprestacion.codtarifa = reader["codtarifa"].ToString();
                                objprestacion.tarifa = reader["tarifa"].ToString();
                                objprestacion.peso = Convert.ToDouble(reader["peso"].ToString());
                                objprestacion.valor = Convert.ToDouble(reader["valor"].ToString());
                                objprestacion.moneda = reader["moneda"].ToString();
                                _listprestacion.Add(objprestacion);
                            }
                        }
                        resultado.IdRegistro = 0;
                        resultado.Mensaje = "OK";
                        resultado.DataList = _listprestacion;
                    }
                    catch (Exception ex) 
                    {
                        resultado.IdRegistro = -1;
                        resultado.Mensaje = ex.Message;
                    }
                }
            }
            return resultado;
        }

        public async Task<ResultadoTransactionE<ErrorDataInsercionE>> Registro_PrestacionTarifa(List<PrestacionesClinicaE> obj, int iduser) 
        {
            ResultadoTransactionE<ErrorDataInsercionE> resultado = new ResultadoTransactionE<ErrorDataInsercionE> ();
            List<ErrorDataInsercionE> dataerror = new List<ErrorDataInsercionE>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica)) 
            {
                cnn.Open ();
                SqlTransaction sqlTransaction = cnn.BeginTransaction ();
                if (obj.Count > 0) 
                {
                    int itemdata = 0;

                    foreach (var item in obj)
                    {
                        itemdata++;

                        var insertar = await Insertar_Prestacion(item, iduser, cnn, sqlTransaction);
                        if (insertar.IdRegistro == -1) 
                        {
                            sqlTransaction.Rollback ();
                            resultado.IdRegistro = -1;
                            resultado.Mensaje = insertar.Mensaje;
                            return resultado;
                        }

                        if (!insertar.Data) 
                        {
                            ErrorDataInsercionE error = new ErrorDataInsercionE ();
                            error.Titulo = "Error de Registro, registro N° " + itemdata.ToString();
                            error.Descripcion = insertar.Mensaje;
                            dataerror.Add (error);
                        }
                    }
                }
                if (dataerror.Count() > 0)
                {
                    resultado.IdRegistro = 1;
                    resultado.Mensaje = "Registro con obervaciones";
                    resultado.DataList = dataerror;
                }
                else 
                {
                    resultado.IdRegistro = 0;
                    resultado.Mensaje = "Registrado Correctamente";
                }
                sqlTransaction.Commit ();
                sqlTransaction.Dispose ();
            }
            return resultado;
        }

        public async Task<ResultadoTransactionE<bool>> Insertar_Prestacion(PrestacionesClinicaE item, int iduser, SqlConnection cnn, SqlTransaction transaction) {
            ResultadoTransactionE<bool> resultado = new ResultadoTransactionE<bool> ();
            using (SqlCommand cmd = new SqlCommand(USP_PRESTACIONES_REGISTRO, cnn, transaction))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", iduser);
                    cmd.Parameters.AddWithValue("@CodTarifa", item.codtarifa);
                    cmd.Parameters.AddWithValue("@CodPrestacion", item.codprestacion);
                    cmd.Parameters.AddWithValue("@Valor", item.valor);
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Exito", SqlDbType.Int, 11).Direction = ParameterDirection.Output;
                    await cmd.ExecuteNonQueryAsync();
                    resultado.IdRegistro = 0;
                    resultado.Mensaje = cmd.Parameters["@Mensaje"].Value.ToString()??"";
                    resultado.Data = (Convert.ToInt32(cmd.Parameters["@Exito"].Value.ToString())) == 1 ? true : false; 
                }
                catch (Exception ex)
                {
                    resultado.IdRegistro = -1;
                    resultado.Mensaje = ex.Message;
                }
            }            
            return resultado;
        }
    }
}
