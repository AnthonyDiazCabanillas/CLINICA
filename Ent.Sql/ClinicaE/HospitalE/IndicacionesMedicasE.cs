using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
	public class IndicacionesMedicasE
	{
		public int? IdTipo { get; set; } = 0;
		public string? NombreTipo { get; set; }
		public string? dsc_producto { get; set; }
		public string? num_dosis { get; set; }
		public string? dsc_via { get; set; }
		public int? ide_receta { get; set; } = 0;
		public int? ide_medicamentorec { get; set; } = 0;
		public string? flg_suspendido { get; set; }
		public string? txt_detalle { get; set; }
		public string? num_duracion { get; set; }
		public string? num_frecuencia { get; set; }
		public decimal? num_cantidad { get; set; } = 0M;
		public string? HOR_REGISTRO { get; set; }
		public string? HOR_REGISTRO2 { get; set; }
		public string? Fecha { get; set; }
		public string? NombreMedico { get; set; }
		public string? cod_atencion { get; set; }
        public bool _Seleccion { get; set; } = false;
		public string? UserRegistro { get; set; }
		public string? Observacion { get; set; }
		public string? horaAtencion { get; set; } = "";
		public int? ide_KardexHospitalario { get; set; } = 0;
		public int? _item { get; set; } = 0;
		public int? HoraSecundaria { get; set; } = 0;
		public string? UltimoFechaRegistro { get; set; }
		public string? UltimoUserRegistro { get; set; } 
		public int? i_horasugerida { get; set; } = 0;
		public string Icons { get; set; }
		public string? SiguienteHora { get; set; }
		public int? NumeracionFrecuencia { get; set; } = 0;
		public int? TotDetalle { get; set; } = 0;
		public int? SumEstado { get; set; } = 0;
     }

	public class IndicacionesMedicaDetalleE
	{
		public int? ide_medicamentorec { get; set; }

		public DateTime? Fecha { get; set; }
		public int? i_Idtipo { get; set; }
		public string? dsc_tipo { get; set; }
		public string? dsc_producto { get; set; }
		public string? usr_registra { get; set; }
		public string? FInsert { get; set; }
		public string? HInsert { get; set; }
		public int? i_Correlativo { get; set; }
		public string? Icons { get; set; }
		public string? peso { get; set; }
		public string fechaprogramada { get; set; }
		public string usr_adminstra { get; set; }
		public string fechaadministrada { get; set; }
		public string dsc_tipoAdminstracio { get; set; }
		public int? i_estadoadministrado { get; set; }
    }

	public class PisoE { 
		public string? NPiso { get; set; }
		public string? PisoSeleccionado { get; set; }
	}

	public class ProgramacionKardexE { 
		public int? item { get; set; }
        public string codatencion { get; set; }
		public int? ide_medicamentorec { get; set; }
		public int? i_Correlativo { get; set; }
		public int? i_estadoadministrado { get; set; }
		public string fechaprogramada { get; set; }
		public string horaprogramada { get; set; }
		public string FechaAdministrada { get; set; }
		public string usr_adminstra { get; set; }
    }
}
