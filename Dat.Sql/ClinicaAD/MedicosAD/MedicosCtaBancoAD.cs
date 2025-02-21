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
    public class MedicosCtaBancoAD
    {

        private MedicosCtaBancoE LlenarEntidad(IDataReader dr,
                                       MedicosCtaBancoE pMedicosCtaBancoE)
        {
            MedicosCtaBancoE oMedicosCtaBancoE = new MedicosCtaBancoE();
            switch (pMedicosCtaBancoE.Orden)
            {
                case 1:
                    oMedicosCtaBancoE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    oMedicosCtaBancoE.IdeMedicosCtaBanco = Convert.ToInt32(dr["ide_medicosctabanco"]);
                    oMedicosCtaBancoE.CodBanco = Convert.ToString(dr["cod_banco"]);
                    oMedicosCtaBancoE.Moneda = Convert.ToInt32(dr["moneda"]);
                    oMedicosCtaBancoE.CodCtaBanco = Convert.ToString(dr["cod_cta_banco"]);
                    oMedicosCtaBancoE.CodCciBanco = Convert.ToString(dr["cod_cci_banco"]);
                    oMedicosCtaBancoE.DscBanco = Convert.ToString(dr["dsc_banco"]);
                    oMedicosCtaBancoE.DscMoneda = Convert.ToString(dr["dsc_moneda"]);
                    break;
            }

            return oMedicosCtaBancoE;
        }

        public List<MedicosCtaBancoE> Sp_MedicosCtaBanco_Consulta(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            List<MedicosCtaBancoE> oListar = new List<MedicosCtaBancoE>();
            MedicosCtaBancoE oMedicosCtaBancoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_MedicosCtaBanco_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@orden", pMedicosCtaBancoE.Orden);
                    cmd.Parameters.AddWithValue("@buscar", pMedicosCtaBancoE.CodMedico);
                    cmd.Parameters.AddWithValue("@key", pMedicosCtaBancoE.Key);
                    cmd.Parameters.AddWithValue("@numerolineas", pMedicosCtaBancoE.NroFilas);

                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oMedicosCtaBancoE = LlenarEntidad(dr, pMedicosCtaBancoE);
                        oListar.Add(oMedicosCtaBancoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_MedicosCtaBanco_Insert(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosCtaBanco_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosCtaBancoE.CodMedico);
                        cmd.Parameters.AddWithValue("@ide_medicosctabanco", pMedicosCtaBancoE.IdeMedicosCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_banco", pMedicosCtaBancoE.CodBanco);
                        cmd.Parameters.AddWithValue("@moneda", pMedicosCtaBancoE.Moneda);
                        cmd.Parameters.AddWithValue("@cod_cta_banco", pMedicosCtaBancoE.CodCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_cci_banco", pMedicosCtaBancoE.CodCciBanco);
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


        public bool Sp_MedicosCtaBanco_Update(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosCtaBanco_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosCtaBancoE.CodMedico);
                        cmd.Parameters.AddWithValue("@ide_medicosctabanco", pMedicosCtaBancoE.IdeMedicosCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_banco", pMedicosCtaBancoE.CodBanco);
                        cmd.Parameters.AddWithValue("@moneda", pMedicosCtaBancoE.Moneda);
                        cmd.Parameters.AddWithValue("@cod_cta_banco", pMedicosCtaBancoE.CodCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_cci_banco", pMedicosCtaBancoE.CodCciBanco);
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


        public string Sp_MedicosCtaBanco_ValidaGraba(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            string resultado = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosCtaBanco_ValidaGraba", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosCtaBancoE.CodMedico);
                        cmd.Parameters.AddWithValue("@ide_medicosctabanco", pMedicosCtaBancoE.IdeMedicosCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_banco", pMedicosCtaBancoE.CodBanco);
                        cmd.Parameters.AddWithValue("@moneda", pMedicosCtaBancoE.Moneda);
                        cmd.Parameters.AddWithValue("@cod_cta_banco", pMedicosCtaBancoE.CodCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_cci_banco", pMedicosCtaBancoE.CodCciBanco);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            resultado = Convert.ToString(dr["resultado"]);
                        }
                        dr.Close();
                        cnn.Close();
                    }
                }
                return resultado;

            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_MedicosCtaBanco_UpdatexCampo(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosCtaBanco_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pMedicosCtaBancoE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pMedicosCtaBancoE.Campo);
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


        public bool Sp_MedicosCtaBanco_Delete(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosCtaBanco_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosCtaBancoE.CodMedico);
                        cmd.Parameters.AddWithValue("@ide_medicosctabanco", pMedicosCtaBancoE.IdeMedicosCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_banco", pMedicosCtaBancoE.CodBanco);
                        cmd.Parameters.AddWithValue("@moneda", pMedicosCtaBancoE.Moneda);
                        cmd.Parameters.AddWithValue("@cod_cta_banco", pMedicosCtaBancoE.CodCtaBanco);
                        cmd.Parameters.AddWithValue("@cod_cci_banco", pMedicosCtaBancoE.CodCciBanco);
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