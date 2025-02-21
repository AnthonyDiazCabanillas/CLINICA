using Ent.Sql.SeguridadE.SeguridadE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.UsuariosE;

namespace Dat.Sql.SeguridadAD.SeguridadAD
{
    public class UsuarioCitaAD
    {
        private UsuarioCitaE LlenarEntidad(IDataReader dr,
                                       UsuarioCitaE pUsuarioE)
        {
            UsuarioCitaE oUsuarioE = new UsuarioCitaE();
            switch (pUsuarioE.Orden)
            {
                case 1:
                case 2:
                    pUsuarioE.IdUsuario = Convert.ToString(dr["ide_usuario"]);
                    pUsuarioE.CodigoUsuario = Convert.ToString(dr["codigo_usuario"]);
                    pUsuarioE.Password = Convert.ToString(dr["password"]);
                    pUsuarioE.Rol = Convert.ToString(dr["rol"]);
                    break;
            }
            return pUsuarioE;
        }

        public UsuarioCitaE Sp_UsuarioCita_Consulta(UsuarioCitaE pUsuarioE)
        {
            List<UsuarioCitaE> oListar = new List<UsuarioCitaE>();
            UsuarioCitaE oUsuarioE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_UsuarioCita_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_usuario", pUsuarioE.IdUsuario);
                    cmd.Parameters.AddWithValue("@codigo_usuario", pUsuarioE.CodigoUsuario);
                    cmd.Parameters.AddWithValue("@password", pUsuarioE.Password);
                    cmd.Parameters.AddWithValue("@rol", pUsuarioE.Rol);
                    cmd.Parameters.AddWithValue("@orden", pUsuarioE.Orden);

                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        oUsuarioE = LlenarEntidad(dr, pUsuarioE);
                        //oListar.Add(oUsuarioE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oUsuarioE;
        }

        public string Sp_CitaPSF_RutaRetorna(RutaRetornaCitaE optData)
            //int pIdeRutaPsf, string pUsuario, string pClave , string pParXML, int pOrden) 
        {
            string resultado = "";
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_CitaPSF_RutaRetorna", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_ruta_psf", optData.IdRutaRetorna);
                    cmd.Parameters.AddWithValue("@usuario", optData.Usuario);
                    cmd.Parameters.AddWithValue("@clave", optData.Password);
                    cmd.Parameters.AddWithValue("@parXML", optData.OpcionXML);
                    cmd.Parameters.AddWithValue("@orden", optData.Orden);

                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        resultado = Convert.ToString(dr["Resultado"]);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return resultado;
        }

        public string Sp_CitaPSF_RutaEjecuta(string pDato)
        {
            string resultado = "";
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_CitaPSF_RutaEjecuta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@dato_origen", pDato);

                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        resultado = Convert.ToString(dr["Resultado"]);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return resultado;
        }



    }
}
