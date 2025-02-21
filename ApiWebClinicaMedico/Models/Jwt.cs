using Dat.Sql.ClinicaAD.UsuarioAD;
using Dat.Sql.SeguridadAD.SeguridadAD;
using Ent.Sql.ClinicaE.UsuariosE;
using Ent.Sql.SeguridadE.SeguridadE;
using System.Security.Claims;

namespace WebAppCitaAgenda.Models
{
    public class Jwt
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }

        public static dynamic validarToken(ClaimsIdentity identity)
        {
            try
            {
                if(identity.Claims.Count() == 0)
                {
                    return new
                    {
                        success = false,
                        message = "Verificar si estas enviando un token valido",
                        result = ""
                    };
                }

                //var id = identity.Claims.FirstOrDefault(x => x.Type == "id").Value;

                ////UsuarioCitaE usuario = Usuario.DB().FirstOrDefault(x => x.idUsuario == id);
                //UsuarioCitaE usuario = new UsuarioCitaAD().Sp_UsuarioCita_Consulta(new UsuarioCitaE(id, "", "", "", 1));


                return new
                {
                    success = true,
                    message = "exito",
                    //result = usuario
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    success= false,
                    message = "Catch: "+ex.Message,
                    result = ""
                };
            }
        }

        public static dynamic validarTokenPSF(ClaimsIdentity identity)
        {
            try
            {
                if (identity.Claims.Count() == 0)
                {
                    return new
                    {
                        success = false,
                        message = "Verificar si estas enviando un token valido",
                        result = ""
                    };
                }

                //var id = identity.Claims.FirstOrDefault(x => x.Type == "id").Value;

                //SeguridadE oSeguridadE = new SeguridadE();

                ////UsuarioCitaE usuario = Usuario.DB().FirstOrDefault(x => x.idUsuario == id);
                //UsuarioCitaE usuario = new UsuarioCitaAD().Sp_UsuarioCita_Consulta(new UsuarioCitaE(id, "", "", "", 1));

                    
                return new
                {
                    success = true,
                    message = "exito",
                    //result = usuario
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    success = false,
                    message = "Catch: " + ex.Message,
                    result = ""
                };
            }
        }








    }




}
