using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
    public  class EscalaEIndicacionesE
    {
        public int?     groupcab        { get; set; }
        public string?  dsc_detalle     { get; set; }
        public int?     itemcab         { get; set; }
        public string?  detalleitem     { get; set; }
        public int?     ide_escaladet   { get; set; }
        public int?     i_order         { get; set; }
        public string?  descripcion_det { get; set; }
        public string?  descripcion_det2 { get; set; }
        public int?     puntuacion       { get; set; }
        public string?  imagencab        { get; set; }
        public string?  imagendet        { get; set; }

    }
    public class EscalaEIndicacionesActividadE { 
        public int? Item { get; set; }
        public int? Codigo { get; set; }
        public string Actividad { get; set; }
        public string Detalle { get; set; }
        public bool Ckeck { get; set; } = false;
    }


    public class PuntuacionEscalaE {
        public int Tipo { get; set; }
        public int Puntaje1 { get; set; }
        public int Puntaje2 { get; set; }
        public int Puntaje3 { get; set; }
        public int Puntaje4 { get; set; }
        public int Puntaje5 { get; set; }
        public int Puntaje6 { get; set; }
        public int Puntaje7 { get; set; }
        public int Total { get; set; }
        public string NomUser { get; set; }
        public string CodUser { get; set; }
        public string Perfil { get; set; }
        public string CodMedico { get; set; }
        public string CodigoAtencion { get; set; }
        public string IdeHistoria { get; set; }
        public string CodPaciente { get; set; }
        public string Valor { get; set; }
    }

    public class EscalaeIndicacionesHistoricoE
    {
        public DateTime Fecha { get; set; }
        public int Ide_Escala { get; set; }
        public string Escala { get; set; }
        public string Hora { get; set; }
        public int Puntaje { get; set; }
        public string Encargado { get; set; }
        public int ide_escalaeintervenciondet { get; set; }
    }

    public class EscalaEIndicacionesHistoriaDetalladoE 
    {
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public int Puntaje { get; set; }
    }
}
