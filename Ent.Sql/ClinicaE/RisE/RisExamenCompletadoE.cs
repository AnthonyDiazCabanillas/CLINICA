using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisExamenCompletadoE
    {
        #region ATRIBUTOS
        public int CodrisExamenrealizado { get; set; } = 0;
        public int CodrisCompletado { get; set; } = 0;
        public string Fecha { get; set; } = "";
        public string Codprestacion { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string SpsId { get; set; } = "";
        public string SequenceId { get; set; } = "";
        public string PacsSpsId { get; set; } = "";
        public string Codsala { get; set; } = "";
        public string Status { get; set; } = "";
        public string Codpresotor { get; set; } = "";
        public string Estado { get; set; } = "";
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisExamenCompletadoE()
        { }

        public RisExamenCompletadoE(int pCodrisExamenrealizado)
        { CodrisExamenrealizado = pCodrisExamenrealizado; }

        public RisExamenCompletadoE(int pCodrisExamenrealizado, string pNuevoValor, string pCampo)
        {
            CodrisExamenrealizado = pCodrisExamenrealizado;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }
}
