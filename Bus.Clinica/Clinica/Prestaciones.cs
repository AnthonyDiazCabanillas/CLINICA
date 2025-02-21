using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica
{
    public class Prestaciones
    {
        #region ConsultaDatosPacientePrestacion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPrestacionesE"></param>
        /// <returns></returns>
        public PrestacionesE ConsultaDatosPacientePrestacion(PrestacionesE pPrestacionesE)
        {
            try
            {
                PrestacionesE prestacionesE = new PrestacionesE();
                List<PrestacionesE> lista = new List<PrestacionesE>();
                lista = new PrestacionesAD().Sp_ValorPrestaciones_Consultav2(pPrestacionesE);

                if (lista.Count >= 1)
                    prestacionesE = lista[0];

                return prestacionesE;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion
        public List<PrestacionesE> ConsultaValorPrestaciones(PrestacionesE pPrestacionesE)
        {
            try
            {
                return new PrestacionesAD().Sp_ValorPrestaciones_Consultav2(pPrestacionesE); ;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<PrestacionesE> Prestaciones_ConsultaPorNombre(string pNombre)
        {
            try
            {
                PrestacionesE oPrestacionesE = new PrestacionesE();
                oPrestacionesE.Dscprestacion = pNombre.Trim().ToUpper();
                oPrestacionesE.Orden = 17;
                oPrestacionesE.NroFilas = 10;
                oPrestacionesE.Codprestacion = "";
                return new PrestacionesAD().Sp_Prestaciones_Consulta(oPrestacionesE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public PrestacionesE Prestaciones_ConsultaPorCodPrestacion(string pNombre)
        {
            try
            {
                PrestacionesE oPrestacionesE = new PrestacionesE();
                oPrestacionesE.Dscprestacion = pNombre.Trim().ToUpper();
                oPrestacionesE.Orden = 18;
                oPrestacionesE.NroFilas = 10;
                oPrestacionesE.Codprestacion = "";

                List<PrestacionesE> olistaPrestacionesE = new PrestacionesAD().Sp_Prestaciones_Consulta(oPrestacionesE);

                return olistaPrestacionesE.FirstOrDefault();
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<PrestacionesE> Prestaciones_Consulta(PrestacionesE pPrestacionesE)
        {
            try
            {
                return new PrestacionesAD().Sp_Prestaciones_Consulta(pPrestacionesE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


    }
}
