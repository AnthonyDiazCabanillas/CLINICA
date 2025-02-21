using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.MedicosE
{
    public class PrestacionxMedicoE
    {
        public string CodMedico { get; set; } = "";
        public string CodPrestacion { get; set; } = "";
        public string NomPrestacion { get; set; } = "";
        public Double PorcentajeRetencion1 { get; set; } = 0;
        public Double PorcentajeRetencion2 { get; set; } = 0;
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;
    }
}
