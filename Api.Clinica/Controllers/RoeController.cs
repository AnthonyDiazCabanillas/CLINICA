//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor        Requerimiento
//    1.0             10/01/2025     HVIDAL       REQ 2024-014877 Neonatologia
//***************************************************************************************
using Api.Clinica.Data;
using Bus.Clinica.Clinica;
using Bus.Utilities;
using Ent.Sql.ClinicaE.PacientesE;
using Microsoft.AspNetCore.Mvc;
using Api.Clinica.Model;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Ent.Sql.ClinicaE.OtrosE;
using Dat.Sql.SeguridadAD.SeguridadAD;
using Ent.Sql.SeguridadE.SeguridadE;
using Dat.Sql.ClinicaAD.OtrosAD;
using Bus.Clinica.Logistica;
using static Ent.Sql.ProveedorE.TCI.ObtenerPDF;
using WsTciComprobantes;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("Roe")]

    public class RoeController : Controller
    {
        [Route("API/Clinica/EnviarDatosNeonatologia")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> EnviarDatosNeonatologia([FromBody] Request.Roe pRoe)
        {
            try
            {
                var LTabla = new TablasAD().Sp_Tablas_Consulta(new TablasE("", "", 0,0, 33));
                var urlEndPoint = LTabla[0].Nombre;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                using (HttpClient client = new HttpClient())
                {
                    var jsonData = JsonConvert.SerializeObject(pRoe);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    using (var request = new HttpRequestMessage(HttpMethod.Put, urlEndPoint) { Content = content })
                    {
                        var response = await client.SendAsync(request);

                        var respuesta = await response.Content.ReadAsStringAsync();
                        return Ok(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
