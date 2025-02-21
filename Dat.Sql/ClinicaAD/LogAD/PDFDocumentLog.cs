using Ent.Sql.LogisticaE.ConveniosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.LogAD
{
    public class PDFDocumentLog
    {
        public bool Sp_Pdf_Document_Log_Insert(string pCodPresotor, string pVersion)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Pdf_Document_Log_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codpresotor", pCodPresotor);
                        cmd.Parameters.AddWithValue("@version", pVersion);
                        //cmd.Parameters.Add(VariablesGlobales.ParametroSql("@idconvenio", ParameterDirection.InputOutput, SqlDbType.Int, 8, pConveniosE.Idconvenio.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            //pConveniosE.Idconvenio = Convert.ToInt32(cmd.Parameters["@idconvenio"].Value);
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
