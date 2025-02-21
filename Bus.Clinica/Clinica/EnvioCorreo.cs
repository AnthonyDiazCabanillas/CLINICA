using Dat.Sql.ClinicaAD.OtrosAD;
using Dat.Sql.ClinicaAD.RisAD;
using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql.ClinicaE.RisE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class EnvioCorreo
    {
        public void Sp_Ris_EnvioCorreo(RisEnvioCorreoE RisEnvioCorreoE)
        {
            try
            { new RisEnvioCorreoAD().Sp_Ris_EnvioCorreo(RisEnvioCorreoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public void Sp_CorreoDigitalizacion(CorreoE pCorreoE)
        {
            try
            { new SisCorreoAD().Sp_CorreoDigitalizacion(pCorreoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}
