using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.MedicosE
{
    public class MedicosEspecialidadE
    {
        public string CodMedico { get; set; } = "";
        public int CodSede { get; set; } = 0;
        public string CodEspecialidad { get; set; } = "";
        public string TipAtencion { get; set; } = "";
        public string TipPaciente { get; set; } = "";
        public int Moneda { get; set; } = 0;
        public decimal ImporteTarifa { get; set; } = 0;

        public string Rne { get; set; } = "";

        public string DscSede { get; set; } = "";
        public string DscEspecialidad { get; set; } = "";
        public string DscTipAtencion { get; set; } = "";
        public string DscTipPaciente { get; set; } = "";
        public string DscMoneda { get; set; } = "";

        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;

        public bool TipAgendaCallCenter { get; set; } = false;
        public bool TipAgendaSecretaria { get; set; } = false;
        public bool TipAgendaInternet { get; set; } = false;
        public bool FlgPrivilegio { get; set; } = false;

        public bool flg_ambulatorio { get; set; } = false;
        public bool flg_hospitalario { get; set; } = false;
        public bool flg_emergencia { get; set; } = false;
    }
}
