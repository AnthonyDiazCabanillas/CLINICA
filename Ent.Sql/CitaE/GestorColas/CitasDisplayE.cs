using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.CitaE.GestorColas
{
    public class CitasDisplayE{
        public string? UbicacionCita { get; set; }
        public List<CitasE>? listaCitas { get;set; }
    }

    public class CitasDisplayTicketE
    {
        public string? paciente { get; set; }
        public List<CitasTicketE>? listaCitas { get; set; }
        //public string? Mensaje { get; set; }
    }

    public class CitasDisplayJsonParamE
    {
        public string? local { get; set; }
        public string? sector { get; set; }
    }

    public class CitasTicketJsonParamE
    {
        public  string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? local { get; set; }
        
    }

    public class CitasE
    {
        public string? Paciente { get; set; }    
        public string? CodigoCita { get; set; }
        public string? Medico { get; set; }
        public string? Especialidad { get; set; }
        public string? Consultorio { get; set; }
        public string? HoraCita { get; set; }
        public string? Estado { get; set; }
        public string? UbicacionCita { get; set; }
        public string? nroDocumentoPaciente { get; set; }
        public string? estadoPago { get; set; }
    }


    public class CitasTicketE
    {
      
        public string? Medico { get; set; }
        public string? Especialidad { get; set; }
        public string? HoraCita { get; set; }
        public int EstadoPago { get; set; }
        public int VigenciaCita { get; set; }
        public string[] Mensaje { get; set; }
        public string? Paciente { get; set; }


    }

    public class CitasRegTurno
    {

        public string? local { get; set; }
        public string? sector { get; set; }
        public string? CodigoCita { get; set; } 
        public string? NombreCliente { get; set; }
        public string? Especialidad { get; set; }
		public string? CodEspecialidad { get; set; }
		public string? Consultorio { get; set; }
        public string? HoraCita { get; set; }

    }

}
