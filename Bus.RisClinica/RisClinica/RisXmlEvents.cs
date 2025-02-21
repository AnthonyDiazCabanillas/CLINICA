using Dat.Sql.RisClinicaAD.RisXmlEventsAD;
using Ent.Sql.RisClinicaE.RisXmlEventsE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.RisClinica.RisClinica
{
    public class RisXmlEvents
    {
        public List<RisXmlEventsE> Sp_RISXMLEVENTS_Consulta(RisXmlEventsE pRisXmlEventsE)
        {
            try
            { return new RisXmlEventsAD().Sp_RisXmlEvents_Consulta(pRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos(RisXmlEventsE pRisXmlEventsE)
        {
            try
            { return new RisXmlEventsAD().Sp_RisXmlEvents_Insert(pRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RISXMLEVENTS_Insert(RisXmlEventsE pRisXmlEventsE)
        {
            try
            { return new RisXmlEventsAD().Sp_RisXmlEvents_Insert(pRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RISXMLEVENTS_Update(RisXmlEventsE pRisXmlEventsE)
        {
            try
            { return new RisXmlEventsAD().Sp_RisXmlEvents_Update(pRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RISXMLEVENTS_UpdatexCampo(RisXmlEventsE pRisXmlEventsE)
        {
            try
            { /*return new RisXmlEventsAD().Sp_RisXmlEvents_UpdatexCampo(pRisXmlEventsE);*/
                return new RisXmlEventsAD().Sp_RisXmlEvents_UpdatexCampo(pRisXmlEventsE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

    }
}