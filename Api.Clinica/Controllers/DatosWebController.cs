using Api.Clinica.Data;
using Bus.Utilities;
using Ent.Sql.ClinicaE;
using Microsoft.AspNetCore.Mvc;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("DatosControlWeb/API/Clinica/")]


    public class DatosWebController:ControllerBase
    {
        Config _config = new Config();


        [Route("DatosValidadoAccesoAgenda")]
        [HttpGet]
        public dynamic EncriptDatosMedico(string _key) 
        {
            RespuestaJsonE _Rjson = new RespuestaJsonE();
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);

                if (token == _config.Key)
                {
                    string Dato = Criptography.DecryptConectionString(_key.Replace(" ", "+"));

                    string menssage = Criptography.EncryptStringAES256(Dato);

                    _Rjson.exito = true;
                    _Rjson.message = menssage;
                    _Rjson.status = "Ok";
                    return _Rjson;
                }
                else
                {
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    _Rjson.status = "Error";
                    return _Rjson;
                }
            }
            catch (Exception ex)
            {
                _Rjson.exito = false;
                _Rjson.message = ex.Message;
                _Rjson.status = "Error";
                return _Rjson;
            }
        }


        [Route("DatoValidarAccesoROE")]
        [HttpGet]
        public List<string> EncriptarDatosROW(string _Key) 
        {
            List<string> _data = new List<string>();
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    var split_data = _Key.Split(';');
                    foreach (var split in split_data)
                    {
                        var encript = Criptography.EncryptStringAES256ROE(split);
                        _data.Add(encript);
                    }
                }
                else {
                    _data = new List<string>();
                }
            }
            catch (Exception ex) { 
                _data = new List<string>();
            }

            return _data;
        }

    }
}
