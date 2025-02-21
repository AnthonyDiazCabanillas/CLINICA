/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version Fecha       Autor       Requerimiento
 1.0      29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using Api.Clinica.Data;
using Bus.AgendaClinica.Clinica;
using Bus.Clinica;
using Bus.Clinica.Clinica;
using Bus.Utilities;
using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql.ProveedorE.TCI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Http.Extensions;
using WsTciComprobantes;

namespace Api.Clinica.Controllers
{
    [ApiController]
    [Route("TCI/API/")]
    public class TCIController : ControllerBase
    {
        Hospital _bl = new Hospital();
        Config _config = new Config();

        [Route("ObtenerPdfByteTCI")]
        [HttpGet]
        public ObtenerPDF.Response ObtenerComprobantePDFByte(string Comprobante)
        {
            try
            {
                Comprobante = Uri.UnescapeDataString(Comprobante);
                ObtenerPDF.Response oObtenerPDFResultado = new ObtenerPDF.Response();
                string token = Criptography.DecryptConectionString(Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value);
                if (token == _config.Key)
                { oObtenerPDFResultado = new Generales().ObtenerComprobantePDF(new ObtenerPDF.Requests(Criptography.DecryptConectionString(Comprobante))); }
                else
                { oObtenerPDFResultado = new ObtenerPDF.Response(true, "No Autorizado"); }
                return oObtenerPDFResultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
