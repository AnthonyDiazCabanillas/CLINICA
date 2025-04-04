﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisOracleRisXmlEventsCompletadoE
    {
        #region ATRIBUTOS
        public int CodrisCompletado { get; set; } = 0;
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
        //EXTENSIONES
        public string Buscar { get; set; } = "";
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int NumeroFilas { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisOracleRisXmlEventsCompletadoE()
        { }

        public RisOracleRisXmlEventsCompletadoE(int pCodrisCompletado)
        { CodrisCompletado = pCodrisCompletado; }

        public RisOracleRisXmlEventsCompletadoE(int pCodrisCompletado, string pNuevoValor, string pCampo)
        {
            CodrisCompletado = pCodrisCompletado;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public RisOracleRisXmlEventsCompletadoE(int pCodrisCompletado, string pBuscar, string pCampo, int pNumeroFilas, int pOrden)
        {
            CodrisCompletado = pCodrisCompletado;
            Buscar= pBuscar;
            Campo = pCampo;
            NumeroFilas= pNumeroFilas;
            Orden = pOrden;
        }
        #endregion
    }
}
