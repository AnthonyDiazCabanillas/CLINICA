using Ent.Sql.ClinicaE.HospitalE;
using System.Data;
using System.Data.SqlClient;

namespace Dat.Sql.ClinicaAD.HospitalAD
{
    public class PrestacionesAD
    {
        private PrestacionesE LlenarEntidad(IDataReader dr, PrestacionesE pPrestacionesE)
        {
            PrestacionesE oPrestacionesE = new PrestacionesE();
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

                case 3:
                    oPrestacionesE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oPrestacionesE.Nomprestacion = Convert.ToString(dr["nomprestacion"]);
                    oPrestacionesE.Valprestacion = Convert.ToDouble(dr["valor"]);
                    oPrestacionesE.Codtarifa = Convert.ToString(dr["codtarifa"]);
                    break;
                case 17:
                case 18:
                    oPrestacionesE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oPrestacionesE.Nomprestacion = Convert.ToString(dr["nombre"]);
                    break;
            }
            return oPrestacionesE;
        }

        public List<PrestacionesE> Sp_ValorPrestaciones_Consultav2(PrestacionesE pPrestacionesE)
        {
            List<PrestacionesE> oListar = new List<PrestacionesE>();
            PrestacionesE oPrestacionesE = new PrestacionesE();
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
                        oPrestacionesE = LlenarEntidad(dr, pPrestacionesE);
                        oListar.Add(oPrestacionesE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        #region Sp_Hospital_Consulta
        public List<PrestacionesE> Sp_Prestaciones_Consulta(PrestacionesE pPrestacionesE)
        {
            IDataReader dr;
            var oListar = new List<PrestacionesE>();
            try
            {
                using (var cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (var cmd = new SqlCommand("Sp_Prestaciones_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@filtro", pPrestacionesE.Filtro);
                        cmd.Parameters.AddWithValue("@buscar", pPrestacionesE.Dscprestacion);
                        cmd.Parameters.AddWithValue("@key", pPrestacionesE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pPrestacionesE.NroFilas);
                        cmd.Parameters.AddWithValue("@orden", pPrestacionesE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            PrestacionesE oHospitalE = LlenarEntidad(dr, pPrestacionesE);
                            oListar.Add(oHospitalE);
                        }

                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
