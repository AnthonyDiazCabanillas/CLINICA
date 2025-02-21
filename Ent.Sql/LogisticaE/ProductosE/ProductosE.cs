using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.LogisticaE.ProductosE
{
    public class ProductosE
    {
        #region ATRIBUTOS
        public string? Codproducto { get; set; }
        public string? Dscproducto { get; set; }

        //EXTENSIONES
        public int Nrofilas { get; set; }
        public int Orden { get; set; }
        #endregion

        #region CONSTRUCTORES
        public ProductosE() { }

        #region Sp_Productos_ConsultaV2
        /// <summary>
        ///         ''' [Sp_Productos_ConsultaV2]
        ///         ''' </summary>
        ///         ''' <param name="pOrden"></param>
        ///         ''' <param name="pDscproducto"></param>
        ///         ''' <param name="pNrofilas"></param>
        public ProductosE(int pOrden, string? pDscproducto, int pNrofilas)
        {
            Orden = pOrden;
            Dscproducto = pDscproducto;
            Nrofilas = pNrofilas;
        }

        #endregion

        #endregion
    }
}
