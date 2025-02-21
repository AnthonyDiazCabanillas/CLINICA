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

using Dat.Sql.ClinicaAD.TerceroAD;
using Ent.Sql.ClinicaE.TerceroE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class Liqxterceros
    {
        #region LiqxTerceros
        public List<LiqxtercerosE> Sp_Liqxterceros_Consulta(LiqxtercerosE pLiqxtercerosE)
        {
            try
            { return new LiqxtercerosAD().Sp_Liqxterceros_Consulta(pLiqxtercerosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_Liqxterceros_UpdatexCampo(LiqxtercerosE pLiqxtercerosE)
        {
            try
            { return new LiqxtercerosAD().Sp_Liqxterceros_UpdatexCampo(pLiqxtercerosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region LiqxtercerosRecibo
        public List<LiqxtercerosReciboE> Sp_LiqxtercerosRecibo_Consulta(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            { return new LiqxtercerosReciboAD().Sp_LiqxtercerosRecibo_Consulta(pLiqxtercerosReciboE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public int Sp_LiqxtercerosRecibo_Insert(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            { return new LiqxtercerosReciboAD().Sp_LiqxtercerosRecibo_Insert(pLiqxtercerosReciboE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_LiqxtercerosRecibo_Update(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            { return new LiqxtercerosReciboAD().Sp_LiqxtercerosRecibo_Update(pLiqxtercerosReciboE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_LiqxtercerosRecibo_UpdatexCampo(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            { return new LiqxtercerosReciboAD().Sp_LiqxtercerosRecibo_UpdatexCampo(pLiqxtercerosReciboE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region LiqxtercerosReciboImg
        public List<LiqxtercerosReciboImgE> Sp_LiqxtercerosReciboImg_Consulta(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            { return new LiqxtercerosReciboImgAD().Sp_LiqxtercerosReciboImg_Consulta(pLiqxtercerosReciboImgE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public int Sp_LiqxtercerosReciboImg_Insert(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            { return new LiqxtercerosReciboImgAD().Sp_LiqxtercerosReciboImg_Insert(pLiqxtercerosReciboImgE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_LiqxtercerosReciboImg_Update(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            { return new LiqxtercerosReciboImgAD().Sp_LiqxtercerosReciboImg_Update(pLiqxtercerosReciboImgE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_LiqxtercerosReciboImg_UpdatexCampo(LiqxtercerosReciboImgE pLiqxtercerosReciboImgE)
        {
            try
            { return new LiqxtercerosReciboImgAD().Sp_LiqxtercerosReciboImg_UpdatexCampo(pLiqxtercerosReciboImgE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion
    }
}