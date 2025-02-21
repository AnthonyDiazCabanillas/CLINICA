using Ent.Sql.ClinicaE;
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
    public class SeguridadAD
    {
        public SeguridadE GetLogin(LoginE Login)
        {
            IDataReader dr;
            var Entity = new SeguridadE();

            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Login_Validar", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parametros del Store
                    cmd.Parameters.AddWithValue("@Login", Login.Login);
                    cmd.Parameters.AddWithValue("@Password", Login.Password);

                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Entity.IdPerfil = Convert.ToInt32(dr["cod_perfil"]);
                        //Entity.UsuarioCodeGuid = Convert.ToString(dr["UsuarioCodeGuid"]);
                        //Entity.UsuarioCodeGuid = Convert.ToString(dr["sesion_web"]);
                        Entity.Login = Convert.ToString(dr["dsc_login"]);
                        Entity.Password = Convert.ToString(dr["dsc_clave"]);
                        Entity.NombreCompleto = Convert.ToString(dr["dsc_nombres"]);
                        // Entity.TipoDocumento = Convert.ToInt32(dr["TipoDocumento"]);
                        //Entity.DocumentoIdentidad = Convert.ToString(dr["DocumentoIdentidad"]);
                        Entity.Email = Convert.ToString(dr["dsc_email"]);
                        //Entity.Estado = Convert.ToBoolean(dr["std_usuario"]);
                        Entity.Estado = Convert.ToString(dr["std_usuario"]);
                        //Entity.Locked = (bool)dr["Locked"];
                        Entity.ide_usuario = Convert.ToInt32(dr["ide_usuario"]);
                        Entity.CodSexo = Convert.ToString(dr["cod_sexo"]);
                        Entity.UrlFoto = Convert.ToString(dr["url_foto"]);
                        Entity.CodUser = Convert.ToInt32(dr["cod_user"]);
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
        //Aqui hace la consulta para poder traer el nombre de la base de datos
        public BaseDatosE GetBaseDatos(BaseDatosE oBaseDatos)
        {
            IDataReader dr;
            var Entity = new BaseDatosE();

            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Traer_BaseDatos", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        //Tener cuidado cuando se usa el simbolo "\\" se uso
                        // un replace para manejarlo en la base de datos
                        cmd.Parameters.AddWithValue("@NombreIp", oBaseDatos.Nombre);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Entity.Descripcion = Convert.ToString(dr["nombreBD"]);
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
            catch (Exception)
            {
                return Entity;
            }
        }

        public TokenResponseE GetNewToken(int ide_usuario, int Tokentype, string ide_modulo, string dsc_version)
        {
            IDataReader dr;
            var Entity = new TokenResponseE();

            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_GetNewToken", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_usuario", ide_usuario);
                    cmd.Parameters.AddWithValue("@ide_modulo", ide_modulo);
                    cmd.Parameters.AddWithValue("@dsc_version", dsc_version);
                    cmd.Parameters.AddWithValue("@TokenType", Tokentype);

                    cnn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Entity.TokenCode = Convert.ToString(dr["TokenCode"]);
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


        public RespuestaJsonE GetActulizacionPerilPersonal(SeguridadE _obj) 
        {
            RespuestaJsonE _respuesta = new RespuestaJsonE();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try 
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_Usuario_Perfil_Menu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order", 1);
                cmd.Parameters.AddWithValue("@login", _obj.Login) ;
                cmd.Parameters.AddWithValue("@imagen", _obj.Img_Perfil) ;
                con.Open();
                dr = cmd.ExecuteReader();
                _respuesta.exito = true;
                _respuesta.message = "Se ha Actualizado la foto de perfil!..";
            }
            catch(Exception ex) {
                _respuesta.exito = false;
                _respuesta.message = "Hubo un error al momento de guardar el registro: \n" + ex.Message + "\n\n Intente en otro momento";
            }
            finally {
                con.Close();
                con.Dispose();
                dr.Close(); // Se cierre la conexión.
                dr.Dispose(); // Se liberan todos los recursos del data reader.
                cmd.Dispose();
            }
            return _respuesta;
        }

        public DataTable MostrarFotoPerfil(SeguridadE _obj)
        {
            DataTable _respuesta = new DataTable();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_Usuario_Perfil_Menu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order", 2);
                cmd.Parameters.AddWithValue("@login", _obj.Login);
                cmd.Parameters.AddWithValue("@imagen", null);
                con.Open();
                dr = cmd.ExecuteReader();
                _respuesta.Load(dr);
            }
            catch (Exception ex)
            {
                _respuesta = new DataTable();
                return _respuesta;
            }
            finally
            {
                con.Close();
                con.Dispose();
                dr.Close(); // Se cierre la conexión.
                dr.Dispose(); // Se liberan todos los recursos del data reader.
                cmd.Dispose();
            }
            return _respuesta;
        }
    }
}
