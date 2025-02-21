//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         25/07/2024     HVIDAL       REQ 2024-011473 AGENDA DE PROCEDIMIENTOS
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Ent.Sql.ClinicaE.RceE.RceValidaHojaRutaE;

namespace Ent.Sql.ClinicaE.RceE
{
	public class RceCptE
    {
		public string cod_cpt { get; set; } = "";
		public string dsc_cpt { get; set; } = "";
        public string cod_segus { get; set; } = "";
        public string dsc_segus { get; set; } = "";
        public string guarismo { get; set; } = "";

        public RceCptE()
		{ }

	}
}
