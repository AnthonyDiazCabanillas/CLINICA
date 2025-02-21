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

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class EnviaCorreoHisE
    {
        #region ATRIBUTOS
        public string Orden { get; set; } = "";
        public string IdUsuario { get; set; } = "";
        public string Usuario { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string RutaArchivo { get; set; } = "";
        public int mailitem_id { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public EnviaCorreoHisE() { }
        public EnviaCorreoHisE(string pOrden, string pIdUsuario, string pRutaArchivo)
        {
            Orden = pOrden;
            IdUsuario = pIdUsuario; 
            RutaArchivo = pRutaArchivo;
        }
        
        public EnviaCorreoHisE(string pOrden, string pIdUsuario, string pRutaArchivo, string pDescripcion)
        {
            Orden = pOrden;
            IdUsuario = pIdUsuario;
            RutaArchivo = pRutaArchivo;
            Descripcion=pDescripcion;
        }
        #endregion

    }
}
