using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class CfgUpdatePorCampoAD
    {
        public CfgUpdatePorCampoE LlenarEntidad(IDataReader dr)
        {
            CfgUpdatePorCampoE ms = new CfgUpdatePorCampoE();
            ms.tabla = dr["tabla"].ToString();
            ms.CampoEntidad = dr["CampoEntidad"].ToString();
            ms.CampoTabla = dr["CampoTabla"].ToString();
            ms.CampoConsulta = dr["CampoConsulta"].ToString();
            ms.CampoUpdate = dr["CampoUpdate"].ToString();
            ms.ValorUpdate = dr["ValorUpdate"].ToString();
            return ms;
        }

        public List<CfgUpdatePorCampoE> Sp_CfgUpdatePorCampo_Consulta(string pTabla)
        {
            IDataReader dr;
            CfgUpdatePorCampoE oCfgUpdatePorCampoE = null/* TODO Change to default(_) if this is not a reference type */;
            List<CfgUpdatePorCampoE> oListar = new List<CfgUpdatePorCampoE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_cfgUpdatePorCampo_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@tabla", pTabla);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oCfgUpdatePorCampoE = LlenarEntidad(dr);
                            oListar.Add(oCfgUpdatePorCampoE);
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


        private bool Compare<T>(T Object1, T object2)
        {
            //Get the type of the object
            Type type = typeof(T);

            //return false if any of the object is false
            if (object.Equals(Object1, default(T)) || object.Equals(object2, default(T)))
                return false;

            //Loop through each properties inside class and get values for the property from both the objects and compare
            foreach (System.Reflection.PropertyInfo property in type.GetProperties())
            {
                if (property.Name != "ExtensionData")
                {
                    string Object1Value = string.Empty;
                    string Object2Value = string.Empty;
                    if (type.GetProperty(property.Name).GetValue(Object1, null) != null)
                        Object1Value = type.GetProperty(property.Name).GetValue(Object1, null).ToString();
                    if (type.GetProperty(property.Name).GetValue(object2, null) != null)
                        Object2Value = type.GetProperty(property.Name).GetValue(object2, null).ToString();
                    if (Object1Value.Trim() != Object2Value.Trim())
                    {
                        return false;
                    }
                }
            }
            return true;
        }



    }
}
