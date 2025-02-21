#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : DshPlanillaHMAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase DshPlanillaHMAD 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.DashboardE;
using Ent.Sql.ClinicaE.TerceroE;

namespace Dat.Sql.ClinicaAD.DashboardAD
{
    public class DshPlanillaHMAD
    {
        private DshPlanillaHME LlenarEntidad(IDataReader dr, DshPlanillaHME pHonorariosMedicosPlanillasE)
        {
            DshPlanillaHME oHonorariosMedicosPlanillasE = new DshPlanillaHME();
            switch (pHonorariosMedicosPlanillasE.Orden)
            {
                case 1:
                    {
                        oHonorariosMedicosPlanillasE.TipoLiquidacion = Convert.ToString(dr["TipoLiquidacion"]);
                        oHonorariosMedicosPlanillasE.Año = Convert.ToInt32(dr["Año"]);
                        oHonorariosMedicosPlanillasE.Mes = Convert.ToString(dr["Mes"]);
                        oHonorariosMedicosPlanillasE.Estado = Convert.ToString(dr["Estado"]);
                        oHonorariosMedicosPlanillasE.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                        oHonorariosMedicosPlanillasE.CntPorcentaje = Convert.ToDecimal(dr["Porcentaje"]);
                        oHonorariosMedicosPlanillasE.Total = Convert.ToDecimal(dr["Total"]);
                        
                        break;
                    }
                case 2:
                    {
                        oHonorariosMedicosPlanillasE.TipoLiquidacion = Convert.ToString(dr["TipoLiquidacion"]);
                        oHonorariosMedicosPlanillasE.Año = Convert.ToInt32(dr["Año"]);
                        oHonorariosMedicosPlanillasE.Mes = Convert.ToString(dr["Mes"]);
                        oHonorariosMedicosPlanillasE.Estado = Convert.ToString(dr["Estado"]);
                        oHonorariosMedicosPlanillasE.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                        oHonorariosMedicosPlanillasE.CntPorcentaje = Convert.ToDecimal(dr["Porcentaje"]);
                        oHonorariosMedicosPlanillasE.Total = Convert.ToDecimal(dr["Total"]);

                        break;
                    }
                case 3:
                    {
                        oHonorariosMedicosPlanillasE.TipoLiquidacion = Convert.ToString(dr["TipoPlanilla"]);
                        oHonorariosMedicosPlanillasE.Cantidad = Convert.ToDecimal(dr["Cantidad"]);
                        oHonorariosMedicosPlanillasE.CntPorcentaje = Convert.ToDecimal(dr["Porcentaje"]);
                        break;
                    }
            }
            return oHonorariosMedicosPlanillasE;
        }
        public List<DshPlanillaHME> Rp_Planilla_Consulta_Dashboard(DshPlanillaHME pHonorariosMedicosPlanillasE)
        {
            IDataReader dr;
            DshPlanillaHME? oHonorariosMedicosPlanillasE = null;
            List<DshPlanillaHME> oListar = new List<DshPlanillaHME>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Rp_Planilla_Consulta_Dashboard", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FechaIncio", pHonorariosMedicosPlanillasE.FechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", pHonorariosMedicosPlanillasE.FechaFin);
                        cmd.Parameters.AddWithValue("@Buscar", pHonorariosMedicosPlanillasE.Buscar);
                        cmd.Parameters.AddWithValue("@Orden", pHonorariosMedicosPlanillasE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oHonorariosMedicosPlanillasE = LlenarEntidad(dr, pHonorariosMedicosPlanillasE);
                            oListar.Add(oHonorariosMedicosPlanillasE);
                        }
                        dr.Close();
                        cnn.Close();

                        return oListar;
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
