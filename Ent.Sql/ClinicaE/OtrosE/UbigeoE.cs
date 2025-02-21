using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class UbigeoE
    {
        public string CodUbigeo { get; set; } = "";
        public string CodPais { get; set; } = "";
        public string CodDpto { get; set; } = "";
        public string CodProv { get; set; } = "";
        public string CodDist { get; set; } = "";
        public string Nombre { get; set; } = "";

        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;

        public string  NombrePais{ get; set; } = "";
        public string NombreDpto { get; set; } = "";
        public string NombreProv { get; set; } = "";
        public string NombreDist { get; set; } = "";
        public string CodPaisSup { get; set; } = "";
        public string CodDptoSup { get; set; } = "";
        public string CodProvSup { get; set; } = "";
        public string CodDistSup { get; set; } = "";
        public string CodUbigeoPeru { get; set; } = "";

        

    }
}
