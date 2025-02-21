using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.HospitalAD
{
    public class AseguradorasAD
    {
        private AseguradorasE LlenarEntidad(IDataReader dr, AseguradorasE pAseguradorasE)
        {
            AseguradorasE oAseguradorasE = new AseguradorasE();
            switch (pAseguradorasE.Orden)
            {
                case 1:
                    {
                        oAseguradorasE.Codaseguradora = Convert.ToString(dr["codaseguradora"]);
                        oAseguradorasE.Dscaseguradora = Convert.ToString(dr["nombreaseguradora"]);
                        break;
                    }
            }
            return oAseguradorasE;
        }

        public List<AseguradorasE> Sp_Aseguradoras_ConsultaV2(AseguradorasE pAseguradorasE)
        {
            List<AseguradorasE> oListar = new List<AseguradorasE>();
            AseguradorasE oAseguradorasE = new AseguradorasE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Aseguradoras_ConsultaV2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pAseguradorasE.Orden);
                    cmd.Parameters.AddWithValue("@dscaseguradora", pAseguradorasE.Dscaseguradora);
                    cmd.Parameters.AddWithValue("@nro_filas", pAseguradorasE.Nrofila);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oAseguradorasE = LlenarEntidad(dr, pAseguradorasE);
                        oListar.Add(oAseguradorasE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
