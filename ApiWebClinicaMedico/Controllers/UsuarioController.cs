using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebAppCitaAgenda.Models;
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
using Dat.Sql.ClinicaAD.MedicosAD;

namespace ApiPaginaWebCSF.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : Controller
    {


        private readonly Seguridad SeguridadBL = new Seguridad();


        public IConfiguration _configuration;
        public UsuarioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        /// <summary>
        /// Devuelve el token a usar en el servicio GetDatoPersona usado por la NuevaAgenda
        /// </summary>
        /// <param name="optData">recibe usuario y clave registrados en la nueva agenda</param>
        /// <returns></returns>
        [EnableCors("CorsPolicy")]
        [HttpPost]
        [Route("login")]
        public dynamic IniciarSesion([FromBody] LoginApiE optData)
        {
            try
            {
                string resultado = new MedicosAD().Sp_MedicoWeb_Usuario(optData.usuario, optData.password);

                if (resultado != "OK")
                {
                    return new
                    {
                        success = false,
                        message = "Credenciales incorrectas",
                        result = ""
                    };
                }

                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("id", optData.usuario),
                    new Claim("usuario", optData.password)
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
