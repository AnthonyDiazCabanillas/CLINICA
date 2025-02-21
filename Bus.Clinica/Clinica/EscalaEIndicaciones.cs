using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class EscalaEIndicaciones
    {
        EscalaEIndicacionesAD _ObjAD = new EscalaEIndicacionesAD();
        public List<EscalaEIndicacionesE> Escala_e_indicaciones_List(int order, int variable, string val, string val1, string val2, string val3) 
        {
            try {
                return _ObjAD.Escala_e_indicaciones_List(order,variable,val, val1, val2, val3);
            }
            catch (Exception ex){ throw ex; }
        }

        public List<EscalaEIndicacionesActividadE> EscalaEIndicacionesActividad_List(int order, int variable, string val, string val1, string val2, string val3)
        {
            try 
            {
                return _ObjAD.EscalaEIndicacionesActividad_List(order, variable, val, val1, val2, val3);
            } 
            catch (Exception ex) { throw ex; }
        }

        public RespuestaJsonE EscalaEintervenciones_Register(PuntuacionEscalaE obj)
        {
            try {
                return _ObjAD.EscalaEintervenciones_Register(obj);
            }
            catch (Exception ex) { throw ex; }
        }
        public List<EscalaeIndicacionesHistoricoE> EscalaEIndicacionesHistorico_List(int order, int variable, string val, string val1, string val2, string val3)
        {
            try
            {
                return _ObjAD.EscalaEIndicacionesHistorico_List(order, variable, val, val1, val2, val3);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<EscalaEIndicacionesHistoriaDetalladoE> EscalaEIndicacionesHistoricoDetallado_List(int order, int variable, string val, string val1, string val2, string val3) 
        {
            try
            {
                return _ObjAD.EscalaEIndicacionesHistoricoDetallado_List(order, variable, val, val1, val2, val3);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
