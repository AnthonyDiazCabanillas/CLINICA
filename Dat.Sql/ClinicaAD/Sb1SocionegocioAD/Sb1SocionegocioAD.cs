using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.Sb1SocionegocioE;

namespace Dat.Sql.ClinicaAD.Sb1SocionegocioAD
{
    public class Sb1SocionegocioAD
    {

        private Sb1SocionegocioE LlenarEntidad(IDataReader dr,
                                       Sb1SocionegocioE pSb1SocionegocioE)
        {
            Sb1SocionegocioE oSb1SocionegocioE = new Sb1SocionegocioE();
            switch (pSb1SocionegocioE.Orden)
            {
                case 1:
                    oSb1SocionegocioE.DscCardcodeOld = Convert.ToString(dr["dsc_cardcode_old"]);
                    oSb1SocionegocioE.DscCardcodeNew = Convert.ToString(dr["dsc_cardcode_new"]);
                    oSb1SocionegocioE.FecRegistro = Convert.ToDateTime(dr["fec_registro"]);
                    oSb1SocionegocioE.IdeSocionegocio = Convert.ToInt32(dr["ide_socionegocio"]);
                    break;
                case 7:
                    oSb1SocionegocioE.Facturar = Convert.ToString(dr["facturar"]);
                    break;
            }

            return oSb1SocionegocioE;
        }

        public List<Sb1SocionegocioE> Sp_Sb1Socionegocio_Consulta(Sb1SocionegocioE pSb1SocionegocioE)
        {
            List<Sb1SocionegocioE> oListar = new List<Sb1SocionegocioE>();
            Sb1SocionegocioE oSb1SocionegocioE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("SB1_MaestroSocioNegocio_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pSb1SocionegocioE.Orden);
                    cmd.Parameters.AddWithValue("@cardcode", pSb1SocionegocioE.CarCode);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oSb1SocionegocioE = LlenarEntidad(dr, pSb1SocionegocioE);
                        oListar.Add(oSb1SocionegocioE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
