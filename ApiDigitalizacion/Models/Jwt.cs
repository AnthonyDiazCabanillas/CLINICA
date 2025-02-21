//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version       Fecha          Autor        Requerimiento
//    1.0           05/08/2024     HVIDAL       REQ 2024-011506 Controller que valida el acceso al Api
//****************************************************************************************
using System.Security.Claims;

namespace ApiDigitalizacion.Models
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

                return new
                {
                    success = true,
                    message = "exito",
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

    }
}
