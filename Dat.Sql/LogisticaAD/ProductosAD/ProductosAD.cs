using Ent.Sql.LogisticaE.ProductosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.LogisticaAD.ProductosAD
{
    public class ProductosAD
    {
        private ProductosE LlenarEntidad(IDataReader dr, ProductosE pProductoE)
        {
            ProductosE oProductoE = new ProductosE();
            switch (pProductoE.Orden)
            {
                case 1:
                    oProductoE.Codproducto = Convert.ToString(dr["codproducto"]);
                    oProductoE.Dscproducto = Convert.ToString(dr["nombre"]);
                    break;
            }
            return oProductoE;
        }

        public List<ProductosE> Sp_Productos_ConsultaV2(ProductosE pProductoE)
        {
            List<ProductosE> oListar = new List<ProductosE>();
            ProductosE opProductoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Productos_ConsultaV2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pProductoE.Orden);
                    cmd.Parameters.AddWithValue("@dscproducto", pProductoE.Dscproducto);
                    cmd.Parameters.AddWithValue("@nro_filas", pProductoE.Nrofilas);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        opProductoE = LlenarEntidad(dr, pProductoE);
                        oListar.Add(opProductoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
