#region Información General de la Clase
/// <remarks>
///**************************************************************************************************************************
/// Objetivo General: Validar password, encriptar y desencriptar password
/// ----------------------------------------------------------------------
/// ----------------------------------------------------------------------
/// VERSIÓN    FECHA			AUTOR       REQUERIMIENTO		DESCRIPCIÓN
/// 1.0		   26/08/2024		MBARDALES	REQ 2024-010476		Creación del Controller
///
///*****************************************************************************************************************************/
/// </remarks>
#endregion

using Api.Clinica.Data;
using Bus.Clinica;
using Bus.Utilities;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql.ClinicaE.SeguridadE;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text.RegularExpressions;
using static Ent.Sql.ProveedorE.TCI.ObtenerPDF;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("SeguridadDePassword/API/Clinica/")]
    public class SeguridadDePasswordController : Controller
    {
        SeguridadDePassword _bl = new SeguridadDePassword();
        Config _config = new Config();

        [HttpGet]
        [Route("ValidarPassword")]
        public async Task<IActionResult> ValidarPassword(string password1, string? password2)
        {
            DataTable dt = new DataTable();
            dt = _bl.Sp_ParamSeguridad_Sel();

            int _min_caracter = 0;
            int _max_caracter = 30;
            int _minus = 0;
            int _mayus = 0;
            int _numero = 0;
            int _especial = 0;

            RespuestaJsonE _respuesta = new RespuestaJsonE();

            foreach (DataRow row in dt.Rows)
            {
                if (row["codigo"].ToString() == "02" && row["estado"].ToString() == "A")
                {
                    _min_caracter = Convert.ToInt32(row["valor"].ToString());
                    _max_caracter = 30;

                    Match matchLongitud1 = Regex.Match(password1, @"^.{" + _min_caracter + "," + _max_caracter + "}$"); //Que tenga al menos 8 caracteres
                    Match matchLongitud2 = Regex.Match(password2, @"^.{" + _min_caracter + "," + _max_caracter + "}$");

                    if (matchLongitud1.Success == false)
                    {
                        _respuesta.message = "p1-El password debe tener una longitud entre 8 a 15 caracteres";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }

                    if (matchLongitud2.Success == false)
                    {
                        _respuesta.message = "p2-El password debe tener una longitud entre 8 a 15 caracteres";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }

                }
                else if (row["codigo"].ToString() == "03" && row["estado"].ToString() == "A")
                {
                    _minus = Convert.ToInt32(row["valor"].ToString());

                    Match matchMinusculas1 = Regex.Match(password1, @"[a-z]"); //Que tena minúscula

                    Match matchMinusculas2 = Regex.Match(password2, @"[a-z]"); //Que tena minúscula

                    if (matchMinusculas1.Success == false)
                    {
                        _respuesta.message = "p1-El password debe incluir una letra minúscula";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }


                    if (matchMinusculas2.Success == false)
                    {
                        _respuesta.message = "p2-El password debe incluir una letra minúscula";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }
                }
                else if (row["codigo"].ToString() == "04" && row["estado"].ToString() == "A")
                {
                    _mayus = Convert.ToInt32(row["valor"].ToString());

                    Match matchMayusculas1 = Regex.Match(password1, @"[A-Z]"); //Que tenga mayúscula

                    Match matchMayusculas2 = Regex.Match(password2, @"[A-Z]"); //Que tenga mayúscula

                    if (matchMayusculas1.Success == false)
                    {
                        _respuesta.message = "p1-El password debe incluir una letra mayúscula";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }

                    if (matchMayusculas2.Success == false)
                    {
                        _respuesta.message = "p2-El password debe incluir una letra mayúscula";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }

                }
                else if (row["codigo"].ToString() == "05" && row["estado"].ToString() == "A")
                {
                    _numero = Convert.ToInt32(row["valor"].ToString());
                    Match matchNumeros1 = Regex.Match(password1, @"\d"); //Que tenga números
                    Match matchNumeros2 = Regex.Match(password2, @"\d"); //Que tenga números

                    if (matchNumeros1.Success == false)
                    {
                        _respuesta.message = "p1-El password debe incluir números";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }


                    if (matchNumeros2.Success == false)
                    {
                        _respuesta.message = "p2-El password debe incluir números";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }

                }
                else if (row["codigo"].ToString() == "06" && row["estado"].ToString() == "A")
                {
                    _especial = Convert.ToInt32(row["valor"].ToString());

                    Match matchEspeciales1 = Regex.Match(password1, @"[ñÑ\-_¿.#¡@!$%&/()=¡¿?+{}|<>*]"); //Que tenga caracteres alfanuméricos
                    Match matchEspeciales2 = Regex.Match(password2, @"[ñÑ\-_¿.#¡@!$%&/()=¡¿?+{}|<>*]"); //Que tenga caracteres alfanuméricos

                    if (matchEspeciales1.Success == false)
                    {
                        _respuesta.message = "p1-El password debe incluir caracteres especiales";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }

                    if (matchEspeciales2.Success == false)
                    {
                        _respuesta.message = "p2-El password debe incluir caracteres especiales";
                        _respuesta.exito = false;

                        return Ok(_respuesta);
                    }
                }
            }

            //--------------------------------------------------------------------------------------------


            _respuesta.message = "p0-Validación correcta";
            _respuesta.exito = true;

            return Ok(_respuesta);
        }

        [Route("EncriptarSegPass")]
        [HttpPost]
        public dynamic Sp_EncriptarSegPass(PasswordE _obj)
        {
            try
            {
                return _bl.Sp_EncriptarSegPass(_obj);
            }
            catch (Exception ex)
            {
                RespuestaJsonE _Rjson = new RespuestaJsonE();
                _Rjson.exito = false;
                _Rjson.message = "Error de acceso, Acción denegada";
                return _Rjson;
            }
        }

        [Route("DesEncriptarSegPass")]
        [HttpPost]
        public dynamic Sp_DesEncriptarSegPass(PasswordE _obj)
        {

            try
            {
                return _bl.Sp_DesEncriptarSegPass(_obj);
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
