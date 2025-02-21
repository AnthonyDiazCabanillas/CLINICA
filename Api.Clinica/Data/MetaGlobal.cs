using Microsoft.AspNetCore.Components;

namespace Api.Clinica.Data
{
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
        #endregion

        #region IdeModuloSistemaPrincipal
        /// <summary>
        /// Ide del Modulo del Sistema
        /// </summary>
        public static string IdeModuloSistemaPrincipal = "";
        #endregion

        public static RenderFragment StringToHtml(string htmlString)
        {
            return new RenderFragment(b => b.AddMarkupContent(0, htmlString));
        }
    }
}
