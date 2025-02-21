//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             27/08/2024     HVIDAL      REQ 2024-XXXXX ACCESO TOKEN APIAGENDA
//****************************************************************************************
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

namespace WebAppCitaAgenda.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioCitaController : ControllerBase
    {

        private readonly Seguridad SeguridadBL = new Seguridad();


        public IConfiguration _configuration;
        public UsuarioCitaController(IConfiguration configuration)
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
                //Object optData
                //var data = JsonConvert.DeserializeObject<dynamic>(optData.ToString());

                string user = optData.usuario;
                string password = optData.password;

                ////UsuarioE usuario = UsuarioE.DB().Where(x => x.usuario == user && x.passrowd == password).FirstOrDefault();
                //UsuarioCitaE usuario = new UsuarioCitaAD().Sp_UsuarioCita_Consulta(new UsuarioCitaE("", user, password, "", 1));
                //INI 1.0
                UsuarioCitaE usuario = new UsuarioCitaAD().Sp_UsuarioCita_Consulta(new UsuarioCitaE("", user, password, "", 3));
                //FIN 1.0

                if (usuario == null)
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





        /// <summary>
        /// Devuelve el token a usar en los servicios del Portal CSF
        /// </summary>
        /// <param name="optData">recibe usuario y clave registrados en SIC</param>
        /// <returns></returns>
        [HttpPost]
        [Route("loginPSF")]
        public dynamic IniciarSesionPSF([FromBody] LoginApiE optData)
        {
            try
            {
                //var data = JsonConvert.DeserializeObject<LoginE>(optData.ToString());

                string user = optData.usuario;
                string password = optData.password;

                LoginE Loginc = new LoginE();
                SeguridadE oSeguridadE = new SeguridadE();

                Loginc.Login = user.ToUpper();
                Loginc.Password = password;//Bus.Utilities.Criptography.EncryptPasswordClinica(password.ToUpper());
                Loginc.IdeModulo = "Portal Clinica"; //MetaGlobal.NameSistema;
                Loginc.DscVersion = "22.7.0"; //MetaGlobal.VersionPublicacion;
                oSeguridadE = SeguridadBL.GetLogin(Loginc);
                if (oSeguridadE.Estado != null)
                {

                    var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

                    var claims = new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("id", oSeguridadE.ide_usuario.ToString()),
                    new Claim("usuario", oSeguridadE.Login.ToString())
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
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: Credenciales incorrectas", result = "" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });

            }



        }


    }
}
