using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Ent.Sql.SeguridadE.SeguridadE;

namespace Dat.Sql.SeguridadAD.SeguridadAD
{
    public class SegModuloAD
    {

        private SegModuloE LlenarEntidad(IDataReader dr,
                                       SegModuloE pSegModuloE)
        {
            SegModuloE oSegModuloE = new SegModuloE();
            switch (pSegModuloE.Orden)
            {
                case 1:
                    oSegModuloE.TxtModulo = (string)dr["txt_modulo"];
                    oSegModuloE.IdeModuloSup = Convert.ToInt32(dr["ide_modulo_sup"]);
                    oSegModuloE.FlgActivo = (string)dr["flg_activo"];
                    oSegModuloE.DscIcono = (string)(dr["dsc_icono"]);
                    oSegModuloE.DscRuta = (string)(dr["dsc_ruta"]);
                    oSegModuloE.IdeModulo = Convert.ToInt32(dr["ide_modulo"]);
                    break;
            }

            return oSegModuloE;
        }

        public List<SegModuloE> Sp_Seg_Modulo_Consultar(SegModuloE pSegModuloE)
        {
            List<SegModuloE> oListar = new List<SegModuloE>();
            SegModuloE oSegModuloE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Seg_Modulo_Consultar", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    //cmd.Parameters.AddWithValue("@ide_modulo", pSegModuloE.IdeModulo);
                    cmd.Parameters.AddWithValue("@ide_modulo_sup", pSegModuloE.IdeModuloSup);
                    cmd.Parameters.AddWithValue("@flg_activo", pSegModuloE.FlgActivo);
                    cmd.Parameters.AddWithValue("@orden", pSegModuloE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oSegModuloE = LlenarEntidad(dr, pSegModuloE);
                        oListar.Add(oSegModuloE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_SEGMODULO_Insert(SegModuloE pSegModuloE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGMODULO_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@txt_modulo", pSegModuloE.TxtModulo);
                        cmd.Parameters.AddWithValue("@ide_modulo_sup", pSegModuloE.IdeModuloSup);
                        cmd.Parameters.AddWithValue("@flg_activo", pSegModuloE.FlgActivo);
                        cmd.Parameters.AddWithValue("@dsc_icono", pSegModuloE.DscIcono);
                        cmd.Parameters.AddWithValue("@dsc_ruta", pSegModuloE.DscRuta);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_modulo", ParameterDirection.InputOutput, SqlDbType.Int, 8, pSegModuloE.IdeModulo.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pSegModuloE.IdeModulo = Convert.ToInt32(cmd.Parameters["@ide_modulo"].Value);
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


        public bool Sp_SEGMODULO_Update(SegModuloE pSegModuloE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGMODULO_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@txt_modulo", pSegModuloE.TxtModulo);
                        cmd.Parameters.AddWithValue("@ide_modulo_sup", pSegModuloE.IdeModuloSup);
                        cmd.Parameters.AddWithValue("@flg_activo", pSegModuloE.FlgActivo);
                        cmd.Parameters.AddWithValue("@dsc_icono", pSegModuloE.DscIcono);
                        cmd.Parameters.AddWithValue("@dsc_ruta", pSegModuloE.DscRuta);
                        cmd.Parameters.AddWithValue("@ide_modulo", pSegModuloE.IdeModulo);
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


        public bool Sp_SEGMODULO_UpdatexCampo(SegModuloE pSegModuloE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGMODULO_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_modulo", pSegModuloE.IdeModulo);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pSegModuloE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pSegModuloE.Campo);
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


        public bool Sp_SEGMODULO_Delete(SegModuloE pSegModuloE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnSeguridad))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_SEGMODULO_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_modulo", pSegModuloE.IdeModulo);
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