using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.RisClinicaE.PDFDocumentE
{
    public class PDFDocumentE
    {
        #region ATRIBUTOS
        public string SPSIDKEY { get; set; } = "";
        public string PDFDATE { get; set; } = "";
        public string DESCRIPTION { get; set; } = "";
        public byte[] CONTENTS { get; set; }
        public string ORDERPLACER { get; set; } = "";
        public string DOCEXTENSION { get; set; } = "";
        public string PDFTIME { get; set; } = "";
        public string CODMEDICO { get; set; } = "";
        public int VERSION { get; set; } = 0;
        public int ESTADO { get; set; } = 0;
        //EXTENSIONES
        public string Buscar { get; set; } = "";
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int NumeroFilas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public PDFDocumentE()
        { }

        public PDFDocumentE(string pSPSIDKEY)
        { SPSIDKEY = pSPSIDKEY; }

        public PDFDocumentE(string pNuevoValor, string pCampo, string pOrderPlacer, string pSPSIDKEY)
        {
            SPSIDKEY = pSPSIDKEY;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
            ORDERPLACER = pOrderPlacer;
        }
        public PDFDocumentE(string pBuscar, string pCampo, int pNumerofilas, int pOrden)
        {
            Buscar = pBuscar;
            Campo = pCampo;
            NumeroFilas = pNumerofilas;
            Orden = pOrden;
        }


        #endregion
    }
}
