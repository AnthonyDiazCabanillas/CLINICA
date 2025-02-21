using Dat.Sql;
using Ent.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica
{
    public class PrestacionesClinica
    {
        public async Task<ResultadoTransactionE<PrestacionesClinicaE>> Listado_Prestaciones(PrestacionBusqE obj) 
        {
            return await new PrestacionesClinicaAD().Listado_Prestaciones(obj);
        }
        public async Task<ResultadoTransactionE<TarifaClinicaE>> Listado_Tarifario(PrestacionBusqE obj) 
        {
            return await new PrestacionesClinicaAD().Listado_Tarifario(obj);
        }

        public async Task<ResultadoTransactionE<PrestacionesClinicaE>> Listado_PrestacionTarifario(PrestacionBusqE obj) 
        {
            return await new PrestacionesClinicaAD().Listado_PrestacionTarifario(obj);
        }
        public async Task<ResultadoTransactionE<ErrorDataInsercionE>> Registro_PrestacionTarifa(List<PrestacionesClinicaE> obj, int iduser) 
        {
            return await new PrestacionesClinicaAD().Registro_PrestacionTarifa(obj, iduser);
        }
    }
}
