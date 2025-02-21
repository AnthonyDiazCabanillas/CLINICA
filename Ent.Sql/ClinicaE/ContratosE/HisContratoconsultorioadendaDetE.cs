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
    public class HisContratoconsultorioadendaDetE
    {
        #region #ATRIBUTOS
        public int IdeAdendaCab { get; set; } = 0;
        public int IdeCalendario { get; set; } = 0;
        public int IdeBeneficiosadenda { get; set; } = 0;
        public int IdeBeneficio { get; set; } = 0;
        public bool EstBeneficio { get; set; } = false;
        public string EstCalendario { get; set; } = "";
        public int CntDescuento { get; set; } = 0;
        public int FlgNewBeneficio { get; set; } = 0;
        public decimal PrecioxHora { get; set; } = 0;
        public string? TipDescuento { get; set; } = "";
        public string? TipDocumento { get; set; } = "";
        public string Estado { get; set; } = "";

        //Extensiones
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int IDBuscar { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public string? Buscar { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public HisContratoconsultorioadendaDetE() { }

        public HisContratoconsultorioadendaDetE(int pIdeAdendaCab)
        { IdeAdendaCab = pIdeAdendaCab; }

        public HisContratoconsultorioadendaDetE(int pIdeAdendaCab, string pNuevoValor, string pCampo)
        {
            IdeAdendaCab = pIdeAdendaCab;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion

    }
}
