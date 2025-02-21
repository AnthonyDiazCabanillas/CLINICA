using Ent.Sql.ClinicaE.Mantenimiento;
using Ent.Sql.ClinicaE.MedicosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.MedicosAD
{
    public class MedicoxEmpresaAD
    {

        private MedicoxEmpresaE LlenarEntidad(IDataReader dr,
                                       MedicoxEmpresaE pMedicoxEmpresaE)
        {
            MedicoxEmpresaE oMedicoxEmpresaE = new MedicoxEmpresaE();
            switch (pMedicoxEmpresaE.Orden)
            {
                case 1:
                    oMedicoxEmpresaE.CodMedico = Convert.ToString(dr["codmedico"]);
                    oMedicoxEmpresaE.CodEmpresa = Convert.ToString(dr["codempresa"]);
                    oMedicoxEmpresaE.FlgFacturar = Convert.ToBoolean(dr["facturar"]);
                    oMedicoxEmpresaE.NombreEmpresa = Convert.ToString(dr["nombreempresa"]);
                    break;
            }

            return oMedicoxEmpresaE;
        }

        public List<MedicoxEmpresaE> Sp_MedicoxEmpresa_Consulta(MedicoxEmpresaE pMedicoxEmpresaE)
        {
            List<MedicoxEmpresaE> oListar = new List<MedicoxEmpresaE>();
            MedicoxEmpresaE oMedicoxEmpresaE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_MedicoxEmpresa_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pMedicoxEmpresaE.CodMedico);
                    cmd.Parameters.AddWithValue("@key", pMedicoxEmpresaE.Key);
                    cmd.Parameters.AddWithValue("@numerolineas", pMedicoxEmpresaE.NroFilas);
                    cmd.Parameters.AddWithValue("@orden", pMedicoxEmpresaE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oMedicoxEmpresaE = LlenarEntidad(dr, pMedicoxEmpresaE);
                        oListar.Add(oMedicoxEmpresaE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_MedicoxEmpresa_Insert(MedicoxEmpresaE pMedicoxEmpresaE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoxEmpresa_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pMedicoxEmpresaE.CodMedico);
                        cmd.Parameters.AddWithValue("@codempresa", pMedicoxEmpresaE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@facturar", pMedicoxEmpresaE.FlgFacturar);
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


        public bool Sp_MedicoxEmpresa_Update(MedicoxEmpresaE pMedicoxEmpresaE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoxEmpresa_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pMedicoxEmpresaE.CodMedico);
                        cmd.Parameters.AddWithValue("@codempresa", pMedicoxEmpresaE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@facturar", pMedicoxEmpresaE.FlgFacturar);
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


        public bool Sp_MedicoxEmpresa_UpdatexCampo(MedicoxEmpresaE pMedicoxEmpresaE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoxEmpresa_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pMedicoxEmpresaE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pMedicoxEmpresaE.Campo);
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


        public bool Sp_MedicoxEmpresa_Delete(MedicoxEmpresaE pMedicoxEmpresaE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoxEmpresa_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pMedicoxEmpresaE.CodMedico);
                        cmd.Parameters.AddWithValue("@codempresa", pMedicoxEmpresaE.CodEmpresa);
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