using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class CorreoE
    {

        public CorreoE(string pasunto, string pcuerpo)
        {
            asunto = pasunto;
            cuerpo = pcuerpo;
        }

        public string asunto { get; set; } = "";
        public string cuerpo { get; set; } = "";
        public int mailitem_id { get; set; } = 0;
        
    }
}
