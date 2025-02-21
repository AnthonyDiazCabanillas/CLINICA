using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisAgendamientoAmbulatorioE
    {
        #region ATRIBUTOS
        public int CodrisAgendamiento { get; set; } = 0;
        public int CodrisAmbulatorio { get; set; } = 0;
        public string? Codpaciente { get; set; } = "";
        public string? Codprestacion { get; set; } = "";
        public string? Nombre { get; set; } = "";
        public string? SpsId { get; set; } = "";
        public string? SequenceId { get; set; } = "";
        public string? PacsSpsId { get; set; } = "";
        public string? StartDatetime { get; set; } = "";
        public string? Codsala { get; set; } = "";
        public string? Status { get; set; } = "";
        public string? Codpresotor { get; set; } = "";
        public string? Estado { get; set; } = "";
        public string? IdeRecetadet { get; set; } = "";
        public string? StatusKey { get; set; } = "";
        public string? FlgPagado { get; set; } = "";
        //EXTENSIONES
        public string? NuevoValor { get; set; } = "";
        public string? Buscar { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int NumeroFilas { get; set; } = 0;
        public int Version { get; set; } = 0;
        public int Orden { get; set; } = 0;

        #endregion

        #region CONSTRUCTORES
        public RisAgendamientoAmbulatorioE()
        { }

        public RisAgendamientoAmbulatorioE(int pCodrisAgendamiento)
        { CodrisAgendamiento = pCodrisAgendamiento; }

        public RisAgendamientoAmbulatorioE(int pCodrisAgendamiento, string? pNuevoValor, string? pCampo)
        {
            CodrisAgendamiento = pCodrisAgendamiento;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public RisAgendamientoAmbulatorioE(string pSpsId, string? pStatusKey, string? pCodpresotor)
        {
            SpsId = pSpsId;
            StatusKey = pStatusKey;
            Codpresotor = pCodpresotor;
        }
        public RisAgendamientoAmbulatorioE(string pSpsId, string? pBuscar, string? pCampo, int pNumeroFilas, int pOrden)
        {
            SpsId = pSpsId;
            Buscar = pBuscar;
            Campo = pCampo;
            NumeroFilas = pNumeroFilas;
            Orden = pOrden;
        }
        #endregion
    }
}
