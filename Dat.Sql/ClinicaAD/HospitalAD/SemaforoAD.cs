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
    public class SemaforoAD
    {
        private SemaforoE LlenarEntidad(IDataReader dr, SemaforoE pSemaforoE)
        {
            SemaforoE oSemaforoE = new SemaforoE();
            switch (pSemaforoE.Orden)
            {
                case 1:
                    oSemaforoE.Cama = Convert.ToString(dr["cama"]);
                    oSemaforoE.CodAtencion = Convert.ToString(dr["codatencion"]);
                    oSemaforoE.FechaAltamedica = Convert.ToString(dr["fechaaltamedica"]);
                    //oSemaforoE.FecAltaadministrativa = Convert.ToString(dr["fec_altaadministrativa"]);
                    oSemaforoE.PacEstado = Convert.ToString(dr["pac_estado"]);
                    oSemaforoE.DscEstado = Convert.ToString(dr["dsc_estado"]);
                    oSemaforoE.TiempoDias = Convert.ToString(dr["tiempo_dias"]);
                    oSemaforoE.FecFallecido = Convert.ToString(dr["fec_fallecido"]);
                    oSemaforoE.Prioridad = Convert.ToString(dr["prioridad"]);
                    oSemaforoE.CodNombreDestino = Convert.ToString(dr["cod_nombre_destino"]);
                    oSemaforoE.NombreDestino = Convert.ToString(dr["nombredestino"]);
                    oSemaforoE.HospEstado = Convert.ToString(dr["hosp_estado"]);
                    oSemaforoE.Semaforo = Convert.ToString(dr["semaforo"]);
                    break;
                case 2:
                    oSemaforoE.Semaforo = Convert.ToString(dr["semaforo"]);
                    oSemaforoE.Cantidad = Convert.ToInt32(dr["cantidad"]);
                    break;
            }
            return oSemaforoE;
        }

        public List<SemaforoE> Sp_HospitalSemaforoEmergencias_Consulta(SemaforoE pSemaforoE)
        {
            List<SemaforoE> oListar = new List<SemaforoE>();
            SemaforoE oSemaforoE = new SemaforoE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HospitalSemaforoEmergencias_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store

                    cmd.Parameters.AddWithValue("@pabellon", pSemaforoE.Pabellon);
                    cmd.Parameters.AddWithValue("@servicio", pSemaforoE.Servicio);
                    cmd.Parameters.AddWithValue("@sede", pSemaforoE.Sede);
                    cmd.Parameters.AddWithValue("@buscar", pSemaforoE.Buscar);
                    cmd.Parameters.AddWithValue("@orden", pSemaforoE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oSemaforoE = LlenarEntidad(dr, pSemaforoE);
                        oListar.Add(oSemaforoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
