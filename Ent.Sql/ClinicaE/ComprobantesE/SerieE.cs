using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.ComprobantesE
{
    public class SerieE
    {
        #region ATRIBUTOS
        public string Tiposerie { get; set; } = "";
        public string Serie { get; set; } = "";
        public string Correlativo { get; set; } = "";
        public string Codlocal { get; set; } = "";
        public string Codcentro { get; set; } = "";
        public string Tipocomprobante { get; set; } = "";
        public string FlgElectronico { get; set; } = "";
        public int FlgOtorgar { get; set; } = 0;
        public string FormatoElectronico { get; set; } = "";
        //EXTENSIONES
        public string Buscar { get; set; } = "";
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int NumeroLineas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public SerieE()
        { }

        public SerieE(string pTiposerie)
        { Tiposerie = pTiposerie; }

        public SerieE(string pBuscar, int pNumeroLineas, int pOrden)
        {
            Buscar = pBuscar;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion
    }
}
