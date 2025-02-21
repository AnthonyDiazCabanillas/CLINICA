using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class ClinicaTorreE
    {
        public int IDClinica { get; set; }
        public string? Clinica { get; set; } = "";
        public int IDUbicacion { get; set; }
        public string? DscUbicacion { get; set; } = "";
        public int Piso { get; set; }

        public int Orden { get; set; }
        public string? Buscar { get; set; } = "";

        public ClinicaTorreE() { }
        public ClinicaTorreE(int pOrden, string pBuscar)
        {
            Orden = pOrden;
            Buscar = pBuscar;
        }

    }
}
