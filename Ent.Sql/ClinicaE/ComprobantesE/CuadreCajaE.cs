using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.ComprobantesE
{
    public class CuadreCajaE
    {
        #region ATRIBUTOS
        public int Correlativo { get; set; } = 0;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Usuario { get; set; } = 0;
        public string Documento { get; set; } = "";
        public string Tipopago { get; set; } = "";
        public string Codentidad { get; set; } = "";
        public string Numeroentidad { get; set; } = "";
        public string Movimiento { get; set; } = "";
        public Double Monto { get; set; } = 0;
        public Double Montodolares { get; set; } = 0;
        public string Moneda { get; set; } = "";
        public Double Tipodecambio { get; set; } = 0;
        public string Codcentro { get; set; } = "";
        public string Tipodocumento { get; set; } = "";
        public string Codempresa { get; set; } = "";
        public string Numeroplanilla { get; set; } = "";
        public string Estado { get; set; } = "";
        public string Codterminal { get; set; } = "";
        public string Codpase { get; set; } = "";
        public bool FlgEnviosap { get; set; } = false;
        public DateTime FecEnviosap { get; set; } = DateTime.Now;
        public int IdeTrans { get; set; } = 0;
        public int DocEntry { get; set; } = 0;
        public bool FlgEnvioanularsap { get; set; } = false;
        public DateTime FecEnvioanularsap { get; set; } = DateTime.Now;
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;


        public string CodComprobante { get; set; } = "";

        #endregion

        #region CONSTRUCTORES
        public CuadreCajaE()
        { }

        public CuadreCajaE(int pCorrelativo)
        { Correlativo = pCorrelativo; }

        public CuadreCajaE(int pCorrelativo, string pNuevoValor, string pCampo)
        {
            Correlativo = pCorrelativo;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        #endregion

    }
}
