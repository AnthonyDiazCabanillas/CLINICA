using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.HospitalAD
{
    public  class EscalaEIndicacionesAD
    {
        public List<EscalaEIndicacionesE> Escala_e_indicaciones_List(int order, int variable, string val, string val1, string val2, string val3) 
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<EscalaEIndicacionesE> Lista = new List<EscalaEIndicacionesE>();
            try { 
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_EscalaEIndicaciones_Menu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order", order);
                cmd.Parameters.AddWithValue("@variable", variable);
                cmd.Parameters.AddWithValue("@val", val);
                cmd.Parameters.AddWithValue("@val1", val1);
                cmd.Parameters.AddWithValue("@val2", val2);
                cmd.Parameters.AddWithValue("@val3", val3);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EscalaEIndicacionesE _obj = new EscalaEIndicacionesE();
                    _obj.groupcab = int.Parse(dr["groupcab"].ToString());
                    _obj.dsc_detalle = dr["dsc_detalle"].ToString();
                    _obj.itemcab = int.Parse(dr["itemcab"].ToString());
                    _obj.detalleitem = dr["detalleitem"].ToString();
                    _obj.ide_escaladet = int.Parse(dr["ide_escaladet"].ToString());
                    _obj.i_order = int.Parse(dr["i_order"].ToString());
                    _obj.descripcion_det = dr["descripcion_det"].ToString();
                    _obj.descripcion_det2 = dr["descripcion_det2"].ToString();
                    _obj.puntuacion = int.Parse(dr["puntuacion"].ToString());
                    _obj.imagencab = dr["imagencab"].ToString();
                    _obj.imagendet = dr["imagendet"].ToString();
                    Lista.Add(_obj);
                }
                return Lista;
            }
            catch (Exception ex) 
            {
                throw;
            }
            finally {
                dr.Close();
                cmd.Dispose();
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }        
        }

        public List<EscalaEIndicacionesActividadE> EscalaEIndicacionesActividad_List(int order, int variable, string val, string val1, string val2, string val3) 
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<EscalaEIndicacionesActividadE> Lista = new List<EscalaEIndicacionesActividadE>();
            try {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_EscalaEIndicaciones_Menu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order", order);
                cmd.Parameters.AddWithValue("@variable", variable);
                cmd.Parameters.AddWithValue("@val", val);
                cmd.Parameters.AddWithValue("@val1", val1);
                cmd.Parameters.AddWithValue("@val2", val2);
                cmd.Parameters.AddWithValue("@val3", val3);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    EscalaEIndicacionesActividadE obj = new EscalaEIndicacionesActividadE();
                    obj.Item = Convert.ToInt32(dr["Item"].ToString());
                    obj.Codigo = Convert.ToInt32(dr["codigo"].ToString());
                    obj.Actividad = dr["actividad"].ToString();
                    obj.Detalle = dr["detalle"].ToString();
                    obj.Ckeck = false;
                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex) { throw ex; }
            finally 
            {
                dr.Close();
                cmd.Dispose();
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }

        public RespuestaJsonE EscalaEintervenciones_Register(PuntuacionEscalaE obj)
        {
            RespuestaJsonE _respuesta = new RespuestaJsonE();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try 
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_escalaeintervenciones_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                cmd.Parameters.AddWithValue("@Puntaje1", obj.Puntaje1);
                cmd.Parameters.AddWithValue("@Puntaje2", obj.Puntaje2);
                cmd.Parameters.AddWithValue("@Puntaje3", obj.Puntaje3);
                cmd.Parameters.AddWithValue("@Puntaje4", obj.Puntaje4);
                cmd.Parameters.AddWithValue("@Puntaje5", obj.Puntaje5);
                cmd.Parameters.AddWithValue("@Puntaje6", obj.Puntaje6);
                cmd.Parameters.AddWithValue("@Puntaje7", obj.Puntaje7);
                cmd.Parameters.AddWithValue("@Total", obj.Total);
                cmd.Parameters.AddWithValue("@NomUser", obj.NomUser);
                cmd.Parameters.AddWithValue("@CodUser", obj.CodUser);
                cmd.Parameters.AddWithValue("@Perfil", obj.Perfil);
                cmd.Parameters.AddWithValue("@CodMedico", obj.CodMedico);
                cmd.Parameters.AddWithValue("@CodigoAtencion", obj.CodigoAtencion);
                cmd.Parameters.AddWithValue("@IdeHistoria", obj.IdeHistoria);
                cmd.Parameters.AddWithValue("@CodPaciente", obj.CodPaciente);
                cmd.Parameters.AddWithValue("@valor", obj.Valor);
                cmd.Parameters.Add("@status", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                con.Open();
                dr = cmd.ExecuteReader();
                int _status = int.Parse(cmd.Parameters["@status"].Value.ToString());
                if (_status == 1)
                {
                    _respuesta.exito = true;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
                else
                {
                    _respuesta.exito = false;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                _respuesta.exito = false;
                _respuesta.message = ex.Message;
            }
            finally { con.Close(); }
            return _respuesta;
        }

        public List<EscalaeIndicacionesHistoricoE> EscalaEIndicacionesHistorico_List(int order, int variable, string val, string val1, string val2, string val3)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<EscalaeIndicacionesHistoricoE> Lista = new List<EscalaeIndicacionesHistoricoE>();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_EscalaEIndicaciones_Menu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order", order);
                cmd.Parameters.AddWithValue("@variable", variable);
                cmd.Parameters.AddWithValue("@val", val);
                cmd.Parameters.AddWithValue("@val1", val1);
                cmd.Parameters.AddWithValue("@val2", val2);
                cmd.Parameters.AddWithValue("@val3", val3);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EscalaeIndicacionesHistoricoE obj = new EscalaeIndicacionesHistoricoE();
                    obj.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    obj.Ide_Escala = Convert.ToInt32(dr["Ide_Escala"].ToString());
                    obj.Escala = dr["Escala"].ToString();
                    obj.Hora = dr["Hora"].ToString();
                    obj.Puntaje = Convert.ToInt32(dr["Puntaje"].ToString());
                    obj.Encargado = dr["Encargado"].ToString();
                    obj.ide_escalaeintervenciondet = Convert.ToInt32(dr["ide_escalaeintervenciondet"].ToString());
                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
            finally
            {
                dr.Close();
                cmd.Dispose();
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }

        public List<EscalaEIndicacionesHistoriaDetalladoE> EscalaEIndicacionesHistoricoDetallado_List(int order, int variable, string val, string val1, string val2, string val3)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<EscalaEIndicacionesHistoriaDetalladoE> Lista = new List<EscalaEIndicacionesHistoriaDetalladoE>();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("sp_EscalaEIndicaciones_Menu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order", order);
                cmd.Parameters.AddWithValue("@variable", variable);
                cmd.Parameters.AddWithValue("@val", val);
                cmd.Parameters.AddWithValue("@val1", val1);
                cmd.Parameters.AddWithValue("@val2", val2);
                cmd.Parameters.AddWithValue("@val3", val3);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EscalaEIndicacionesHistoriaDetalladoE obj = new EscalaEIndicacionesHistoriaDetalladoE();
                    obj.Concepto = dr["Concepto"].ToString();
                    obj.Descripcion = dr["Descripcion"].ToString();
                    obj.Observacion = dr["Observacion"].ToString();
                    obj.Puntaje = int.Parse(dr["Puntaje"].ToString());
                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                cmd.Dispose();
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }


    }
}
