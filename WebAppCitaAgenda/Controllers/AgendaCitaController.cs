//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         25/07/2024     HVIDAL       REQ 2024-011473 AGENDA DE PROCEDIMIENTOS
//****************************************************************************************
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
using Ent.Sql.ClinicaE.RceE;
using Bus.Clinica;
using Ent.Sql.ClinicaE.HospitalE;
using RestSharp;
using static Bus.AgendaClinica.Clinica.AdmisionHospitalariaWs;
using RestSharp;
using System.Text;
using WsTciComprobantes;
using Bus.Utilities;
using Dat.Sql.ClinicaAD.RceAD;
using System.ServiceModel.Channels;

namespace WebAppCitaAgenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendaCitaController : ControllerBase
    {

        Generales oGenerales = new Generales();


        //public AgendaCitaController()
        //{

        //}

        private readonly IWebHostEnvironment environment;
        //private readonly LearndataContext context;
        public AgendaCitaController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        //[HttpPut("UploadImage")]
        //private async Task<IActionResult> UploadImage(IFormFile formFile, string productcode)
        //{
        //    APIResponse response = new APIResponse();
        //    try
        //    {
        //        string Filepath = GetFilepath(productcode);
        //        if (!System.IO.Directory.Exists(Filepath))
        //        {
        //            System.IO.Directory.CreateDirectory(Filepath);
        //        }

        //        string imagepath = Filepath + "\\" + productcode + ".png";
        //        if (System.IO.File.Exists(imagepath))
        //        {
        //            System.IO.File.Delete(imagepath);
        //        }
        //        using (FileStream stream = System.IO.File.Create(imagepath))
        //        {
        //            await formFile.CopyToAsync(stream);
        //            response.ResponseCode = 200;
        //            response.Result = "pass";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Errormessage = ex.Message;
        //    }
        //    return Ok(response);
        //}

        //[NonAction]
        //private string GetFilepath(string productcode)
        //{
        //    return this.environment.WebRootPath + "\\Upload\\product\\" + productcode;
        //    //return this.environment.WebRootPath  + productcode;
        //}


        //[HttpPost]
        //[Route("GrabaFoto")]
        ////[Authorize]
        //public dynamic GrabaFoto([FromBody] MedicoObsAuxE pMedicoObsAuxE)
        //{
        //    try
        //    {
        //        string _rutaFoto = rutaFoto();
        //        string filePath = _rutaFoto + pMedicoObsAuxE.NombreFoto;

        //        if (_rutaFoto != "")
        //            System.IO.File.WriteAllBytes(filePath, Convert.FromBase64String(pMedicoObsAuxE.Foto));

        //         return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = "Ok" });
        //    }

        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
        //    }
        //}

        //private string rutaFoto()
        //{
        //    string resultado = "";
        //    List<TablasE> oList;
        //    oList = new TablasAD().Sp_Tablas_Consulta(new TablasE("RUTAFOTOMEDICO", "02", 50, 1, -1));
        //    if (oList.Count >= 1) resultado = oList[0].Nombre.Trim();
        //    return resultado;
        //}


        [HttpGet]
        [Route("GetDatoPersona")]
        public dynamic GetDatoPersona(string? Nombres, string Docidentidad, string Tipdocidentidad = "0", string? CodPacienteAuditor = "")
        {
            List<DatosPacientesE> oListDatosPacientes = new List<DatosPacientesE>();
            var oList = new List<PacientesE>();

            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;


                Nombres = Nombres == null ? "" : Nombres;
                CodPacienteAuditor = CodPacienteAuditor == null ? "0" : CodPacienteAuditor;

                PacientesE oPacientesE = new PacientesE();
                oPacientesE.Nombres = Nombres;
                oPacientesE.Docidentidad = Docidentidad;
                oPacientesE.Tipdocidentidad = Tipdocidentidad;
                oPacientesE.Orden = 1;
                oPacientesE.CodPacienteAuditor = CodPacienteAuditor;


                oList = new PacientesAD().Sp_BuscarPacienteTercero_Consulta(oPacientesE);
                for (int i = 0, loopTo = oList.Count - 1; i <= loopTo; i++)
                {
                    {
                        var withBlock = oList[i];
                        withBlock.Correo = "";
                        withBlock.Celular = "";
                        withBlock.Direccion = "";
                        oListDatosPacientes.Add(new DatosPacientesE(withBlock.Codigo, withBlock.Nombres, withBlock.Docidentidad, withBlock.Direccion, withBlock.Tabla, withBlock.Nombre, withBlock.ApPaterno, withBlock.ApMaterno, withBlock.Parentesco, withBlock.Correo, withBlock.Celular));
                    }
                }

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", persona = oListDatosPacientes });
            }

            catch (Exception e)
            {
                //return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message, response = lstPersona });
                return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = e.Message, persona = oListDatosPacientes });
            }
        }



        [HttpPost]
        [Route("CitaPSF_RutaRetorna")]
        //[Authorize]
        public dynamic CitaPSF_RutaRetorna([FromBody] RutaRetornaCitaE optData)
        {
            try
            {
                ////var data = JsonConvert.DeserializeObject<dynamic>(optData.ToString());

                ////int _IdPantalla = optData.IdRutaRetorna;
                ////string _Usuario = optData.Usuario;
                ////string _Clave = optData.Password;
                ////string _IdOpcion = optData.Opcion;
                ////int _Orden = optData.Orden;

                //var identity = HttpContext.User.Identity as ClaimsIdentity;
                //var rToken = Jwt.validarToken(identity);
                //if (!rToken.success) return rToken;

                string ruta = new UsuarioCitaAD().Sp_CitaPSF_RutaRetorna(optData);
                //_IdPantalla, _Usuario, _Clave, _IdOpcion, _Orden);
                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = ruta });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }



        [HttpGet]
        [Route("CitaPSF_RutaEjecuta")]
        //[Authorize]
        public dynamic CitaPSF_RutaEjecuta(string pDato)
        {
            try
            {
                //var identity = HttpContext.User.Identity as ClaimsIdentity;
                //var rToken = Jwt.validarToken(identity);
                //if (!rToken.success) return rToken;

                string ruta = new UsuarioCitaAD().Sp_CitaPSF_RutaEjecuta(pDato);
                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = ruta });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }


        //[HttpGet]
        //[Route("ProcesoPagoPorIdCitaPre")]
        ////[Authorize]
        //public dynamic ProcesoPagoPorIdCitaPre(string pIdCita)
        //{
        //    try
        //    {
        //        //return new Task<dynamic>(() =>
        //        //{
        //        //var identity = HttpContext.User.Identity as ClaimsIdentity;
        //        //var rToken = Jwt.validarToken(identity);
        //        //if (!rToken.success) return rToken;

        //        int ide_cita = int.Parse(pIdCita);
        //        string Resultado = oGenerales.ProcesoPagoPorIdCitaPre(ide_cita);
        //        //string ruta = new UsuarioCitaAD().Sp_CitaPSF_RutaEjecuta(pDato);

        //        return StatusCode(StatusCodes.Status200OK,
        //                    new
        //                    {
        //                        success = true,
        //                        mensaje = Resultado,
        //                        result = ""
        //                    });
        //        //});
        //    }

        //    catch (Exception ex)
        //    {
        //        //return new Task<dynamic>(() =>
        //        //{
        //        return StatusCode(StatusCodes.Status200OK,
        //            new
        //            {
        //                success = false,
        //                mensaje = "No se pudo procesar. " + ex.Message,
        //                result = ""
        //            });
        //        //});
        //    }
        //}


        //[HttpGet]
        //[Route("ProcesoPagoPorIdCitaPost")]
        ////[Authorize]
        //public dynamic ProcesoPagoPorIdCitaPost(string pIdCita)
        //{
        //    try
        //    {
        //        //return new Task<dynamic>(() =>
        //        //{
        //        //var identity = HttpContext.User.Identity as ClaimsIdentity;
        //        //var rToken = Jwt.validarToken(identity);
        //        //if (!rToken.success) return rToken;

        //        int ide_cita = int.Parse(pIdCita);
        //        string Resultado = oGenerales.ProcesoPagoPorIdCitaPost(ide_cita);
        //        //string ruta = new UsuarioCitaAD().Sp_CitaPSF_RutaEjecuta(pDato);

        //        return StatusCode(StatusCodes.Status200OK,
        //                    new
        //                    {
        //                        success = true,
        //                        mensaje = Resultado,
        //                        result = ""
        //                    });
        //        //});
        //    }

        //    catch (Exception ex)
        //    {
        //        //return new Task<dynamic>(() =>
        //        //{
        //        return StatusCode(StatusCodes.Status200OK,
        //            new
        //            {
        //                success = false,
        //                mensaje = "No se pudo procesar. " + ex.Message,
        //                result = ""
        //            });
        //        //});
        //    }
        //}

        //[HttpGet]
        //[Route("Lista")]
        //public IActionResult Lista()
        //{
        //    string respuesta = "";
        //    try
        //    {

        //        return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = respuesta });
        //    }

        //    catch (Exception e)
        //    {
        //        //return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message, response = lstPersona });
        //        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = e.Message, response = respuesta });
        //    }
        //}


        //[HttpGet]
        //[Route("Obtener/{CodProfMedisyn:int}")]
        //private IActionResult Obtener(int CodProfMedisyn)
        //{
        //    TarifaParticular xResult = new TarifaParticular();
        //    try
        //    {
        //        AgendaCitas agendaCitas = new AgendaCitas();
        //        xResult = agendaCitas.MtDatosMedicosSic(CodProfMedisyn.ToString());
        //        return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", persona = xResult });
        //    }

        //    catch (Exception e)
        //    {
        //        //return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message, response = lstPersona });
        //        return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = e.Message, persona = xResult });
        //    }
        //}


        //[HttpGet]
        //[Route("ObtenerConToken/{CodProfMedisyn:int}")]
        //[Authorize]
        //private dynamic ObtenerConToken(int CodProfMedisyn)
        //{
        //    TarifaParticular xResult = new TarifaParticular();
        //    try
        //    {
        //        var identity = HttpContext.User.Identity as ClaimsIdentity;
        //        var rToken = Jwt.validarToken(identity);
        //        if (!rToken.success) return rToken;



        //        AgendaCitas agendaCitas = new AgendaCitas();
        //        xResult = agendaCitas.MtDatosMedicosSic(CodProfMedisyn.ToString());
        //        //return StatusCode(StatusCodes.Status200OK, new { success = true, message = "exito", result = xResult });
        //        return new
        //        {
        //            success = true,
        //            message = "exito",
        //            result = xResult
        //        };
        //    }

        //    catch (Exception ex)
        //    {
        //        //return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message, response = lstPersona });
        //        //return StatusCode(StatusCodes.Status501NotImplemented, new { mensaje = e.Message, persona = xResult });
        //        return new
        //        {
        //            success = false,
        //            message = "Catch: " + ex.Message,
        //            result = ""
        //        };
        //    }
        //}

        [HttpPost]
        [Route("ReporteByte")]
        [Authorize]
        public dynamic ReporteByte([FromBody] RceValidaHojaRutaE.SoftVan pSoftVan)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                //INI 1.0
                int ide_historia = 0;
                int ID_PQ_Det = 0;

                var pBody = new RceValidaHojaRutaE.Body();
                if (pSoftVan.tipo_reporte == "HojaDeRuta")//Obtener Hoja de Ruta del ApiReporteria
                {
                    var pRceHistoriaClinicaCabE = new RceHistoriaClinicaCabE(pSoftVan.cod_atencion, pSoftVan.cod_paciente);
                    ide_historia = new RceHistoriaClinicaCabAD().Sp_RceHistoriaClinicaCab_ObtenerID(pRceHistoriaClinicaCabE);

                    if (ide_historia == 0)
                        return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Verificar el cod_atencion y el cod_paciente", result = "" });

                    pBody = new AgendaCitas().ObtenerHojaDeRutaByte(pSoftVan, ide_historia);
                }
                else if (pSoftVan.tipo_reporte == "Receta")//Obtener Receta del ApiReporteria
                {
                    var pRceHistoriaClinicaCabE = new RceHistoriaClinicaCabE(pSoftVan.cod_atencion, pSoftVan.cod_paciente);
                    ide_historia = new RceHistoriaClinicaCabAD().Sp_RceHistoriaClinicaCab_ObtenerID(pRceHistoriaClinicaCabE);

                    if (ide_historia == 0)
                        return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Verificar el cod_atencion y el cod_paciente", result = "" });

                    pBody = new AgendaCitas().ObtenerRecetaByte(pSoftVan, ide_historia);
                }
                else if (pSoftVan.tipo_reporte == "PQ")//Obtener Programación Quirúrgica del ApiReporteria
                {
                    var pRceProgramacionQuirurgicaE = new RceProgramacionQuirurgicaE(pSoftVan.cod_atencion, pSoftVan.cod_cpt);
                    ID_PQ_Det = new RceProgramacionQuirurgicaAD().Sp_ProgramacionQuirurgicaDet_ObtenerId(pRceProgramacionQuirurgicaE);

                    if (ID_PQ_Det == 0)
                        return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Verificar el cod_atencion y el cod_cpt", result = "" });

                    pBody = new AgendaCitas().ObtenerPQ(pSoftVan, ID_PQ_Det);
                }
                //FIN 1.0
                else
                    return StatusCode(StatusCodes.Status200OK, new { success = false, message = "Tipo Reporte no encontrado", result = "" });

                APIResponseDoc oRespuesta = new APIResponseDoc();
                string ruta = new AgendaCitas().pValorCodigoTabla("RUTAINFORMES", "01");
                var _Json = JsonConvert.SerializeObject(pBody);

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    HttpContent content = new StringContent(_Json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = httpClient.PostAsync(ruta, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        oRespuesta = JsonConvert.DeserializeObject<APIResponseDoc>(responseBody);
                    }
                    else
                    {
                        oRespuesta = new APIResponseDoc { ArchivoByte = null };
                    }
                }

                return StatusCode(StatusCodes.Status200OK, new { success = true, message = "Ok", result = oRespuesta });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, message = "Error: " + ex.Message, result = "" });
            }
        }

        [HttpPost]
        [Route("ObtenerQR")]
        [Authorize]
        public dynamic ObtenerQR([FromBody] CitaAgendaE.Documento pCitaAgendaE)
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                AgendaCitas oAgendaCitas = new AgendaCitas();
                var oData = oAgendaCitas.Sp_Cita_ListarQR(pCitaAgendaE);

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oData });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }

        //INI 1.0
        [HttpGet]
        [Route("ListarCpt")]
        [Authorize]
        public dynamic ListarCpt()
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                AgendaCitas oAgendaCitas = new AgendaCitas();
                var oData = oAgendaCitas.Sp_Cpt_ListarDetalle();

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oData });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }

        [HttpGet]
        [Route("ListarAnestesiologo")]
        [Authorize]
        public dynamic ListarAnestesiologo([FromQuery] string? medico = "")
        {
            try
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                var rToken = Jwt.validarToken(identity);
                if (!rToken.success) return rToken;

                //medicos a consultar
                MedicosE oMedicosE = new MedicosE();
                oMedicosE.Buscar = medico;
                oMedicosE.Orden = 13;//orden para anestesiologos

                Medicos oMedicos = new Medicos();
                var Lmedicos = oMedicos.ConsultarMedicos(oMedicosE);

                //Formatear con los campos requeridos
                var LAPIAnestesiologoE = new List<APIAnestesiologo>();
                for (int i = 0; i <= Lmedicos.Count - 1; i++)
                {
                    var oAPIAnestesiologo = new APIAnestesiologo();
                    oAPIAnestesiologo.CodMedico = Lmedicos[i].CodMedico;
                    oAPIAnestesiologo.NombreComercial = Lmedicos[i].NombreComercial.Trim();
                    oAPIAnestesiologo.NombresMedico = Lmedicos[i].NombresMedico.Trim();
                    oAPIAnestesiologo.ColMedico = Lmedicos[i].ColMedico;
                    LAPIAnestesiologoE.Add(oAPIAnestesiologo);
                }
                var oData = LAPIAnestesiologoE;

                return StatusCode(StatusCodes.Status200OK, new { success = true, mensaje = "Ok", result = oData });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { success = false, mensaje = "Error: " + ex.Message, result = "" });
            }
        }
    }
    //FIN 1,0
    public class APIResponse
    {
        public int ResponseCode { get; set; }
        public string Result { get; set; }
        public string Errormessage { get; set; }
    }

    public class APIResponseDoc
    {
        public byte[]? ArchivoByte { get; set; }
    }

    //INI 1.0
    public class APIAnestesiologo
    {
        public string CodMedico { get; set; }
        public string NombreComercial { get; set; }
        public string NombresMedico { get; set; }
        public string ColMedico { get; set; }

    }
    //FIN 1.0
}
