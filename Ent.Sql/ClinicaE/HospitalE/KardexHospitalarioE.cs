using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
    public class KardexHospitalarioE
    {
        public int? ide_kardexhospitalario { get; set; }
        public string? codatencion { get; set; }
        public string? codpaciente { get; set; }
        public decimal? peso { get; set; }
        public string? usr_registra { get; set; }
        public string? estado { get; set; }
        public int? eliminado { get; set; }
        public DateTime? fecharegistro { get; set; }
        public DateTime? fechainicio { get; set; }
        public DateTime? fechafin { get; set; }
        public int? order { get; set; }
    }


    public class ApiJSONConsultaDniE { 
        public string token { get; set; }
        public string dni { get; set; }
    }

    public class ApiJsonResultadoDNiE { 
        public bool success { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
    }
}
