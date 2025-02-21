using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisOracleRisXmlEventsE
    {
        #region ATRIBUTOS
        public int CodRisAmbulatorio { get; set; } = 0;
        public int CodEmpresa { get; set; } = 0;
        public int CodSucursal { get; set; } = 0;
        public string EventId { get; set; } = "";
        public string? EventDesc { get; set; } = "";
        public string EventDatetime { get; set; } = "";
        public int EventTypeId { get; set; } = 0;
        public string? OrderStatus { get; set; } = "";
        public string? IdPaciente { get; set; } = "";
        public string? IdPacienteRis { get; set; } = "";
        public string? RutPaciente { get; set; } = "";
        public string? TipoPaciente { get; set; } = "";
        public int IdAdmision { get; set; } = 0;
        public int IdIngreso { get; set; } = 0;
        public int IdAtencion { get; set; } = 0;
        public int CodPaquete { get; set; } = 0;
        public string? FillerOrderNumber { get; set; } = "";
        public string? XmlMsg { get; set; } = "";
        public string? XmlIntegrationDate { get; set; } = "";
        public string? XmlEventStatus { get; set; } = "";
        public string? XmlMessageStatus { get; set; } = "";
        public string? XmlUserUpdated { get; set; } = "";
        public string? XmlFlag1 { get; set; } = "";
        public string? Fechahoraregistro { get; set; } = "";
        public int Version { get; set; } = 0;
        public string? FecTrama { get; set; } = "";
        //EXTENSIONES
        public string? Buscar { get; set; } = "";
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int NumeroFila { get; set; } = 0;
        public int Result{ get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisOracleRisXmlEventsE()
        { }

        public RisOracleRisXmlEventsE(int pCodEmpresa)
        { CodEmpresa = pCodEmpresa; }

        public RisOracleRisXmlEventsE(int pCodRisAmbulatorio, string? pNuevoValor, string? pCampo)
        {
            CodRisAmbulatorio = pCodRisAmbulatorio;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }


        #endregion
    }
}
