using Ent.Sql.ClinicaE.RisE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RisAD
{
    public class RisOraclePDFDocument
    {

        public bool Sp_RisOraclePdfDocument_Insert(RisOraclePDFDocumentE pRisOraclePdfDocumentE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_OraclePDFDocument_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@sps_id_key", pRisOraclePdfDocumentE.SpsIdKey);
                        cmd.Parameters.AddWithValue("@pdf_date", Convert.ToDateTime(pRisOraclePdfDocumentE.PdfDate));
                        cmd.Parameters.AddWithValue("@description", pRisOraclePdfDocumentE.Description);
                        cmd.Parameters.AddWithValue("@contents", pRisOraclePdfDocumentE.Contents);
                        cmd.Parameters.AddWithValue("@codpresotor", pRisOraclePdfDocumentE.Codpresotor);
                        cmd.Parameters.AddWithValue("@doc_extension", pRisOraclePdfDocumentE.DocExtension);
                        cmd.Parameters.AddWithValue("@pdf_time", Convert.ToDateTime (pRisOraclePdfDocumentE.PdfTime));
                        cmd.Parameters.AddWithValue("@colmedico", pRisOraclePdfDocumentE.Colmedico);
                        cmd.Parameters.AddWithValue("@version", pRisOraclePdfDocumentE.Version);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
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

        public bool Sp_RisCopiar_PDF(RisOraclePDFDocumentE pRisOraclePdfDocumentE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_Copiar_PDF", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codpresotor", pRisOraclePdfDocumentE.Codpresotor);
                        cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(pRisOraclePdfDocumentE.PdfDate));
                        cmd.Parameters.AddWithValue("@cmp", pRisOraclePdfDocumentE.Colmedico);
                        cmd.Parameters.AddWithValue("@pdf", pRisOraclePdfDocumentE.Contents);
                        cmd.Parameters.AddWithValue("@version", pRisOraclePdfDocumentE.Version);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
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
    }
}
