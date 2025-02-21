/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using Ent.Sql.ClinicaE.ContratosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultoriocalendarioMaeAD
    {

        private HisContratoconsultoriocalendarioMaeE LlenarEntidad(IDataReader dr,
                                  HisContratoconsultoriocalendarioMaeE pHisContratoconsultoriocalendarioMaeE)
        {
            HisContratoconsultoriocalendarioMaeE oHisContratoconsultoriocalendarioMaeE = new HisContratoconsultoriocalendarioMaeE();
            switch (pHisContratoconsultoriocalendarioMaeE.Orden)
            {
                case 1:
                    oHisContratoconsultoriocalendarioMaeE.HoraInicio = Convert.ToString(dr["hora_inicio"]);
                    oHisContratoconsultoriocalendarioMaeE.HoraFin = Convert.ToString(dr["hora_fin"]);
                    oHisContratoconsultoriocalendarioMaeE.Dia = Convert.ToInt32(dr["dia"]);
                    oHisContratoconsultoriocalendarioMaeE.EstCalendario = Convert.ToString(dr["est_calendario"]);
                    oHisContratoconsultoriocalendarioMaeE.IDCalendario = Convert.ToInt32(dr["ide_calendario"]);
                    break;
            }
            return oHisContratoconsultoriocalendarioMaeE;
        }

        public List<HisContratoconsultoriocalendarioMaeE> Sp_HisContratoconsultoriocalendarioMae_Consulta(HisContratoconsultoriocalendarioMaeE pHisContratoconsultoriocalendarioMaeE)
        {
            List<HisContratoconsultoriocalendarioMaeE> oListar = new List<HisContratoconsultoriocalendarioMaeE>();
            HisContratoconsultoriocalendarioMaeE oHisContratoconsultoriocalendarioMaeE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriocalendarioMae_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultoriocalendarioMaeE.IDCalendario);
                    cmd.Parameters.AddWithValue("@hora_inicio", pHisContratoconsultoriocalendarioMaeE.HoraInicio);
                    cmd.Parameters.AddWithValue("@hora_fin", pHisContratoconsultoriocalendarioMaeE.HoraFin);
                    cmd.Parameters.AddWithValue("@dia", pHisContratoconsultoriocalendarioMaeE.Dia);
                    cmd.Parameters.AddWithValue("@est_calendario", pHisContratoconsultoriocalendarioMaeE.EstCalendario);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultoriocalendarioMaeE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultoriocalendarioMaeE = LlenarEntidad(dr, pHisContratoconsultoriocalendarioMaeE);
                        oListar.Add(oHisContratoconsultoriocalendarioMaeE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
