//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version       Fecha          Autor        Requerimiento
//    1.0           05/08/2024     HVIDAL       REQ 2024-011506 Controller que desencripta clave de red
//****************************************************************************************
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiDigitalizacion.Models;
using System.Security.Claims;
using Bus.Clinica;
using Ent.Sql.ClinicaE.PacientesE;
using Ent.Sql.ClinicaE.HospitalE;
using Dat.Sql.ClinicaAD.HospitalAD;
using Microsoft.AspNetCore.Authorization;
using Bus.AgendaClinica.Clinica;
using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql;
using Dat.Sql;

namespace ApiDigitalizacion.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UtilitarioController : Controller
    {
        private readonly IWebHostEnvironment environment;
        public UtilitarioController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpPost]
        [Route("Desencriptar")]
        [Authorize]
        public dynamic Desencriptar([FromBody] UtilitarioE pUtilitario)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                Utilitario oUtilitario = new Utilitario();
                var oData = oUtilitario.Sp_EncriptarDesencriptar_Valor(pUtilitario);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oData });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }
    }
}
