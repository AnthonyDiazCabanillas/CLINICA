using Dat.Sql.ClinicaAD.UsuarioAD;
using Ent.Sql;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.UsuariosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class Seguridad
    {
        public SeguridadE GetLogin(LoginE Login)
        {
            SeguridadE? Security = new SeguridadAD().GetLogin(Login);

            if (Security != null)
            {
                if (Security.Estado != "X" && Security.Estado != null)
                {
                    if (Security.Locked == false)
                    {
                        TokenResponseE Token = new SeguridadAD().GetNewToken(Security.ide_usuario, (int)Enums.TokenType.LOGIN, Login.IdeModulo, Login.DscVersion);
                        Security.TokenCode = Token.TokenCode;
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            return Security;
        }

        public BaseDatosE GetBaseDatos(BaseDatosE oBaseDatos)
        {
            BaseDatosE Security = new SeguridadAD().GetBaseDatos(oBaseDatos);

            return Security;
        }

        public RespuestaJsonE GetActulizacionPerilPersonal(SeguridadE _obj) 
        {
            try {
                 return new SeguridadAD().GetActulizacionPerilPersonal(_obj);
            }
            catch (Exception ex) { throw ex; }
        }
        public DataTable MostrarFotoPerfil(SeguridadE _obj)
        {
            try {
                return new SeguridadAD().MostrarFotoPerfil(_obj);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
