using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using static Bus.AgendaClinica.Clinica.AgendaCitas;
using Bus.AgendaClinica.Clinica;

namespace AgendaCita.Controllers
{
    public class AgendaCita
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AgendaCitaController : ControllerBase
        {

            public AgendaCitaController(IConfiguration config)
            {
                //cadenaSQL = config.GetConnectionString("cadenaSQL");
            }

            [HttpGet]
            [Route("MtDatosMedicosSic/{CodProfMedisyn:string}")]
            public IActionResult MtDatosMedicosSic2(string CodProfMedisyn)
            {
                TarifaParticular xResult = new TarifaParticular();
                try
                {
                    AgendaCitas agendaCitas = new AgendaCitas();    
                    xResult = agendaCitas.MtDatosMedicosSic(CodProfMedisyn);
                    return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = xResult });
                }

                catch (Exception e)
                {
                    //return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message, response = lstPersona });
                    return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = e.Message, response = xResult });
                }
            }

        }

    }
}
