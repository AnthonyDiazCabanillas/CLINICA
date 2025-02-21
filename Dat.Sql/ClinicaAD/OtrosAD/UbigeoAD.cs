using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
    public class UbigeoAD
    {

        private UbigeoE LlenarEntidad(IDataReader dr,
                                       UbigeoE pUbigeoE)
        {
            UbigeoE oUbigeoE = new UbigeoE();
            switch (pUbigeoE.Orden)
            {
                case -1:
                    oUbigeoE.CodUbigeo = Convert.ToString(dr["codubigeo"]);
                    oUbigeoE.CodPais = Convert.ToString(dr["codpais"]);
                    oUbigeoE.CodDpto = Convert.ToString(dr["coddpto"]);
                    oUbigeoE.CodProv = Convert.ToString(dr["codprov"]);
                    oUbigeoE.CodDist = Convert.ToString(dr["coddist"]);
                    oUbigeoE.Nombre = Convert.ToString(dr["nombre"]);

                    oUbigeoE.NombrePais = Convert.ToString(dr["NombrePais"]);
                    oUbigeoE.NombreDpto = Convert.ToString(dr["NombreDpto"]);
                    oUbigeoE.NombreProv = Convert.ToString(dr["NombreProv"]);
                    oUbigeoE.NombreDist = Convert.ToString(dr["NombreDist"]);
                    oUbigeoE.CodPaisSup = Convert.ToString(dr["CodPaisSup"]);
                    oUbigeoE.CodDptoSup = Convert.ToString(dr["CodDptoSup"]);
                    oUbigeoE.CodProvSup = Convert.ToString(dr["CodProvSup"]);
                    oUbigeoE.CodDistSup = Convert.ToString(dr["CodDistSup"]);
                    break;
                case 1:
                    oUbigeoE.CodUbigeo = Convert.ToString(dr["codubigeo"]);
                    oUbigeoE.CodPais = Convert.ToString(dr["codpais"]);
                    oUbigeoE.CodDpto = Convert.ToString(dr["coddpto"]);
                    oUbigeoE.CodProv = Convert.ToString(dr["codprov"]);
                    oUbigeoE.CodDist = Convert.ToString(dr["coddist"]);
                    oUbigeoE.CodUbigeoPeru = Convert.ToString(dr["codubigeoPeru"]);

                    oUbigeoE.NombrePais = Convert.ToString(dr["NombrePais"]);
                    oUbigeoE.NombreDpto = Convert.ToString(dr["NombreDpto"]);
                    oUbigeoE.NombreProv = Convert.ToString(dr["NombreProv"]);
                    oUbigeoE.NombreDist = Convert.ToString(dr["NombreDist"]);

                    break;
            }

            return oUbigeoE;
        }

        public List<UbigeoE> Sp_Ubigeo_Consulta(UbigeoE pUbigeoE)
        {
            List<UbigeoE> oListar = new List<UbigeoE>();
            UbigeoE oUbigeoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Ubigeo_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pUbigeoE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oUbigeoE = LlenarEntidad(dr, pUbigeoE);
                        oListar.Add(oUbigeoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public List<UbigeoE> Sp_Ubigeo_ConsultaPeru(UbigeoE pUbigeoE)
        {
            try
            {
                List<UbigeoE> oListar = new List<UbigeoE>();
                UbigeoE oUbigeoE = null;
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ubigeo_ConsultaPeru", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@filtro", pUbigeoE.CodPais);
                        cmd.Parameters.AddWithValue("@buscar", pUbigeoE.Nombre);
                        cmd.Parameters.AddWithValue("@key", pUbigeoE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pUbigeoE.NroFilas);
                        cmd.Parameters.AddWithValue("@orden", pUbigeoE.Orden);

                        cnn.Open();
                        IDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oUbigeoE = LlenarEntidad(dr, pUbigeoE);
                            oListar.Add(oUbigeoE);
                        }
                        dr.Close();
                        cnn.Close();
                    }
                }
                return oListar;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }



        public bool Sp_Ubigeo_Insert(UbigeoE pUbigeoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ubigeo_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codubigeo", pUbigeoE.CodUbigeo);
                        cmd.Parameters.AddWithValue("@codpais", pUbigeoE.CodPais);
                        cmd.Parameters.AddWithValue("@coddpto", pUbigeoE.CodDpto);
                        cmd.Parameters.AddWithValue("@codprov", pUbigeoE.CodProv);
                        cmd.Parameters.AddWithValue("@coddist", pUbigeoE.CodDist);
                        cmd.Parameters.AddWithValue("@nombre", pUbigeoE.Nombre);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_Ubigeo_Update(UbigeoE pUbigeoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ubigeo_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codubigeo", pUbigeoE.CodUbigeo);
                        cmd.Parameters.AddWithValue("@codpais", pUbigeoE.CodPais);
                        cmd.Parameters.AddWithValue("@coddpto", pUbigeoE.CodDpto);
                        cmd.Parameters.AddWithValue("@codprov", pUbigeoE.CodProv);
                        cmd.Parameters.AddWithValue("@coddist", pUbigeoE.CodDist);
                        cmd.Parameters.AddWithValue("@nombre", pUbigeoE.Nombre);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_Ubigeo_UpdatexCampo(UbigeoE pUbigeoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ubigeo_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pUbigeoE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pUbigeoE.Campo);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_Ubigeo_Delete(UbigeoE pUbigeoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnLogistica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Ubigeo_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

    }
}