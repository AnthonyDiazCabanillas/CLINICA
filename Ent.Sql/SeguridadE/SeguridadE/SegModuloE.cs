using System;

namespace Ent.Sql.SeguridadE.SeguridadE
{
    public class SegModuloE
    {
        #region ATRIBUTOS
        public int IdeModulo { get; set; } = 0;
        public string TxtModulo { get; set; } = "";
        public int IdeModuloSup { get; set; } = 0;
        public string FlgActivo { get; set; } = "";
        public string DscIcono { get; set; } = "";
        public string DscRuta { get; set; } = "";
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public SegModuloE()
        { }

        public SegModuloE(int pIdeModulo)
        { IdeModulo = pIdeModulo; }

        public SegModuloE(int pIdeModulo, string pNuevoValor, string pCampo)
        {
            IdeModulo = pIdeModulo;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }
}