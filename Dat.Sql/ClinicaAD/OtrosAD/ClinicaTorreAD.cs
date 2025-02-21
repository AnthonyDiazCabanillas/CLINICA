using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class ClinicaTorreAD
    {
        private ClinicaTorreE LlenarEntidad(IDataReader dr, ClinicaTorreE pClinicaTorreE)
        {
            ClinicaTorreE oClinicaTorreE = new ClinicaTorreE();
            switch (pClinicaTorreE.Orden)
            {
                case 1:
                    {
                        oClinicaTorreE.IDClinica = Convert.ToInt32(dr["IdClinica"] + "");
                        oClinicaTorreE.Clinica = Convert.ToString(dr["Nombre"] + "");
                        oClinicaTorreE.IDUbicacion = Convert.ToInt32(dr["IdUbicacion"] + "");
                        oClinicaTorreE.DscUbicacion = Convert.ToString(dr["Descripcion"] + "");
                        oClinicaTorreE.Piso = Convert.ToInt32(dr["NumPiso"] + "");
                        break;
                    }
            }
            return oClinicaTorreE;
        }

        public List<ClinicaTorreE> Sp_ClinicaTorreE_Consulta(ClinicaTorreE pClinicaTorreE)
        {
            IDataReader dr;
            ClinicaTorreE oClinicaTorreE = null;
            List<ClinicaTorreE> oListar = new List<ClinicaTorreE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hisclinicatorre_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@clinica", pClinicaTorreE.Clinica);
                        cmd.Parameters.AddWithValue("@ubicacion", pClinicaTorreE.DscUbicacion);
                        cmd.Parameters.AddWithValue("@piso", pClinicaTorreE.Piso);
                        cmd.Parameters.AddWithValue("@busca", pClinicaTorreE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pClinicaTorreE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oClinicaTorreE = LlenarEntidad(dr, pClinicaTorreE);
                            oListar.Add(oClinicaTorreE);
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
    }
}
