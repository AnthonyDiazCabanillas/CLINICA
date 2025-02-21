//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version       Fecha          Autor        Requerimiento
//    1.0           05/08/2024     HVIDAL       REQ 2024-011506 Controller que valida el acceso al Api
//****************************************************************************************
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ApiDigitalizacion.Models;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ent.Sql.SeguridadE.SeguridadE;
using Dat.Sql.SeguridadAD.SeguridadAD;
using Dat.Sql.ClinicaAD.UsuarioAD;
using Ent.Sql.ClinicaE.UsuariosE;
using Bus.Clinica.Clinica;
using Microsoft.AspNetCore.Cors;
using static Bus.AgendaClinica.Clinica.SynapsisWS.ResponseNotificationOrderApi;

namespace ApiDigitalizacion.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        public IConfiguration _configuration;
        public UsuarioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [EnableCors("CorsPolicy")]
        [HttpPost]
        [Route("login")]
        public dynamic IniciarSesion([FromBody] LoginApiE optData)
        {
            try
            {   
                UsuarioCitaE usuario = new UsuarioCitaAD().Sp_UsuarioCita_Consulta(new UsuarioCitaE("", optData.usuario, optData.password, "", 4));

                if (usuario == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, new { success = false, mensaje = "Credenciales incorrectas", result = "" });
                }

                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("id", usuario.IdUsuario),
                    new Claim("usuario", usuario.CodigoUsuario)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
                var singIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                        jwt.Issuer,
                        jwt.Audience,
                        claims,
                        expires: DateTime.Now.AddHours(24),
                        signingCredentials: singIn
                    );

                return new
                {
                    success = true,
                    message = "exito",
                    result = new JwtSecurityTokenHandler().WriteToken(token)
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }
    }
}
