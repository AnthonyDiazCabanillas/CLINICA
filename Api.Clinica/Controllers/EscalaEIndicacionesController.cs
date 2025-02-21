using Api.Clinica.Data;
using Bus.Clinica.Clinica;
using Bus.Utilities;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("EscalaEIndicacionesEnfermeria/API/Clinica/")]
    public class EscalaEIndicacionesController:ControllerBase
    {
        EscalaEIndicaciones _objCN = new EscalaEIndicaciones();
        EscalaEIndicacionesE _objEN = new EscalaEIndicacionesE();
        Config _config = new Config();

        [Route("ConsultaEscalaEIndicaciones")]
        [HttpGet]
        public List<EscalaEIndicacionesE> Listar_Escala_e_Indicaciones(string order, string variable, string val, string val1, string val2, string val3) 
        {

            try {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    List<EscalaEIndicacionesE> Lista = new List<EscalaEIndicacionesE>();
                    int _order = int.Parse(Criptography.DecryptConectionString(order.Replace(" ", "+")));
                    int _variable = int.Parse(Criptography.DecryptConectionString(variable.Replace(" ", "+")));
                    string _val = Criptography.DecryptConectionString(val.Replace(" ","+"));
                    string _val1 = Criptography.DecryptConectionString(val1.Replace(" ","+"));
                    string _val2 = Criptography.DecryptConectionString(val2.Replace(" ","+"));
                    string _val3 = Criptography.DecryptConectionString(val3.Replace(" ","+"));
                    Lista=  _objCN.Escala_e_indicaciones_List(_order, _variable, _val, _val1, _val2, _val3);
                    return Lista;
                }
                else {
                    return new List<EscalaEIndicacionesE>();
                }
            }
            catch (Exception ex)
            {
                return new List<EscalaEIndicacionesE>();
            }
        }


        [Route("ActividadEscalaEindicaciones")]
        [HttpGet]
        public List<EscalaEIndicacionesActividadE> Listar_actividades_escalae_indicaciones(string order, string variable, string val, string val1, string val2, string val3)
        {

            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    List<EscalaEIndicacionesActividadE> Lista = new List<EscalaEIndicacionesActividadE>();
                    int _order = int.Parse(Criptography.DecryptConectionString(order.Replace(" ", "+")));
                    int _variable = int.Parse(Criptography.DecryptConectionString(variable.Replace(" ", "+")));
                    string _val =  Criptography.DecryptConectionString(val.Replace(" ", "+")) ;
                    string _val1 = Criptography.DecryptConectionString(val1.Replace(" ", "+"));
                    string _val2 = Criptography.DecryptConectionString(val2.Replace(" ", "+"));
                    string _val3 = Criptography.DecryptConectionString(val3.Replace(" ", "+"));
                    Lista = _objCN.EscalaEIndicacionesActividad_List(_order, _variable, _val, _val1, _val2, _val3);
                    return Lista;
                }
                else
                {
                    return new List<EscalaEIndicacionesActividadE>();
                }
            }
            catch (Exception ex)
            {
                return new List<EscalaEIndicacionesActividadE>();
            }
        }

        [Route("ActividadEscalaEindicacionesRegister")]
        [HttpPost]
        public dynamic ActividadEscalaEindicacionesRegister(PuntuacionEscalaE obj) {
            try
            {
                string _Id = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
                if (string.IsNullOrWhiteSpace(_Id))
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    _Rjson.status = "Error";
                    return _Rjson;
                }
                string token = Criptography.DecryptConectionString(_Id);
                if (token == _config.Key)
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    //_Rjson.exito = true;
                    //_Rjson.message = "OK";
                    //_Rjson.status = "Success";
                    _Rjson = _objCN.EscalaEintervenciones_Register(obj);
                    return _Rjson;
                }
                else 
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    _Rjson.status = "Error";

                    return _Rjson;
                }
            }
            catch (Exception ex) {
                 RespuestaJsonE _Rjson = new RespuestaJsonE();
                _Rjson.exito = false;
                _Rjson.message = ex.Message;
                _Rjson.status = "Error";
                return _Rjson;
            }
        }

        [Route("ActividadEscalaEindicacionesDatoshistoricos")]
        [HttpGet]
        public List<EscalaeIndicacionesHistoricoE> ActividadEscalaEindicacionesDatoshistoricos(string order, string variable, string val, string val1, string val2, string val3)
        {

            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    List<EscalaeIndicacionesHistoricoE> Lista = new List<EscalaeIndicacionesHistoricoE>();
                    int _order = int.Parse(Criptography.DecryptConectionString(order.Replace(" ", "+")));
                    int _variable = int.Parse(Criptography.DecryptConectionString(variable.Replace(" ", "+")));
                    string _val = Criptography.DecryptConectionString(val.Replace(" ", "+"));
                    string _val1 = Criptography.DecryptConectionString(val1.Replace(" ", "+"));
                    string _val2 = Criptography.DecryptConectionString(val2.Replace(" ", "+"));
                    string _val3 = Criptography.DecryptConectionString(val3.Replace(" ", "+"));
                    Lista = _objCN.EscalaEIndicacionesHistorico_List(_order, _variable, _val, _val1, _val2, _val3);
                    return Lista;
                }
                else
                {
                    return new List<EscalaeIndicacionesHistoricoE>();
                }
            }
            catch (Exception ex)
            {
                return new List<EscalaeIndicacionesHistoricoE>();
            }
        }

        [Route("ActividadEscalaEindicacionesDatoshistoricosDetallado")]
        [HttpGet]
        public List<EscalaEIndicacionesHistoriaDetalladoE> ActividadEscalaEindicacionesDatoshistoricosDetallado(string order, string variable, string val, string val1, string val2, string val3)
        {

            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    List<EscalaEIndicacionesHistoriaDetalladoE> Lista = new List<EscalaEIndicacionesHistoriaDetalladoE>();
                    int _order = int.Parse(Criptography.DecryptConectionString(order.Replace(" ", "+")));
                    int _variable = int.Parse(Criptography.DecryptConectionString(variable.Replace(" ", "+")));
                    string _val = Criptography.DecryptConectionString(val.Replace(" ", "+"));
                    string _val1 = Criptography.DecryptConectionString(val1.Replace(" ", "+"));
                    string _val2 = Criptography.DecryptConectionString(val2.Replace(" ", "+"));
                    string _val3 = Criptography.DecryptConectionString(val3.Replace(" ", "+"));
                    Lista = _objCN.EscalaEIndicacionesHistoricoDetallado_List(_order, _variable, _val, _val1, _val2, _val3);
                    return Lista;
                }
                else
                {
                    return new List<EscalaEIndicacionesHistoriaDetalladoE>();
                }
            }
            catch (Exception ex)
            {
                return new List<EscalaEIndicacionesHistoriaDetalladoE>();
            }
        }
    }
}
