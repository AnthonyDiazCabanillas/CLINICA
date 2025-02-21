#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : Liqxterceros
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase Liqxterceros
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
    public class LiqxtercerosE
    {
        #region ATRIBUTOS
        public string Codliqxterceros { get; set; } = "";
        public string Numeroliquidacion { get; set; } = "";
        public string Codmedico { get; set; } = "";
        public string NombreMedico { get; set; } = "";
        public string RUCMedico { get; set; } = "";
        public string DocMedico { get; set; } = "";
        public string ColMedico { get; set; } = "";
        public string Fechacancela { get; set; } = "";
        public string Codentidad { get; set; } = "";
        public string Tipopago { get; set; } = "";
        public string Numeroentidad { get; set; } = "";
        public string Documento { get; set; } = "";
        public string Ruc { get; set; } = "";
        public string Estado { get; set; } = "";
        public string Voucher { get; set; } = "";
        public decimal Monto { get; set; } = 0;
        public decimal MontoTotal { get; set; } = 0;
        public decimal Montoclinica { get; set; } = 0;
        public decimal Montoretencion1 { get; set; } = 0;
        public decimal Montoretencion2 { get; set; } = 0;
        public decimal Montoimpuestoigv { get; set; } = 0;
        public decimal Montoprontopago { get; set; } = 0;
        public decimal Montoneto { get; set; } = 0;
        public string Idasiento { get; set; } = "";
        public string Tipodocemite { get; set; } = "";
        public string EstRecibo { get; set; } = "";
        public bool FlgEnviosap { get; set; } = false;
        public string FecEnviosap { get; set; } = "";
        public int IdeDocentrysap { get; set; } = 0;
        public string FecDocentrysap { get; set; } = "";
        public int IdeTablaintersap { get; set; } = 0;
        public bool FlgSelect { get; set; } = false;
        public string Tiporetencion1 { get; set; } = "";
        public string Tiporetencion2 { get; set; } = "";
        public string FechaInicio { get; set; } = "";
        public string FechaFin { get; set; } = "";
        public bool FlgValidacionSic { get; set; } = false;
        public string FechaGenera { get; set; } = "";
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public string Buscar { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public int RptStatus { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public LiqxtercerosE()
        { }

        public LiqxtercerosE(string pCodliqxterceros)
        { Codliqxterceros = pCodliqxterceros; }

        public LiqxtercerosE(string pCodliqxterceros,string pNumeroLiquidacion, string pNuevoValor, string pCampo)
        {
            Codliqxterceros = pCodliqxterceros;
            Numeroliquidacion= pNumeroLiquidacion;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public LiqxtercerosE(string pBuscar,string pCodMedico, string pNumeroLiquidacion,string pEstado, int pNumeroLineas, int pOrden)
        {
            Buscar = pBuscar;
            Codmedico= pCodMedico;
            Numeroliquidacion=pNumeroLiquidacion;
            Estado=pEstado;
            NumeroLineas=pNumeroLineas;
            Orden=pOrden;
        }
        #endregion
    }
}