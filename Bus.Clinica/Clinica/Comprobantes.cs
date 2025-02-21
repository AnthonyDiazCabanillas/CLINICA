/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version Fecha       Autor       Requerimiento
 1.0      29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using Dat.Sql.ClinicaAD.ComprobantesAD;
using Ent.Sql.ClinicaE.CirugiaE;
using Ent.Sql.ClinicaE.ComprobantesE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class ComprobantesElectronicos
    {
        public List<ComprobantesElectronicosE> ComprobantesElectronicos_Consulta(ComprobantesElectronicosE oComprobantesElectronicos)
        {
            try
            { return new ComprobantesElectronicosAD().Sp_ComprobantesElectronicos_Consulta(oComprobantesElectronicos); }
            catch (Exception ex)
            { throw ex = new Exception(ex.Message); }
        }
    }
    public class Comprobantes
    {
        public List<ComprobantesE> Sp_Comprobantes_Consulta(ComprobantesE pComprobantesE)
        {
            try
            { return new ComprobantesAD().Sp_Comprobantes_Consulta(pComprobantesE); }
            catch (Exception ex)
            { throw ex = new Exception(ex.Message); }
        }
        //
    }

    public class Serie
    {
        public List<SerieE> Sp_Serie_Consulta(SerieE pSerieE)
        {
            try
            { return new SerieAD().Sp_Serie_Consulta(pSerieE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}