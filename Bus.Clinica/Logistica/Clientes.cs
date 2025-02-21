using Dat.Sql.LogisticaAD.ClientesAD;
using Ent.Sql.LogisticaE.ClientesE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Logistica
{
    public class Clientes
    {
        public List<ClientesE> Sp_Clientes_Consulta(ClientesE pClientesE)
        {
            try
            { return new ClientesAD().Sp_Clientes_Consulta(pClientesE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}
