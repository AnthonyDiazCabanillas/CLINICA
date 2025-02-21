using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Ent.Sql.ClinicaE.SistemasE;

namespace Dat.Sql.ClinicaAD.SistemasAD
{
    public class SisCorreoDestinatarioMaeAD
    {

        private SisCorreoDestinatarioMaeE LlenarEntidad(IDataReader dr,
                                       SisCorreoDestinatarioMaeE pSisCorreoDestinatarioMaeE)
        {
            SisCorreoDestinatarioMaeE oSisCorreoDestinatarioMaeE = new SisCorreoDestinatarioMaeE();
            switch (pSisCorreoDestinatarioMaeE.Orden)
            {
                case 1:
                    oSisCorreoDestinatarioMaeE.CodLista = Convert.ToString(dr["cod_lista"] + "");
                    oSisCorreoDestinatarioMaeE.SecLista = Convert.ToInt32(dr["sec_lista"]);
                    oSisCorreoDestinatarioMaeE.CodTipo = Convert.ToInt32(dr["cod_tipo"]);
                    oSisCorreoDestinatarioMaeE.DscDestinatario = Convert.ToString(dr["dsc_destinatario"] + "");
                    oSisCorreoDestinatarioMaeE.FlgRegistro = Convert.ToBoolean(dr["flg_registro"]);
                    oSisCorreoDestinatarioMaeE.IdeCorreo = Convert.ToInt32(dr["ide_correo"]);
                    oSisCorreoDestinatarioMaeE.NombCodTipo = Convert.ToString(dr["nomb_codTipo"]);
                    break;
                case 2:
                    oSisCorreoDestinatarioMaeE.CodLista = Convert.ToString(dr["cod_lista"] + "");
                    oSisCorreoDestinatarioMaeE.SecLista = Convert.ToInt32(dr["sec_lista"]);
                    oSisCorreoDestinatarioMaeE.CodTipo = Convert.ToInt32(dr["cod_tipo"]);
                    oSisCorreoDestinatarioMaeE.DscDestinatario = Convert.ToString(dr["dsc_destinatario"] + "");
                    oSisCorreoDestinatarioMaeE.FlgRegistro = Convert.ToBoolean(dr["flg_registro"]);
                    oSisCorreoDestinatarioMaeE.IdeCorreo = Convert.ToInt32(dr["ide_correo"]);
                    break;
                case 3:
                    oSisCorreoDestinatarioMaeE.CodLista = Convert.ToString(dr["cod_lista"] + "");
                    break;
                case 4:
                    oSisCorreoDestinatarioMaeE.DscDestinatario = Convert.ToString(dr["dsc_destinatario"] + "");
                    break;
            }

            return oSisCorreoDestinatarioMaeE;
        }

        public List<SisCorreoDestinatarioMaeE> Sp_SisCorreodestinatarioMae_Consulta(SisCorreoDestinatarioMaeE pSisCorreoDestinatarioMaeE)
        {
            List<SisCorreoDestinatarioMaeE> oListar = new List<SisCorreoDestinatarioMaeE>();
            SisCorreoDestinatarioMaeE oSisCorreoDestinatarioMaeE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_SisCorreodestinatarioMae_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_correo", pSisCorreoDestinatarioMaeE.IdeCorreo);
                    cmd.Parameters.AddWithValue("@cod_lista", pSisCorreoDestinatarioMaeE.CodLista);
                    cmd.Parameters.AddWithValue("@dsc_destinatario", pSisCorreoDestinatarioMaeE.DscDestinatario);
                    cmd.Parameters.AddWithValue("@nro_filas", pSisCorreoDestinatarioMaeE.NroFilas);
                    cmd.Parameters.AddWithValue("@orden", pSisCorreoDestinatarioMaeE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oSisCorreoDestinatarioMaeE = LlenarEntidad(dr, pSisCorreoDestinatarioMaeE);
                        oListar.Add(oSisCorreoDestinatarioMaeE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_SisCorreodestinatarioMae_Insert(SisCorreoDestinatarioMaeE pSisCorreoDestinatarioMaeE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SisCorreoDestinatarioMae_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_lista", pSisCorreoDestinatarioMaeE.CodLista);
                        cmd.Parameters.AddWithValue("@cod_tipo", pSisCorreoDestinatarioMaeE.CodTipo);
                        cmd.Parameters.AddWithValue("@dsc_destinatario", pSisCorreoDestinatarioMaeE.DscDestinatario);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_correo", ParameterDirection.InputOutput, SqlDbType.Int, 8, pSisCorreoDestinatarioMaeE.IdeCorreo.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pSisCorreoDestinatarioMaeE.IdeCorreo = Convert.ToInt32(cmd.Parameters["@ide_correo"].Value);
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


        public bool Sp_SisCorreodestinatarioMae_Update(SisCorreoDestinatarioMaeE pSisCorreoDestinatarioMaeE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SisCorreodestinatarioMae_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_tipo", pSisCorreoDestinatarioMaeE.CodTipo);
                        cmd.Parameters.AddWithValue("@dsc_destinatario", pSisCorreoDestinatarioMaeE.DscDestinatario);
                        cmd.Parameters.AddWithValue("@cod_lista", pSisCorreoDestinatarioMaeE.CodLista);
                        cmd.Parameters.AddWithValue("@flg_registro", pSisCorreoDestinatarioMaeE.FlgRegistro);
                        cmd.Parameters.AddWithValue("@ide_correo", pSisCorreoDestinatarioMaeE.IdeCorreo);
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

        public bool Sp_SisCorreodestinatarioMae_UpdatexCampo(SisCorreoDestinatarioMaeE pSisCorreoDestinatarioMaeE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SisCorreodestinatarioMae_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_correo", pSisCorreoDestinatarioMaeE.IdeCorreo);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pSisCorreoDestinatarioMaeE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pSisCorreoDestinatarioMaeE.Campo);
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


        public bool Sp_SisCorreodestinatarioMae_Delete(SisCorreoDestinatarioMaeE pSisCorreoDestinatarioMaeE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SisCorreodestinatarioMae_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_correo", pSisCorreoDestinatarioMaeE.IdeCorreo);
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
