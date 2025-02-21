//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version       Fecha          Autor        Requerimiento
//    1.0           05/08/2024     HVIDAL       REQ 2024-011506 Controller que proporciona información a ScanFlw
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

namespace ApiDigitalizacion.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DigitalizacionController : Controller
    {
        private readonly IWebHostEnvironment environment;
        public DigitalizacionController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpGet]
        [Route("ListarAtenciones")]
        [Authorize]
        public dynamic ListarAtenciones([FromQuery] string? docidentidad = "", [FromQuery] string? tipdocidentidad = "")
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                PacientesE pPacientesE = new PacientesE();
                pPacientesE.Docidentidad = docidentidad;
                pPacientesE.Tipdocidentidad = tipdocidentidad;
                pPacientesE.Orden = 1;

                Pacientes oPacientes = new Pacientes();
                var oData = oPacientes.Sp_Pacientes_ListarAtenciones(pPacientesE);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oData });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }

        [HttpGet]
        [Route("ListarMetaData")]
        [Authorize]
        public dynamic ListarMetaData([FromQuery] string? codatencion = "")
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                HospitalE pHospitalE = new HospitalE();
                pHospitalE.CodAtencion = codatencion;
                pHospitalE.Orden = 1;

                HospitalAD oHospitalAD = new HospitalAD();
                var oData = oHospitalAD.Sp_Hospital_ListarMetaData(pHospitalE);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oData });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }
    }
}
