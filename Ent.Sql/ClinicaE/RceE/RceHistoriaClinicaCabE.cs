using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RceE
{
    public class RceHistoriaClinicaCabE
    {

        private string _cod_atencion = "";
        public string cod_atencion
        {
            get
            {
                return _cod_atencion;
            }
            set
            {
                _cod_atencion = value;
            }
        }

        private int _cod_paciente = 0;
        public int cod_paciente
        {
            get
            {
                return _cod_paciente;
            }
            set
            {
                _cod_paciente = value;
            }
        }

        private int _ide_historia = 0;
        public int ide_historia
        {
            get
            {
                return _ide_historia;
            }
            set
            {
                _ide_historia = value;
            }
        }

        public RceHistoriaClinicaCabE(string pcod_atencion, int pcod_paciente)
        {
            cod_atencion= pcod_atencion;
            cod_paciente = pcod_paciente;
        }
    }
}
