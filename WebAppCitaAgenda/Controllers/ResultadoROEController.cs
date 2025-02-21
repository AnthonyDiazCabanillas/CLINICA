//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             06/09/2024     HVIDAL      REQ 2024-010467 RESULTADOS ROE
//****************************************************************************************
using Bus.AgendaClinica.Clinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAppCitaAgenda.Models;
using Newtonsoft.Json;
using System.Text;
using static Bus.AgendaClinica.Clinica.AgendaCitas;
using Microsoft.AspNetCore.Authorization;
using Ent.Sql.ProveedorE.ROE;
using static Ent.Sql.ProveedorE.ROE.ResultadosRoeE;
using System.Globalization;
using Bus.AgendaClinica.Proveedores;

namespace WebAppCitaAgenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultadoROEController : Controller
    {
        [HttpPost]
        [Route("ListarResultados")]
        [Authorize]
        public dynamic ListarResultados([FromBody] ResultadosRoeE.ReqListarAtencionSoftvan pRequest)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                string urlEndPoint = new AgendaCitas().pValorCodigoTabla("URL_ROE_SERVICIO", "01");
                string codigoEmpresa = new AgendaCitas().pValorCodigoTabla("URL_ROE_VALOR", "01");
                string tipoBusqueda = new AgendaCitas().pValorCodigoTabla("URL_ROE_VALOR", "02");

                var oRequest = new ResultadosRoeE.ReqListarAtencionCSF();
                oRequest.codigoEmpresa = codigoEmpresa;
                oRequest.tipoBusqueda = tipoBusqueda;
                oRequest.busqueda = pRequest.numeroDocumento;
                string body = JsonConvert.SerializeObject(oRequest);

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

                    HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = httpClient.PostAsync(urlEndPoint, content).Result;

                    var LResultadoCSF = new List<ResultadosRoeE.ResListarAtencionCSF>();
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        var LResultadosRoeE = JsonConvert.DeserializeObject<ResultadosRoeE.ResListarAtencionSoftvan>(responseBody);
                        
                        if (LResultadosRoeE.detalleOrdenes == null)
                            return StatusCode(StatusCodes.Status200OK, new { success = true, message = "No se encontraron resultados en la busqueda.", result = LResultadoCSF });

                        foreach (var item in LResultadosRoeE.detalleOrdenes)
                        {
                            DateTime fecha;
                            DateTime.TryParseExact(item.fechaHoraAtencion, new[] { "d/M/yyyy HH:mm:ss", "dd/MM/yyyy HH:mm:ss" },CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

                            if (fecha.Year == Convert.ToInt32(pRequest.periodo))
                            {
                                var oResultadoCSF = new ResultadosRoeE.ResListarAtencionCSF
                                {
                                    ordenAtencion = item.ordenAtencion,
                                    codatencion = item.codigoAtencionCSF,
                                    fec_registra = item.fechaHoraAtencion,
                                    numDocumento = item.numeroDocumento,
                                    nombrePaciente = item.nombreCompletoPaciente.Substring(0, item.nombreCompletoPaciente.IndexOf("</br>")),
                                    nombreExamen = item.nombresAnalisis,
                                    esInformeResultado = item.puedeVerResultados,
                                    esInformeHistorico = item.puedeVerHistoricos
                                };
                                LResultadoCSF.Add(oResultadoCSF);
                            }
                        }

                        return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Búsqueda encontrada de manera correcta.", result = LResultadoCSF });
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Busqueda no encontrada con el servicio ROE.", result = LResultadoCSF });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Error al buscar los resultados.", result = new List<ResultadosRoeE.ResListarAtencionCSF>() });
            }
        }

        [HttpPost]
        [Route("ObtenerResultado")]
        [Authorize]
        public dynamic ObtenerResultado([FromBody] ResultadosRoeE.ReqObtenerResultadoSoftvan pRequest)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                string urlEndPoint = new AgendaCitas().pValorCodigoTabla("URL_ROE_SERVICIO", "04");
                string body = JsonConvert.SerializeObject(pRequest);

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

                    HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = httpClient.PostAsync(urlEndPoint, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        var ResultadosRoeE = JsonConvert.DeserializeObject<ResultadosRoeE.ResObtenerResultadoSoftvan>(responseBody);

                        return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Búsqueda encontrada de manera correcta.", result = ResultadosRoeE.data });
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Busqueda no encontrada con el servicio ROE.", result = "" });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Error al buscar los resultados.", result = "" });
            }
        }

        [HttpPost]
        [Route("ObtenerHistorico")]
        [Authorize]
        public dynamic ObtenerHistorico([FromBody] ResultadosRoeE.ReqObtenerResultadoSoftvan pRequest)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                List<string> LAnalisis = new ResultadosROE().ObtenerAnalisis(pRequest);

                string urlEndPoint = new AgendaCitas().pValorCodigoTabla("URL_ROE_SERVICIO", "05");
                var oReqListarHistorico = new ResultadosRoeE.ReqListarHistorico();
                oReqListarHistorico.ordenAtencion = pRequest.ordenAtencion;
                oReqListarHistorico.listaCodigosAnalisis = LAnalisis;
                oReqListarHistorico.toBase64 = true;
                string body = JsonConvert.SerializeObject(oReqListarHistorico);

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

                    HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = httpClient.PostAsync(urlEndPoint, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        var ResultadosRoeE = JsonConvert.DeserializeObject<ResultadosRoeE.ResObtenerHistoricoSoftvan>(responseBody);

                        return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Búsqueda encontrada de manera correcta.", result = ResultadosRoeE.data[0] });
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Busqueda no encontrada con el servicio ROE.", result = "" });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Error al buscar los resultados.", result = "" });
            }
        }

    }
}
