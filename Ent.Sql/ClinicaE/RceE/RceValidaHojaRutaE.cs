using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Ent.Sql.ClinicaE.RceE.RceValidaHojaRutaE;

namespace Ent.Sql.ClinicaE.RceE
{
	public class RceValidaHojaRutaE
	{
		public string cod_atencion { get; set; } = "";
		//public int ide_historia { get; set; } = 0;
		public int orden { get; set; } = 0;

		public RceValidaHojaRutaE()
		{ }

        public class SoftVan
        {
            public string cod_atencion { get; set; } = "";

            public int cod_paciente { get; set; } = 0;
            //INI 1.0
            public int cod_cpt { get; set; } = 0;
            //FIN 1.0
            public string tipo_reporte { get; set; } = "";
        }

        public class Data
		{
			public int? ide_historia { get; set; } = 0;

			public int? Retorno { get; set; } = 0;
		}

		public class Parametros 
		{
			public string Dsc_Parametro { get; set; } = "";

			public string Valor_Parametro { get; set; } = "";

			public string Dsc_archivo_rpt { get; set; } = "";
		}

		public class rptInformesMaeE
		{
			public int ide_informe { get; set; } = 0;
		}

		public class Body
		{
			public int ide_log_consulta { get; set; } = 0;

			public int ide_usuario { get; set; } = 0;

			public string dsc_login { get; set; } = "";

			public string dsc_archivo_rpt { get; set; } = "";

			public string tip_reporte { get; set; } = "";

			public string dsc_parametros_valores { get; set; } = "";

			public List<Parametros> Parametros { get; set; } = new List<Parametros>();
			public rptInformesMaeE rptInformesMaeE { get; set; } = new rptInformesMaeE();
			public string dsc_sistema { get; set; } = "";

			public string cod_atencion { get; set; } = "";

			public bool chkfarmacologicot { get; set; } = false;

			public bool chknofarmacologicop { get; set; } = false;

		}
	}
}
