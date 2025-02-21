#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : LiqxtercerosReciboImgE
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase LiqxtercerosReciboImgE
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

namespace Ent.Sql.ClinicaE.TerceroE
{
    public class TerceroE
    {
        #region ATRIBUTOS
        public string? CodTercero { get; set; } = "";
        public string? NombreTercero { get; set; } = "";
        public string? TipoTercero { get; set; } = "";
        public string? FlagPago { get; set; } = "";
        public string? Estado { get; set; } = "";

        public string? Buscar { get; set; } = "";
        public int key { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONTRUCTORES
        public TerceroE()
        {
        }

        public TerceroE(string pBuscar, int pKey, int pNumeroLineas, int pOrden)
        {
            Buscar = pBuscar;
            key = pKey;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion
    }
}
