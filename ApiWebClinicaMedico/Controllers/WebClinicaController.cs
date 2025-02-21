//********************************************************************************************************************
//   Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

//    Version  Fecha        Autor           Requerimiento
//    1.0      14/06/2024   CPARRALES       REQ 2024-005048 Proyecto buscador web
//******************************************************************************************************************** 
using Bus.AgendaClinica.Clinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAppCitaAgenda.Models;
using static Bus.AgendaClinica.Clinica.AgendaCitas;
using Microsoft.AspNetCore.Authorization;
using Ent.Sql.ClinicaE.PacientesE;
using Dat.Sql.ClinicaAD.PacientesAD;
using Dat.Sql.SeguridadAD.SeguridadAD;
using Ent.Sql.ClinicaE.UsuariosE;
using Ent.Sql.SeguridadE.SeguridadE;
using Newtonsoft.Json;
using System.DirectoryServices.Protocols;
using Ent.Sql.ClinicaE.MedicosE;
using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.OtrosE;
using ApiPaginaWebCSF.Filters;
using Dat.Sql.ClinicaAD.MedicosAD;

namespace ApiPaginaWebCSF.Controllers
{
    [TypeFilter(typeof(ExceptionManagerFilter))]
    public class WebClinicaController : Controller
    {

        Generales oGenerales = new Generales();

        [HttpGet]
        [Route("ObtenerEspecialidades")]
        [Authorize]
        public dynamic ObtenerEspecialidades()
        {
            List<EspecialidadWebE> oListaEspecialidadWebE = new List<EspecialidadWebE>();
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                oListaEspecialidadWebE = new MedicosAD().Sp_EspecialidadWeb_Consulta();

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oListaEspecialidadWebE });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, new { success = false, mensaje = e.Message, result = "" });
            }
        }


        [HttpGet]
        [Route("ObtenerMedicos")]
        [Authorize]
        public dynamic Sp_MedicosWeb_Consulta()
        {
            List<MedicoWebE> oListMedicoWebE = new List<MedicoWebE>();
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                oListMedicoWebE = new MedicosAD().Sp_MedicosWeb_Consulta();

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oListMedicoWebE });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, new { success = false, mensaje = e.Message, result = ""  });
            }
        }

        [HttpGet]
        [Route("ObtenerDetalleMedico")]
        [Authorize]
        public dynamic ObtenerDetalleMedico(int pidm)
        {
            MedicoDetalleWebE oMedicoDetalleWebE = new MedicoDetalleWebE();
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                oMedicoDetalleWebE = new MedicosAD().Sp_MedicoWeb_Detalle_Consulta(pidm);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oMedicoDetalleWebE });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }
        //1.0 INI
        [HttpGet]
        [Route("ObtenerDetalleMedicoV2/{pidm}")]
        [Authorize]
        public dynamic ObtenerDetalleMedicoV2(string pidm)
        {
            MedicoDetalleWebE oMedicoDetalleWebE = new MedicoDetalleWebE();
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                oMedicoDetalleWebE = new MedicosAD().Sp_MedicoWeb_Detalle_ConsultaV2(pidm);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oMedicoDetalleWebE });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }
        //1.0 FIN

        [HttpGet]
        [Route("ObtenerDetalleEspecialidad")]
        [Authorize]
        public dynamic ObtenerDetalleEspecialidad(int pesp)
        {
            List<EspecialidadDetalleWebE> oListaEspecialidadWebE = new List<EspecialidadDetalleWebE>();
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                oListaEspecialidadWebE = new MedicosAD().Sp_EspecialidadDetalleWeb_Consulta(pesp);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oListaEspecialidadWebE });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, new { success = false, mensaje = e.Message, result = "" });
            }
        }


    }
}
