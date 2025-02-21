//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 Metodos para la digitalización
//****************************************************************************************
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.HospitalE;
using Ent.Sql.ClinicaE.OtrosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.HospitalAD
{
    public class HospitalAD
    {
        private HospitalE LlenarEntidad(IDataReader dr, HospitalE pHospitalE)
        {
            HospitalE oHospitalE = new HospitalE();
            switch (pHospitalE.Orden)
            {
                case 1:
                    {
                        oHospitalE.CodAtencion = (string) dr["codatencion"];
                        oHospitalE.CodPaciente = (string) dr["codpaciente"];
                        oHospitalE.Tipoingreso = (string) dr["tipoingreso"];
                        oHospitalE.Tipoegreso = (string) dr["tipoegreso"];
                        oHospitalE.Activo = (string) dr["activo"];
                        oHospitalE.CodDiagnostico = (string) dr["coddiagnostico"];
                        oHospitalE.Fechainicio = (DateTime) dr["fechainicio"];
                        oHospitalE.Fechafin = (DateTime) dr["fechafin"];
                        oHospitalE.Codmedico = (string) dr["codmedico"];
                        oHospitalE.Tipomedico = (string) dr["tipomedico"];
                        oHospitalE.Cama = (string) dr["cama"];
                        oHospitalE.Codpoliza = (string) dr["codpoliza"];
                        oHospitalE.Planpoliza = (string) dr["planpoliza"];
                        oHospitalE.Codaseguradora = (string) dr["codaseguradora"];
                        oHospitalE.Titular = (string) dr["titular"];
                        oHospitalE.Quirofano = (bool) dr["quirofano"];
                        oHospitalE.Codcia = (string) dr["codcia"];
                        oHospitalE.Quiencreoregistro = (string) dr["quiencreoregistro"];
                        oHospitalE.Quienmodificoregistro = (string) dr["quienmodificoregistro"];
                        oHospitalE.Estado = (string) dr["estado"];
                        oHospitalE.Familiar = (string) dr["familiar"];
                        oHospitalE.Gestante = (string) dr["gestante"];
                        oHospitalE.Fur = (DateTime) dr["fur"];
                        oHospitalE.Fechaaltamedica = (DateTime) dr["fechaaltamedica"];
                        oHospitalE.Vaseguradora = (double) dr["vaseguradora"];
                        oHospitalE.Vpaciente = (double) dr["vpaciente"];
                        oHospitalE.Vcontratante = (double) dr["vcontratante"];
                        oHospitalE.Quieneliminoregistro = (string) dr["quieneliminoregistro"];
                        oHospitalE.UsrAltamedica = (int) dr["usr_altamedica"];
                        oHospitalE.UsrAltaadministrativa = (int) dr["usr_altaadministrativa"];
                        oHospitalE.FecAltaadministrativa = (DateTime) dr["fec_altaadministrativa"];
                        break;
                    }

                case 14:
                    {
                        oHospitalE.CodPaciente = (string) dr["codpaciente"];
                        oHospitalE.TipoAtencion = (string) dr["tipo"];
                        oHospitalE.FlagCorreo = (string) dr["flagcorreo"];
                        oHospitalE.Nombres = (string) dr["nombres"];
                        oHospitalE.ApellidoPat = (string) dr["apellido_pat"];
                        oHospitalE.CodTipo = (string) dr["codtipo"];
                        oHospitalE.Correo = (string) dr["correo"];
                        oHospitalE.NombresPaciente = (string) dr["nombres_paciente"];
                        break;
                    }

                case 15:
                    {
                        oHospitalE.CodAtencion = (string) dr["codatencion"] + "";
                        oHospitalE.CodPaciente = (string) dr["codpaciente"] + "";
                        oHospitalE.NombresPaciente = (string) dr["nombres"] + "";
                        oHospitalE.Correo = (string) dr["email"] + "";
                        oHospitalE.Telefono = (string) dr["telefono"] + "";
                        oHospitalE.Telefono1 = (string) dr["telefono1"] + "";
                        break;
                    }
            }
            return oHospitalE;
        }

        //INI 1.0
        private HospitalE.ListarMetaData LlenarMetaData(IDataReader dr, HospitalE pHospitalE)
        {
            HospitalE.ListarMetaData oHospitalE = new HospitalE.ListarMetaData();
            switch (pHospitalE.Orden)
            {
                case 1:
                    {
                        oHospitalE.codatencion = (string)dr["codatencion"].ToString().Trim();
                        oHospitalE.idTipoAtencion = (int)dr["idTipoAtencion"];
                        oHospitalE.tipoAtencion = (string)dr["tipoAtencion"].ToString().Trim();
                        oHospitalE.sede = (string)dr["sede"].ToString().Trim();
                        oHospitalE.numeroHC = (string)dr["numeroHC"];
                        oHospitalE.nombrePaciente = (string)dr["nombrePaciente"].ToString().Trim();
                        oHospitalE.apellidosPaciente = (string)dr["apellidosPaciente"].ToString().Trim();
                        oHospitalE.tipdocidentidad = (string)dr["tipdocidentidad"].ToString().Trim();
                        oHospitalE.docidentidad = (string)dr["docidentidad"].ToString().Trim();
                        oHospitalE.nombreMedico = (string)dr["nombreMedico"].ToString().Trim();
                        oHospitalE.especialidadMedico = (string)dr["especialidadMedico"].ToString().Trim();
                        oHospitalE.fechaAtencion = (DateTime)dr["fechaAtencion"];
                        break;
                    }
            }
            return oHospitalE;
        }

        public List<HospitalE.ListarMetaData> Sp_Hospital_ListarMetaData(HospitalE pHospitalE)
        {
            IDataReader dr;
            List<HospitalE.ListarMetaData> oListar = new List<HospitalE.ListarMetaData>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_ListarMetaData", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codatencion", pHospitalE.CodAtencion);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            HospitalE.ListarMetaData oHospitalE = LlenarMetaData(dr, pHospitalE);
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
        //FIN 1.0

        public List<HospitalE> Sp_Hospital_Consulta(HospitalE pHospitalE)
        {
            IDataReader dr;
            List<HospitalE> oListar = new List<HospitalE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pHospitalE.Buscar);
                        cmd.Parameters.AddWithValue("@key", pHospitalE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pHospitalE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pHospitalE.Orden);
                        cmd.Parameters.AddWithValue("@tipoatencion", pHospitalE.TipoAtencion);
                        cmd.Parameters.AddWithValue("@activo", pHospitalE.Activo);
                        cmd.Parameters.AddWithValue("@filtrolocal", pHospitalE.FiltroLocal);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            HospitalE oHospitalE = LlenarEntidad(dr, pHospitalE);
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

        public bool Sp_Hospital_Insert(HospitalE pHospitalE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codatencion", pHospitalE.CodAtencion);
                        cmd.Parameters.AddWithValue("@codpaciente", pHospitalE.CodPaciente);
                        cmd.Parameters.AddWithValue("@tipoingreso", pHospitalE.Tipoingreso);
                        cmd.Parameters.AddWithValue("@tipoegreso", pHospitalE.Tipoegreso);
                        cmd.Parameters.AddWithValue("@activo", pHospitalE.Activo);
                        cmd.Parameters.AddWithValue("@coddiagnostico", pHospitalE.CodDiagnostico);
                        cmd.Parameters.AddWithValue("@fechainicio", pHospitalE.Fechainicio);
                        cmd.Parameters.AddWithValue("@fechafin", pHospitalE.Fechafin);
                        cmd.Parameters.AddWithValue("@codmedico", pHospitalE.Codmedico);
                        cmd.Parameters.AddWithValue("@tipomedico", pHospitalE.Tipomedico);
                        cmd.Parameters.AddWithValue("@cama", pHospitalE.Cama);
                        cmd.Parameters.AddWithValue("@codpoliza", pHospitalE.Codpoliza);
                        cmd.Parameters.AddWithValue("@planpoliza", pHospitalE.Planpoliza);
                        cmd.Parameters.AddWithValue("@codaseguradora", pHospitalE.Codaseguradora);
                        cmd.Parameters.AddWithValue("@titular", pHospitalE.Titular);
                        cmd.Parameters.AddWithValue("@quirofano", pHospitalE.Quirofano);
                        cmd.Parameters.AddWithValue("@codcia", pHospitalE.Codcia);
                        cmd.Parameters.AddWithValue("@quiencreoregistro", pHospitalE.Quiencreoregistro);
                        cmd.Parameters.AddWithValue("@quienmodificoregistro", pHospitalE.Quienmodificoregistro);
                        cmd.Parameters.AddWithValue("@estado", pHospitalE.Estado);
                        cmd.Parameters.AddWithValue("@familiar", pHospitalE.Familiar);
                        cmd.Parameters.AddWithValue("@gestante", pHospitalE.Gestante);
                        cmd.Parameters.AddWithValue("@fur", pHospitalE.Fur);
                        cmd.Parameters.AddWithValue("@fechaaltamedica", pHospitalE.Fechaaltamedica);
                        cmd.Parameters.AddWithValue("@vaseguradora", pHospitalE.Vaseguradora);
                        cmd.Parameters.AddWithValue("@vpaciente", pHospitalE.Vpaciente);
                        cmd.Parameters.AddWithValue("@vcontratante", pHospitalE.Vcontratante);
                        cmd.Parameters.AddWithValue("@quieneliminoregistro", pHospitalE.Quieneliminoregistro);
                        cmd.Parameters.AddWithValue("@usr_altamedica", pHospitalE.UsrAltamedica);
                        cmd.Parameters.AddWithValue("@usr_altaadministrativa", pHospitalE.UsrAltaadministrativa);
                        cmd.Parameters.AddWithValue("@fec_altaadministrativa", pHospitalE.FecAltaadministrativa);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Hospital_Insert1(HospitalE pHospitalE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_Insert1", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codpaciente", pHospitalE.CodPaciente);
                        cmd.Parameters.AddWithValue("@tipoatencion", pHospitalE.TipoAtencion);
                        cmd.Parameters.AddWithValue("@codusuario", pHospitalE.CodUser);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codigo", ParameterDirection.Output, SqlDbType.VarChar, 8, pHospitalE.CodAtencion));

                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            pHospitalE.CodAtencion = (string)cmd.Parameters["@codigo"].Value;
                            return true;
                        }
                        else
                            return false;

                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Hospital_Insert_App(HospitalE pHospitalE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_Insert_App", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codpaciente", pHospitalE.CodPaciente);
                        cmd.Parameters.AddWithValue("@tipoatencion", pHospitalE.TipoAtencion);
                        cmd.Parameters.AddWithValue("@codusuario", pHospitalE.CodUser);
                        cmd.Parameters.AddWithValue("@codsedelocal", pHospitalE.CodSede);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codigo", ParameterDirection.Output, SqlDbType.VarChar, 8, pHospitalE.CodAtencion));

                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            pHospitalE.CodAtencion = (string)cmd.Parameters["@codigo"].Value;
                            return true;
                        }
                        else
                            return false;

                        cmd.Dispose(); // Se liberan todos los recursos de la 
                        cnn.Close(); // Se cierre la conexión
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Hospital_Update(HospitalE pHospitalE)
        {
            bool xResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codigo", pHospitalE.CodAtencion);
                        cmd.Parameters.AddWithValue("@campo", pHospitalE.Campo);
                        cmd.Parameters.AddWithValue("@nuevovalor", pHospitalE.NuevoValor);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        xResult = true;

                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return xResult;
        }

        public bool Sp_Hospital_Delete(HospitalE pHospitalE)
        {
            bool xResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Hospital_Delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@return", "").Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.AddWithValue("@codatencion", pHospitalE.CodAtencion);
                        cmd.Parameters.AddWithValue("@accion", pHospitalE.Orden);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        xResult = true;
                        cnn.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return xResult;
        }

        // 
        public DataSet Sp_ConsultarDatosHospitalarios(HospitalE pHospitalE)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_ConsultarDatosHospitalarios", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_paciente", pHospitalE.CodPaciente);
                        cnn.Open();

                        SqlDataAdapter oda = new SqlDataAdapter(cmd);
                        oda.Fill(ds);

                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*Pacientes Hospitalizados   Fchuje*/
        public List<HospitalE> Listado_PacientesHospitaliazados_Coincidencias(int order, int n_fila , string codatencion, string Busq) 
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<HospitalE> Lista = new List<HospitalE>();
            try  
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", order);
                cmd.Parameters.AddWithValue("@n_filas", n_fila);
                cmd.Parameters.AddWithValue("@cod_atencion", codatencion);
                cmd.Parameters.AddWithValue("@v_Busq", Busq);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HospitalE _obj = new HospitalE();
                    _obj.Item = int.Parse(dr["item"].ToString());
                    _obj.Ide_Historia = dr["ide_historia"].ToString();
                    _obj.CodPaciente = dr["codpaciente"].ToString();
                    _obj.CodAtencion = dr["cod_atencion"].ToString();
                    _obj.NombresPaciente = dr["nombres"].ToString();
                    _obj.DocumentoIdentidad = dr["docidentidad"].ToString();
                    _obj.Direccion = dr["direccion"].ToString();
                    _obj.Cama = dr["cama"].ToString();
                    _obj.Fechainicio = DateTime.Parse(dr["fechainicio"].ToString());
                    _obj.Edad = dr["Edad"].ToString();
                    _obj.NombreMedico = dr["NombreMedico"].ToString();
                    _obj.Piso = dr["Piso"].ToString();
                    Lista.Add(_obj );
                }
                return Lista; 
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception) 
            {
                throw ; 
            } 
            finally 
            {
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }

        public HospitalE Datos_PacienteHospitalizado(int order, int n_fila, string codatencion, string Busq)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            HospitalE obj = new HospitalE();
            try 
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", order);
                cmd.Parameters.AddWithValue("@n_filas", n_fila);
                cmd.Parameters.AddWithValue("@cod_atencion", codatencion);
                cmd.Parameters.AddWithValue("@v_Busq", Busq);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    obj.TipoDocumento = dr["TipoDocumento"].ToString();
                    obj.DocumentoIdentidad = dr["docidentidad"].ToString();
                    obj.CodPaciente = dr["codpaciente"].ToString();
                    obj.NombresPaciente = dr["nombres"].ToString();
                    obj.Sexo = dr["SEXO"].ToString();
                    obj.Telefono = dr["telefono"].ToString();
                    obj.Edad = dr["edad"].ToString();
                    obj.Cama = dr["cama"].ToString();
                    obj.CodAtencion = dr["codatencion"].ToString();
                    obj.Fechainicio = DateTime.Parse(dr["fechainicio"].ToString());
                    obj.DiasHospitalizados = dr["DiasHospitalizados"].ToString();
                    obj.Codmedico = dr["codmedico"].ToString();
                    obj.NombreMedico = dr["NombreMedico"].ToString();
                    obj.Especialidad = dr["especialidad"].ToString();
                    obj.Codaseguradora = dr["codaseguradora"].ToString();
                    obj.NombreAseguradora = dr["NombreAseguradora"].ToString();
                    obj.Ide_Historia = dr["ide_historia"].ToString();
                    obj.FechaNacimiento = DateTime.Parse(dr["fechanacimiento"].ToString());
                    obj.FechaIngresoHabitacion = DateTime.Parse(dr["FechaIngresoHabitacion"].ToString());
                    obj.FechaIngresoEmergencia = dr["FechaIngresoEmergencia"].ToString();
                    obj.CodCivil = dr["codcivil"].ToString();
                    obj.Activo = dr["activo"].ToString();
                    obj.alergias = dr["Flg_alergia"].ToString();
                    obj.Diagnostico = dr["Diagnostico"].ToString();
                    obj.Ide_kardexhospitalizacion = int.Parse(dr["Ide_kardexhospitalizacion"].ToString());
                    obj.alergias = dr["AlergiaMedica"].ToString();
                    obj.EstadoAlergia = dr["EstadoAlergia"].ToString();
                    obj.PesoPaciente = Convert.ToDecimal(dr["PesoPaciente"].ToString());
                 }
                return obj;
            }
            catch (Exception ex) 
            {
                throw;
            }
            finally 
            {
                con.Close();
                con.Dispose();
            }
        }

        public List<IndicacionesMedicasE> Listado_IndicacionesMedicas(int order, int n_fila, string codatencion, string Busq) 
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<IndicacionesMedicasE> Lista = new List<IndicacionesMedicasE>();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", order);
                cmd.Parameters.AddWithValue("@n_filas", n_fila);
                cmd.Parameters.AddWithValue("@cod_atencion", codatencion);
                cmd.Parameters.AddWithValue("@v_Busq", Busq);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IndicacionesMedicasE _obj = new IndicacionesMedicasE();
                    _obj.IdTipo = int.Parse(dr["IdTipo"].ToString());
                    _obj.NombreTipo = dr["NombreTipo"].ToString();
                    _obj.dsc_producto = dr["dsc_producto"].ToString();
                    _obj.num_dosis = dr["num_dosis"].ToString();
                    _obj.num_duracion = dr["num_duracion"].ToString();
                    _obj.num_frecuencia = dr["num_frecuencia"].ToString();
                    _obj.num_cantidad = Convert.ToDecimal(dr["num_cantidad"].ToString());
                    _obj.dsc_via = dr["dsc_via"].ToString();
                    _obj.ide_receta = int.Parse(dr["ide_receta"].ToString());
                    _obj.ide_medicamentorec = int.Parse(dr["ide_medicamentorec"].ToString());
                    _obj.flg_suspendido = dr["flg_suspendido"].ToString();
                    _obj.txt_detalle = dr["txt_detalle"].ToString();
                    _obj.HOR_REGISTRO = dr["HOR_REGISTRO"].ToString();
                    _obj.HOR_REGISTRO2 = dr["HOR_REGISTRO2"].ToString();
                    _obj.Fecha = dr["Fecha"].ToString();
                    _obj.NombreMedico = dr["NombreMedico"].ToString();
                    _obj.cod_atencion = dr["cod_atencion"].ToString();
                    _obj._item = int.Parse(dr["ItemKardex"].ToString());
                    _obj.UltimoUserRegistro = dr["UltimoUserRegistro"].ToString();
                    _obj.UltimoFechaRegistro = dr["ultFechaRegistro"].ToString();
                    _obj.Icons = dr["Icons"].ToString();
                    _obj.NumeracionFrecuencia = int.Parse(dr["NumeracionFrecuencia"].ToString());
                    _obj.SiguienteHora = dr["SiguienteHora"].ToString();
                    _obj.ide_KardexHospitalario = 0;
                    _obj.HoraSecundaria = 0;
                    _obj.i_horasugerida = 0;
                    _obj.TotDetalle = int.Parse(dr["TotDetalle"].ToString());
                    _obj.SumEstado = int.Parse(dr["SumEstado"].ToString());
                    Lista.Add(_obj);
                }
                return Lista;
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }

        public List<IndicacionesMedicaDetalleE> Listado_KardexHistoricoIndicacionesMedicas(int order, int n_fila, string codatencion, string Busq) 
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<IndicacionesMedicaDetalleE> Lista = new List<IndicacionesMedicaDetalleE>();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", order);
                cmd.Parameters.AddWithValue("@n_filas", n_fila);
                cmd.Parameters.AddWithValue("@cod_atencion", codatencion);
                cmd.Parameters.AddWithValue("@v_Busq", Busq);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IndicacionesMedicaDetalleE _obj = new IndicacionesMedicaDetalleE();
                    _obj.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    _obj.ide_medicamentorec = int.Parse(dr["ide_medicamentorec"].ToString());
                    _obj.i_Idtipo = int.Parse(dr["i_Idtipo"].ToString());
                    _obj.dsc_tipo = dr["dsc_tipo"].ToString();
                    _obj.dsc_producto = dr["dsc_producto"].ToString();
                    _obj.usr_registra = dr["usr_registra"].ToString();
                    _obj.i_Correlativo = int.Parse(dr["i_Correlativo"].ToString());
                    _obj.FInsert = dr["FInsert"].ToString();
                    _obj.fechaprogramada = dr["fechaprogramada"].ToString();                   
                    _obj.HInsert = dr["HInsert"].ToString();
                    _obj.Icons = dr["Icons"].ToString();
                    _obj.peso = dr["peso"].ToString();
                    _obj.usr_adminstra = dr["usr_adminstra"].ToString();
                    _obj.fechaadministrada = dr["fechaadministrada"].ToString();
                    _obj.dsc_tipoAdminstracio = dr["dsc_tipoAdminstracio"].ToString();
                    _obj.i_estadoadministrado = int.Parse(dr["i_estadoadministrado"].ToString());

                    Lista.Add(_obj);
                }
                return Lista;
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }

        public List<ProgramacionKardexE> Listado_KardexHistoricoIndicacionesProgramada(int order, int n_fila, string codatencion, string Busq)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<ProgramacionKardexE> Lista = new List<ProgramacionKardexE>();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", order);
                cmd.Parameters.AddWithValue("@n_filas", n_fila);
                cmd.Parameters.AddWithValue("@cod_atencion", codatencion);
                cmd.Parameters.AddWithValue("@v_Busq", Busq);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProgramacionKardexE _obj = new ProgramacionKardexE();
                    _obj.item = int.Parse(dr["item"].ToString());
                    _obj.codatencion = dr["codatencion"].ToString();
                    _obj.ide_medicamentorec = int.Parse(dr["ide_medicamentorec"].ToString());
                    _obj.i_Correlativo = int.Parse(dr["i_Correlativo"].ToString());
                    _obj.i_estadoadministrado = int.Parse(dr["i_estadoadministrado"].ToString());
                    _obj.fechaprogramada = dr["fechaprogramada"].ToString();
                    _obj.horaprogramada = dr["horaprogramada"].ToString();
                    _obj.FechaAdministrada = dr["FechaAdministrada"].ToString();
                    _obj.usr_adminstra = dr["usr_adminstra"].ToString();
                    Lista.Add(_obj);
                }
                return Lista;
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }


        public List<PisoE> Listar_piso_x_usuario(int order, int n_fila, string codatencion, string Busq)
        {
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            List<PisoE> Lista = new List<PisoE>();
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", order);
                cmd.Parameters.AddWithValue("@n_filas", n_fila);
                cmd.Parameters.AddWithValue("@cod_atencion", codatencion);
                cmd.Parameters.AddWithValue("@v_Busq", Busq);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PisoE _obj = new PisoE();
                    _obj.NPiso = dr["piso"].ToString();
                    _obj.PisoSeleccionado = dr["nro_piso"].ToString();
                    Lista.Add(_obj);
                }
                return Lista;
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close(); //cierra conexion con la base de datos
                con.Dispose(); // libera recursos de la conexion base de datos
            }
        }

        /*Registro Cabecera*/
        public RespuestaJsonE Registrar_Kardex_datosHospitalario_Paciente(KardexHospitalarioE _obj) 
        {
            RespuestaJsonE _respuesta = new RespuestaJsonE();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ide_kardexhospitalario", _obj.ide_kardexhospitalario);
                cmd.Parameters.AddWithValue("@codatencion", _obj.codatencion);
                cmd.Parameters.AddWithValue("@codpaciente", _obj.codpaciente);
                cmd.Parameters.AddWithValue("@peso", _obj.peso);
                cmd.Parameters.AddWithValue("@usr_registra", _obj.usr_registra);
                cmd.Parameters.AddWithValue("@estado", _obj.estado);
                cmd.Parameters.AddWithValue("@eliminado", _obj.eliminado);
                cmd.Parameters.AddWithValue("@order", _obj.order);
                cmd.Parameters.AddWithValue("@Hora2", 0);
                cmd.Parameters.AddWithValue("@idtipo", 0);
                cmd.Parameters.AddWithValue("@nombretipo", "");
                cmd.Parameters.AddWithValue("@ide_medicamentorec", 0);
                cmd.Parameters.Add("@status", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;


                con.Open();
                dr = cmd.ExecuteReader();
                int _status = int.Parse(cmd.Parameters["@status"].Value.ToString());
                if (_status == 1)
                {
                    _respuesta.exito = true;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
                else
                {
                    _respuesta.exito = false;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                _respuesta.exito = false;
                _respuesta.message = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return _respuesta;
        }


        /*Registro Detalle*/
        public RespuestaJsonE Registrar_kardex_datosHospitalarios_Detalle(IndicacionesMedicasE _obj)
        {
            RespuestaJsonE _respuesta = new RespuestaJsonE();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ide_kardexhospitalario", _obj.ide_KardexHospitalario);
                cmd.Parameters.AddWithValue("@codatencion", _obj.cod_atencion);
                cmd.Parameters.AddWithValue("@codpaciente", _obj.horaAtencion);
                cmd.Parameters.AddWithValue("@peso", _obj.i_horasugerida);
                cmd.Parameters.AddWithValue("@usr_registra", _obj.UserRegistro);
                cmd.Parameters.AddWithValue("@estado", "0");
                cmd.Parameters.AddWithValue("@eliminado", "0");
                cmd.Parameters.AddWithValue("@order", 2);
                cmd.Parameters.AddWithValue("@Hora2", _obj.HoraSecundaria);
                cmd.Parameters.AddWithValue("@idtipo", _obj.IdTipo);
                cmd.Parameters.AddWithValue("@nombretipo", _obj.NombreTipo);
                cmd.Parameters.AddWithValue("@ide_medicamentorec", _obj.ide_medicamentorec);
                cmd.Parameters.Add("@status", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;


                con.Open();
                dr = cmd.ExecuteReader();
                int _status = int.Parse(cmd.Parameters["@status"].Value.ToString());
                if (_status == 1)
                {
                    _respuesta.exito = true;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
                else
                {
                    _respuesta.exito = false;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                _respuesta.exito = false;
                _respuesta.message = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return _respuesta;
        }

        public RespuestaJsonE Registrar_UsuarioPisoAtencion(PisoE _obj)
        {
            RespuestaJsonE _respuesta = new RespuestaJsonE();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Kardex_PacientesHospitalizados_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ide_kardexhospitalario", 0);
                cmd.Parameters.AddWithValue("@codatencion", "");
                cmd.Parameters.AddWithValue("@codpaciente", "");
                cmd.Parameters.AddWithValue("@peso", 0M);
                cmd.Parameters.AddWithValue("@usr_registra", _obj.NPiso);
                cmd.Parameters.AddWithValue("@estado", "0");
                cmd.Parameters.AddWithValue("@eliminado", "0");
                cmd.Parameters.AddWithValue("@order", 3);
                cmd.Parameters.AddWithValue("@Hora2", 0);
                cmd.Parameters.AddWithValue("@idtipo", 0);
                cmd.Parameters.AddWithValue("@nombretipo", _obj.PisoSeleccionado);
                cmd.Parameters.AddWithValue("@ide_medicamentorec", 0);
                cmd.Parameters.Add("@status", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;


                con.Open();
                dr = cmd.ExecuteReader();
                int _status = int.Parse(cmd.Parameters["@status"].Value.ToString());
                if (_status == 1)
                {
                    _respuesta.exito = true;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
                else
                {
                    _respuesta.exito = false;
                    _respuesta.message = cmd.Parameters["@message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                _respuesta.exito = false;
                _respuesta.message = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return _respuesta;
        }

		public bool Sp_hospitalqr_Actualizar(HospitalE.HospitalQR pHospitalQR)
		{
			try
			{
				using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
				{
					using (SqlCommand cmd = new SqlCommand("Sp_hospitalqr_Actualizar", cnn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@codatencion", pHospitalQR.codatencion);
						cmd.Parameters.AddWithValue("@dsc_nombre_qr", pHospitalQR.dsc_nombre_qr);
						
						cnn.Open();
						if (cmd.ExecuteNonQuery() >= 1)
						{
							//pHospitalE.CodAtencion = (string)cmd.Parameters["@codigo"].Value;
							return true;
						}
						else
							return false;

						cmd.Dispose(); // Se liberan todos los recursos de la 
						cnn.Close(); // Se cierre la conexión
						cnn.Dispose(); // Se liberan todos los recursos de la conexión
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
