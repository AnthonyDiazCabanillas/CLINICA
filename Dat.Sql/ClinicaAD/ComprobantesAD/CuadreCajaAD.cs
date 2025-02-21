using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Ent.Sql.ClinicaE.ComprobantesE;

namespace Dat.Sql.ClinicaAD.ComprobantesAD
{
    public class CuadreCajaAD
    {

        public bool Sp_CuadreCajaOnline_Update(ref CuadreCajaE pCuadreCajaE)
        {
            bool xResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_CuadreCajaOnline_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodComprobante", pCuadreCajaE.CodComprobante);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        xResult = true;
                        cnn.Close();
                        cmd.Dispose();
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
