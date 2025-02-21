#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : EnviaCorreoHisAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase EnviaCorreoHisAD 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.MedisynE;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class EnviaCorreoHisAD
    {
        public bool Sp_HIS_EnvioCorreo(EnviaCorreoHisE pEnviaCorreoHisE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HIS_EnvioCorreo", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@Orden",       pEnviaCorreoHisE.Orden);
                        cmd.Parameters.AddWithValue("@IdUsuario",   pEnviaCorreoHisE.IdUsuario);
                        cmd.Parameters.AddWithValue("@Usuario",     pEnviaCorreoHisE.Usuario);
                        cmd.Parameters.AddWithValue("@Correo",      pEnviaCorreoHisE.Correo);
                        cmd.Parameters.AddWithValue("@Descripcion", pEnviaCorreoHisE.Descripcion);
                        cmd.Parameters.AddWithValue("@RutaArchivo", pEnviaCorreoHisE.RutaArchivo);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@mailitem_id", ParameterDirection.InputOutput, SqlDbType.Int, 8, pEnviaCorreoHisE.mailitem_id.ToString()));
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        pEnviaCorreoHisE.mailitem_id= (int)cmd.Parameters["@mailitem_id"].Value;
                        if (pEnviaCorreoHisE.mailitem_id != 0)
                        { return true; }
                        else
                        { return false; }
                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {return false;}
        }

    }
}
