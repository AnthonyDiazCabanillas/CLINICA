using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.OtrosE
{
    public class CorrelativoE
    {
        #region ATRIBUTOS
        public string Boleta { get; set; } = "";
        public string Factura { get; set; } = "";
        public string CreditoB { get; set; } = "";
        public string CreditoF { get; set; } = "";
        public string DebitoB { get; set; } = "";
        public string DebitoF { get; set; } = "";
        public string Guia { get; set; } = "";
        public string Garantia { get; set; } = "";
        public string GarantiaManual { get; set; } = "";

        public bool FlgElectronicof { get; set; } = false;
        public bool flg_electronicob { get; set; } = false;
        public bool flg_electronicocb { get; set; } = false;
        public bool flg_electronicocf { get; set; } = false;
        public bool flg_electronicodb { get; set; } = false;
        public bool flg_electronicodf { get; set; } = false;
        public bool flg_otorgarf { get; set; } = false;
        public bool flg_otorgarb { get; set; } = false;
        public bool flg_otorgarcb { get; set; } = false;
        public bool flg_otorgarcf { get; set; } = false;
        public bool flg_otorgardb { get; set; } = false;
        public bool flg_otorgardf { get; set; } = false;
        public bool flg_electronico { get; set; } = false;
        public bool generar_e { get; set; } = false;
        #endregion

        #region ADICIONALES
        public string PCHostname { get; set; } = "";
        #endregion

        #region CONSTRUCTORES
        public CorrelativoE() { }

        public CorrelativoE(string pPCHostname)
        { PCHostname = pPCHostname; }
        #endregion
    }
}
