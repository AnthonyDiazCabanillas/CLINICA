#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : LiqxtercerosReciboImgAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase LiqxtercerosReciboImgAD 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Ent.Sql.ClinicaE.TerceroE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.MedicosE;

namespace Dat.Sql.ClinicaAD.TerceroAD
{
    public class LiqxtercerosReciboImgAD
    {
        private LiqxtercerosReciboImgE LlenarEntidad(IDataReader dr,
                               LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            LiqxtercerosReciboImgE oLiqxtercerosReciboImgE = new LiqxtercerosReciboImgE();
            switch (pLiqxtercerosReciboImgE.Orden)
            {
                case 1:
                    oLiqxtercerosReciboImgE.NmrRecibo = Convert.ToString(dr["Nmr_Recibo"]);
                    oLiqxtercerosReciboImgE.ImgRecibo = Convert.ToString(dr["Img_Recibo"]);
                    oLiqxtercerosReciboImgE.NmbArchivo = Convert.ToString(dr["Nmb_Archivo"]);
                    oLiqxtercerosReciboImgE.Estado = Convert.ToBoolean(dr["Estado"]);
                    oLiqxtercerosReciboImgE.IDLiqxtercerosReciboImg = Convert.ToInt32(dr["ID_LiqxTerceros_Recibo_Img"]);
                    break;
            }

            return oLiqxtercerosReciboImgE;
        }

        public List<LiqxtercerosReciboImgE> Sp_LiqxtercerosReciboImg_Consulta(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            List<LiqxtercerosReciboImgE> oListar = new List<LiqxtercerosReciboImgE>();
            LiqxtercerosReciboImgE oLiqxtercerosReciboImgE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosReciboImg_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo_Img", pLiqxtercerosReciboImgE.IDLiqxtercerosReciboImg);
                    cmd.Parameters.AddWithValue("@orden", pLiqxtercerosReciboImgE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oLiqxtercerosReciboImgE = LlenarEntidad(dr, pLiqxtercerosReciboImgE);
                        oListar.Add(oLiqxtercerosReciboImgE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public int Sp_LiqxtercerosReciboImg_Insert(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            {
                int result = 0;
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosReciboImg_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@Nmr_Recibo", pLiqxtercerosReciboImgE.NmrRecibo);
                        cmd.Parameters.AddWithValue("@Img_Recibo", pLiqxtercerosReciboImgE.ImgRecibo);
                        cmd.Parameters.AddWithValue("@Nmb_Archivo", pLiqxtercerosReciboImgE.NmbArchivo);
                        cmd.Parameters.AddWithValue("@Estado", pLiqxtercerosReciboImgE.Estado);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ID_LiqxTerceros_Recibo_Img", ParameterDirection.InputOutput, SqlDbType.Int, 8, pLiqxtercerosReciboImgE.IDLiqxtercerosReciboImg.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return result = Convert.ToInt32(cmd.Parameters["@ID_LiqxTerceros_Recibo_Img"].Value); }
                        else
                        { return result = 0; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_LiqxtercerosReciboImg_Update(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosReciboImg_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@Nmr_Recibo", pLiqxtercerosReciboImgE.NmrRecibo);
                        cmd.Parameters.AddWithValue("@Img_Recibo", pLiqxtercerosReciboImgE.ImgRecibo);
                        cmd.Parameters.AddWithValue("@Nmb_Archivo", pLiqxtercerosReciboImgE.NmbArchivo);
                        cmd.Parameters.AddWithValue("@Estado", pLiqxtercerosReciboImgE.Estado);
                        cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo_Img", pLiqxtercerosReciboImgE.IDLiqxtercerosReciboImg);
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


        public bool Sp_LiqxtercerosReciboImg_UpdatexCampo(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosReciboImg_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo_Img", pLiqxtercerosReciboImgE.IDLiqxtercerosReciboImg);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pLiqxtercerosReciboImgE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pLiqxtercerosReciboImgE.Campo);
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