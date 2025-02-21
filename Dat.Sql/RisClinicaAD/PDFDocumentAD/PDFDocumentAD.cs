using Ent.Sql.RisClinicaE.PDFDocumentE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.RisClinicaAD.PDFDocumentAD
{
    public class PDFDocumentAD
    {
        private PDFDocumentE LlenarEntidad(IDataReader dr,
                                  PDFDocumentE pPDFDOCUMENTE)
        {
            PDFDocumentE oPDFDOCUMENTE = new PDFDocumentE();
            switch (pPDFDOCUMENTE.Orden)
            {
                case 1:
                    oPDFDOCUMENTE.SPSIDKEY = Convert.ToString(dr["SPS_ID_KEY"]);
                    oPDFDOCUMENTE.PDFDATE = Convert.ToString(dr["PDF_DATE"]);
                    oPDFDOCUMENTE.DESCRIPTION = Convert.ToString(dr["DESCRIPTION"]);
                    oPDFDOCUMENTE.CONTENTS = (byte[])(dr["CONTENTS"]);
                    oPDFDOCUMENTE.ORDERPLACER = Convert.ToString(dr["ORDERPLACER"]);
                    oPDFDOCUMENTE.DOCEXTENSION = Convert.ToString(dr["DOC_EXTENSION"]);
                    oPDFDOCUMENTE.PDFTIME = Convert.ToString(dr["PDF_TIME"]);
                    oPDFDOCUMENTE.CODMEDICO = Convert.ToString(dr["CODMEDICO"]);
                    oPDFDOCUMENTE.VERSION = Convert.ToInt32(dr["VERSION"]);
                    oPDFDOCUMENTE.ESTADO = Convert.ToInt32(dr["ESTADO"]);
                    break; /*byte[]*/
                case 2:
                    oPDFDOCUMENTE.CODMEDICO = Convert.ToString(dr["CODMEDICO"]);
                    oPDFDOCUMENTE.SPSIDKEY = Convert.ToString(dr["SPS_ID_KEY"]);
                    oPDFDOCUMENTE.PDFDATE = Convert.ToString(dr["PDF_DATE"]);
                    oPDFDOCUMENTE.DESCRIPTION = Convert.ToString(dr["DESCRIPTION"]);
                    oPDFDOCUMENTE.CONTENTS = (byte[])(dr["CONTENTS"]);
                    oPDFDOCUMENTE.ORDERPLACER = Convert.ToString(dr["ORDERPLACER"]);
                    oPDFDOCUMENTE.DOCEXTENSION = Convert.ToString(dr["DOC_EXTENSION"]);
                    oPDFDOCUMENTE.VERSION = Convert.ToInt32(dr["VERSION"]);
                    oPDFDOCUMENTE.ESTADO = Convert.ToInt32(dr["ESTADO"]);
                    oPDFDOCUMENTE.PDFTIME = Convert.ToString(dr["PDF_TIME"]);
                    break;
            }
            return oPDFDOCUMENTE;
        }

        public List<PDFDocumentE> Sp_PDFDOCUMENT_Consulta(PDFDocumentE pPDFDOCUMENTE)
        {
            List<PDFDocumentE> oListar = new List<PDFDocumentE>();
            PDFDocumentE oPDFDOCUMENTE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_PDFDOCUMENT_Consulta", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@busca", pPDFDOCUMENTE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pPDFDOCUMENTE.Campo);
                    cmd.Parameters.AddWithValue("@numerofilas", pPDFDOCUMENTE.NumeroFilas);
                    cmd.Parameters.AddWithValue("@orden", pPDFDOCUMENTE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oPDFDOCUMENTE = LlenarEntidad(dr, pPDFDOCUMENTE);
                        oListar.Add(oPDFDOCUMENTE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_PDFDOCUMENT_Insert(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PDFDOCUMENT_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@SPS_ID_KEY", pPDFDOCUMENTE.SPSIDKEY);
                        cmd.Parameters.AddWithValue("@PDF_DATE", pPDFDOCUMENTE.PDFDATE);
                        cmd.Parameters.AddWithValue("@DESCRIPTION", pPDFDOCUMENTE.DESCRIPTION);
                        cmd.Parameters.AddWithValue("@CONTENTS", pPDFDOCUMENTE.CONTENTS);
                        cmd.Parameters.AddWithValue("@ORDERPLACER", pPDFDOCUMENTE.ORDERPLACER);
                        cmd.Parameters.AddWithValue("@DOC_EXTENSION", pPDFDOCUMENTE.DOCEXTENSION);
                        cmd.Parameters.AddWithValue("@PDF_TIME", pPDFDOCUMENTE.PDFTIME);
                        cmd.Parameters.AddWithValue("@CODMEDICO", pPDFDOCUMENTE.CODMEDICO);
                        cmd.Parameters.AddWithValue("@VERSION", pPDFDOCUMENTE.VERSION);
                        cmd.Parameters.AddWithValue("@ESTADO", pPDFDOCUMENTE.ESTADO);
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


        public bool Sp_PDFDOCUMENT_Update(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PDFDOCUMENT_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@SPS_ID_KEY", pPDFDOCUMENTE.SPSIDKEY);
                        cmd.Parameters.AddWithValue("@PDF_DATE", pPDFDOCUMENTE.PDFDATE);
                        cmd.Parameters.AddWithValue("@DESCRIPTION", pPDFDOCUMENTE.DESCRIPTION);
                        cmd.Parameters.AddWithValue("@CONTENTS", pPDFDOCUMENTE.CONTENTS);
                        cmd.Parameters.AddWithValue("@ORDERPLACER", pPDFDOCUMENTE.ORDERPLACER);
                        cmd.Parameters.AddWithValue("@DOC_EXTENSION", pPDFDOCUMENTE.DOCEXTENSION);
                        cmd.Parameters.AddWithValue("@PDF_TIME", pPDFDOCUMENTE.PDFTIME);
                        cmd.Parameters.AddWithValue("@CODMEDICO", pPDFDOCUMENTE.CODMEDICO);
                        cmd.Parameters.AddWithValue("@VERSION", pPDFDOCUMENTE.VERSION);
                        cmd.Parameters.AddWithValue("@ESTADO", pPDFDOCUMENTE.ESTADO);
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


        public bool Sp_PDFDOCUMENT_UpdatexCampo(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PDFDOCUMENT_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pPDFDOCUMENTE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pPDFDOCUMENTE.Campo);
                        cmd.Parameters.AddWithValue("@orderplacer", pPDFDOCUMENTE.ORDERPLACER);
                        cmd.Parameters.AddWithValue("@spsidkey", pPDFDOCUMENTE.SPSIDKEY);

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
