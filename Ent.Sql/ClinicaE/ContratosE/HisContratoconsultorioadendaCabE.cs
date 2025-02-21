/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
 1.1        23/10/2024  PBARDALES    REQ 2024-020175 : Alquiler de consultorios e agrega dos variables
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.ContratosE
{
    public class HisContratoconsultorioadendaCabE
    {
        #region ATRIBUTOR
        public int IdeAdendaCab { get; set; } = 0;
        public int IdeHisContratoconsultorioCab { get; set; } = 0;
        public string? TipPago { get; set; } = "";
        public string? FecInicioContrato { get; set; } = "";
        public string? FecFinContrato { get; set; } = "";
        public string? DsObservaciones { get; set; } = "";
        public decimal CntRentaMensual { get; set; }
        public int CntTotalHoras { get; set; } = 0;
        public decimal CntPrecioxhora { get; set; }
        public string? EstAdenda { get; set; } = "";
        public string? EstContrato { get; set; } = "";
        public string? FecRegistro { get; set; } = "";
        public int UsrRegistra { get; set; } = 0;
        public string? DscUsrRegistra { get; set; } = "";
        public string? FecActualizacion { get; set; } = "";
        public int UsrActualizacion { get; set; } = 0;
        public string? BlbArchivoAdjunto { get; set; } = "";
        public int IDCalendario { get; set; } = 0;
        public int IdeBeneficioAdenda { get; set; } = 0;
        public int CntDescuento { get; set; } = 0;
        // 1.1  INI
        public string? EstTipoComprob { get; set; } = "";  
        public string? tip_comprobante { get; set; } = "";
        //FIN    

        //Extensiones
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int IDBuscar { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public string? Buscar { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public HisContratoconsultorioadendaCabE() { }

        public HisContratoconsultorioadendaCabE(int pIdeAdendaCab)
        { IdeAdendaCab = pIdeAdendaCab; }
        public HisContratoconsultorioadendaCabE(int pIDBuscar, int pOrden)
        {
            IDBuscar = pIDBuscar;
            Orden = pOrden;
        }

        public HisContratoconsultorioadendaCabE(int pIdeAdendaCab,int pIdeHisContratoconsultorioCab, string pNuevoValor, string pCampo, int pOrden)
        {
            IdeAdendaCab = pIdeAdendaCab;
            IdeHisContratoconsultorioCab = pIdeHisContratoconsultorioCab;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
            Orden = pOrden;
        }
        #endregion
    }
}
