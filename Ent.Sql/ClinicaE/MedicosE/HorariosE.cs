using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.MedicosE
{
    public class HorariosE
    {
        public int IdSede { get; set; }
        public string Sede { get; set; }
        public DateTime FechaInicio { get; set;}
        public DateTime FechaFin { get; set; }
        public int IdDia { get; set;}
        public string NombreDia { get; set; }
        public string HoraInicio { get; set;}
        public string HoraFin { get; set;}
        public string Especialidad { get;set;}
        public string Consultorio { get; set; }

        

    }
}
