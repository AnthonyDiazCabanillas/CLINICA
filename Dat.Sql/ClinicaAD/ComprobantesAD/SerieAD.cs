using Ent.Sql.ClinicaE.ComprobantesE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.ComprobantesAD
{
    public class SerieAD
    {
        private SerieE LlenarEntidad(IDataReader dr,
                                       SerieE pSerieE)
        {
            SerieE oSerieE = new SerieE();
            switch (pSerieE.Orden)
            {
                case 0:
                    oSerieE.Tiposerie = Convert.ToString(dr["tiposerie"]);
                    oSerieE.Serie = Convert.ToString(dr["serie"]);
                    oSerieE.Correlativo = Convert.ToString(dr["correlativo"]);
                    oSerieE.Codlocal = Convert.ToString(dr["codlocal"]);
                    oSerieE.Codcentro = Convert.ToString(dr["codcentro"]);
                    oSerieE.Tipocomprobante = Convert.ToString(dr["tipocomprobante"]);
                    oSerieE.FlgElectronico = Convert.ToString(dr["flg_electronico"]);
                    oSerieE.FlgOtorgar = Convert.ToInt32(dr["flg_otorgar"]);
                    oSerieE.FormatoElectronico = Convert.ToString(dr["formato_electronico"]);
                    break;
            }

            return oSerieE;
        }

        public List<SerieE> Sp_Serie_Consulta(SerieE pSerieE)
        {
            List<SerieE> oListar = new List<SerieE>();
            SerieE oSerieE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Serie_ConsultaV2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pSerieE.Buscar);
                    cmd.Parameters.AddWithValue("@numerolineas", pSerieE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pSerieE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oSerieE = LlenarEntidad(dr, pSerieE);
                        oListar.Add(oSerieE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
