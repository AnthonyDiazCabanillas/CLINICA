using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class PresotorxDimensionesAD
    {
        public bool Sp_Sb1Presotorxdimension_Insert(PresotorxDimensionesE pPresotorxDimensionesE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Sb1Presotorxdimension_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_presotor", pPresotorxDimensionesE.CodPresotor);
                        cmd.Parameters.AddWithValue("@cod_dimension1", pPresotorxDimensionesE.CodDimension1);
                        cmd.Parameters.AddWithValue("@cod_dimension2", pPresotorxDimensionesE.CodDimension2);
                        cmd.Parameters.AddWithValue("@cod_dimension3", pPresotorxDimensionesE.CodDimension3);
                        cmd.Parameters.AddWithValue("@cod_dimension4", pPresotorxDimensionesE.CodDimension4);
                        cmd.Parameters.AddWithValue("@usr_registro", pPresotorxDimensionesE.UsrRegistro);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_presotordim", ParameterDirection.InputOutput, SqlDbType.Int, 8, pPresotorxDimensionesE.IdePresotordim.ToString()));
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        pPresotorxDimensionesE.IdePresotordim = (int)cmd.Parameters["@ide_presotordim"].Value;
                        if (pPresotorxDimensionesE.IdePresotordim != 0)
                        { return true; }
                        else
                        { return false; }
                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            { return false; }
        }
    }
}
