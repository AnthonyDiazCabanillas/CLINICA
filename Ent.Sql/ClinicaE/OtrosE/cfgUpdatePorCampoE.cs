using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class CfgUpdatePorCampoE
    {
        public string tabla { get; set; } = "";
        public string CampoEntidad { get; set; } = "";
        public string CampoTabla { get; set; } = "";
        public string CampoConsulta { get; set; } = "";
        public string CampoUpdate { get; set; } = "";
        public string ValorUpdate { get; set; } = "";
        public bool FlagActualiza { get; set; } = false;
    }


}
