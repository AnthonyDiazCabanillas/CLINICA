#region Información General de la Clase
/// <remarks>
///**************************************************************************************************************************
/// Objetivo General: Validar password, encriptar y desencriptar password
/// ----------------------------------------------------------------------
/// ----------------------------------------------------------------------
/// VERSIÓN    FECHA			AUTOR       REQUERIMIENTO		DESCRIPCIÓN
/// 1.0		   26/08/2024		MBARDALES	REQ 2024-010476		Creación de la clase
///
///*****************************************************************************************************************************/
/// </remarks>
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ent.Sql.ClinicaE.HospitalE;
using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.SeguridadE;
using System.Data;



namespace Bus.Clinica
{
    public class SeguridadDePassword
    {
        SeguridadDePasswordAD objSeguridadDePasswordAD = new SeguridadDePasswordAD();

        public PasswordE Sp_EncriptarSegPass(PasswordE pPasswordE)
        {
            try { return objSeguridadDePasswordAD.Sp_EncriptarSegPass(pPasswordE); }
            catch (Exception ex) { throw ex; }
        }

        public PasswordE Sp_DesEncriptarSegPass(PasswordE pPasswordE)
        {
            try { return objSeguridadDePasswordAD.Sp_DesEncriptarSegPass(pPasswordE); }
            catch (Exception ex) { throw ex; }
        }
        public DataTable Sp_ParamSeguridad_Sel()
        {
            try { return objSeguridadDePasswordAD.Sp_ParamSeguridad_Sel(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
