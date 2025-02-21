using System;

namespace Ent.Sql.SeguridadE.SeguridadE
{
    public class SegOpcionE
    {
        #region ATRIBUTOS
        public int IdeOpcion { get; set; } = 0;
        public int IdeModulo { get; set; } = 0;
        public string TxtOpcion { get; set; } = "";
        public string CodOpcion { get; set; } = "";
        public int IdeOpcionSup { get; set; } = 0;
        public DateTime FecRegistro { get; set; } = DateTime.Now;
        public string DscOpcion { get; set; } = "";
        public string DscIcono { get; set; } = "";
        public string DscRuta { get; set; } = "";
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int IdeModuloSup { get; set; } = 0;
        public int IdeUsuario { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public SegOpcionE()
        { }

        public SegOpcionE(int pIdeOpcion)
        { IdeOpcion = pIdeOpcion; }

        public SegOpcionE(int pIdeOpcion, string pNuevoValor, string pCampo)
        {
            IdeOpcion = pIdeOpcion;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }

		public SegOpcionE(int pOrden, int pIdeModulo, string pCodOpcion, int pIdeUsuario)
		{
			Orden = pOrden;
			IdeModulo = pIdeModulo;
			CodOpcion = pCodOpcion;
			IdeUsuario = pIdeUsuario;
		}

		#endregion
	}
}