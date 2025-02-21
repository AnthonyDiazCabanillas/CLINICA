#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : Detalleliquidacion
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase Detalleliquidacion 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Dat.Sql.ClinicaAD.TerceroAD;
using Ent.Sql.ClinicaE.TerceroE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class Detalleliquidacion
    {
        public List<DetalleliquidacionE> Sp_Detalleliquidacion_Consulta(DetalleliquidacionE pDetalleliquidacionE)
        {
            try
            { return new DetalleliquidacionAD().Sp_Detalleliquidacion_Consulta(pDetalleliquidacionE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_Detalleliquidacion_UpdatexCampo(DetalleliquidacionE pDetalleliquidacionE)
        {
            try
            { return new DetalleliquidacionAD().Sp_Detalleliquidacion_UpdatexCampo(pDetalleliquidacionE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}