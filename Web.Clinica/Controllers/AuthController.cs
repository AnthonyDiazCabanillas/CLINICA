using Ent.Sql.ClinicaE.UsuariosE;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using System;
using System.ComponentModel.DataAnnotations;

using System.Threading.Tasks;
using Bus.Clinica.Clinica;

using Microsoft.Extensions.Configuration;
//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;

namespace Web.Clinica.Controllers
{
    /// <summary>
    /// Web API to login a authenticated user, and store these claims into a local cookie.
    /// </summary>
    [ApiController]
    public class AuthController : ControllerBase //ControllerBase
    {
        private readonly Seguridad SeguridadBL = new Seguridad();


        private static readonly AuthenticationProperties COOKIE_SESSION = new AuthenticationProperties();
        private static readonly AuthenticationProperties COOKIE_EXPIRES = new AuthenticationProperties()
        {
            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            IsPersistent = true,
        };

        /// <summary />
        [HttpPost]
        [Route("api/auth/signin")]
        public async Task<ActionResult> SignInPost(Credenciales oCredenciales)
        {
            try
            {
                if (oCredenciales.TipoConexion != "Seleccionar Ambiente")
                {
                    LoginE Loginc = new LoginE();
                    SeguridadE oSeguridadE = new SeguridadE();

                    //Cmendez 20/05/22 - Se crea para manejar una variable HttpContext
                    LoginController controller = new LoginController();
                    controller.ControllerContext = new ControllerContext();
                    controller.ControllerContext.HttpContext = new DefaultHttpContext();
                    //Fin

                    Loginc.Login = oCredenciales.UsernameClinica.ToUpper();
                    Loginc.Password = Bus.Utilities.Criptography.EncryptPasswordClinica(oCredenciales.PasswordClinica.ToUpper());
                    Loginc.IdeModulo = MetaGlobal.NameSistema;
                    Loginc.DscVersion = MetaGlobal.VersionPublicacion;
                    oSeguridadE = SeguridadBL.GetLogin(Loginc);
                    if (oSeguridadE.Estado != null)
                    {
                        //Cmendez 13/05/2022 - Se agregan todas las variables que se deseen guardar en Claim
                        var claims = new[]
                        {
                            new Claim(ClaimTypes.Name, oSeguridadE.NombreCompleto.Trim()),
                            new Claim(ClaimTypes.NameIdentifier, oCredenciales.UsernameClinica.Trim()),
                            new Claim(ClaimTypes.Gender, oSeguridadE.CodSexo.Trim()),
                            new Claim(ClaimTypes.Uri, oSeguridadE.UrlFoto.Trim()),
                            new Claim(ClaimTypes.Dns, oCredenciales.TipoConexion.Trim()),
                            new Claim(ClaimTypes.Sid, oSeguridadE.IdPerfil.ToString().Trim())
                        };
                        //Fin

                        //Se guarda los datos obtenidos del usuario que se loguea en ClaimsIdentity
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                        //bool lsw = HttpContext.User.Identity.IsAuthenticated;

                        if (HttpContext == null)
                        {


                            ////Se asigna un Provider para que no genere error la variable HttpContext
                            //controller.ControllerContext.HttpContext.Request.Headers["provider"] = " ";
                            //var result = controller.ControllerContext.HttpContext.Request.Headers["provider"];
                            //await controller.ControllerContext.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                            //Redirect("/");
                            //HttpContext = new DefaultHttpContext();
                            ////var httpContext = controller.ControllerContext.GetHttpContext();
                            //////Se asigna un Provider para que no genere error la variable HttpContext
                            //controller.ControllerContext.HttpContext.Request.Headers["provider"] = "provider";

                            //var result = controller.ControllerContext.HttpContext.Request.Headers["provider"];
                            AuthenticationProperties authProperties = new AuthenticationProperties
                            {
                                AllowRefresh = true,
                                //ExpiresUtc = DateTime.Now.AddDays(_jwtModel.ExpirationInDays),
                                IsPersistent = true,
                                IssuedUtc = DateTime.Now,
                                //Parameters["provider"] = claimsPrincipal,
                            };


                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProperties);
                            //https://stackoverflow.com/questions/58387683/signin-for-blazor-server-side-app-not-working
                            //https://dvoituron.com/2021/08/26/blazor-cookie-authentication/

                        }
                        else
                        {
                            var result = HttpContext.Request.Headers["provider"];
                            var result2 = controller.GetHeaderValue("provider");
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                        }
                        //Se pueden agregar propiedades de tiempo de desconexion
                        //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,claimsPrincipal,
                        //                           new AuthenticationProperties
                        //                           {
                        //                               IsPersistent = true,
                        //                               ExpiresUtc = DateTime.UtcNow.AddHours(8)
                        //                           });
                        return Redirect("/Clinica/01/Clinica");
                    }
                    else
                    {
                        return Redirect("/login/Credenciales Invalidas/" + oCredenciales.UsernameClinica.ToUpper());
                    }
                }
                else
                {
                    return Redirect("/login/Debe Seleccionar Ambiente/" + oCredenciales.UsernameClinica);
                }
            }
            catch (Exception ex)
            {
                return Redirect("/login/Credenciales Invalidas/" + oCredenciales.UsernameClinica.ToUpper());
            }
        }


        /// <summary />
        [HttpPost]
        [Route("api/auth/signinOLD")]
        public async Task<ActionResult> SignInPostOLD(SigninData value)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, value.Email),
                new Claim(ClaimTypes.Name, value.Email),
                new Claim(ClaimTypes.Role, "Administrator"),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = COOKIE_EXPIRES;

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                          new ClaimsPrincipal(claimsIdentity),
                                          authProperties);

            return this.Ok();
        }

        /// <summary />
        [HttpPost]
        [Route("api/auth/signout")]
        public async Task<ActionResult> SignOutPost()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return this.Ok();
        }
    }

    /// <summary />
    public class SigninData
    {
        /// <summary />
        public string Email { get; set; }
        /// <summary />
        public string Password { get; set; }
    }
}
