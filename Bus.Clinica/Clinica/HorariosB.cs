using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE.MedicosE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class HorariosB
    {
        HorariosD _horario = new HorariosD();
        public List<HorariosE> Lista_Horario_Medico(string cmp) 
        {
            return _horario.Lista_Horario_Medico(cmp);
        }
    }
}
