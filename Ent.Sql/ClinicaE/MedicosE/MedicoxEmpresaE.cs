using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ent.Sql.ClinicaE.MedicosE
{
    public class MedicoxEmpresaE
    {
        public string CodMedico { get; set; } = "";
        public string CodEmpresa { get; set; } = "";
        public bool FlgFacturar { get; set; } = false;
        public string NombreEmpresa { get; set; } = "";



        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;




    }
}
