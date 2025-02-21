using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ProveedorE.ROE
{
    public class ResultadosRoeE
    {
        public ResultadosRoeE()
        {
        }

        public class ReqListarAtencionSoftvan
        {
            public string numeroDocumento { get; set; } = "";
            public string periodo { get; set; } = "";

        }

        public class ResListarAtencionSoftvan
        {
            public int codigoRespuesta { get; set; } = 0;
            public string mensaje { get; set; } = "";
            public List<detalleOrdenes> detalleOrdenes { get; set; }
        }

        public class ResListarHistorico
        {
            public int codigoRespuesta { get; set; } = 0;
            public string mensaje { get; set; } = "";
            public List<listadoHistoricos> listadoHistoricos { get; set; }
        }

        public class ReqListarHistorico
        {
            public string ordenAtencion { get; set; } = "";
            public List<string> listaCodigosAnalisis { get; set; }
            public bool toBase64 { get; set; } = false;
        }

        public class ReqObtenerResultadoSoftvan
        {
            public string ordenAtencion { get; set; } = "";

        }

        public class ResObtenerResultadoSoftvan
        {
            public int codigoRespuesta { get; set; } = 0;
            public string mensaje { get; set; } = "";
            public string data { get; set; } = "";
        }

        public class ResObtenerHistoricoSoftvan
        {
            public int rpta { get; set; } = 0;
            public string mensaje { get; set; } = "";
            public List<string> data { get; set; }
        }

        public class detalleOrdenes
        {
            public int tipoDocumento { get; set; } = 0;
            public string numeroDocumento { get; set; } = "";
            public string ordenAtencion { get; set; } = "";
            public string codigoAtencionCSF { get; set; } = "";
            public string fechaHoraAtencion { get; set; } = "";
            public string nombreCompletoPaciente { get; set; } = "";
            public string cmp { get; set; } = "";
            public string nombreCompletoMedico { get; set; } = "";
            public string nombresAnalisis { get; set; } = "";
            public bool indInforme { get; set; } = false;
            public int edad { get; set; } = 0;
            public string sexo { get; set; } = "";
            public decimal montoaCuenta { get; set; } = 0;
            public decimal montoAnalisis { get; set; } = 0;
            public decimal saldo { get; set; } = 0;
            public bool puedeVerResultados { get; set; } = false;
            public bool puedePagarWeb { get; set; } = false;
            public bool puedeVerHistoricos { get; set; } = false;
        }

        public class listadoHistoricos
        {
            public string CodigoAnalisis { get; set; } = "";
            public string NombreAnalisis { get; set; } = "";
            public string Referencia { get; set; } = "";
        }

        public class ReqListarAtencionCSF
        {
            public string codigoEmpresa { get; set; } = "";
            public string tipoBusqueda { get; set; } = "";
            public string busqueda { get; set; } = "";
        }

        public class ResListarAtencionCSF
        {
            public string ordenAtencion { get; set; } = "";
            public string codatencion { get; set; } = "";
            public string fec_registra { get; set; } = "";
            public string numDocumento { get; set; } = "";
            public string nombrePaciente { get; set; } = "";
            public string nombreExamen { get; set; } = "";
            public bool esInformeResultado { get; set; } = false;
            public bool esInformeHistorico { get; set; } = false;
        }

    }
}
