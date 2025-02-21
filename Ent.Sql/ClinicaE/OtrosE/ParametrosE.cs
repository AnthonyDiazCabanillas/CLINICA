using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE
{
    public  class ParametrosE
    {
        public int Order { get; set; }
        public int N_Filas { get; set; }
        public string Cod_Atencion { get; set; }
        public string Cod_Historia { get; set; }
        public string V_Busqueda { get; set; }
    }

    public class RespuestaJsonE 
    {
        public string status { get; set; }
        public bool exito { get; set; }
        public string message { get; set; }

        public RespuestaJsonE()
        {
            status = "success";
        }
    }
}
