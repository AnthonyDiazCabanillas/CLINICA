using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql 
{
    public class PrestacionesClinicaE : TarifaClinicaE
    {
        public int Item { get; set; } = 0;
        public string codprestacion {  get; set; }=string.Empty;
        public string prestacion { get; set; } = string.Empty;
        public string codperiodo { get; set; } = string.Empty;
    }

    public class TarifaClinicaE
    {
        public string codtarifa { get; set; } = "";
        public string tarifa { get; set; } = "";
        public double peso { get; set; } = 0;
        public double valor { get; set; } = 0;
        public string moneda { get; set; } = "";
    }


    public class PrestacionBusqE
    {
        public int orden { get; set; }
        public string codprestacion { get; set; }
        public string codtarifa { get; set; }
        public string busq { get; set; }
        public int flglimit { get; set; }
    }

    public class ErrorDataInsercionE 
    {
        public string Titulo { get; set; }
        public string Descripcion {  get; set; }    
    }
}
