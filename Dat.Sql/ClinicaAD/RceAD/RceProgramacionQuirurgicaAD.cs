//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         25/07/2024     HVIDAL       REQ 2024-011473 AGENDA DE PROCEDIMIENTOS
//****************************************************************************************
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
    public class RceProgramacionQuirurgicaAD
    {
        public int Sp_ProgramacionQuirurgicaDet_ObtenerId(RceProgramacionQuirurgicaE pRceProgramacionQuirurgicaE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_ProgramacionQuirurgicaDet_ObtenerId", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_atencion", pRceProgramacionQuirurgicaE.cod_atencion);
                        cmd.Parameters.AddWithValue("@cod_cpt", pRceProgramacionQuirurgicaE.cod_cpt);
                        cmd.Parameters.Add(new SqlParameter("@ID_PQ_Det", SqlDbType.Int) { Direction = ParameterDirection.Output, IsNullable = true });
                        cnn.Open();

                        cmd.ExecuteNonQuery();
                        int Resultado = (int)cmd.Parameters["@ID_PQ_Det"].Value;

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
