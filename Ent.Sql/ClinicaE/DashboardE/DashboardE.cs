#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : DshPlanillaHME
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase DshPlanillaHME 
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

namespace Ent.Sql.ClinicaE.DashboardE
{
    public class DshPlanillaHME
    {
        #region ATRIBUTOS
        public string? TipoLiquidacion { get; set; } = "";
        public int Año { get; set; } = 0;
        public string? Mes { get; set; } = "";
        public string? Estado { get; set; } = "";
        public decimal Cantidad { get; set; } = 0;
        public string? Porcentaje { get; set; } = "";
        public decimal CntPorcentaje { get; set; } = 0;
        public decimal Total { get; set; } = 0;

        public string? FechaInicio { get; set; } = "";
        public string? FechaFin { get; set; } = "";
        public string? Buscar { get; set; } = "";
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public DshPlanillaHME() { }

        public DshPlanillaHME(string pTipoLiquidacion, decimal pCantidad, decimal pTotal, decimal pCntPorcentaje)
        {

            TipoLiquidacion = pTipoLiquidacion;
            Cantidad = pCantidad;
            Total = pTotal;
            CntPorcentaje = pCntPorcentaje;
        }
        public DshPlanillaHME(string pEstado, decimal pCantidad, decimal pTotal)
        {
            Estado = pEstado;
            Cantidad = pCantidad;
            Total = pTotal;

        }

        public DshPlanillaHME(string pFechaInicio, string pFechaFin, string pBuscar, int pOrden)
        {
            FechaInicio = pFechaInicio;
            FechaFin = pFechaFin;
            Buscar = pBuscar;
            Orden = pOrden;
        }
        public DshPlanillaHME(string pEstado)
        { pEstado = Estado; }
        #endregion
    }
}
