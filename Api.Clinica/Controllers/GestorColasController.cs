using Api.Clinica.Data;
using Bus.Utilities;
using Ent.Sql.CitaE.GestorColas;
using Bus.AgendaClinica.GestorColas;
using Microsoft.AspNetCore.Mvc;
using RestSharp;


namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("GestorColas/API/Clinica/")]
    public class GestorColasController  : ControllerBase
    {
        
  
        CitasDisplay _objCN = new CitasDisplay(); 
        Config _config = new Config();

        [Route("ConsultaCitasDisplay")]
        [HttpPost]
        public async Task<ActionResult<CitasDisplayE>> ListarCitasDisplay (CitasDisplayJsonParamE objParametros) 
        {
            try
            {
                var Lista = await _objCN.CitasDisplay_Listar(objParametros);
                //if (Lista.listaCitas != null)
                //{
                //    if (Lista.listaCitas.Count == 0)
                //    {
                //        //return BadRequest(new { Mensaje = "La lista de citas para el display está vacía" });
                //        return Ok(new { Mensaje = "La lista de citas para el display está vacía" });

                //    }
                //}
                return Ok(Lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("ConsultaCitasTicketera")]
        public async Task<ActionResult<CitasDisplayTicketE>> CitasDisplayTicket_Listar(CitasTicketJsonParamE objParametros)
        {
            try
            {
                var Lista = await _objCN.CitasDisplayTicket_Listar(objParametros);
                if (Lista.listaCitas != null)
                {
                    if (Lista.listaCitas.Count == 0)
                    {
                        string strfechaProxima = _objCN.uspCitaGetProximaCita(objParametros);
                        string[] _resp = strfechaProxima.Split ('|');
                        if (_resp.Length == 1)
                            return BadRequest(new { Codigo = "001", Mensaje = _resp });
                        else
                            return BadRequest(new { Codigo = "002", Mensaje = _resp });
                    }
                }
                return Ok(Lista);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpGet]
        [Route("CrearTurnoPaciente")]
        public async Task<IActionResult> CitasPacienteCrearTurno(string id_cita)
        {
            try
            {

                var token = Criptography.DecryptStringAES256(Request.Headers.Where(x => x.Key == "AuthorizationSoftvan").FirstOrDefault().Value);
                if (token == _config.keySoftvan)
                {
                    int _idCita = int.Parse(Criptography.DecryptStringAES256(id_cita.Replace(" ", "+")));
                    CitasRegTurno objCitasRegTurno = _objCN.GetCitasBMaticRegTurno(_idCita);

                    if (objCitasRegTurno.local != null)
                    {
                        /*
                        Invocando al api de BMactic
                        */
                        var ApiBMactic = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ApiBMactic")["RegTurnoPaciente"];

                        RestClient _cliente = new RestClient(ApiBMactic);
                        RestRequest _request = new RestRequest();
                        _request.Method = Method.Post;
                        _request.RequestFormat = DataFormat.Json;
                        _request.AddJsonBody(new
                        {
                            local = objCitasRegTurno.local,
                            sector = objCitasRegTurno.sector,
                            codigoCita = objCitasRegTurno.CodigoCita,
                            nombreCliente = objCitasRegTurno.NombreCliente,
                            especialidad = objCitasRegTurno.Especialidad,
                            codEspecialidad = objCitasRegTurno.CodEspecialidad,
                            consultorio = objCitasRegTurno.Consultorio,
                            horaCita = objCitasRegTurno.HoraCita
                        });
                        RestResponse _response = await _cliente.ExecuteAsync(_request);

                        if (_response.StatusCode != System.Net.HttpStatusCode.OK)
                        {
                            var codError = _response.StatusCode;
                            //**  registrar en el log de errores **//
                        }

                        return Ok(_response.StatusCode);
                    }
                    else
                    {
                        return BadRequest("No existe registro de cita para ejecutar el servicio de BMatic");
                    }
                   
                }
                else 
                {
                    return BadRequest("El token es invalido");
                }
                return BadRequest("No se ha logrado realizar la ejecución del servicio de BMACTIC");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }   
        }



    }
}
