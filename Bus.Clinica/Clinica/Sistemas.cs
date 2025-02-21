using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.SistemasE;
using Dat.Sql.ClinicaAD.SistemasAD;

namespace Bus.Clinica.Clinica
{
    public class Sistemas
    {
        public bool GrabarCorreoDestinatario(SisCorreoDestinatarioMaeE sisCorreoDestinatario)
        {
            bool result = false;
            try
            {
                if (sisCorreoDestinatario.IdeCorreo == 0)
                {
                    result = new SisCorreoDestinatarioMaeAD().Sp_SisCorreodestinatarioMae_Insert(sisCorreoDestinatario);
                }
                else
                {
                    result = new SisCorreoDestinatarioMaeAD().Sp_SisCorreodestinatarioMae_Update(sisCorreoDestinatario);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public bool ActualizarCorreoDestinatario(SisCorreoDestinatarioMaeE sisCorreoDestinatario)
        {
            bool result = false;
            try
            {
                if (sisCorreoDestinatario.NuevoValor == "False")
                { sisCorreoDestinatario.NuevoValor = "0"; }
                if (sisCorreoDestinatario.NuevoValor == "True")
                { sisCorreoDestinatario.NuevoValor = "1"; }

                result = new SisCorreoDestinatarioMaeAD().Sp_SisCorreodestinatarioMae_UpdatexCampo(sisCorreoDestinatario);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public List<SisCorreoDestinatarioMaeE> ListarCorreosDestinatarios(SisCorreoDestinatarioMaeE sisCorreoDestinatario)
        {
            List<SisCorreoDestinatarioMaeE> lista = new List<SisCorreoDestinatarioMaeE>();

            lista = new SisCorreoDestinatarioMaeAD().Sp_SisCorreodestinatarioMae_Consulta(sisCorreoDestinatario);

            return lista;
        }
    }
}
