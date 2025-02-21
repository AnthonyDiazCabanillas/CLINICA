using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.LogisticaE.ConveniosE
{
    public class ConveniosE
    {
        #region ATRIBUTOS
        public int Idconvenio { get; set; } = 0;
        public int Idcliente { get; set; } = 0;
        public DateTime Fechadocumento { get; set; } = DateTime.Now;
        public string? Codalmacen { get; set; }
        public string? Tipomovimiento { get; set; }
        public string? Codtipocliente { get; set; }
        public string? Nomtipocliente { get; set; }
        public string? Codcliente { get; set; }
        public string? Codpaciente { get; set; }
        public string? Nompaciente { get; set; }
        public string? Codaseguradora { get; set; }
        public string? Codcia { get; set; }
        public string? Codproducto { get; set; }
        public DateTime Fechainicio { get; set; } = DateTime.Now;
        public string Fechafin { get; set; }
        public int Excepto { get; set; } = 0;
        public string? Tipomonto { get; set; } = "";
        public Double Monto { get; set; } = 0;
        public string? Moneda { get; set; } = "";
        public int Estado { get; set; } = 0;
        public string? Nomaseguradora { get; set; }
        public string? Nomproducto { get; set; }
        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Nrofilas { get; set; } = 0;

        public int FactorLogistica { get; set; } = 0;
        public double PrecioUnitario { get; set; } = 0;

        public double MontoFinal() 
        {
            return Math.Round((FactorLogistica * PrecioUnitario), 2);
        }
        #endregion


        #region CONSTRUCTORES
        public ConveniosE() { }

        public ConveniosE(int pIdconvenio, string pNuevoValor, string pCampo)
        {
            Idconvenio = pIdconvenio;
            NuevoValor = pNuevoValor;
            Campo = pCampo;
        }

        public ConveniosE(int pOrden, string? pCodaseguradora, string? pCodpaciente, string? pCodproducto, int pNrofilas, string pCodalmacen, string? pTipomovimiento, string? pcodcliente, string? pcodcia, string? pFechafin, int pExcepto, int pEstado)
        {
            Orden = pOrden;
            Codaseguradora = pCodaseguradora;
            Codpaciente = pCodpaciente;
            Codproducto = pCodproducto;
            Nrofilas = pNrofilas;
            Codalmacen = pCodalmacen;
            Tipomovimiento = pTipomovimiento;
            Codcliente = pcodcliente;
            Codcia = pcodcia;
            Fechafin = pFechafin;
            Excepto = pExcepto;
            Estado = pEstado;
        }



        #endregion
    }
}
