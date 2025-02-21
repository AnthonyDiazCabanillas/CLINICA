using Api.Clinica.Data;
using Bus.Clinica.Clinica;
using Bus.Utilities;
using Ent.Sql.ClinicaE;
using Microsoft.AspNetCore.Mvc;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("Tramas")]
    public class TramasController : ControllerBase
    {
        Config _config = new Config();

        [Route("API/Clinica/ListadoTabsTrama")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListadoTabsTrama() 
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    var Resultado = await new TramaBus().ListadoTramaTabs();
                    if (Resultado.IdRegistro == -1)
                    {
                        return BadRequest(Resultado.Mensaje);
                    }
                    return Ok(Resultado);
                }
                else 
                {
                    return BadRequest("Usuario no autorizado");
                }
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

        [Route("API/Clinica/ListadoDetalleTramas")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ListadoDetalleTramas(string NroComprobante) 
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key) 
                {
                    var resultado = await new TramaBus().ListadoDetalleTramas(NroComprobante);
                    if (resultado.IdRegistro == -1)
                    {
                        return BadRequest(resultado.Mensaje);
                    }
                    return Ok(resultado);
                }
                else {
                    return BadRequest("Usuario no autorizado");
                }
                    
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        
        [Route("API/Clinica/ActualizarDetalleTrama")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ActualizarDetalleTrama([FromBody] TramasE objTrama) 
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    var tramaupdate = await new TramaBus().ActualizarTramas(objTrama);
                    if (tramaupdate.IdRegistro == -1)
                    {
                        return BadRequest(tramaupdate.Mensaje);
                    }


                    return Ok(tramaupdate);
                }
                else {
                    return BadRequest("Usuario no autorizado");
                }
                    
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
    }
}
