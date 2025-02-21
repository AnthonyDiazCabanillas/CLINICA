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
    public class PrestacionxmedicoAD
    {
        private PrestacionxMedicoE LlenarEntidad(IDataReader dr,
                                       PrestacionxMedicoE pPrestacionxmedicoE)
        {
            PrestacionxMedicoE oPrestacionxmedicoE = new PrestacionxMedicoE();
            switch (pPrestacionxmedicoE.Orden)
            {
                case -1:
                    oPrestacionxmedicoE.CodMedico = Convert.ToString(dr["codmedico"]);
                    oPrestacionxmedicoE.CodPrestacion = Convert.ToString(dr["codprestacion"]);
                    oPrestacionxmedicoE.PorcentajeRetencion1 = Convert.ToDouble(dr["porcentajeretencion1"]);
                    oPrestacionxmedicoE.PorcentajeRetencion2 = Convert.ToDouble(dr["porcentajeretencion2"]);
                    oPrestacionxmedicoE.NomPrestacion = Convert.ToString(dr["nombreprestacion"]);

                    
                    break;
            }

            return oPrestacionxmedicoE;
        }

        public List<PrestacionxMedicoE> Sp_Prestacionxmedico_Consulta(PrestacionxMedicoE pPrestacionxMedicoE)
        {
            List<PrestacionxMedicoE> oListar = new List<PrestacionxMedicoE>();
            PrestacionxMedicoE oPrestacionxmedicoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_PrestacionxMedico_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pPrestacionxMedicoE.CodMedico);
                    cmd.Parameters.AddWithValue("@key", pPrestacionxMedicoE.Key);
                    cmd.Parameters.AddWithValue("@numerolineas", pPrestacionxMedicoE.NroFilas);
                    cmd.Parameters.AddWithValue("@orden", pPrestacionxMedicoE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oPrestacionxmedicoE = LlenarEntidad(dr, pPrestacionxMedicoE);
                        oListar.Add(oPrestacionxmedicoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_PrestacionxMedico_Insert(PrestacionxMedicoE pPrestacionxmedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PrestacionxMedico_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pPrestacionxmedicoE.CodMedico);
                        cmd.Parameters.AddWithValue("@codprestacion", pPrestacionxmedicoE.CodPrestacion);
                        cmd.Parameters.AddWithValue("@porcretencion1", pPrestacionxmedicoE.PorcentajeRetencion1);
                        cmd.Parameters.AddWithValue("@porcretencion2", pPrestacionxmedicoE.PorcentajeRetencion2);
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
            { 
                throw e = new Exception(e.Message); 
            }
        }


        public bool Sp_PrestacionxMedico_Update(PrestacionxMedicoE pPrestacionxmedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PrestacionxMedico_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pPrestacionxmedicoE.CodMedico);
                        cmd.Parameters.AddWithValue("@codprestacion", pPrestacionxmedicoE.CodPrestacion);
                        cmd.Parameters.AddWithValue("@porcretencion1", pPrestacionxmedicoE.PorcentajeRetencion1);
                        cmd.Parameters.AddWithValue("@porcretencion2", pPrestacionxmedicoE.PorcentajeRetencion2);
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


        public bool Sp_Prestacionxmedico_UpdatexCampo(PrestacionxMedicoE pPrestacionxmedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Prestacionxmedico_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pPrestacionxmedicoE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pPrestacionxmedicoE.Campo);
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


        public bool Sp_Prestacionxmedico_Delete(PrestacionxMedicoE pPrestacionxmedicoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_PrestacionxMedico_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pPrestacionxmedicoE.CodMedico);
                        cmd.Parameters.AddWithValue("@codprestacion", pPrestacionxmedicoE.CodPrestacion);

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