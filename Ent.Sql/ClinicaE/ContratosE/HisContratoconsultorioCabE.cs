/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.ContratosE
{
    public class HisContratoconsultorioCabE
    {
        #region ATRIBUTOS
        public int IdeHisContratoconsultorioCab { get; set; } = 0;
        public int IdeAdendaCab { get; set; } = 0;
        public string? CodMedico { get; set; } = "";
        public string? NumDocIdeMedico { get; set; } = "";
        public string? DscMedico { get; set; } = "";
        public string? TipPago { get; set; } = "";
        public string? DscTipPago { get; set; } = "";
        public string? TipComprobante { get; set; } = "";
        public string? FacturaEmpresa { get; set; } = "";
        public string? NumFactura { get; set; } = "";
        public string? TipMoneda { get; set; } = "";
        public string? DscMoneda { get; set; } = "";
        public int IdeSede { get; set; } = 0;
        public string? DscSede { get; set; } = "";
        public int IdeTorre { get; set; } = 0;
        public string? DscTorre { get; set; } = "";
        public int Piso { get; set; } = 0;
        public string? FecInicioContrato { get; set; } = "";
        public string? FecFinContrato { get; set; } = "";
        public string? DscObservaciones { get; set; } = "";
        public decimal CntRentaMensual { get; set; } = 0;
        public string? RentaMensual { get; set; } = "";
        public int CntTotalHoras { get; set; } = 0;
        public decimal CntPrecioxhora { get; set; } = 0;
        public string? EstContratoConsultorio { get; set; } = "";
        public string? DscEstContratoConsultorio { get; set; } = "";
        public int IdeUsrRegistra { get; set; } = 0;
        public string? FecRegistro { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");
        public int IdeUsrActualiza { get; set; } = 0;
        public string? FecActualiza { get; set; } = "";
        public string? BlbArchivoAdjunto { get; set; } = "";
        public string? DscContacto { get; set; } = "";
        public string? TelContacto { get; set; } = "";
        public string? EmailContacto { get; set; } = "";
        public int ComprobantesPendientes { get; set; } = 0;
        public Decimal? DeudaTotal { get; set; } = 0;
        public int? CntComprobantePendientes { get; set; } = 0;
        public int? IdeContratoBeneficio { get; set; } = 0;
        public string? DscContratoBeneficio { get; set; } = "";
        public int CntDescuento { get; set; } = 0;

        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public string? IDBuscar { get; set; } = "";
        public string? Buscar { get; set; } = "";
        public int NumeroLineas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTUROES
        public HisContratoconsultorioCabE()
        { }
        public HisContratoconsultorioCabE(int pIdeHisContratoconsultorioCab)
        { IdeHisContratoconsultorioCab = pIdeHisContratoconsultorioCab; }
        public HisContratoconsultorioCabE(int pIdeHisContratoconsultorioCab, int pOrden)
        {
            IdeHisContratoconsultorioCab = pIdeHisContratoconsultorioCab;
            Orden = pOrden;
        }
        public HisContratoconsultorioCabE(int pIdeHisContratoconsultorioCab, string pNuevoValor, string pCampo)
        {
            IdeHisContratoconsultorioCab = pIdeHisContratoconsultorioCab;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public HisContratoconsultorioCabE(string pIDBuscar, string pBuscar, string pFecInicioContrato, string pFecFinContrato, int pNumeroLineas, int pOrden)
        {
            IDBuscar = pIDBuscar;
            Buscar = pBuscar;
            FecInicioContrato = pFecInicioContrato;
            FecFinContrato = pFecFinContrato;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion
    }
}
