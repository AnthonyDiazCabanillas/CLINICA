#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : Dashboard
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase Dashboard 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Dat.Sql.ClinicaAD.DashboardAD;
using Ent.Sql.ClinicaE.DashboardE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica
{
    public class Dashboard
    {
        public class HonoraiosMedicosLiquidacion
        {
            public List<DshPlanillaHME> Rp_Planilla_Consulta_Dashboard(DshPlanillaHME pHonorariosMedicosPlanillasE)
            {
                try
                { return new DshPlanillaHMAD().Rp_Planilla_Consulta_Dashboard(pHonorariosMedicosPlanillasE); }
                catch (Exception e)
                { throw e = new Exception(e.Message); }

            }
        }
    }
}
