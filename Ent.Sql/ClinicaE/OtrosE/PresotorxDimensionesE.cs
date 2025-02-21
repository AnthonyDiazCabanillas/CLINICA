using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class PresotorxDimensionesE
    {
        public string CodPresotor { get; set; } = "";
        public string CodDimension1 { get; set; } = "";
        public string CodDimension2 { get; set; } = "";
        public string CodDimension3 { get; set; } = "";
        public string CodDimension4 { get; set; } = "";
        public int UsrRegistro { get; set; }
        public int IdePresotordim { get; set; }

        public PresotorxDimensionesE() { }
        public PresotorxDimensionesE(string pCodPresotor, string pCodDimension2, int pUsrRegistro, string pCodDimension1)
        {
            CodPresotor = pCodPresotor;
            CodDimension1 = pCodDimension1;
            CodDimension2 = pCodDimension2;
            UsrRegistro = pUsrRegistro;

        }

    }
}
