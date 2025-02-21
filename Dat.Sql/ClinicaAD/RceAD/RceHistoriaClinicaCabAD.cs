using Ent.Sql.ClinicaE.RceE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RceAD
{
    public class RceHistoriaClinicaCabAD
    {
       
        public int Sp_RceHistoriaClinicaCab_ObtenerID(RceHistoriaClinicaCabE pRceHistoriaClinicaCabE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RceHistoriaClinicaCab_ObtenerID", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_atencion", pRceHistoriaClinicaCabE.cod_atencion);
                        cmd.Parameters.AddWithValue("@cod_paciente", pRceHistoriaClinicaCabE.cod_paciente);
                        cmd.Parameters.Add(new SqlParameter("@ide_historia", SqlDbType.Int) { Direction = ParameterDirection.Output, IsNullable = true });
                        cnn.Open();

                        cmd.ExecuteNonQuery();
                        int Resultado = (int)cmd.Parameters["@ide_historia"].Value;

                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return Resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
