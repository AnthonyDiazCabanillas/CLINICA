using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.RisE
{
    public class RisPrestacionVsSalasE
    {
        #region ATRIBUTOS
        public string? Codprestacion { get; set; } = "";
        public string? Codsala { get; set; } = "";
        public int Prioridad { get; set; } = 0;
        public string? Estado { get; set; } = "";
        //EXTENSIONES
        public string? Buscar { get; set; } = "";
        public string? NuevoValor { get; set; } = "";
        public string? Campo { get; set; } = "";
        public int NumeroFilas { get; set; } = 0;
        public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public RisPrestacionVsSalasE()
        { }

        public RisPrestacionVsSalasE(string? pCodprestacion)
        { Codprestacion = pCodprestacion; }

        public RisPrestacionVsSalasE(string? pCodprestacion, string? pNuevoValor, string? pCampo)
        {
            Codprestacion = pCodprestacion;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }
        public RisPrestacionVsSalasE(string? pCodsala, string? pCodprestacion, int pOrden)
        {
            Codsala = pCodsala;
            Codprestacion = pCodprestacion;
            Orden = pOrden;
        }
        #endregion
    }
}
