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
    public class LiqxtercerosReciboImgE
    {
        #region ATRIBUTOS
        public int IDLiqxtercerosReciboImg { get; set; } = 0;
        public string NmrRecibo { get; set; } = "";
        public string ImgRecibo { get; set; } = "";
        public string NmbArchivo { get; set; } = "";
        public bool Estado { get; set; } = false;
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public LiqxtercerosReciboImgE()
        { }

        public LiqxtercerosReciboImgE(int pIDLiqxtercerosReciboImg)
        { IDLiqxtercerosReciboImg = pIDLiqxtercerosReciboImg; }
        public LiqxtercerosReciboImgE(string pNmrRecibo, string pImgRecibo, string pNmbArchivo, bool pEstado)
        {
            NmrRecibo = pNmrRecibo;
            ImgRecibo = pImgRecibo;
            NmbArchivo = pNmbArchivo;
            Estado= pEstado;
        }

        public LiqxtercerosReciboImgE(int pIDLiqxtercerosReciboImg, string pNuevoValor, string pCampo)
        {
            IDLiqxtercerosReciboImg = pIDLiqxtercerosReciboImg;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }
}