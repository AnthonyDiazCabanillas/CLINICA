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
    public class ValorPrestacionesAD
    {
        private ValorPrestacionesE LlenarEntidad(IDataReader dr, ValorPrestacionesE pPrestacionesE)
        {
            ValorPrestacionesE oPrestacionesE = new ValorPrestacionesE();
            switch (pPrestacionesE.Orden)
            {
                case 1:
                    oPrestacionesE.Codatencion = Convert.ToString(dr["codatencion"]);
                    oPrestacionesE.Nompaciente = Convert.ToString(dr["nompaciente"]);
                    oPrestacionesE.Monto = Convert.ToDouble(dr["monto"]);
                    oPrestacionesE.Codtarifa = Convert.ToString(dr["codtarifa"]);
                    oPrestacionesE.Nomtarifa = Convert.ToString(dr["nomtarifa"]);
                    oPrestacionesE.Nomcobertura = Convert.ToString(dr["nomcobertura"]);
                    oPrestacionesE.Codaseguradora = Convert.ToInt32(dr["codaseguradora"]);
                    oPrestacionesE.Nomaseguradora = Convert.ToString(dr["nombreaseguradora"]);
                    
                    break;

                case 2:
                    oPrestacionesE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oPrestacionesE.Nomprestacion = Convert.ToString(dr["nomprestacion"]);
                    oPrestacionesE.Valprestacion = Convert.ToDouble(dr["valor"]);
                    oPrestacionesE.Codtarifa = Convert.ToString(dr["codtarifa"]);
                    break;
            }
            return oPrestacionesE;
        }
        
        public List<ValorPrestacionesE> Sp_ValorPrestaciones_Consultav2(ValorPrestacionesE pPrestacionesE)
        {
            List<ValorPrestacionesE> oListar = new List<ValorPrestacionesE>();
            ValorPrestacionesE oConveniosE = new ValorPrestacionesE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ValorPrestaciones_Consultav2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pPrestacionesE.Orden);
                    cmd.Parameters.AddWithValue("@cod_atencion", pPrestacionesE.Codatencion);
                    cmd.Parameters.AddWithValue("@cod_prestacion", pPrestacionesE.Codprestacion);
                    cmd.Parameters.AddWithValue("@cod_tarifa", pPrestacionesE.Codtarifa);
                    cmd.Parameters.AddWithValue("@dsc_prestacion", pPrestacionesE.Dscprestacion);
                    cmd.Parameters.AddWithValue("@nro_filas", pPrestacionesE.NroFilas);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oConveniosE = LlenarEntidad(dr, pPrestacionesE);
                        oListar.Add(oConveniosE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public List<ValorPrestacionesE> Sp_Prestaciones_Consulta(ValorPrestacionesE pPrestacionesE)
        {
            List<ValorPrestacionesE> oListar = new List<ValorPrestacionesE>();
            ValorPrestacionesE oConveniosE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Prestaciones_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pPrestacionesE.Orden);
                    cmd.Parameters.AddWithValue("@cod_atencion", pPrestacionesE.Codatencion);
                    cmd.Parameters.AddWithValue("@cod_prestacion", pPrestacionesE.Codprestacion);
                    cmd.Parameters.AddWithValue("@cod_tarifa", pPrestacionesE.Codtarifa);
                    cmd.Parameters.AddWithValue("@dsc_prestacion", pPrestacionesE.Dscprestacion);
                    cmd.Parameters.AddWithValue("@nro_filas", pPrestacionesE.NroFilas);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oConveniosE = LlenarEntidad(dr, pPrestacionesE);
                        oListar.Add(oConveniosE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
