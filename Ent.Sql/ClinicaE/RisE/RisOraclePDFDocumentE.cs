using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisOraclePDFDocumentE
    {
        #region ATRIBUTOS
        public string SpsIdKey { get; set; } = "";
        public string PdfDate { get; set; } = "";
        public string Description { get; set; } = "";
        public byte[] Contents { get; set; }
        public string Codpresotor { get; set; } = "";
        public string DocExtension { get; set; } = "";
        public string PdfTime { get; set; } = "";
        public string Colmedico { get; set; } = "";
        public int Version { get; set; } = 0;
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisOraclePDFDocumentE()
        { }

        public RisOraclePDFDocumentE(string pSpsIdKey)
        { SpsIdKey = pSpsIdKey; }

        public RisOraclePDFDocumentE(string pSpsIdKey, string pNuevoValor, string pCampo)
        {
            SpsIdKey = pSpsIdKey;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }

}
