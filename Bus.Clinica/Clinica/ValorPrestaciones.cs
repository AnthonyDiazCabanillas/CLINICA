using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica
{
    public class ValorPrestaciones
    {
        #region ConsultaDatosPacientePrestacion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPrestacionesE"></param>
        /// <returns></returns>
        public ValorPrestacionesE ConsultaDatosPacientePrestacion(ValorPrestacionesE pPrestacionesE)
        {
            try
            {
                ValorPrestacionesE prestacionesE = new ValorPrestacionesE();
                List<ValorPrestacionesE> lista = new List<ValorPrestacionesE>();
                lista = new ValorPrestacionesAD().Sp_ValorPrestaciones_Consultav2(new ValorPrestacionesE(1, pPrestacionesE.Codatencion, "", "", "", 1));

                if (lista.Count >= 1)
                    prestacionesE = lista[0];

                return prestacionesE;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion
        public List<ValorPrestacionesE> ConsultaValorPrestaciones(ValorPrestacionesE pPrestacionesE)
        {
            ValorPrestacionesE xPrestacionesE = new ValorPrestacionesE();
            try
            {
                return new ValorPrestacionesAD().Sp_ValorPrestaciones_Consultav2(new ValorPrestacionesE(2, "", pPrestacionesE.Codprestacion, pPrestacionesE.Codtarifa, "", 25));
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

    }
}
