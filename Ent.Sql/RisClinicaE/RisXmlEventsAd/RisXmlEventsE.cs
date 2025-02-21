using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.RisClinicaE.RisXmlEventsE
{
    public class RisXmlEventsE
    {
        #region ATRIBUTOS
        public int CodEmpresa { get; set; } = 0;
        public int CodSucursal { get; set; } = 0;
        public string? EventId { get; set; } = "";
        public string? EventDesc { get; set; } = "";
        public string? EventDateTime { get; set; } = "";
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
        public string? FillerOrderInt { get; set; } = "";
        public string? XmlMsg { get; set; } = "";
        public string? XmlIntegrationDate { get; set; } = "";
        public string? XmlEventStatus { get; set; } = "";
        public string? XmlMessageStatus { get; set; } = "";
        public string? XmlUserUpdated { get; set; } = "";
        public string? XmlFlag1 { get; set; } = "";
        public int Version { get; set; } = 0;
        public string? FlgProcesado { get; set; } = "";
        //EXTENSIONES
        public string? Buscar { get; set; } = "";
        public string? Campo { get; set; } = "";
        public string? Fecha { get; set; } = "";
        public int NumeroFila { get; set; } = 0;
        public string? NuevoValor { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisXmlEventsE()
        { }

        public RisXmlEventsE(int pCodEmpresa)
        { CodEmpresa = pCodEmpresa; }

        public RisXmlEventsE(int pCodEmpresa, string pNuevoValor, string pCampo)
        {
            CodEmpresa = pCodEmpresa;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }

        public RisXmlEventsE(string pBuscar, string pCampo, string pFecha, int pNumeroFila, int pOrden)
        {
            Buscar = pBuscar;
            Buscar = pCampo;
            Fecha = pFecha;
            NumeroFila = pNumeroFila;
            Orden = pOrden;
        }
        #endregion
    }
}
