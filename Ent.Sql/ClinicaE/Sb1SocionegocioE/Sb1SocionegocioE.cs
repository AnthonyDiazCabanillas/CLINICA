using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.Sb1SocionegocioE
{
    public class Sb1SocionegocioE
    {
        #region ATRIBUTOS
        public int IdeSocionegocio { get; set; } = 0;
        public string? DscCardcodeOld { get; set; } = "";
        public string? DscCardcodeNew { get; set; } = "";
        public string? Facturar { get; set; } = "";
        public DateTime FecRegistro { get; set; } = DateTime.Now;
        //EXTENSIONES
        public string? CarCode { get; set; } = "";
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public Sb1SocionegocioE()
        { }

        public Sb1SocionegocioE(int pIdeSocionegocio)
        { IdeSocionegocio = pIdeSocionegocio; }
        public Sb1SocionegocioE(string pCarCode, int pOrden)
        {
            CarCode = pCarCode;
            Orden = pOrden;
        }

        public Sb1SocionegocioE(int pIdeSocionegocio, string pNuevoValor, string pCampo)
        {
            IdeSocionegocio = pIdeSocionegocio;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion
    }
}
