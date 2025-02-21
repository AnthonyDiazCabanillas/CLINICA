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
    public class HisContratoconsultoriobeneficioMaeAD
    {
        private HisContratoconsultoriobeneficioMaeE LlenarEntidad(IDataReader dr,
                                  HisContratoconsultoriobeneficioMaeE pHisContratoconsultoriobeneficioMaeE)
        {
            HisContratoconsultoriobeneficioMaeE oHisContratoconsultoriobeneficioMaeE = new HisContratoconsultoriobeneficioMaeE();
            switch (pHisContratoconsultoriobeneficioMaeE.Orden)
            {
                case 1:
                    oHisContratoconsultoriobeneficioMaeE.DscBeneficio = Convert.ToString(dr["nombre"]);
                    oHisContratoconsultoriobeneficioMaeE.TipDescuento = Convert.ToString(dr["tip_descuento"]);
                    oHisContratoconsultoriobeneficioMaeE.TipCantidad = Convert.ToString(dr["tip_cantidad"]);
                    oHisContratoconsultoriobeneficioMaeE.CntDescuento = Convert.ToInt32(dr["cnt_descuento"]);
                    oHisContratoconsultoriobeneficioMaeE.EstBeneficio = Convert.ToString(dr["est_beneficio"]);
                    oHisContratoconsultoriobeneficioMaeE.HorasAplicar = Convert.ToString(dr["horas_aplicar"]);
                    oHisContratoconsultoriobeneficioMaeE.IDBeneficio = Convert.ToInt32(dr["ide_beneficio"]);
                    break;
            }

            return oHisContratoconsultoriobeneficioMaeE;
        }

        public List<HisContratoconsultoriobeneficioMaeE> Sp_HisContratoconsultoriocalendarioMae_Consulta(HisContratoconsultoriobeneficioMaeE pHisContratoconsultoriobeneficioMaeE)
        {
            List<HisContratoconsultoriobeneficioMaeE> oListar = new List<HisContratoconsultoriobeneficioMaeE>();
            HisContratoconsultoriobeneficioMaeE oHisContratoconsultoriobeneficioMaeE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficioMae_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficioMaeE.IDBeneficio);
                    cmd.Parameters.AddWithValue("@buscar", pHisContratoconsultoriobeneficioMaeE.Buscar);
                    cmd.Parameters.AddWithValue("@tip_descuento", pHisContratoconsultoriobeneficioMaeE.TipDescuento);
                    cmd.Parameters.AddWithValue("@tip_cantidad", pHisContratoconsultoriobeneficioMaeE.TipCantidad);
                    cmd.Parameters.AddWithValue("@cnt_descuento", pHisContratoconsultoriobeneficioMaeE.CntDescuento);
                    cmd.Parameters.AddWithValue("@est_beneficio", pHisContratoconsultoriobeneficioMaeE.EstBeneficio);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultoriobeneficioMaeE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultoriobeneficioMaeE = LlenarEntidad(dr, pHisContratoconsultoriobeneficioMaeE);
                        oListar.Add(oHisContratoconsultoriobeneficioMaeE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
