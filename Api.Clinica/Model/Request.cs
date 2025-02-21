//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor        Requerimiento
//    1.0             10/01/2025     HVIDAL       REQ 2024-014877 Neonatologia
//***************************************************************************************
namespace Api.Clinica.Model
{
    public class Request
    {
        public string Id { get; set; } = "";

        public class Roe
        {
            public string CodigoAtencion { get; set; } = "";
            public string Documento { get; set; } = "";

        }
    }
}
