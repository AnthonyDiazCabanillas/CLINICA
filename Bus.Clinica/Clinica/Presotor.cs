using Dat.Sql.ClinicaAD.PresotorAD;
using Ent.Sql.ClinicaE.PresotorE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class Presotor
    {
        public List<PresotorE> Sp_Presotor_ConsultaV2(PresotorE pPresotorE)
        {
            try
            { return new PresotorAD().Sp_Presotor_ConsultaV2(pPresotorE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}
