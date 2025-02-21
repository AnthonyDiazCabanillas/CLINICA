using Dat.Sql.ClinicaAD.HospitalAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ent.Sql.CitaE.GestorColas;
using Dat.Sql.CitaAD.GestorColas;


namespace Bus.AgendaClinica.GestorColas
{
    public class CitasDisplay
    {
        CitasDisplayAD _ObjAD = new CitasDisplayAD();


        public async Task <CitasDisplayE> CitasDisplay_Listar(CitasDisplayJsonParamE objParametros)
        {
            try
            {
                return await _ObjAD.CitasDisplay_Listar(objParametros);
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task <CitasDisplayTicketE> CitasDisplayTicket_Listar(CitasTicketJsonParamE objParametros)
        {
            try
            {
                return await _ObjAD.CitasDisplayTicket_Listar(objParametros);
            }
            catch (Exception ex) { throw ex; }
        }
        public string uspCitaGetProximaCita(CitasTicketJsonParamE objParametros)
        {
            try
            {
                return _ObjAD.uspCitaGetProximaCita(objParametros);
            }
            catch (Exception ex) { throw ex; }
        }

        


        public CitasRegTurno GetCitasBMaticRegTurno(int pIDCita) 
        {
            try
            {
                return _ObjAD.GetCitasBMaticRegTurno(pIDCita);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
