#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : EnviaCorreoHis
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase EnviaCorreoHis 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class EnviaCorreoHis
    {
        public bool Sp_HIS_EnvioCorreo(EnviaCorreoHisE pEnviaCorreoHisE)
        {
            try
            {
              return new EnviaCorreoHisAD().Sp_HIS_EnvioCorreo(pEnviaCorreoHisE);
            }
            catch (Exception ex)
            { throw ex = new Exception(ex.Message); }
        }
    }
}
