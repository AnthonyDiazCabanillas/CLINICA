using Ent.Sql.ClinicaE.MedicosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.HospitalAD
{
    public class HorariosD
    {
        public List<HorariosE> Lista_Horario_Medico(string cmp) 
        {
            List<HorariosE> lista_Horario = null;
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try { 
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Cita_San_Felipe_HorarioMEdico_detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CMP", cmp);
                con.Open();
                dr = cmd.ExecuteReader();
                lista_Horario = new List<HorariosE>();
                while (dr.Read()) 
                {
                    HorariosE obj = new HorariosE();
                    obj.IdSede = Convert.ToInt32(dr["IdSede"].ToString());
                    obj.Sede = dr["Sede"].ToString();
                    obj.FechaInicio = Convert.ToDateTime(dr["FechaInicio"].ToString());
                    obj.FechaFin = Convert.ToDateTime(dr["FechaFin"].ToString());
                    obj.IdDia = Convert.ToInt32(dr["IdDia"].ToString());
                    obj.NombreDia = dr["NombreDia"].ToString();
                    obj.HoraInicio = dr["HoraInicio"].ToString();
                    obj.HoraFin = dr["HoraFin"].ToString();
                    obj.Especialidad = dr["Especialidad"].ToString();
                    obj.Consultorio = dr["Consultorio"].ToString();
                    lista_Horario.Add(obj);
                }
            }
            catch(Exception ex) 
            {
                lista_Horario = new List<HorariosE>();
            }
            finally 
            {
                con.Close();
                dr.Close();

            }
            return lista_Horario;

        }
    }
}
