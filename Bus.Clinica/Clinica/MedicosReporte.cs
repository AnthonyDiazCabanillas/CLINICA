/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      07/02/2024   FGONZALES       REQ 2024-002761 RE: EXPORTAR INFO
    1.1      09/05/2024   CPARRALES       REQ 2024-007413 Maestro de medicos y empresas
********************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dat.Sql.ClinicaAD.MedicosAD;
using Ent.Sql.ClinicaE.MedicosE;
namespace Bus.Clinica.Clinica
{
    public class MedicosReporte
    {
        public List<MedicoReporteE> ListaMedicosReporte(MedicoReporteE pMedicoReporteE)
        {
            List<MedicoReporteE>  oListarMedicosReporte =  new List<MedicoReporteE>();
            try
            {
                return new MedicoReporteAD().Rp_RceMedicos(pMedicoReporteE);
            }
            catch (Exception ex)
            {
                return oListarMedicosReporte;
            }
        }
        //1.1 INI
        public List<MedicoReporteCompletoE> ListaMedicosReporteCompleto(MedicoReporteCompletoE pMedicoReporteCompletoE)
        {
            List<MedicoReporteCompletoE> oListarMedicosReporte = new List<MedicoReporteCompletoE>();
            try
            {
                return new MedicoReporteAD().Rp_RceMedicosCompleto(pMedicoReporteCompletoE);
            }
            catch (Exception ex)
            {
                return oListarMedicosReporte;
            }
        }
        //1.1 FIN
    }
}