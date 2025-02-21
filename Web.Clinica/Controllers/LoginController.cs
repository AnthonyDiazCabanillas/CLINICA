using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Bus.Clinica.Clinica;
using Ent.Sql.ClinicaE.UsuariosE;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Http;
using Web.Clinica.Pages.Login;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Net;
using System.Text;
//using System.Net.Http;
using static Bus.AgendaClinica.Clinica.SynapsisWS.ResponseNotificationOrderApi;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Text.Json.Nodes;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
using Ent.Sql.ClinicaE;
using RestSharp;
using System.Xml;
using Newtonsoft.Json.Linq;
using Bus.Utilities;
using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.OtrosE;
using System.Net.Http;

//using RestSharp;

namespace Web.Clinica.Controllers
{
    public class LoginController : Controller
    {
        private readonly Seguridad SeguridadBL = new Seguridad();
        List<TablasE> oList = new List<TablasE>();

        public IActionResult Index()
        {
            return View();
        }

        public string GetHeaderValue([FromHeader(Name = "device-id")] string id)
        {
            return id;
        }

        //public dynamic PSF_SetParametro()
        //{
        //    string objBase = "{ \"usuario\": \"jcaicedo\", \"password\": \"123456x\"}";
        //    string objEncriptado = Bus.Utilities.Criptography.EncryptConectionString(objBase);
        //    return PSF_GetParametro(objEncriptado);
        //}

        //private dynamic PSF_GetParametro(string pCadenaEncriptada)
        //{
        //    string oDato = Bus.Utilities.Criptography.DecryptConectionString(pCadenaEncriptada);
        //    dynamic data = JsonConvert.DeserializeObject<dynamic>(oDato);
        //    return data;
        //}

        [HttpPost("account/login")]
        public async Task<ActionResult> LoginAsync(Credenciales oCredenciales)
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
                    //Loginc.Password = Bus.Utilities.Criptography.EncryptPasswordClinica(oCredenciales.PasswordClinica.ToUpper());
                    Loginc.Password = oCredenciales.PasswordClinica;
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
                            new Claim(ClaimTypes.Sid, oSeguridadE.IdPerfil.ToString().Trim()),
                            new Claim(ClaimTypes.UserData, oSeguridadE.CodUser.ToString().Trim())//1.0

                        };
                        //Fin

                        //Se guarda los datos obtenidos del usuario que se loguea en ClaimsIdentity
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                        bool lsw = HttpContext.User.Identity.IsAuthenticated;

                        if (HttpContext == null)
                        {

                            //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProperties);


                        }
                        else
                        {
                            var result = HttpContext.Request.Headers["provider"];
                            var result2 = controller.GetHeaderValue("provider");

                            //Guarda el idusuario en una variable Global -- GLLUNCOR
                            var userDataClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.UserData);
                            Web.Clinica.MetaGlobal.IdUserLogin = Convert.ToInt32(userDataClaim?.Value);

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


        [HttpPost("account/login2")]
        public async Task<ActionResult> LoginAsync2(Credenciales oCredenciales, HttpContext httpContext, UsuarioAux oUsuarioAux)
        {
            try
            {
                if (oCredenciales.TipoConexion != "Seleccionar Ambiente")
                {


                    oCredenciales.UsernameClinica = oUsuarioAux.usuario;
                    oCredenciales.PasswordClinica = oUsuarioAux.clave;



                    LoginE Loginc = new LoginE();
                    SeguridadE oSeguridadE = new SeguridadE();

                    //Cmendez 20/05/22 - Se crea para manejar una variable HttpContext
                    LoginController controller = new LoginController();
                    controller.ControllerContext = new ControllerContext();
                    controller.ControllerContext.HttpContext = new DefaultHttpContext();
                    //Fin

                    string token = "Mitoken";
                    //string valor = pLeeRuta(token).ToString();


                    Loginc.Login = oCredenciales.UsernameClinica.ToUpper();
                    //Loginc.Password = Bus.Utilities.Criptography.EncryptPasswordClinica(oCredenciales.PasswordClinica.ToLower());
                    Loginc.Password = Bus.Utilities.Criptography.EncryptPasswordClinica(oCredenciales.PasswordClinica);
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
                            new Claim(ClaimTypes.Sid, oSeguridadE.IdPerfil.ToString().Trim()),
                          };
                        //Fin

                        //Se guarda los datos obtenidos del usuario que se loguea en ClaimsIdentity
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                        //bool lsw = HttpContext.User.Identity.IsAuthenticated;

                        if (HttpContext == null)
                        {

                            AuthenticationProperties authProperties = new AuthenticationProperties
                            {
                                AllowRefresh = true,
                                //ExpiresUtc = DateTime.Now.AddDays(_jwtModel.ExpirationInDays),
                                IsPersistent = true,
                                IssuedUtc = DateTime.Now,
                                //Parameters["provider"] = claimsPrincipal,
                            };


                            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProperties);
                            //https://stackoverflow.com/questions/58387683/signin-for-blazor-server-side-app-not-working
                            //https://dvoituron.com/2021/08/26/blazor-cookie-authentication/


                            //js.InvokeVoidAsync("alert", oUsuarioAux.ruta);
                            //SeguridadBL.Sp_XTMP_Auditor_Insert(oUsuarioAux.ruta + " -- LoginAsync2()");
                            return LocalRedirect(oUsuarioAux.ruta);
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



        public async Task<IActionResult> Redirige(string _pDato)
        {
            //return RedirectPermanentPreserveMethod(_pDato);
            //httpContext.Response.Redirect(_pDato);
            return LocalRedirect(_pDato);
        }


        public UsuarioAux pLeeRutaVerAsync(string _pDato)
        {
            UsuarioAux resultContent = new UsuarioAux();
            try
            {
                // Obtener tarifa del QR.
                string url = "";
                oList = new TablasAD().Sp_Tablas_Consulta(new TablasE("APIKEYPSF", "03", 0, 0, 8));
                if (oList.Count > 0)
                {

                    url = oList[0].Nombre;
                    //string url = (oList.Count >= 0 ? oList[0].Nombre : "");
                    url = url + "AgendaCita/CitaPSF_RutaEjecuta?pDato=" + _pDato;
                    //SeguridadBL.Sp_XTMP_Auditor_Insert(url + " -- pLeeRutaVerAsync(1)");

                    var client = new RestClient(url);
                    var request = new RestRequest();
                    request.Method = Method.Get;
                    RestResponse response = client.Execute(request);
                    RptApi oRptApi = JsonConvert.DeserializeObject<RptApi>(response.Content);
                    string xml = oRptApi.result;
                    //SeguridadBL.Sp_XTMP_Auditor_Insert(xml + " -- pLeeRutaVerAsync(2)");

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);
                    string json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
                    //SeguridadBL.Sp_XTMP_Auditor_Insert(json + " -- pLeeRutaVerAsync(3)");

                    resultContent = JsonConvert.DeserializeObject<UsuarioAux>(json);
                }
            }
            catch (Exception ex)
            {
                string Tuerror = ex.Message;
                //SeguridadBL.Sp_XTMP_Auditor_Insert(ex.Message + " -- pLeeRutaVerAsync(4)");
                //resultContent = ex.Message;
            }
            return resultContent;
        }


        [HttpGet("/account/logout")]
        public async Task<IActionResult> Logout()
        {
            ViewBag.Name = "";
            ViewBag.Login = "";
            ViewBag.CodSexo = "";
            ViewBag.UrlFoto = "";
            ViewBag.Dns = "";
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("/");
        }
    }
    public class Credenciales
    {
        [Required]
        //[RegularExpression(@"^[a-zA-Z0-9]*$",
        // ErrorMessage = "Characters are not allowed.")]
        public string UsernameClinica { get; set; }
        [Required]
        public string PasswordClinica { get; set; }
        [Required]
        public string TipoConexion { get; set; }
        public bool RememberMe { get; set; }
    }

    public class UsuarioAux
    {

        public string usuario { get; set; } = "";
        public string clave { get; set; } = "";
        public string ruta { get; set; } = "";
    }

    public class UsuarioLogin
    {

        public string usuario { get; set; } = "";
        public string password { get; set; } = "";
        //public string ruta { get; set; } = "";
    }


    public class RptApi
    {

        public bool success { get; set; }
        public string mensaje { get; set; }
        public string result { get; set; }
    }

}