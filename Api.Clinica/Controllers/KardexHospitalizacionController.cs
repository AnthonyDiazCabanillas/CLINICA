using Api.Clinica.Data;
using Bus.Clinica;
using Bus.Utilities;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.OtrosE;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;

namespace Api.Clinica.Controllers
{
    
    [ApiController]
    [Route("KardexHospitalizacion")]
	public class KardexHospitalizacionController : ControllerBase
	{
        Hospital _bl = new Hospital();
        Config _config = new Config();

        [Route("API/Clinica/ConsultaPacientesHospitalarios")]
        [HttpGet]
        public List<HospitalE> Listado_PacientesHospitaliazados(string Order, string Fila, string Atencion, string Busqueda)
        {
            try 
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value) ;
                if (token == _config.Key)
                {
                    //int order, int n_fila, string codatencion, string Busq
                    int _order = int.Parse(Criptography.DecryptConectionString(Order));
                    int _Fila = int.Parse(Criptography.DecryptConectionString(Fila));
                    string _Atencion = Criptography.DecryptConectionString(Atencion);
                    string _Busqueda = Criptography.DecryptConectionString(Busqueda.Replace(" ","+"));
                    return _bl.Listado_PacientesHospitaliazados_Coincidencias(_order, _Fila, _Atencion, _Busqueda);
                }
                else { return new List<HospitalE>(); }
            } 
            catch (Exception ex) 
            {
                return new List<HospitalE>();
            }
        }

        [Route("API/Clinica/DatosPacienteHospitalizado")]
        [HttpGet]
        public HospitalE Datos_PacienteHospitalizado(string _Key)
        {
            try {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    string codigo = _Key.Replace(" ", "+");
                    string CodAtencion = Criptography.DecryptConectionString(codigo);
                    int order = 2; int n_fila = 0; string Busq = "";
                    return _bl.Datos_PacienteHospitalizado(order, n_fila, CodAtencion, Busq);
                }
                else {
                    return new HospitalE();
                }
            }
            catch (Exception ex)
            {
                return new HospitalE();
            }
        }

        [Route("API/Clinica/PacienteIndicacionesMedica")]
        [HttpGet]
        public List<IndicacionesMedicasE> PacienteIndicacionesMedicas(string _Key)
        {
            try {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    string codigo = _Key.Replace(" ", "+");
                    string CodAtencion = Criptography.DecryptConectionString(codigo);
                    int order = 3; int n_fila = 0; string Busq = "";
                    return _bl.Listado_IndicacionesMedicas(order, n_fila, CodAtencion, Busq);
                }
                else {
                    return new List<IndicacionesMedicasE>();
                }   
            }
            catch (Exception ex) { return new List<IndicacionesMedicasE>(); }
        }

        [Route("API/Clinica/KardexHistoricoPacienteHospitalario")]
        [HttpGet]
        public List<IndicacionesMedicaDetalleE> KardexHistoricoIndicacionesMedica(string _Key)
        {
            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    string codigo = _Key.Replace(" ", "+");
                    string CodAtencion = Criptography.DecryptConectionString(codigo);
                    int order = 4; int n_fila = 0; string Busq = "";
                    return _bl.Listado_KardexHistoricoIndicacionesMedicas(order, n_fila, CodAtencion, Busq);
                }
                else {
                    return new List<IndicacionesMedicaDetalleE>();
                }                    
            }
            catch (Exception ex) { return new List<IndicacionesMedicaDetalleE>(); }
        }


        [Route("API/Clinica/KardexHistoricoPacienteHospitalario2")]
        [HttpGet]
        public List<IndicacionesMedicaDetalleE> KardexHistoricoIndicacionesMedica2(string _Key, string valor)
        {
            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    string codigo = _Key.Replace(" ", "+");
                    string CodAtencion = Criptography.DecryptConectionString(codigo);
                    string Busq = Criptography.DecryptConectionString(valor.Replace(" ", "+"));
                    int order = 7; int n_fila = 0;  
                    return _bl.Listado_KardexHistoricoIndicacionesMedicas(order, n_fila, CodAtencion, Busq);
                }
                else
                {
                    return new List<IndicacionesMedicaDetalleE>();
                }
            }
            catch (Exception ex) { 
                return new List<IndicacionesMedicaDetalleE>();
            }
        }




        [Route("API/Clinica/KardexHistoricoPacienteHospitalarioPRogramado")]
        [HttpGet]
        public List<ProgramacionKardexE> KardexHistoricoPacienteHospitalarioPRogramado(string _Key)
        {
            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    string codigo = _Key.Replace(" ", "+");
                    string CodAtencion = Criptography.DecryptConectionString(codigo);
                    int order = 6; int n_fila = 0; string Busq = "";
                    return _bl.Listado_KardexHistoricoIndicacionesProgramada(order, n_fila, CodAtencion, Busq);
                }
                else
                {
                    return new List<ProgramacionKardexE>();
                }
            }
            catch (Exception ex) { return new List<ProgramacionKardexE>(); }
        }

        [Route("API/Clinica/ConsultaPisoPaciente")]
        [HttpGet]
        public List<PisoE> Listado_PacienteXPiso(string _Key) 
        {
            try
            {
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                {
                    string codigo = _Key.Replace(" ", "+");
                    string CodAtencion = "";
                    int order = 5; int n_fila = 0; string Busq = Criptography.DecryptConectionString(codigo);
                    return _bl.Listar_piso_x_usuario(order, n_fila, CodAtencion, Busq);
                }
                else
                {
                    return new List<PisoE>();
                }
            }
            catch (Exception ex) { return new List<PisoE>(); }
        }

        [Route("API/Clinica/RegistroKardexCabecera")]
        [HttpPost]
        public dynamic Registrar_Kardex_datosHospitalario_Paciente(KardexHospitalarioE _obj)
        {

            try {
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
                    return _bl.Registrar_Kardex_datosHospitalario_Paciente(_obj);
                }
                else
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    return _Rjson;
                }
            }
            catch (Exception ex) 
            {
                RespuestaJsonE _Rjson = new RespuestaJsonE();
                _Rjson.exito = false;
                _Rjson.message = "Error de acceso, Acción denegada";
                return _Rjson;
            }
        }

        [Route("API/Clinica/RegistroKardexDetalle")]
        [HttpPost]
        public dynamic Registrar_Kardex_DatosHospitalario_Detalle(IndicacionesMedicasE _obj) 
        {
            try {
                string _Id = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
                if (string.IsNullOrWhiteSpace(_Id))
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    return _Rjson;
                }
                string token = Criptography.DecryptConectionString(_Id);
                if (token == _config.Key)
                {
                    return _bl.Registrar_kardex_datosHospitalarios_Detalle(_obj);
                }
                else
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    return _Rjson;
                }
            }
            catch (Exception ex) {
                RespuestaJsonE _Rjson = new RespuestaJsonE();
                _Rjson.exito = false;
                _Rjson.message = "Error de acceso, Acción denegada";
                return _Rjson;
            }
        }

        [Route("API/Clinica/RegistrarusuariosPisoAtencion")]
        [HttpPost]
        public dynamic Registrar_UsuarioPisoAtencion(PisoE _obj)
        {
            try
            {
                string _Id = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
                if (string.IsNullOrWhiteSpace(_Id))
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    return _Rjson;
                }
                string token = Criptography.DecryptConectionString(_Id);
                if (token == _config.Key)
                {
                    return _bl.Registrar_UsuarioPisoAtencion(_obj);
                }
                else
                {
                    RespuestaJsonE _Rjson = new RespuestaJsonE();
                    _Rjson.exito = false;
                    _Rjson.message = "Error de acceso, Acción denegada";
                    return _Rjson;
                }
            }
            catch (Exception ex)
            {
                RespuestaJsonE _Rjson = new RespuestaJsonE();
                _Rjson.exito = false;
                _Rjson.message = "Error de acceso, Acción denegada";
                return _Rjson;
            }
        }
    }
}
