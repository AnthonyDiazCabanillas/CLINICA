using Dat.Sql.ClinicaAD;
using Ent.Sql;
using Ent.Sql.ClinicaE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class TramaBus
    {
        public async Task<ResultadoTransactionE<TabsTituloDataE>> ListadoTramaTabs() 
        { 
            return await new TramasAD().ListadoTramaTabs();
        }

        public async Task<ResultadoTransactionE<TramasE>> ListadoDetalleTramas(string NroComprobante) 
        {
            return await new TramasAD().ListadoDetalleTramas(NroComprobante);
        }

        public async Task<ResultadoTransactionE<bool>> ActualizarTramas(TramasE objtrama) 
        {
            return await new TramasAD().ActualizarTramas(objtrama);
        }
    }
}
