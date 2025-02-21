using Api.Clinica.Data;
using Bus.Clinica;
using Bus.Utilities;
using Ent.Sql;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("PrestacionesClinica")]
    public class PrestacionesClinicaController : ControllerBase
    {
        Config _config = new Config();

        [Route("API/Clinica/Listado_Prestaciones")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Listado_Prestaciones([FromBody] PrestacionBusqE busq) 
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    var resultado = await new PrestacionesClinica().Listado_Prestaciones(busq);
                    if (resultado.IdRegistro == -1)
                    {
                        return BadRequest(resultado.Mensaje);
                    }
                    return Ok(resultado);
                }
                else 
                {
                    return BadRequest("Error de acceso");
                }                    
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("API/Clinica/Listado_Tarifario")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Listado_Tarifario([FromBody] PrestacionBusqE busq) 
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    var resultado = await new PrestacionesClinica().Listado_Tarifario(busq);
                    if (resultado.IdRegistro == -1)
                    {
                        return BadRequest(resultado.Mensaje);
                    }
                    return Ok(resultado);
                }
                else 
                {
                    return BadRequest("Error de acceso");
                }
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }



        [Route("API/Clinica/Listado_PrestacionTarifa")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Listado_PrestacionTarifa([FromBody] PrestacionBusqE busq) 
        {
            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    var resultado = await new PrestacionesClinica().Listado_PrestacionTarifario(busq);
                    if (resultado.IdRegistro == -1)
                    {
                        return BadRequest(resultado.Mensaje);
                    }
                    return Ok(resultado);
                }
                else
                {
                    return BadRequest("Error de acceso");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("API/Clinica/Registrar_TarifarioPrestacion")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Registrar_TarifarioPrestacion([FromBody] List<PrestacionesClinicaE> objprestacion) 
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    int Iduser = Convert.ToInt32(Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "AuthoKey").FirstOrDefault().Value));
                    var insertar = await new PrestacionesClinica().Registro_PrestacionTarifa(objprestacion, Iduser);
                    if (insertar.IdRegistro == -1)
                    {
                        return BadRequest(insertar.Mensaje);
                    }
                    else 
                    {
                        return Ok(insertar);
                    }
                }
                else
                {
                    return BadRequest("Error de acceso");
                }
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }
    }
}
