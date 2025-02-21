#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : LiqxtercerosReciboE
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase LiqxtercerosReciboE
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
    public class LiqxtercerosReciboE
    {
        #region ATRIBUTOS
        public int IDLiqxtercerosRecibo { get; set; } = 0;
        public int IDLiqxtercerosReciboImg { get; set; } = 0;
        public string CodLiqxterceros { get; set; } = "";
        public string NmrLiquidacion { get; set; } = "";
        public string CodMedico { get; set; } = "";
        public string Ruc { get; set; } = "";
        public DateTime FchRegistro { get; set; } = DateTime.Now;
        public int IDUsrRegistro { get; set; } = 0;
        public bool Estado { get; set; } = false;
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public LiqxtercerosReciboE()
        { }

        public LiqxtercerosReciboE(int pIDLiqxtercerosRecibo)
        { IDLiqxtercerosRecibo = pIDLiqxtercerosRecibo; }
        public LiqxtercerosReciboE(int pIDLiqxtercerosReciboImg, string pCodLiqxterceros, string pNmrLiquidacion, string pCodMedico, string pRuc, bool pEstado)
        {
            IDLiqxtercerosReciboImg = pIDLiqxtercerosReciboImg;
            CodLiqxterceros = pCodLiqxterceros;
            NmrLiquidacion = pNmrLiquidacion;
            CodMedico = pCodMedico;
            Ruc = pRuc;
            Estado = pEstado;
        }

        public LiqxtercerosReciboE(int pIDLiqxtercerosRecibo, string pNuevoValor, string pCampo)
        {
            IDLiqxtercerosRecibo = pIDLiqxtercerosRecibo;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }

        #endregion
    }
}
