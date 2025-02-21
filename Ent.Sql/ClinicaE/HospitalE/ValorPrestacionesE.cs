using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
    public class ValorPrestacionesE
    {
        public string? Codatencion { get; set; }
        public string? Nompaciente { get; set; }
        public Double Monto { get; set; }
        public string? Nomtarifa { get; set; }
        public string? Nomcobertura { get; set; }
        public string? Nomprestacion { get; set; }
        public Double Valprestacion { get; set; }
        public string? Codprestacion { get; set; }
        public string? Codtarifa { get; set; }
        public string? Dscprestacion { get; set; }
        public int Codaseguradora { get; set; }
        public string? Nomaseguradora { get; set; }

        // Extensiones
        public int? NroFilas { get; set; }
        public int Orden { get; set; }
        public Double Descuentoporcentaje { get; set; }
        public Double Descuentosoles { get; set; }
        public Double Total { get; set; }

        #region CONSTRUCTORES
        public ValorPrestacionesE() { }

        #region Sp_ValorPrestaciones_Consultav2
        /// <summary>
        ///         ''' [Sp_ValorPrestaciones_Consultav2]
        ///         ''' </summary>
        ///         ''' <param name="pOrden"></param>
        ///         ''' <param name="pCodatencion"></param>
        ///         ''' <param name="pCodprestacion"></param>
        ///         ''' <param name="pCodtarifa"></param>
        ///         ''' <param name="pDscprestacion"></param>
        ///         ''' <param name="pNroFilas"></param>
        public ValorPrestacionesE(int pOrden, string? pCodatencion, string? pCodprestacion, string? pCodtarifa, string? pDscprestacion, int pNroFilas)
        {
            Orden = pOrden;
            Codatencion = pCodatencion;
            Codprestacion = pCodprestacion;
            Codtarifa = pCodtarifa;
            Dscprestacion = pDscprestacion;
            NroFilas = pNroFilas;
        }

        #endregion

        #endregion
    }
}
