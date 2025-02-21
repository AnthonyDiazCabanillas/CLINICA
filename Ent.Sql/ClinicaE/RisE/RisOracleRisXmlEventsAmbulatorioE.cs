using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisOracleRisXmlEventsAmbulatorioE
    {
        #region ATRIBUTOS
        public int CodrisAmbulatorio { get; set; } = 0;
        public string FlagProcesado { get; set; } = "";
        public int CodEmpresa { get; set; } = 0;
        public int CodSucursal { get; set; } = 0;
        public string EventId { get; set; } = "";
        public string EventDesc { get; set; } = "";
        public string EventDatetime { get; set; } = "";
        public int EventTypeId { get; set; } = 0;
        public string OrderStatus { get; set; } = "";
        public string IdPaciente { get; set; } = "";
        public string IdPacienteRis { get; set; } = "";
        public string RutPaciente { get; set; } = "";
        public string TipoPaciente { get; set; } = "";
        public int IdAdmision { get; set; } = 0;
        public int IdIngreso { get; set; } = 0;
        public int IdAtencion { get; set; } = 0;
        public int CodPaquete { get; set; } = 0;
        public string FillerOrderNumber { get; set; } = "";
        public string XmlMsg { get; set; } = "";
        public string XmlIntegrationDate { get; set; } = "";
        public string XmlEventStatus { get; set; } = "";
        public string XmlMessageStatus { get; set; } = "";
        public string XmlUserUpdated { get; set; } = "";
        public string XmlFlag1 { get; set; } = "";
        public int Version { get; set; } = 0;
        public string FecTrama { get; set; } = "";
        //EXTENSIONES
        public string Buscar { get; set; } = "";
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int NumeroFilas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisOracleRisXmlEventsAmbulatorioE()
        { }

        public RisOracleRisXmlEventsAmbulatorioE(int pCodrisAmbulatorio)
        { CodrisAmbulatorio = pCodrisAmbulatorio; }

        public RisOracleRisXmlEventsAmbulatorioE(int pCodrisAmbulatorio, string? pNuevoValor, string? pCampo)
        {
            CodrisAmbulatorio = pCodrisAmbulatorio;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public RisOracleRisXmlEventsAmbulatorioE(int pCodrisAmbulatorio, string? pBuscar, string? pCampo, int pNumeroFilas, int pOrden)
        {
            CodrisAmbulatorio = pCodrisAmbulatorio;
            Buscar = pBuscar;
            Campo = pCampo;
            NumeroFilas = pNumeroFilas;
            Orden = pOrden;
        }
        #endregion
    }
}
