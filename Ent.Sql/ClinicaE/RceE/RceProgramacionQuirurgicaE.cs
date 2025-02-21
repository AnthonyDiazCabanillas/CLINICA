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
	public class RceProgramacionQuirurgicaE
    {
		public int ID_PQ_Det { get; set; } = 0;
        public int cod_cpt { get; set; } = 0;
        public string cod_atencion { get; set; } = "";


        public RceProgramacionQuirurgicaE()
		{ }

        public RceProgramacionQuirurgicaE(string pcod_atencion, int pcod_cpt)
        {
            cod_atencion = pcod_atencion;
            cod_cpt = pcod_cpt;
        }
    }
}