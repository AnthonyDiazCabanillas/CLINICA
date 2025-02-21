//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             06/09/2024     HVIDAL      REQ 2024-010468 IMAGENES DEL VUEMOTION
//****************************************************************************************
using Bus.AgendaClinica.Clinica;
using Dat.Sql.ClinicaAD.PacientesAD;
using Ent.Sql.ClinicaE.PacientesE;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAppCitaAgenda.Models;
using Newtonsoft.Json;
using System.Text;
using static Bus.AgendaClinica.Clinica.AgendaCitas;
using Ent.Sql.ClinicaE.MedicosE;
using Ent.Sql.RisClinicaE.ImagenRisPacs;
using Dat.Sql.RisClinicaAD.ImagenRisPacsAD;
using Ent.Sql.ClinicaE.RceE;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;
using Bus.Utilities;
using static Ent.Sql.RisClinicaE.ImagenRisPacs.ImagenRisPacsE;

namespace WebAppCitaAgenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagenRisPacsController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        Generales oGenerales = new Generales();

        public ImagenRisPacsController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet]
        [Route("ListarPeriodos")]
        [Authorize]
        public dynamic ListarPeriodos([FromQuery] string? codPaciente = "")
        {
           try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                ImagenRisPacsE oImagenRisPacsE = new ImagenRisPacsE();
                oImagenRisPacsE.codpaciente = Convert.ToInt32(codPaciente);

                ImagenRisPacsAD oImagenRisPacsAD = new ImagenRisPacsAD();
                var LPeriodos= oImagenRisPacsAD.Sp_ImagenRis_ListarPeriodo(oImagenRisPacsE);

                return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Ok", result = LPeriodos });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, message = e.Message, result = "" });
            }
        }

        [HttpGet]
        [Route("ListarImagenes")]
        [Authorize]
        public dynamic ListarImagenes([FromQuery] string? codPaciente = "", [FromQuery] string? periodo = "")
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                // Obtener el jti del token
                var jti = identity.Claims.FirstOrDefault(c => c.Type == "jti")?.Value;
                if (string.IsNullOrWhiteSpace(jti))
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new { success = false, message = "Token inválido", result = "" });
                }

                if (!ValidarIntentos(jti))
                {
                    return StatusCode(StatusCodes.Status429TooManyRequests, new { success = false, message = "Límite de intentos alcanzado", result = "" });
                }

                ImagenRisPacsE oImagenRisPacsE = new ImagenRisPacsE();
                oImagenRisPacsE.codpaciente = Convert.ToInt32(codPaciente);
                oImagenRisPacsE.periodo = Convert.ToInt32(periodo);

                ImagenRisPacsAD oImagenRisPacsAD = new ImagenRisPacsAD();
                var LImagenes = oImagenRisPacsAD.Sp_ImagenRis_ListarImagen(oImagenRisPacsE);

                return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Ok", result = LImagenes });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, message = e.Message, result = "" });
            }
        }

        [HttpPost]
        [Route("ObtenerResultado")]
        [Authorize]
        public dynamic ObtenerResultado([FromBody] ImagenRisPacsE.ReqObtenerResultado pReqObtenerResultado)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                //Validar que el codpaciente corresponde a la imagen
                var oImagenRisE = new ImagenRisPacsE(Convert.ToInt32(pReqObtenerResultado.codPaciente), 1);
                oImagenRisE.identificador = pReqObtenerResultado.idInformeResultado;
                var oImagenValidar = new ImagenRisPacsAD().Sp_ImagenRis_Validar(oImagenRisE);

                if (oImagenValidar.cantidad == 0)
                    return StatusCode(StatusCodes.Status403Forbidden, new { success = true, message = "Ok", result = "El acceso esta restringido, no corresponde el resultado con el paciente" });

                ImagenRisPacsAD oImagenRisPacsAD = new ImagenRisPacsAD();
                var oResultado = oImagenRisPacsAD.Sp_ImagenRis_ObtenerResultado(pReqObtenerResultado);

                return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Ok", result = oResultado });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, message = e.Message, result = "" });
            }
        }

        [HttpPost]
        [Route("ObtenerImagen")]
        [Authorize]
        public dynamic ObtenerImagen([FromBody] ImagenRisPacsE.ReqObtenerImagen pReqObtenerImagen)
        {
            string MensajeInoperativo = "";
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                string valorUrlToken = new AgendaCitas().pValorCodigoTablaImg("RIS_URL_APIAGENDA", "01");
                string valorParametro = new AgendaCitas().pValorCodigoTablaImg("RIS_URL_APIAGENDA", "02");
                string valorUsuario = new AgendaCitas().pValorCodigoTablaImg("RIS_URL_APIAGENDA", "03");
                string valorClave = new AgendaCitas().pValorCodigoTablaImg("RIS_URL_APIAGENDA", "04");
                string valorUrlImagen = new AgendaCitas().pValorCodigoTablaImg("RIS_URL_APIAGENDA", "05");
                MensajeInoperativo = new AgendaCitas().pValorCodigoTablaImg("RIS_MENSAJE_INOPERATIVO", "01");

                valorParametro = valorParametro.Replace("%U", valorUsuario);
                valorParametro = valorParametro.Replace("%P", valorClave);
                valorParametro = valorParametro.Replace("%H", "");
                valorParametro = valorParametro.Replace("%O", pReqObtenerImagen.idImagenResultado);

                string rutaToken = valorUrlToken + valorParametro;
                var body = valorParametro;

                HttpClientHandler handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                };

                //Validar que el codpaciente corresponde a la imagen
                var oImagenRisE = new ImagenRisPacsE(Convert.ToInt32(pReqObtenerImagen.codPaciente), 2);
                oImagenRisE.identificador = pReqObtenerImagen.idImagenResultado;
                var oImagenValidar = new ImagenRisPacsAD().Sp_ImagenRis_Validar(oImagenRisE);

                if (oImagenValidar.cantidad == 0)
                    return StatusCode(StatusCodes.Status403Forbidden, new { success = true, message = "Ok", result = "El acceso esta restringido, no corresponde la imagen con el paciente" });


                using (HttpClient httpClient = new HttpClient(handler))
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

                    var newBody = JsonConvert.SerializeObject(body);
                    HttpContent content = new StringContent(newBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = httpClient.PostAsync(rutaToken, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = response.Content.ReadAsStringAsync().Result;
                        var token = responseBody.Substring(1, responseBody.Length - 2);
                        valorUrlImagen = valorUrlImagen + token;
                        return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Ok", result = valorUrlImagen });
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status200OK, new { success = true, message = MensajeInoperativo, result = MensajeInoperativo });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { success = false, message = MensajeInoperativo, result = MensajeInoperativo });
            }
        }

        private bool ValidarIntentos(string jti)
        {
            //Obtener valores desde Tablas configurables
            int valorIntentos = Convert.ToInt32(new AgendaCitas().pValorCodigoTablaImg("INTENTOS_IMAGEN_VUE", "01"));
            int valorTiempo = Convert.ToInt32(new AgendaCitas().pValorCodigoTablaImg("TIEMPO_IMAGEN_VUE", "01"));

            var cacheKey = $"intentos_{jti}";

            if (!_memoryCache.TryGetValue(cacheKey, out int intentos))
            {
                _memoryCache.Set(cacheKey, 1, TimeSpan.FromMinutes(valorTiempo));
                return true;
            }

            if (intentos >= valorIntentos)
            {
                return false;
            }

            _memoryCache.Set(cacheKey, intentos + 1, TimeSpan.FromMinutes(valorTiempo));
            return true;
        }

    }
}
