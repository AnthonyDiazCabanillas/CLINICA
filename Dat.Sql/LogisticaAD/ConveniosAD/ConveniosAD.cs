using Ent.Sql;
using Ent.Sql.LogisticaE.ConveniosE;
using Microsoft.Win32;
using System.Data;
using System.Data.SqlClient;

namespace Dat.Sql.LogisticaAD.ConveniosAD
{
    public class ConveniosAD
    {
        public static string SP_CONVENIOS_INSERTV2 = "Sp_Convenios_InsertV2";
        private ConveniosE LlenarEntidad(IDataReader dr, ConveniosE pConveniosE)
        {
            ConveniosE oConveniosE = new ConveniosE();
            switch (pConveniosE.Orden)
            {
                case 1:
                    oConveniosE.Fechadocumento = Convert.ToDateTime(dr["fechadocumento"]);
                    oConveniosE.Codtipocliente = Convert.ToString(dr["codtipocliente"]);
                    oConveniosE.Nomtipocliente = Convert.ToString(dr["nombretipocliente"]);
                    oConveniosE.Codaseguradora = Convert.ToString(dr["codaseguradora"]);
                    oConveniosE.Nomaseguradora = (string)(dr["nombreaseguradora" + ""]);
                    oConveniosE.Codproducto = Convert.ToString(dr["codproducto"]);
                    oConveniosE.Nomproducto = Convert.ToString(dr["nombreproducto"]);
                    oConveniosE.Fechainicio = Convert.ToDateTime(dr["fechainicio"]);
                    oConveniosE.Tipomonto = Convert.ToString(dr["tipomonto"]);
                    oConveniosE.Monto = Convert.ToDouble(dr["monto"]);
                    oConveniosE.Moneda = Convert.ToString(dr["moneda"]);
                    oConveniosE.Idconvenio = Convert.ToInt32(dr["idconvenio"]);
                    oConveniosE.Codpaciente = Convert.ToString(dr["codpaciente"]);
                    oConveniosE.Nompaciente = Convert.ToString(dr["nombrepaciente"]);
                    break;
                case 2:
                    oConveniosE.Fechadocumento = Convert.ToDateTime(dr["fechadocumento"]);
                    oConveniosE.Codtipocliente = Convert.ToString(dr["codtipocliente"]);
                    oConveniosE.Nomtipocliente = Convert.ToString(dr["nombretipocliente"]);
                    oConveniosE.Codaseguradora = Convert.ToString(dr["codaseguradora"]);
                    oConveniosE.Nomaseguradora = (string)(dr["nombreaseguradora" + ""]);
                    oConveniosE.Codproducto = Convert.ToString(dr["codproducto"]);
                    oConveniosE.Nomproducto = Convert.ToString(dr["nombreproducto"]);
                    oConveniosE.Fechainicio = Convert.ToDateTime(dr["fechainicio"]);
                    oConveniosE.Tipomonto = Convert.ToString(dr["tipomonto"]);
                    oConveniosE.Monto = Convert.ToDouble(dr["monto"]);
                    oConveniosE.Moneda = Convert.ToString(dr["moneda"]);
                    oConveniosE.Idconvenio = Convert.ToInt32(dr["idconvenio"]);
                    oConveniosE.Codpaciente = Convert.ToString(dr["codpaciente"]);
                    oConveniosE.Nompaciente = Convert.ToString(dr["nombrepaciente"]);
                    break;
            }
            return oConveniosE;
        }

        public List<ConveniosE> Sp_Convenios_ConsultaV2(ConveniosE pConveniosE)
        {
            List<ConveniosE> oListar = new List<ConveniosE>();
            ConveniosE oConveniosE = new ConveniosE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Convenios_ConsultaV2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pConveniosE.Orden);
                    cmd.Parameters.AddWithValue("@codaseguradora", pConveniosE.Nomaseguradora);
                    cmd.Parameters.AddWithValue("@codpaciente", pConveniosE.Nompaciente);
                    cmd.Parameters.AddWithValue("@codproducto", pConveniosE.Nomproducto);
                    cmd.Parameters.AddWithValue("@nro_filas", pConveniosE.Nrofilas);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oConveniosE = LlenarEntidad(dr, pConveniosE);
                        oListar.Add(oConveniosE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_Convenios_Insert(ConveniosE pConveniosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
                {
                    using (SqlCommand cmd = new SqlCommand(SP_CONVENIOS_INSERTV2, cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@fechadocumento", pConveniosE.Fechadocumento);
                        cmd.Parameters.AddWithValue("@codalmacen", pConveniosE.Codalmacen);
                        cmd.Parameters.AddWithValue("@tipomovimiento", pConveniosE.Tipomovimiento);
                        cmd.Parameters.AddWithValue("@codtipocliente", pConveniosE.Codtipocliente);
                        cmd.Parameters.AddWithValue("@codcliente", pConveniosE.Codcliente);
                        cmd.Parameters.AddWithValue("@codpaciente", pConveniosE.Codpaciente);
                        cmd.Parameters.AddWithValue("@codaseguradora", pConveniosE.Codaseguradora);
                        cmd.Parameters.AddWithValue("@codcia", pConveniosE.Codcia);
                        cmd.Parameters.AddWithValue("@codproducto", pConveniosE.Codproducto);
                        cmd.Parameters.AddWithValue("@fechainicio", pConveniosE.Fechainicio);
                        cmd.Parameters.AddWithValue("@fechafin", pConveniosE.Fechafin);
                        cmd.Parameters.AddWithValue("@excepto", pConveniosE.Excepto);
                        cmd.Parameters.AddWithValue("@tipomonto", pConveniosE.Tipomonto);
                        cmd.Parameters.AddWithValue("@monto", pConveniosE.Monto);
                        cmd.Parameters.AddWithValue("@moneda", pConveniosE.Moneda);
                        cmd.Parameters.AddWithValue("@estado", pConveniosE.Estado);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@idconvenio", ParameterDirection.InputOutput, SqlDbType.Int, 8, pConveniosE.Idconvenio.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pConveniosE.Idconvenio = Convert.ToInt32(cmd.Parameters["@idconvenio"].Value);
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

        public ResultadoTransactionE<ErrorDataInsercionE> Sp_Convenios_Insert_Masivo(List<ConveniosE> objconvenios)
        {
            ResultadoTransactionE<ErrorDataInsercionE> resultado = new ResultadoTransactionE<ErrorDataInsercionE>();
            
            List<ErrorDataInsercionE> listadoerror = new List<ErrorDataInsercionE>();
            
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica)) 
            {
                if (objconvenios.Count() > 0) {
                    cnn.Open();
                    SqlTransaction sqlTransaction = cnn.BeginTransaction();
                    try
                    {
                        int fila = 0;
                        foreach (var item in objconvenios) 
                        {
                            fila++;
                            
                            var _registro = Registrar_Convenios_Item(item, cnn, sqlTransaction);
                            
                            if (_registro.IdRegistro == -1) 
                            {
                                sqlTransaction.Rollback();
                                resultado.IdRegistro = -1;
                                resultado.Mensaje = "Error de registro: " + resultado.Mensaje;
                                
                                return resultado;
                            }

                            if (!_registro.Data) 
                            {
                                ErrorDataInsercionE _objerror = new ErrorDataInsercionE();
                                _objerror.Titulo = "Error de inserción";
                                _objerror.Descripcion = "Registro fila Nro: " + fila.ToString();
                                listadoerror.Add(_objerror);
                            }
                        }

                        resultado.IdRegistro = (listadoerror.Count() == 0)? 1 : 2;
                        resultado.Mensaje = (listadoerror.Count() == 0)? "Se ha registrado correctamente" : "Registro con errores";
                        resultado.DataList = listadoerror;

                        sqlTransaction.Commit();
                        sqlTransaction.Dispose();
                    }
                    catch (Exception ex) 
                    {
                        sqlTransaction.Rollback();
                        resultado.IdRegistro = -1;
                        resultado.Mensaje = "Error de registro: " + ex.Message;

                    }
                }
            }
            return resultado;
        }
        public ResultadoTransactionE<bool> Registrar_Convenios_Item(ConveniosE pConveniosE, SqlConnection cnn, SqlTransaction sqlTransaction) 
        {
            ResultadoTransactionE<bool> resultado = new ResultadoTransactionE<bool>();
            using (SqlCommand cmd = new SqlCommand(SP_CONVENIOS_INSERTV2, cnn, sqlTransaction)) {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechadocumento", pConveniosE.Fechadocumento);
                    cmd.Parameters.AddWithValue("@codalmacen", pConveniosE.Codalmacen);
                    cmd.Parameters.AddWithValue("@tipomovimiento", pConveniosE.Tipomovimiento);
                    cmd.Parameters.AddWithValue("@codtipocliente", pConveniosE.Codtipocliente);
                    cmd.Parameters.AddWithValue("@codcliente", pConveniosE.Codcliente);
                    cmd.Parameters.AddWithValue("@codpaciente", pConveniosE.Codpaciente);
                    cmd.Parameters.AddWithValue("@codaseguradora", pConveniosE.Codaseguradora);
                    cmd.Parameters.AddWithValue("@codcia", pConveniosE.Codcia);
                    cmd.Parameters.AddWithValue("@codproducto", pConveniosE.Codproducto);
                    cmd.Parameters.AddWithValue("@fechainicio", pConveniosE.Fechainicio);
                    cmd.Parameters.AddWithValue("@fechafin", pConveniosE.Fechafin);
                    cmd.Parameters.AddWithValue("@excepto", pConveniosE.Excepto);
                    cmd.Parameters.AddWithValue("@tipomonto", pConveniosE.Tipomonto);
                    cmd.Parameters.AddWithValue("@monto", pConveniosE.Monto);
                    cmd.Parameters.AddWithValue("@moneda", pConveniosE.Moneda);
                    cmd.Parameters.AddWithValue("@estado", pConveniosE.Estado);
                    cmd.Parameters.Add(VariablesGlobales.ParametroSql("@idconvenio", ParameterDirection.InputOutput, SqlDbType.Int, 8, pConveniosE.Idconvenio.ToString()));
                    int exito = cmd.ExecuteNonQuery();
                    resultado.IdRegistro = 0;
                    if (exito >= 1)
                    {
                        pConveniosE.Idconvenio = Convert.ToInt32(cmd.Parameters["@idconvenio"].Value);
                        resultado.Data = true;
                        resultado.Mensaje = "Registro Correcto, IdRegistro: " + pConveniosE.Idconvenio.ToString();
                    }
                    else
                    {
                         resultado.Data = false;  
                    }
                }
                catch (Exception ex) 
                {
                    resultado.IdRegistro = -1;
                    resultado.Mensaje = ex.Message;
                }
            }  
            return resultado;
        }


        public bool Sp_Convenios_UpdatexCampo(ConveniosE pConveniosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Convenios_UpdatexCampoV2", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@idconvenio", pConveniosE.Idconvenio);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pConveniosE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pConveniosE.Campo);
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

