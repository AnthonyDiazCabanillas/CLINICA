using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RceAD
{
    public class RceRecetaImagenDetEstadoRisPacsAD
    {
        public bool Sp_RceRecetaImagenDetEstadoRisPacs_Update(string pSpsIdKey, string pEventTypeId)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RceRecetaImagenDetEstadoRisPacs_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_receta_det", "");
                        cmd.Parameters.AddWithValue("@sps_id", pSpsIdKey);
                        cmd.Parameters.AddWithValue("@valor_nuevo", pEventTypeId);
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
