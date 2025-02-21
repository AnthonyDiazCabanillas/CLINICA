using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RceE
{
    public class RceRecetaImagenDetE
    {
        #region ATRIBUTOS
        public int IdeRecetadet { get; set; } = 0;
        public int IdeRecetacab { get; set; } = 0;
        public string CodPrestacion { get; set; } = "";
        public string CodMedico { get; set; } = "";
        public string CodPresotor { get; set; } = "";
        public int IdeImagen { get; set; } = 0;
        public string DscImagen { get; set; } = "";
        public string EstImagen { get; set; } = "";
        public string FecRegistra { get; set; } = "";
        public int UsrRegistra { get; set; } = 0;
        public string FecModifica { get; set; } = "";
        public int UsrModifica { get; set; } = 0;
        public string FlgRevisado { get; set; } = "";
        public int UsrAnulacion { get; set; } = 0;
        public string FecAnulacion { get; set; } = "";
        public string DscAnulacion { get; set; } = "";
        public long SpsId { get; set; } = 0;
        public string FlgEnviadoris { get; set; } = "";
        public string FlgEnviarjpgRis { get; set; } = "";
        public string FecEnviarjpgRis { get; set; } = "";
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RceRecetaImagenDetE()
        { }

        public RceRecetaImagenDetE(int pIdeRecetadet)
        { IdeRecetadet = pIdeRecetadet; }

        public RceRecetaImagenDetE(int pIdeRecetadet, string pNuevoValor, string pCampo)
        {
            IdeRecetadet = pIdeRecetadet;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }
}
