/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version Fecha       Autor       Requerimiento
 1.0      29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.ContratosE
{
    public class HisDatospagosconsultoriosE
    {
        #region ATRIBUTOS
        public int IdePagocontrato { get; set; } = 0;
        public int IdeHisContratoconsultorioCab { get; set; } = 0;
        public int IdeAdendaCab { get; set; } = 0;
        public int MesComprobante { get; set; } = 0;
        public int AñoComprobante { get; set; } = 0;
        public int IdePagosBot { get; set; } = 0;
        public string? CodPresotor { get; set; } = "";
        public string? CodLiquidacion { get; set; } = "";
        public string? CodComprobante { get; set; } = "";
        public string? OrigenPago { get; set; } = "";
        public string? Link { get; set; } = "";
        public string? Estado { get; set; } = "";
        public string? FecVencimiento { get; set; } = "";
        public string? FecRegistro { get; set; } = "";
        public string? TipComprobante { get; set; } = "";
        public string? CardCode { get; set; } = "";
        public string? ANombreDeQuien { get; set; } = "";
        public string? TipMoneda { get; set; } = "";
        public string? Ruc { get; set; } = "";
        public string? Direccion { get; set; } = "";
        public string? TipDocIdentidad { get; set; } = "";
        public string? DocIdentidad { get; set; } = "";
        public string? CodTipoFactura { get; set; } = "";
        public string? CodMedico { get; set; } = "";
        public string? Concepto { get; set; } = "";
        public double TipCambio { get; set; } = 0;
        public string? Empresa { get; set; } = "";
        public string? TipoImpresion { get; set; } = "";
        public string? TipPago { get; set; } = "";
        public string? Entidad { get; set; } = "";
        public string? NumeroEntidad { get; set; } = "";
        public string? CodTerminal { get; set; } = "";
        public string? Operacion { get; set; } = "";
        public string? VariosTipoPago { get; set; } = "";
        public string? Email_Medico { get; set; } = "";
        public int IdeSede { get; set; } = 0;
        public decimal CntRentaMensual { get; set; } = 0;
        public decimal CntPagar { get; set; } = 0;

        //EXTENSIONES
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public int IDBuscar { get; set; } = 0;
        public string? Buscar { get; set; } = "";
        public string? FiltroSede { get; set; } = "";
        public string? FiltroFecha { get; set; } = "";
        #endregion

        #region CONSTRUCTORES
        public HisDatospagosconsultoriosE()
        { }

        public HisDatospagosconsultoriosE(int pIdePagocontrato)
        { IdePagocontrato = pIdePagocontrato; }

        public HisDatospagosconsultoriosE(int pIdePagocontrato, string pNuevoValor, string pCampo)
        {
            IdePagocontrato = pIdePagocontrato;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }

        public HisDatospagosconsultoriosE(int pIdePagocontrato, int pIDBuscar, string pBuscar, int pNumeroLineas, int pOrden)
        {
            IdePagocontrato = pIdePagocontrato;
            Buscar = pBuscar;
            IDBuscar = pIDBuscar;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion
    }
}
