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

namespace WsEnvioDocumentoDigitalizacion
{
    public class TokenResponse
    {
        public string token { get; set; }
        public string timpoExpiracion { get; set; }
    }
}