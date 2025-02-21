using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class Aseguradoras
    {
        public List<AseguradorasE> ConsultaAseguradoras(AseguradorasE pAseguradoras)
        {
            try
            {
                return new AseguradorasAD().Sp_Aseguradoras_ConsultaV2(pAseguradoras);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }
    }
}