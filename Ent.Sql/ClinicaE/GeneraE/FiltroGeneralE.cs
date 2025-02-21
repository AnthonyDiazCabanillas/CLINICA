#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : FiltroGeneralE
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase FiltroGeneralE
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.GeneraE
{
    public class FiltroGeneralE
    {
        #region FILTROBUSCAR
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; } = DateTime.Now;
        public string? Buscardor { get; set; } = "";
        #endregion

        #region RESULTADOBUSCAR
        public string? Codigo { get; set; }
        public string? NumDocumento { get; set; }
        public string? Nombres { get; set; }
        public string? CMP { get; set; }
        public bool IsSelected { get; set; }
        #endregion
    }
}
