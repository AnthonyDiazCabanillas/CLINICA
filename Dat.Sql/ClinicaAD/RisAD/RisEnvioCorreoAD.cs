using Ent.Sql.ClinicaE.RisE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RisAD
{
    public class RisEnvioCorreoAD
    {
        public void Sp_Ris_EnvioCorreo(RisEnvioCorreoE RisEnvioCorreo)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ris_EnvioCorreo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@tipocorreo", RisEnvioCorreo.TipoCorreo);
                        cmd.Parameters.AddWithValue("@tipoerror", RisEnvioCorreo.TipoError);
                        cmd.Parameters.AddWithValue("@codpaciente", RisEnvioCorreo.CodigoPacienteEnvio);
                        cmd.Parameters.AddWithValue("@docpaciente", RisEnvioCorreo.DocPacienteEnvio);
                        cmd.Parameters.AddWithValue("@exsubject", RisEnvioCorreo.exSubject);
                        cmd.Parameters.AddWithValue("@exbody", RisEnvioCorreo.exBody);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}
