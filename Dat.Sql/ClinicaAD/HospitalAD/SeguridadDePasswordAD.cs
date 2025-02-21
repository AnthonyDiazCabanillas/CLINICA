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

using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql.ClinicaE.SeguridadE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.HospitalAD
{
    public class SeguridadDePasswordAD
    {
        public PasswordE Sp_EncriptarSegPass(PasswordE pPasswordE)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            PasswordE obj = new PasswordE();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_EncriptarSegPass", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", pPasswordE.Orden);
                cmd.Parameters.AddWithValue("@clave", pPasswordE.Clave);

                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj.WqCadenaEncriptada = dr["wqCadenaEncriptada"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public PasswordE Sp_DesEncriptarSegPass(PasswordE pPasswordE)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            PasswordE obj = new PasswordE();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_DesEncriptarSegPass", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", pPasswordE.Orden);
                cmd.Parameters.AddWithValue("@clave", pPasswordE.Clave);

                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj.WqCadenaDesEncriptada = dr["wqCadenaDesEncriptada"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public DataTable Sp_ParamSeguridad_Sel()
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_ParamSeguridad_Sel", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

    }
}
