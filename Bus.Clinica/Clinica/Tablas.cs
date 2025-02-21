/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version Fecha         Autor      Requerimiento
 1.1      25/11/2024  FPINEDO    REQ 2024-026000: Alquiler de consultorios-Alerta de servicio detenido.
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.OtrosE;
using Dat.Sql.ClinicaAD.OtrosAD;

namespace Bus.Clinica.Clinica
{
    public class Tablas
    {
        public List<TablasE> ListaTipoCliente(TablasE oTablasE)
        {
            try
            { return new TablasAD().Sp_Tablas_ConsultaV2(oTablasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<TablasE> ListaConsulta(TablasE oTablasE)
        {
            try
            { return new TablasAD().Sp_Tablas_Consulta(oTablasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public List<TablasE> Sp_Tablas_Consulta(TablasE pTablasE)
        {
            try
            {
                return new TablasAD().Sp_Tablas_Consulta(pTablasE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }
        //1.1 INI
        public void Sp_Tablas_Update(TablasE pTablasE)
        {
            try
            {
                new TablasAD().Sp_Tablas_Update(pTablasE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }
        //1.1 FIN

    }
}
