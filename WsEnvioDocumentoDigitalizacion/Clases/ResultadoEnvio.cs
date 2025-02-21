//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WsEnvioDocumentoDigitalizacion.Program;

namespace WsEnvioDocumentoDigitalizacion
{
    public class ResultadoEnvio
    {
        public string numero { get; set; }
        public string numeroHistoriaClinca { get; set; }
        public string nombrePaciente { get; set; }
        public string apellidosdelPaciente { get; set; }

        public Atencion atencion { get; set; }

        public class Documento
        {
            public int idDocumento { get; set; }
            public int idTipoDocumento { get; set; }
            public string nombre { get; set; }
            public string archivo { get; set; }
            public string extencion { get; set; }
            public bool eliminar { get; set; } = false;
        }

        public class Atencion
        {
            public string numero { get; set; }
            public int idTipoAtencion { get; set; }
            public string tipoAtencion { get; set; }
            public string sede { get; set; }
            public string nombreMedico { get; set; }
            public string especialidadMedico { get; set; }
            public DateTime fechaAtencion { get; set; }

            public Documento documento { get; set; }
        }
    }
}
