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

namespace Ent.Sql.ClinicaE.ContratosE
{
    public class HisContratoconsultorioDetE
    {
        #region ATRIBUTOR
        public int IDContratoConsultorioCab { get; set; }
        public int IDCalendario { get; set; }
        public int IDContratoBeneficios { get; set; } = 0;
        public int IDBeneficio { get; set; } = 0;
        public string? EstContratoConsultorioDet { get; set; } = "";
        public string? TipDescuento { get; set; } = "";
        public string? DscObsBeneficios { get; set; } = "";
        public int CntDescuento { get; set; } = 0;
        public decimal PrecioxHora { get; set; } = 0;
        public bool Respuesta { get; set; } = false;
        //Extensiones
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int IDBuscar { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public HisContratoconsultorioDetE() { }
        public HisContratoconsultorioDetE(int pIDContratoConsultorioCab, int pOrden)
        {
            IDContratoConsultorioCab = pIDContratoConsultorioCab;
            Orden = pOrden;
        }
        #endregion
    }
}