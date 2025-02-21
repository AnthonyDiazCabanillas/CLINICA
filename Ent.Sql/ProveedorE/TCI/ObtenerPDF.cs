using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ProveedorE.TCI
{
    public class ObtenerPDF
    {
        public class Requests
        {
            public bool EnviarSunat { get; set; }
            public string Comprobante { get; set; } = "";

            public Requests() { }
            public Requests(string pComprobante)
            { Comprobante = pComprobante; }
            public Requests(bool pEnviarSunat, string pComprobante)
            {
                EnviarSunat = pEnviarSunat;
                Comprobante = pComprobante;
            }
        }

        public class Response
        {
            public byte[] ArchivoByte { get; set; }
            public string NombreArchivo { get; set; } = "";
            public string Mensaje { get; set; } = "";
            public bool Error { get; set; } = true;
            public Response() { }

            public Response(bool pError, string pMensaje)
            {
                Error = pError;
                Mensaje = pMensaje;
            }
            public Response(byte[] pArchivoByte, string pNombreArchivo, bool pError, string pMensaje)
            {
                ArchivoByte = pArchivoByte;
                NombreArchivo = pNombreArchivo;
                Error = pError;
                Mensaje = pMensaje;
            }
        }
    }
}
