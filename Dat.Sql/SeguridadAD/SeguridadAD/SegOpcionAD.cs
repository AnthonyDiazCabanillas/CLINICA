using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Ent.Sql.SeguridadE.SeguridadE;

namespace Dat.Sql.SeguridadAD.SeguridadAD
{
    public class SegOpcionAD
    {
        private SegOpcionE LlenarEntidad(IDataReader dr,
                                       SegOpcionE pSegOpcionE)
        {
            SegOpcionE oSegOpcionE = new SegOpcionE();
            switch (pSegOpcionE.Orden)
            {
                case 1:
                case 4:
                    //oSegOpcionE.IdeModulo = Convert.ToInt32(dr["ide_modulo"]);
                    oSegOpcionE.TxtOpcion = Convert.ToString(dr["txt_opcion"]);
                    oSegOpcionE.CodOpcion = Convert.ToString(dr["cod_opcion"]);
                    oSegOpcionE.IdeOpcionSup = Convert.ToInt32(dr["ide_opcion_sup"]);
                    //oSegOpcionE.FecRegistro = Convert.ToDateTime(dr["fec_registro"]);
                    oSegOpcionE.DscOpcion = Convert.ToString(dr["dsc_opcion"]);
                    oSegOpcionE.DscIcono = Convert.ToString(dr["dsc_icono"]);
                    oSegOpcionE.DscRuta = Convert.ToString(dr["dsc_ruta"]);
                    oSegOpcionE.IdeOpcion = Convert.ToInt32(dr["ide_opcion"]);
                    break;

            }

            return oSegOpcionE;
        }

        public List<SegOpcionE> Sp_SegOpcion_Consulta(SegOpcionE pSegOpcionE)
        {
            List<SegOpcionE> oListar = new List<SegOpcionE>();
            SegOpcionE oSegOpcionE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_SegOpcion_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_opcion", pSegOpcionE.IdeOpcion);
                    cmd.Parameters.AddWithValue("@ide_opcion_sup", pSegOpcionE.IdeOpcionSup);
                    cmd.Parameters.AddWithValue("@ide_modulo", pSegOpcionE.IdeModulo);
                    cmd.Parameters.AddWithValue("@ide_modulo_sup", pSegOpcionE.IdeModuloSup);
                    cmd.Parameters.AddWithValue("@ide_usuario", pSegOpcionE.IdeUsuario);
                    cmd.Parameters.AddWithValue("@cod_opcion", pSegOpcionE.CodOpcion);
                    cmd.Parameters.AddWithValue("@orden", pSegOpcionE.Orden);

                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oSegOpcionE = LlenarEntidad(dr, pSegOpcionE);
                        oListar.Add(oSegOpcionE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_SEGOPCION_Insert(SegOpcionE pSegOpcionE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGOPCION_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_modulo", pSegOpcionE.IdeModulo);
                        cmd.Parameters.AddWithValue("@txt_opcion", pSegOpcionE.TxtOpcion);
                        cmd.Parameters.AddWithValue("@cod_opcion", pSegOpcionE.CodOpcion);
                        cmd.Parameters.AddWithValue("@ide_opcion_sup", pSegOpcionE.IdeOpcionSup);
                        cmd.Parameters.AddWithValue("@fec_registro", pSegOpcionE.FecRegistro);
                        cmd.Parameters.AddWithValue("@dsc_opcion", pSegOpcionE.DscOpcion);
                        cmd.Parameters.AddWithValue("@dsc_icono", pSegOpcionE.DscIcono);
                        cmd.Parameters.AddWithValue("@dsc_ruta", pSegOpcionE.DscRuta);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_opcion", ParameterDirection.InputOutput, SqlDbType.Int, 8, pSegOpcionE.IdeOpcion.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pSegOpcionE.IdeOpcion = Convert.ToInt32(cmd.Parameters["@ide_opcion"].Value);
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


        public bool Sp_SEGOPCION_Update(SegOpcionE pSegOpcionE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGOPCION_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_modulo", pSegOpcionE.IdeModulo);
                        cmd.Parameters.AddWithValue("@txt_opcion", pSegOpcionE.TxtOpcion);
                        cmd.Parameters.AddWithValue("@cod_opcion", pSegOpcionE.CodOpcion);
                        cmd.Parameters.AddWithValue("@ide_opcion_sup", pSegOpcionE.IdeOpcionSup);
                        cmd.Parameters.AddWithValue("@fec_registro", pSegOpcionE.FecRegistro);
                        cmd.Parameters.AddWithValue("@dsc_opcion", pSegOpcionE.DscOpcion);
                        cmd.Parameters.AddWithValue("@dsc_icono", pSegOpcionE.DscIcono);
                        cmd.Parameters.AddWithValue("@dsc_ruta", pSegOpcionE.DscRuta);
                        cmd.Parameters.AddWithValue("@ide_opcion", pSegOpcionE.IdeOpcion);
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


        public bool Sp_SEGOPCION_UpdatexCampo(SegOpcionE pSegOpcionE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGOPCION_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_opcion", pSegOpcionE.IdeOpcion);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pSegOpcionE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pSegOpcionE.Campo);
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


        public bool Sp_SEGOPCION_Delete(SegOpcionE pSegOpcionE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGOPCION_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_opcion", pSegOpcionE.IdeOpcion);
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