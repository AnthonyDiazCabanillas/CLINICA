#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : EnviarCorreoHis
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase EnviarCorreoHis
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
    public class DetalleliquidacionE
    {
        #region ATRIBUTOS
        public string? Coddetalle { get; set; } = "";
        public string? Codliqxterceros { get; set; } = "";
        public string? Numeroliquidacion { get; set; } = "";
        public string? Codpresotor { get; set; } = "";
        public string? DscPrestacion { get; set; } = "";
        public string? Codatencion { get; set; } = "";
        public string? Codprestacion { get; set; } = "";
        public string? Fechahoraatencion { get; set; } = "";
        public string? Fechafin { get; set; } = "";
        public string? Documento { get; set; } = "";
        public string? Tipomedico { get; set; } = "";
        public string? Codpaciente { get; set; } = "";
        public string? NombPaciente { get; set; } = "";
        public string? Codcomprobante { get; set; } = "";
        public decimal Monto { get; set; } = 0;
        public decimal Montocorregido { get; set; } = 0;
        public decimal Retencion { get; set; } = 0;
        public decimal  Montoretencion { get; set; } = 0;
        public decimal  Retencion1 { get; set; } = 0;
        public decimal  Montoretencion1 { get; set; } = 0;
        public decimal  Retencion2 { get; set; } = 0;
        public decimal  Montoretencion2 { get; set; } = 0;
        public decimal  Impuestoigv { get; set; } = 0;
        public decimal  Montoimpuestoigv { get; set; } = 0;
        public decimal  Retencionppago { get; set; } = 0;
        public decimal  Montoprontopago { get; set; } = 0;
        public string? Flagcia { get; set; } = "";
        public string? Estado { get; set; } = "";
        public string? Codliquidacion { get; set; } = "";
        public string? Fechageneradaliquidacion { get; set; } = "";
        public string? Reciboxhonorarios { get; set; } = "";
        public string? Tiporetencion1 { get; set; } = "";
        public string? Tiporetencion2 { get; set; } = "";
        public decimal Costo { get; set; } = 0;
        public decimal MontoTotal { get; set; } = 0;
        //EXTENSIONES
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int NumerodeLineas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public DetalleliquidacionE()
        { }

        public DetalleliquidacionE(string pCoddetalle)
        { Coddetalle = pCoddetalle; }

        public DetalleliquidacionE(string pCoddetalle, string pNuevoValor, string pCampo)
        {
            Coddetalle = pCoddetalle;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }
}