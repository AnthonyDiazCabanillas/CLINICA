#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : MetalGobal
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase MetalGobal
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se agrega la variable StoreServer(Rutal del servidor de correo)
//====================================================================================================
#endregion

using Microsoft.AspNetCore.Components;

namespace Web.Clinica
{
    #region MetaGlobal
    /// <summary>
    /// Variable global que se puede usar en toda la web.
    /// </summary>
    public static class MetaGlobal
    {
        #region PageDescription
        /// <summary>
        /// Descripción de la página web.
        /// </summary>
        public static string PageDescription = "";
        #endregion



        #region PageTitle
        /// <summary>
        /// Titulo de la página web
        /// </summary>
        public static string PageTitle = "";
        #endregion

        #region VersionPublicacion
        /// <summary>
        /// Versión de la publicación en la que está actualmente
        /// </summary>
        public static string VersionPublicacion = "";
        #endregion

        #region NameSistema
        /// <summary>
        /// Nombre del Sistema
        /// </summary>
        public static string NameSistema = "";
        public static string StoreServer = "";
        #endregion
        #region
        ///<summary>
        ///ruta api sistema
        ///
        ///</summary>

        public static string RutaApiClinica = "";
        public static string RutaApiAgendaSoftvan = "";
    
        #endregion
        #region IdeModuloSistemaPrincipal
        /// <summary>
        /// Ide del Modulo del Sistema
        /// </summary>
        public static string IdeModuloSistemaPrincipal = "";
        #endregion
        
        #region IdUser
        /// <summary>
        /// Id del usuario que inicia sesion
        /// </summary>
        public static int IdUserLogin = 0;
        #endregion

        public static RenderFragment StringToHtml(string htmlString)
        {
            return new RenderFragment(b => b.AddMarkupContent(0, htmlString));
        }
    }
    #endregion        
}
