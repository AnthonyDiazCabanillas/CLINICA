using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.LogisticaE.ProductosE;
using Dat.Sql.LogisticaAD.ProductosAD;

namespace Bus.Clinica.Logistica
{
    public class Productos
    {
        public List<ProductosE> ListaProductos(ProductosE pProductosE)
        {
            try
            { return new ProductosAD().Sp_Productos_ConsultaV2(pProductosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

    }
}
