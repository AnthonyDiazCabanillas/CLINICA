using Ent.Sql.LogisticaE.ProductosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.LogisticaAD.VentaxFirmaAD
{
    public  class VentaxFirmaAD
    {
        public static bool Sp_VentaxFirma_Update(string pIdPK, byte[] pArchivo, int pOrden)
        {
            int exito = 0;
            bool xResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("logistica.dbo.Sp_VentaxFirma_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_PK", pIdPK);
                        cmd.Parameters.AddWithValue("@Archivo", pArchivo);
                        cmd.Parameters.AddWithValue("@Orden", pOrden);
                        cnn.Open();
                        exito = cmd.ExecuteNonQuery();
                        xResult = (exito >= 1 ? true : false);
                        cmd.Dispose();
                        cnn.Close();
                        cnn.Close();
                    }
                }

                return xResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool Sp_VentaxFirma_Insert(string pCodVenta, byte[] pImagen, int pCodUser)
        {
            int exito = 0;
            bool xResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_VentaxFirma_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codventa", pCodVenta);
                        cmd.Parameters.AddWithValue("@imagen", pImagen);
                        cmd.Parameters.AddWithValue("@coduser", pCodUser);
                        cnn.Open();
                        exito = cmd.ExecuteNonQuery();
                        xResult = (exito >= 1 ? true : false);
                        cmd.Dispose();
                        cnn.Close();
                        cnn.Close();
                    }
                }

                return xResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
