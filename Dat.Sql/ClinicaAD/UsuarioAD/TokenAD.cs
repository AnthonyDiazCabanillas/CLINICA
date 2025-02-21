using Ent.Sql.ClinicaE.UsuariosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.UsuarioAD
{
    public class TokenAD
    {
        public UsuarioE GetUserByToken(TokenRequestE Token)
        {
            IDataReader dr;
            UsuarioE? Entity = null;

            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetUserByToken", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parametros del Store
                    cmd.Parameters.AddWithValue("@TokenCode", Token.TokenCode);
                    cmd.Parameters.AddWithValue("@TokenType", Token.TokenType);

                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Entity = new UsuarioE();
                        //Entity.UserCode = Convert.ToString(dr["UsuarioCodeGuid"]);
                        Entity.UserCode = Convert.ToString(dr["TokenCodeGuid"]);
                        Entity.Login = (string)dr["dsc_login"];
                        Entity.Fullname = (string)dr["dsc_nombres"];
                        //Entity.DocumentType = Convert.ToInt32(dr["TipoDocumento"]);
                        //Entity.DocumentNumber = (string)dr["DocumentoIdentidad"];
                        Entity.Email = (string)dr["dsc_email"];
                        Entity.ProfileId = (int)dr["cod_perfil"];
                        Entity.Status = Convert.ToString(dr["std_usuario"]);
                        Entity.IdUsuario = (decimal)dr["ide_usuario"];
                        break;
                    }
                    dr.Close(); // Se cierre la conexión.
                    dr.Dispose(); // Se liberan todos los recursos del data reader.
                    cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                    cnn.Close(); // Se cierre la conexión.
                    cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                    return Entity;
                }
            }
        }


        public List<ListaPortalTablasE> GetPortalTablas()
        {
            IDataReader dr;
            List<ListaPortalTablasE> List = new List<ListaPortalTablasE>();

            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Get_PotalTablas", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var Entity = new ListaPortalTablasE();

                        if (dr["Id"] != DBNull.Value) { Entity.Id = (int)dr["Id"]; }
                        if (dr["cod_tabla"] != DBNull.Value) { Entity.cod_tabla = (string)dr["cod_tabla"]; }
                        if (dr["nro_linea"] != DBNull.Value) { Entity.nro_linea = (string)dr["nro_linea"]; }
                        if (dr["dsc_nombre"] != DBNull.Value) { Entity.dsc_nombre = (string)dr["dsc_nombre"]; }
                        if (dr["dsc_nombre2"] != DBNull.Value) { Entity.dsc_nombre2 = (string)dr["dsc_nombre2"]; }
                        if (dr["flg_estado"] != DBNull.Value) { Entity.flg_estado = (string)dr["flg_estado"]; }

                        List.Add(Entity);
                    }
                }
            }
            return List;
        }
    }
}
