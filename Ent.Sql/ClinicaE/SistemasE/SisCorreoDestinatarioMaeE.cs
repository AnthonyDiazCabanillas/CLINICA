using System;

namespace Ent.Sql.ClinicaE.SistemasE
{
    public class SisCorreoDestinatarioMaeE
    {
        #region ATRIBUTOS
        public int IdeCorreo { get; set; } = 0;
        public string CodLista { get; set; } = "";
        public int SecLista { get; set; } = 0;
        public int CodTipo { get; set; } = 0;
        public string DscDestinatario { get; set; } = "";
        public string NombCodTipo { get; set; } = "";
        public bool FlgRegistro { get; set; } = false;
        public DateTime FecRegistro { get; set; } = DateTime.Now;
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int NroFilas { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public SisCorreoDestinatarioMaeE()
        { }

        public SisCorreoDestinatarioMaeE(int pIdeCorreo)
        { IdeCorreo = pIdeCorreo; }

        public SisCorreoDestinatarioMaeE(int pIdeCorreo, string pNuevoValor, string pCampo)
        {
            IdeCorreo = pIdeCorreo;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public SisCorreoDestinatarioMaeE( string pCodLista, string pDscDestinatario, int pNroFilas, int pOrden)
        {
            CodLista = pCodLista;
            DscDestinatario = pDscDestinatario;
            NroFilas = pNroFilas;
            Orden = pOrden;
        }

        #endregion
    }
}