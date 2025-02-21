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
    public class HisContratoconsultoriobeneficioMaeE
    {
        #region ATRIBUTOS
        public int IDBeneficio { get; set; }
        public string? DscBeneficio { get; set; } = "";
        public string? TipDescuento { get; set; } = "";
        public string? TipCantidad { get; set; } = "";
        public int CntDescuento { get; set; } = 0;
        public string? EstBeneficio { get; set; } = "";
        public string? HorasAplicar { get; set; } = "";
        public bool CheckBoxBeneficio { get; set; } = false;
        public DateTime FechaIncio { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; } = DateTime.Now;
        public int CntDescuentoAplicar { get; set; } = 0;
        public decimal PrecioxHora{ get; set; } = 0;

        public int Orden { get; set; }
        public string? Buscar { get; set; } = "";
        public string? NuevoValor { get; set; } = "";
        #endregion

        #region CONSTRUCTORES
        public HisContratoconsultoriobeneficioMaeE() { }
        #endregion
    }
}
