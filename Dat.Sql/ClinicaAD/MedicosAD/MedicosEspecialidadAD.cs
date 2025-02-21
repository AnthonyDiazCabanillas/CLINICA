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
    public class MedicosEspecialidadAD
    {

        private MedicosEspecialidadE LlenarEntidad(IDataReader dr,
                                       MedicosEspecialidadE pMedicosEspecialidadE)
        {
            MedicosEspecialidadE oMedicosespecialidadE = new MedicosEspecialidadE();
            switch (pMedicosEspecialidadE.Orden)
            {
                case 1:
                    oMedicosespecialidadE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    oMedicosespecialidadE.CodSede = Convert.ToInt32(dr["cod_sede"]);
                    oMedicosespecialidadE.CodEspecialidad = Convert.ToString(dr["cod_especialidad"]);
                    oMedicosespecialidadE.TipAtencion = Convert.ToString(dr["tip_atencion"]);
                    oMedicosespecialidadE.TipPaciente = Convert.ToString(dr["tip_paciente"]);
                    oMedicosespecialidadE.Moneda = Convert.ToInt32(dr["moneda"]);
                    oMedicosespecialidadE.ImporteTarifa = Convert.ToDecimal(dr["importe_tarifa"]);
                    oMedicosespecialidadE.Rne = Convert.ToString(dr["rne"]);

                    oMedicosespecialidadE.DscSede = Convert.ToString(dr["dsc_sede"]);
                    oMedicosespecialidadE.DscEspecialidad = Convert.ToString(dr["dsc_especialidad"]);
                    oMedicosespecialidadE.DscTipAtencion = Convert.ToString(dr["dsc_tip_atencion"]);
                    oMedicosespecialidadE.DscTipPaciente = Convert.ToString(dr["dsc_tip_paciente"]);
                    oMedicosespecialidadE.DscMoneda = Convert.ToString(dr["dsc_moneda"]);

                    oMedicosespecialidadE.TipAgendaCallCenter = bool.Parse(dr["tip_agenda_callcenter"].ToString());
                    oMedicosespecialidadE.TipAgendaSecretaria = bool.Parse(dr["tip_agenda_secretaria"].ToString());
                    oMedicosespecialidadE.TipAgendaInternet = bool.Parse(dr["tip_agenda_internet"].ToString());

                    oMedicosespecialidadE.FlgPrivilegio = bool.Parse(dr["flg_privilegio"].ToString());
                    oMedicosespecialidadE.flg_ambulatorio = bool.Parse(dr["flg_ambulatorio"].ToString());
                    oMedicosespecialidadE.flg_hospitalario = bool.Parse(dr["flg_hospitalario"].ToString());
                    oMedicosespecialidadE.flg_emergencia = bool.Parse(dr["flg_emergencia"].ToString());

                    break;
            }

            return oMedicosespecialidadE;
        }

        public List<MedicosEspecialidadE> Sp_MedicosEspecialidad_Consulta(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            List<MedicosEspecialidadE> oListar = new List<MedicosEspecialidadE>();
            MedicosEspecialidadE oMedicosespecialidadE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_MedicosEspecialidad_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pMedicosEspecialidadE.CodMedico);
                    cmd.Parameters.AddWithValue("@key", pMedicosEspecialidadE.Key);
                    cmd.Parameters.AddWithValue("@numerolineas", pMedicosEspecialidadE.NroFilas);
                    cmd.Parameters.AddWithValue("@orden", pMedicosEspecialidadE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oMedicosespecialidadE = LlenarEntidad(dr, pMedicosEspecialidadE);
                        oListar.Add(oMedicosespecialidadE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_MedicosEspecialidad_Insert(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosEspecialidad_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosEspecialidadE.CodMedico);
                        cmd.Parameters.AddWithValue("@cod_especialidad", pMedicosEspecialidadE.CodEspecialidad);

                        cmd.Parameters.AddWithValue("@rne", pMedicosEspecialidadE.Rne);
                        cmd.Parameters.AddWithValue("@flg_privilegio", pMedicosEspecialidadE.FlgPrivilegio);
                        cmd.Parameters.AddWithValue("@flg_ambulatorio", pMedicosEspecialidadE.flg_ambulatorio);
                        cmd.Parameters.AddWithValue("@flg_hospitalario", pMedicosEspecialidadE.flg_hospitalario);
                        cmd.Parameters.AddWithValue("@flg_emergencia", pMedicosEspecialidadE.flg_emergencia);
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


        public bool Sp_MedicosEspecialidad_Update(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosEspecialidad_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosEspecialidadE.CodMedico);
                        cmd.Parameters.AddWithValue("@cod_especialidad", pMedicosEspecialidadE.CodEspecialidad);

                        cmd.Parameters.AddWithValue("@rne", pMedicosEspecialidadE.Rne);
                        cmd.Parameters.AddWithValue("@flg_privilegio", pMedicosEspecialidadE.FlgPrivilegio);
                        cmd.Parameters.AddWithValue("@flg_ambulatorio", pMedicosEspecialidadE.flg_ambulatorio);
                        cmd.Parameters.AddWithValue("@flg_hospitalario", pMedicosEspecialidadE.flg_hospitalario);
                        cmd.Parameters.AddWithValue("@flg_emergencia", pMedicosEspecialidadE.flg_emergencia);
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

        public bool Sp_MedicosEspecialidadDetalle_Update(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosEspecialidadDetalle_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosEspecialidadE.CodMedico);
                        cmd.Parameters.AddWithValue("@cod_especialidad", pMedicosEspecialidadE.CodEspecialidad);

                        cmd.Parameters.AddWithValue("@tip_atencion", pMedicosEspecialidadE.TipAtencion);
                        cmd.Parameters.AddWithValue("@tip_paciente", pMedicosEspecialidadE.TipPaciente);
                        cmd.Parameters.AddWithValue("@moneda", pMedicosEspecialidadE.Moneda);
                        cmd.Parameters.AddWithValue("@importe_tarifa", pMedicosEspecialidadE.ImporteTarifa);

                        cmd.Parameters.AddWithValue("@tip_agenda_callcenter", pMedicosEspecialidadE.TipAgendaCallCenter);
                        cmd.Parameters.AddWithValue("@tip_agenda_secretaria", pMedicosEspecialidadE.TipAgendaSecretaria);
                        cmd.Parameters.AddWithValue("@tip_agenda_internet", pMedicosEspecialidadE.TipAgendaInternet);
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



        public bool Sp_MedicosEspecialidad_UpdatexCampo(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosEspecialidad_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pMedicosEspecialidadE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pMedicosEspecialidadE.Campo);
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


        public bool Sp_MedicosEspecialidad_Delete(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosEspecialidad_Delete", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosEspecialidadE.CodMedico);
                        cmd.Parameters.AddWithValue("@cod_especialidad", pMedicosEspecialidadE.CodEspecialidad);


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