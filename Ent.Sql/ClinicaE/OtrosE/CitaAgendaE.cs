using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
	public class CitaAgendaE
	{
		public string paciente { get; set; } = "";
		public string fecha { get; set; } = "";
		public string hora { get; set; } = "00:00";
		public string doctor { get; set; } = "";
		public string nombreEspecialidad { get; set; } = "";
		public string url_qr { get; set; } = "";
		public string cod_atencion { get; set; } = "";
		public string tipoServicio { get; set; } = "";
		//public string NumeroDocumento { get; set; } = "";

		public class Documento
		{
			public string NumeroDocumento { get; set; } = "";
			public int TipoDocumento { get; set; } = 0;
		}
	}
}
