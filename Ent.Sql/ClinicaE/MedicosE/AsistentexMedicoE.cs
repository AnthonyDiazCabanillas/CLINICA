using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.MedicosE
{
    public class AsistentexMedicoE
    {
        public string CodMedicoTitular { get; set; } = "";
        public string CodMedicoAsistente { get; set; } = "";
        public string NombreAsistente { get; set; } = "";


        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;

    }
}
