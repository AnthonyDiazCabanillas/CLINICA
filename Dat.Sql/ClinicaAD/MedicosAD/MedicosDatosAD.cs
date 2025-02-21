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
    public class MedicosDatosAD
    {

       private MedicosDatosE LlenarEntidad(IDataReader dr, 
                                      MedicosDatosE pMedicosDatosE)
       {
           MedicosDatosE oMedicosDatosE = new MedicosDatosE();
           switch(pMedicosDatosE.Orden)
           {
               case 1:
                    oMedicosDatosE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    oMedicosDatosE.TipDatomedico = Convert.ToString(dr["tip_datomedico"]);
                    oMedicosDatosE.IdeMedicosDatos = Convert.ToInt32(dr["ide_MedicosDatos"]);
                    oMedicosDatosE.Valor = Convert.ToString(dr["valor"]);
                   break;
           }

           return oMedicosDatosE;
       }

       public List<MedicosDatosE> Sp_MedicosDatos_Consulta(MedicosDatosE pMedicosDatosE)
       {
           List<MedicosDatosE> oListar = new List<MedicosDatosE>();
           MedicosDatosE oMedicosDatosE = null;
           using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
           {
               using (SqlCommand cmd = new SqlCommand("Sp_MedicosDatos_Consulta", cnn))
               {
                   cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pMedicosDatosE.Buscar);
                    cmd.Parameters.AddWithValue("@key", pMedicosDatosE.Key);
                    cmd.Parameters.AddWithValue("@numerolineas", pMedicosDatosE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pMedicosDatosE.Orden);
                    cnn.Open();
                   IDataReader dr = cmd.ExecuteReader();
                   while (dr.Read())
                   {
                       oMedicosDatosE = LlenarEntidad(dr, pMedicosDatosE);
                       oListar.Add(oMedicosDatosE);
                   }
                   dr.Close();
                   cnn.Close();
               }
           }
           return oListar;
       }


       public bool Sp_MedicosDatos_Insert(MedicosDatosE pMedicosDatosE)
       {
           try
           {
               using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
               {
                   using (SqlCommand cmd = new SqlCommand("Sp_MedicosDatos_Insert", cnn))
                   {
                       cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       //Parametros del Store
                       cmd.Parameters.AddWithValue("@cod_medico", pMedicosDatosE.CodMedico);
                       cmd.Parameters.AddWithValue("@tip_datomedico", pMedicosDatosE.TipDatomedico);
                       cmd.Parameters.AddWithValue("@ide_medicosdatos", pMedicosDatosE.IdeMedicosDatos);
                       cmd.Parameters.AddWithValue("@valor", pMedicosDatosE.Valor);
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


       public bool Sp_MedicosDatos_Update(MedicosDatosE pMedicosDatosE)
       {
           try
           {
               using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
               {
                   using (SqlCommand cmd = new SqlCommand("Sp_MedicosDatos_Update", cnn))
                   {
                       cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       //Parametros del Store
                       cmd.Parameters.AddWithValue("@cod_medico", pMedicosDatosE.CodMedico);
                       cmd.Parameters.AddWithValue("@tip_datomedico", pMedicosDatosE.TipDatomedico);
                       cmd.Parameters.AddWithValue("@ide_medicosdatos", pMedicosDatosE.IdeMedicosDatos);
                       cmd.Parameters.AddWithValue("@valor", pMedicosDatosE.Valor);
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


       public bool Sp_MedicosDatos_UpdatexCampo(MedicosDatosE pMedicosDatosE)
       {
           try
           {
               using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
               {
                   using (SqlCommand cmd = new SqlCommand("Sp_MedicosDatos_UpdatexCampo", cnn))
                   {
                       cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       //Parametros del Store
                       cmd.Parameters.AddWithValue("@nuevo_valor", pMedicosDatosE.NuevoValor);
                       cmd.Parameters.AddWithValue("@campo", pMedicosDatosE.Campo);
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


       public bool Sp_MedicosDatos_Delete(MedicosDatosE pMedicosDatosE)
       {
           try
           {
               using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
               {
                   using (SqlCommand cmd = new SqlCommand("Sp_MedicosDatos_Delete", cnn))
                   {
                       cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosDatosE.CodMedico);
                        cmd.Parameters.AddWithValue("@tip_datomedico", pMedicosDatosE.TipDatomedico);
                        cmd.Parameters.AddWithValue("@ide_medicosdatos", pMedicosDatosE.IdeMedicosDatos);
                        cmd.Parameters.AddWithValue("@valor", pMedicosDatosE.Valor);
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