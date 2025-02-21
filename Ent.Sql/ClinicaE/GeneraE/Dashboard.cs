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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.GeneraE
{
    #region ChartDataset
    public class ChartDataset
    {
        #region ATRIBUTOS
        public string? label { get; set; } = "";
        public string? backgroundColor { get; set; } = "";
        public string? borderColor { get; set; } = "";
        public bool pointRadius { get; set; }
        public string? pointColor { get; set; } = "";
        public string? pointStrokeColor { get; set; } = "";
        public string? pointHighlightFill { get; set; } = "";
        public string? pointHighlightStroke { get; set; } = "";
        public List<decimal> data { get; set; }
        public TooltipDt? tooltip { get; set; } // Propiedad para el tooltip
        #endregion

        #region CLASE TOOLTIP
        public class TooltipDt
        {
            public bool enabled { get; set; } = true;
            public string? mode { get; set; } = "single";
            public TooltipCallbacksDt? callbacks { get; set; }
        }
        #endregion

        #region CLASE TOOLTIPCALLBACKS
        public class TooltipCallbacksDt
        {
            public string? label { get; set; } = "";
            public List<decimal> Soles { get; set; } = new List<decimal>();

        }
        #endregion
    }
    #endregion
}
