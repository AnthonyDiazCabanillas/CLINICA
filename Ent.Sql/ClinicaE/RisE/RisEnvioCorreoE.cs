using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisEnvioCorreoE
    {
        #region ATRIBUTOS
        public string? TipoCorreo { get; set; }
        public string? TipoError { get; set; }
        public string? CodigoPacienteEnvio { get; set; }
        public string? DocPacienteEnvio { get; set; }
        public string? exSubject { get; set; }
        public string? exBody { get; set; }
        #endregion

        #region CONSTRUCTOR
        public RisEnvioCorreoE()
        { }
        public RisEnvioCorreoE(string? pTipoCorreo, string? pTipoError, string? pCodigoPacienteEnvio, string? pDocPacienteEnvio, string? pExSubject, string? pExbody)
        {
            TipoCorreo = pTipoCorreo;
            TipoError = pTipoError;
            CodigoPacienteEnvio = pCodigoPacienteEnvio;
            DocPacienteEnvio = pDocPacienteEnvio;
            exSubject = pExSubject;
            exBody = pExbody;
        }
        #endregion
    }
}
