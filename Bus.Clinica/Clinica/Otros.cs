using Dat.Sql.ClinicaAD.OtrosAD;
using Ent.Sql.ClinicaE.HospitalE;
using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica
{
    public class Otros
    {
        public List<TablasE> ConsultarTablas(TablasE objTablasE)
        {
            List<TablasE> oList = new List<TablasE>();
            oList = new TablasAD().Sp_Tablas_Consulta(objTablasE);
            return oList;
        }
        public bool Sp_Tablas_Update(TablasE pTablasE)
        {
            try
            { return new TablasAD().Sp_Tablas_Update(pTablasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<SemaforoE> ListaSemanforoEmergencias(SemaforoE oSemaforoE)
        {
            try
            {
                return new SemaforoAD().Sp_HospitalSemaforoEmergencias_Consulta(oSemaforoE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<CfgUpdatePorCampoE> CfgUpdatePorCampo_Consulta(string pTabla)
        {
            List<CfgUpdatePorCampoE> oList = new List<CfgUpdatePorCampoE>();
            oList = new CfgUpdatePorCampoAD().Sp_CfgUpdatePorCampo_Consulta(pTabla);
            return oList;
        }

        public List<UbigeoE> Ubigeo_ConsultaPeru(string pTextoaBuscar)
        {
            List<UbigeoE> oList = new List<UbigeoE>();
            UbigeoE oUbigeoE = new UbigeoE();
            oUbigeoE.CodPais = "";
            oUbigeoE.Nombre = pTextoaBuscar;
            oUbigeoE.Orden = 1;
            oUbigeoE.NroFilas = 25;
            //oUbigeoE.Codprestacion = "";
            oList = new UbigeoAD().Sp_Ubigeo_ConsultaPeru(oUbigeoE);
            return oList;
        }

        public List<UbigeoE> Ubigeo_Consulta(UbigeoE pUbigeoE)
        {
            List<UbigeoE> oList = new List<UbigeoE>();
            oList = new UbigeoAD().Sp_Ubigeo_Consulta(pUbigeoE);
            return oList;
        }

        public List<ClinicaTorreE> ConsultarClinicaTorrePiso(ClinicaTorreE pClinicaTorreE)
        {
            try
            { return new ClinicaTorreAD().Sp_ClinicaTorreE_Consulta(pClinicaTorreE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

    }
}