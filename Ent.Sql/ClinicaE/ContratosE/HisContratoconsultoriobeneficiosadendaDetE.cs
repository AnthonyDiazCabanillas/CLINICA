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
    public class HisContratoconsultoriobeneficiosadendaDetE
    {
        #region #ATRIBUTOS
        public int IdeBeneficiosadenda { get; set; }
        public int IdeAdendaCab { get; set; }
        public int IdeBeneficio { get; set; }
        public string? FecInicio { get; set; } = "";
        public string? FecFin { get; set; } = "";
        public string? DscObservacion { get; set; } = "";
        public string? EstBeneficiosadenda { get; set; } = "";
        public decimal PrecioxHora { get; set; } = 0;
        public int CntDescuento { get; set; } = 0;
        public string? TipDescuento { get; set; } = "";
        //Extensiones
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public string? Buscar { get; set; } = "";
        public int IDBuscar { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion
        #region CONSTRUCTORES
        public HisContratoconsultoriobeneficiosadendaDetE() { }

        public HisContratoconsultoriobeneficiosadendaDetE(int pIdeBeneficiosadenda, int pIDBuscar, string pBuscar, int pNumeroLineas, int pOrden)
        {
            IdeBeneficiosadenda = pIdeBeneficiosadenda;
            IDBuscar = pIDBuscar;
            Buscar = pBuscar;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion
    }
}
