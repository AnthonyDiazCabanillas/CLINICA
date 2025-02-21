/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.ContratosE
{
    public class HisContratoconsultoriocalendarioMaeE
    {
        #region ATRIBUTOS
        public int IDCalendario { get; set; }
        public string? HoraInicio { get; set; } = "";
        public string? HoraFin { get; set; } = "";
        public int Dia { get; set; }
        public string? DscDia { get; set; } = "";
        public string? EstCalendario { get; set; } = "";
        public int IDBeneficio { get; set; } = 0;
        public int IDBeneficioDet { get; set; } = 0;
        public bool EstBeneficio { get; set; } = false;
        public int CntDescuento { get; set; } = 0;
        public decimal PrecioxHora { get; set; } = 0;
        public string  TipDescuento { get; set; } = "";
        public string  TipDocumento { get; set; } = "";

        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTUROES
        public HisContratoconsultoriocalendarioMaeE()
        { }

        public HisContratoconsultoriocalendarioMaeE(int xIDCalendario, string? xHoraInicio, string? xHoraFin,int xDia,string? xDscDia,string? xEstCalendario,int xIDBeneficio,bool xEstBeneficio,int xCntDescuento,decimal xPrecioxHora,string? xTipDescuento,string? xNuevoValor,string? xCampo,int xOrden)
        {
            IDCalendario = xIDCalendario;
            HoraInicio  = xHoraInicio;
            HoraFin = xHoraFin;
            Dia = xDia;
            DscDia = xDscDia;
            EstCalendario = xEstCalendario;
            IDBeneficio = xIDBeneficio;
            EstBeneficio= xEstBeneficio;
            CntDescuento = xCntDescuento;
            PrecioxHora = xPrecioxHora;
            TipDescuento = xTipDescuento;
            NuevoValor = xNuevoValor;
            Campo = xCampo;
            Orden = xOrden;
        }
        #endregion
    }
}
