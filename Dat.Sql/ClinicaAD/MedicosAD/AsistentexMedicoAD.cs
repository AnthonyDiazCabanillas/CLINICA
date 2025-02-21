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
    public class AsistentexmedicoAD
    {

        private AsistentexMedicoE LlenarEntidad(IDataReader dr,
                                       AsistentexMedicoE pAsistentexMedicoE)
        {
            AsistentexMedicoE oAsistentexMedicoE = new AsistentexMedicoE();
            switch (pAsistentexMedicoE.Orden)
            {
                case 1:
                    oAsistentexMedicoE.CodMedicoTitular = Convert.ToString(dr["codmedicotitular"]);
                    oAsistentexMedicoE.CodMedicoAsistente = Convert.ToString(dr["codmedicoasistente"]);
                    oAsistentexMedicoE.NombreAsistente = Convert.ToString(dr["nombreasistente"]);
                    break;
            }

            return oAsistentexMedicoE;
        }

        private MedicosE LlenarEntidadAsistente(IDataReader dr,
                               int Orden)
        {
            MedicosE oMedicosE = new MedicosE();
            switch (Orden)
            {
                case 4:
                case 5:
                    oMedicosE.CodMedico = Convert.ToString(dr["codmedico"]);
                    oMedicosE.NombresMedico = Convert.ToString(dr["nombres"]);
                    break;
            }

            return oMedicosE;
        }



        public List<AsistentexMedicoE> Sp_Asistentexmedico_Consulta(AsistentexMedicoE pAsistentexMedicoE)
        {
            List<AsistentexMedicoE> oListar = new List<AsistentexMedicoE>();
            AsistentexMedicoE oAsistentexMedicoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_AsistentexMedico_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pAsistentexMedicoE.CodMedicoTitular);
                    cmd.Parameters.AddWithValue("@key", pAsistentexMedicoE.Key);
                    cmd.Parameters.AddWithValue("@numerolineas", pAsistentexMedicoE.NroFilas);
                    cmd.Parameters.AddWithValue("@orden", pAsistentexMedicoE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oAsistentexMedicoE = LlenarEntidad(dr, pAsistentexMedicoE);
                        oListar.Add(oAsistentexMedicoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_Asistentexmedico_Insert(AsistentexMedicoE pAsistentexMedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_AsistentexMedico_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedicotitular", pAsistentexMedicoE.CodMedicoTitular);
                        cmd.Parameters.AddWithValue("@codmedicoasistente", pAsistentexMedicoE.CodMedicoAsistente);
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


        public bool Sp_Asistentexmedico_Update(AsistentexMedicoE pAsistentexMedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_AsistentexMedico_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedicotitular", pAsistentexMedicoE.CodMedicoTitular);
                        cmd.Parameters.AddWithValue("@codmedicoasistente", pAsistentexMedicoE.CodMedicoAsistente);
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


        public bool Sp_Asistentexmedico_UpdatexCampo(AsistentexMedicoE pAsistentexMedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Asistentexmedico_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pAsistentexMedicoE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pAsistentexMedicoE.Campo);
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


        public bool Sp_Asistentexmedico_Delete(AsistentexMedicoE pAsistentexMedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Asistentexmedico_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedicotitular", pAsistentexMedicoE.CodMedicoTitular);
                        cmd.Parameters.AddWithValue("@codmedicoasistente", pAsistentexMedicoE.CodMedicoAsistente);
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
            { 
                throw e = new Exception(e.Message); 
            }
        }




        public List<MedicosE> Sp_Asistentes_Consulta(string textoaBuscar, int orden)
        {
            List<MedicosE> oListar = new List<MedicosE>();
            MedicosE oMedicosE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Asistentes_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", textoaBuscar);
                    cmd.Parameters.AddWithValue("@key", 50);
                    cmd.Parameters.AddWithValue("@numerolineas", 100);
                    cmd.Parameters.AddWithValue("@orden", orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oMedicosE = LlenarEntidadAsistente(dr, orden);
                        oListar.Add(oMedicosE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }





    }
}