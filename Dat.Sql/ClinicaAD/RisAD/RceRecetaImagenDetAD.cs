using Ent.Sql.ClinicaE.RceE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RisAD
{
    public class RceRecetaImagenDetAD
    {
        public bool Sp_RceRecetaImagenDet_UpdatexCampo(RceRecetaImagenDetE pRceRecetaImagenDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RceRecetaImagenDet_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_recetadet", pRceRecetaImagenDetE.IdeRecetadet);
                        cmd.Parameters.AddWithValue("@campo", pRceRecetaImagenDetE.Campo);
                        cmd.Parameters.AddWithValue("@valor_nuevo", pRceRecetaImagenDetE.NuevoValor);
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
