//********************************************************************************************************************
//   Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

//    Version  Fecha        Autor           Requerimiento
//    1.0      14/06/2024   CPARRALES       REQ 2024-005048 Proyecto buscador web
//******************************************************************************************************************** 
using Ent.Sql.ClinicaE;
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

    public class MedicosAD
    {
        Utilitario util = new Utilitario();

        private MedicoE LlenarEntidadMedico(IDataReader dr)
        {
            MedicoE ms = new MedicoE();
            //ms.CodProfMedisyn =  dr["CodProfMedisyn"] == DBNull.Value ? "" : dr["CodProfMedisyn"];
            //ms.CodProfMedisyn = (dr.IsDBNull(dr.GetOrdinal("CodProfMedisyn"))) ? "" : dr["CodProfMedisyn"].ToString();
            //ms.CodProfMedisyn = dr["CodProfMedisyn"] is DBNull ? "" : (string)dr["CodProfMedisyn"];
            //ms.CodProfMedisyn = dr["cod_prof_medisyn"].ToString() == DBNull.Value.ToString() ? "" : (string)dr["cod_prof_medisyn"];

            ms.Anexo = dr["anexo"].ToString().Trim();
            ms.ApMaterno = dr["apmaterno"].ToString();
            ms.ApPaterno = dr["appaterno"].ToString();
            ms.Area = dr["area"].ToString().Trim();
            ms.Beeper = dr["beeper"].ToString().Trim();
            ms.CardCode = dr["cardcode"].ToString();
            ms.CodAfp = dr["codafp"].ToString().Trim();
            ms.CodCivil = dr["codcivil"].ToString().Trim();
            ms.CodDistrito = dr["coddistrito"].ToString().Trim();
            ms.CodMedico = dr["codmedico"].ToString().Trim();
            ms.CodProfMedisyn = dr["cod_prof_medisyn"].ToString();
            ms.CodProvincia = dr["codprovincia"].ToString().Trim();
            ms.CodTipoConsulta = dr["cod_tipo_consulta"].ToString();
            ms.CodUbigeo = dr["cod_ubigeo"].ToString();
            ms.CodUbigeoId = dr["codubigeo"].ToString();
            ms.ColMedico = dr["colmedico"].ToString().Trim();
            ms.Consultorio = dr["consultorio"].ToString().Trim();
            ms.Cuspp = dr["cuspp"].ToString().Trim();
            ms.Direccion = dr["direccion"].ToString().Trim();
            ms.DocIdentidad = dr["docidentidad"].ToString().Trim();
            ms.DscObservacionSubEspecialidad = dr["dsc_observacion_sub_especialidad"].ToString();
            ms.NombreComercial = dr["nombre_comercial"].ToString();
            ms.CampoClinico = dr["campo_clinico"].ToString();

            ms.Email = dr["email"].ToString();
            ms.FechaCuarta = util.ValFecha(dr["fechacuarta"].ToString());

            ms.FechaPagorrhh = util.ValFecha(dr["fec_pagorrhh"].ToString());

            ms.FechaDocentrySap = util.ValFecha(dr["fec_docentrysap"].ToString());
            ms.FechaEnvioSap = util.ValFecha(dr["fec_enviosap"].ToString());
            ms.FechaFin = util.ValFecha(dr["fechafin"].ToString());
            ms.FechaFonavi = util.ValFecha(dr["fechafonavi"].ToString());
            ms.FechaIngreso = util.ValFecha(dr["fechaingreso"].ToString());
            ms.FechaNacimiento = util.ValFecha(dr["fechanacimiento"].ToString());
            ms.FechaProntoPago = util.ValFecha(dr["fechaprontopago"].ToString());
            ms.FechaRecepcionSap = util.ValFecha(dr["fec_recepcionsap"].ToString());
            ms.FechaRegistro = util.ValFecha(dr["fecharegistro"].ToString());
            ms.FechaSnp = util.ValFecha(dr["fechasnp"].ToString());
            ms.FechaSpp = util.ValFecha(dr["fechaspp"].ToString());
            ms.FlagActivoInternet = dr["activointernet"].ToString() == "1" ? true : false; // bool.Parse(dr["activointernet"].ToString());
            ms.FlagAfectoCuarta = bool.Parse(dr["afectocuarta"].ToString());
            ms.FlagAfectoFonavi = bool.Parse(dr["afectofonavi"].ToString());
            ms.FlagAfectoProntoPago = bool.Parse(dr["afectoprontopago"].ToString());
            ms.FlagAfectoSnp = bool.Parse(dr["afectosnp"].ToString());
            ms.FlagAfectoSpp = bool.Parse(dr["afectospp"].ToString());
            ms.FlagAmbulatorio = bool.Parse(dr["ambulatorio"].ToString());
            ms.FlagCortesia = bool.Parse(dr["cortesia"].ToString());
            ms.FlagEmergencia = bool.Parse(dr["emergencia"].ToString());
            ms.FlagEstado = bool.Parse(dr["estado"].ToString());
            ms.FlgAsistente = bool.Parse(dr["flagasistente"].ToString());
            ms.FlgCia = bool.Parse(dr["flagcia"].ToString());
            ms.FlgEnvioSap = bool.Parse(dr["flg_enviosap"].ToString());
            ms.FlgHospital = bool.Parse(dr["hospital"].ToString());
            ms.FlgHospitalario = bool.Parse(dr["flg_hospitalario"].ToString());
            ms.FlgMf = bool.Parse(dr["flag_mf"].ToString());
            ms.FlgPlanilla = bool.Parse(dr["flagplanilla"].ToString());
            ms.FlgPresencialCm = bool.Parse(dr["flg_presencial_cm"].ToString()); // dr["flg_presencial_cm"].ToString() == "S" ? true : false; //
            ms.FlgPresencialJm = bool.Parse(dr["flg_presencial_jm"].ToString()); // dr["flg_presencial_jm"].ToString() == "S" ? true : false; //
            ms.FlgPresencialLm = bool.Parse(dr["flg_presencial_lm"].ToString()); // dr["flg_presencial_jm"].ToString() == "S" ? true : false; //

            ms.FlgPrestacion = bool.Parse(dr["flag_prestacion"].ToString());
            ms.FlgRetencion = dr["flg_retencion"].ToString() == "1" ? true : false; // bool.Parse(dr["flg_retencion"].ToString());
            ms.TipoServicio = dr["flag_servicio"].ToString();
            ms.FlgTeleConsulta = bool.Parse(dr["flg_teleconsulta"].ToString());// dr["flg_teleconsulta"].ToString() == "S" ? true : false; //
            ms.IdeDocEntrySap = util.ValInt(dr["ide_docentrysap"].ToString());
            ms.Iniciales = dr["iniciales"].ToString().Trim();
            ms.Login = dr["login"].ToString().Trim();
            ms.Nombre = dr["nombre"].ToString();
            ms.NombreArea = dr["nombrearea"].ToString();
            ms.NombreCivil = dr["nombrecivil"].ToString();
            ms.NombrePais = dr["nombrepais"].ToString().Trim();
            ms.NombreDepartamento = dr["nombredepartamento"].ToString().Trim();
            ms.NombreDistrito = dr["nombredistrito"].ToString().Trim();
            ms.NombreProvincia = dr["nombreprovincia"].ToString().Trim();
            ms.NombreSexo = dr["nombresexo"].ToString();
            ms.NombreTipDocIdentidad = dr["nombretipdocidentidad"].ToString();
            ms.Nombre_Afp = dr["nombreafp"].ToString();
            ms.Nombres = dr["nombres"].ToString().Trim();
            ms.Observaciones = dr["observaciones"].ToString();
            ms.Password = dr["password"].ToString().Trim();
            ms.PorcentajeProntoPago = util.ValDecimal(dr["porcentajeprontopago"].ToString());
            ms.PorcentajeRetencion = util.ValDecimal(dr["porcentajeretencion"].ToString());
            ms.PorcentajeSnp = util.ValDecimal(dr["porcentajesnp"].ToString());
            ms.PorcentajeSpp = util.ValDecimal(dr["porcentajespp"].ToString());
            ms.Ruc = dr["ruc"].ToString().Trim();
            ms.Sexo = dr["sexo"].ToString().Trim();
            ms.Telefono = dr["telefono"].ToString().Trim();
            ms.TipColegio = dr["tipocolegio"].ToString().Trim();
            ms.TipDocEmite = dr["tipodocemite"].ToString().Trim();
            ms.TipDocIdentidad = dr["tipdocidentidad"].ToString().Trim();
            ms.Urlweb = dr["urlweb"].ToString();
            ms.FlagBaja = bool.Parse(dr["flg_baja"].ToString());
            ms.FlgTieneHorario = bool.Parse(dr["flg_tiene_horario"].ToString());
            ms.MensajePersonalizado = dr["mensajepersonalizado"].ToString().Trim();
            ms.TelefonoSecretaria = dr["telefonosecretaria"].ToString().Trim();
            ms.PalabraClave = dr["palabraclave"].ToString().Trim(); //1.0
            return ms;
        }



        public MedicoE Sp_Medico_ConsultaPorCodMedico(string _codmedico)
        {
            IDataReader dr;
            MedicoE oMedicoE = new MedicoE();
            oMedicoE.FechaIngreso = DateTime.Now;

            List<MedicosE> oListar = new List<MedicosE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medico_ConsultaPorCodMedico", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", _codmedico);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            oMedicoE = LlenarEntidadMedico(dr);
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oMedicoE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private MedicosE LlenarEntidad(IDataReader dr, int pOrden)
        {
            MedicosE oMedicosE = new MedicosE();

            switch (pOrden)
            {
                case -1:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.NombresMedico = (string)(dr["nombres"] + "").Trim();

                        oMedicosE.FlgTeleConsulta = (string)dr["flg_teleconsulta"] + "";
                        oMedicosE.FlgTeleConsulta = (string)(oMedicosE.FlgTeleConsulta == "" ? "false" : "true");
                        oMedicosE.FlgPresencialJM = (string)dr["flg_presencial_jm"] + "";
                        oMedicosE.FlgPresencialJM = (string)(oMedicosE.FlgPresencialJM == "" ? "false" : "true");
                        oMedicosE.FlgPresencialCM = (string)dr["flg_presencial_cm"] + "";
                        oMedicosE.FlgPresencialCM = (string)(oMedicosE.FlgPresencialCM == "" ? "false" : "true");
                        oMedicosE.FlgPresencialLM = (string)dr["flg_presencial_lm"] + "";
                        oMedicosE.FlgPresencialLM = (string)(oMedicosE.FlgPresencialLM == "" ? "false" : "true");

                        oMedicosE.CodTipoConsulta = (string)dr["cod_tipo_consulta"] + "";

                        oMedicosE.CodProfMedisyn = (string)dr["cod_prof_medisyn"] + "";
                        oMedicosE.ColMedico = (string)dr["colmedico"] + "";
                        break;
                    }

                case 0:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.NombresMedico = (string)(dr["nombres"] + "").Trim();

                        oMedicosE.FlgTeleConsulta = (string)dr["flg_teleconsulta"] + "";
                        oMedicosE.FlgTeleConsulta = (string)(oMedicosE.FlgTeleConsulta == "" ? "false" : "true");

                        oMedicosE.FlgPresencialJM = (string)dr["flg_presencial_jm"] + "";
                        oMedicosE.FlgPresencialJM = (string)(oMedicosE.FlgPresencialJM == "" ? "false" : "true");

                        oMedicosE.FlgPresencialCM = (string)dr["flg_presencial_cm"] + "";
                        oMedicosE.FlgPresencialCM = (string)(oMedicosE.FlgPresencialCM == "" ? "false" : "true");

                        oMedicosE.FlgPresencialLM = (string)dr["flg_presencial_lm"] + "";
                        oMedicosE.FlgPresencialLM = (string)(oMedicosE.FlgPresencialLM == "" ? "false" : "true");

                        oMedicosE.CodTipoConsulta = (string)dr["cod_tipo_consulta"] + "";

                        oMedicosE.CodProfMedisyn = (string)dr["cod_prof_medisyn"] + "";
                        oMedicosE.ColMedico = (string)dr["colmedico"] + "";

                        oMedicosE.MntTarifaParticular = (string)dr["mnt_tarifa_particular"]; //Interaction.IIf(Information.IsDBNull(dr["mnt_tarifa_particular"]) == true, 0, dr["mnt_tarifa_particular"]);
                        oMedicosE.DscObservacionSubEspecialidad = (string)dr["dsc_observacion_sub_especialidad"] + "";
                        oMedicosE.DscEmail = (string)(dr["email"] + "").Trim();
                        break;
                    }

                case 2:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.NombresMedico = (string)(dr["nombres"] + "").Trim();
                        // oMedicosE.DocIdentidad = ""

                        // oMedicosE.ColMedico = dr("colmedico")
                        //oMedicosE.FlgTeleConsulta = (string) dr["flg_teleconsulta"] + "";
                        //oMedicosE.FlgTeleConsulta = (string)(oMedicosE.FlgTeleConsulta == ""? "false": "true");

                        //oMedicosE.FlgPresencialJM = (string) dr["flg_presencial_jm"] + "";
                        //oMedicosE.FlgPresencialJM = (string)(oMedicosE.FlgPresencialJM == ""? "false": "true");

                        //oMedicosE.FlgPresencialCM = (string) dr["flg_presencial_cm"] + "";
                        //oMedicosE.FlgPresencialCM = (string) (oMedicosE.FlgPresencialCM == ""? "false": "true");

                        //oMedicosE.CodTipoConsulta = (string) dr["cod_tipo_consulta"] + "";

                        //oMedicosE.CodProfMedisyn = (string) dr["cod_prof_medisyn"] + "";
                        break;
                    }

                case 11:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.CodProfMedisyn = (string)dr["cod_prof_medisyn"] + "";
                        oMedicosE.CodTipoConsulta = (string)dr["cod_tipo_consulta"] + "";
                        oMedicosE.DscObservacionSubEspecialidad = dr["dsc_observacion_sub_especialidad"] + "";
                        oMedicosE.DscTituloTarifa = (string)dr["dsc_titulo_tarifa"] + "";
                        oMedicosE.MntTarifaParticular = dr["mnt_tarifa_particular"].ToString();
                        oMedicosE.TipMoneda = (string)dr["tip_moneda"] + "";
                        oMedicosE.TipoConsultaMedica = (string)dr["cod_tipo_consulta"] + "";
                        break;
                    }

                case 12:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.CodProfMedisyn = (string)dr["cod_prof_medisyn"] + "";
                        break;
                    }
                //INI 1.0
                case 13:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.NombreComercial = dr["nombre_comercial"] != DBNull.Value ? (string)dr["nombre_comercial"] : "";
                        oMedicosE.NombresMedico = (string)dr["nombres"] + "";
                        oMedicosE.ColMedico = (string)dr["CMP"] + "";

                        break;
                    }
                //FIN 1.0
                case 14:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.CodProfMedisyn = (string)dr["cod_prof_medisyn"] + "";
                        break;
                    }

                case 15:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.CodProfMedisyn = (string)dr["cod_prof_medisyn"] + "";
                        break;
                    }

                case 17:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        oMedicosE.NombresMedico = (string)(dr["nombres"] + "").Trim();
                        oMedicosE.DocIdentidad = (string)(dr["docidentidad"] + "").Trim();
                        break;
                    }

                case 18:
                    {
                        oMedicosE.CodMedico = (string)dr["codmedico"] + "";
                        break;
                    }
                case 19:
                    {
                        oMedicosE.CodMedico = Convert.ToString(dr["codmedico"]);
                        oMedicosE.NombresMedico = Convert.ToString(dr["nombres"]);
                        oMedicosE.ColMedico = Convert.ToString(dr["colmedico"]);
                        oMedicosE.DocIdentidad = Convert.ToString(dr["docidentidad"]);
                        oMedicosE.Ruc = Convert.ToString(dr["ruc"]);
                        oMedicosE.DscEmail = Convert.ToString(dr["email"]);
                        oMedicosE.DscObservacionSubEspecialidad = Convert.ToString(dr["dsc_observacion_sub_especialidad"]);

                        oMedicosE.FlgTeleConsulta = Convert.ToString(dr["flg_teleconsulta"]);
                        oMedicosE.FlgTeleConsulta = (string)(oMedicosE.FlgTeleConsulta == "" ? "false" : "true");

                        oMedicosE.FlgPresencialJM = Convert.ToString(dr["flg_presencial_jm"]);
                        oMedicosE.FlgPresencialJM = (string)(oMedicosE.FlgPresencialJM == "" ? "false" : "true");

                        oMedicosE.FlgPresencialCM = Convert.ToString(dr["flg_presencial_cm"]);
                        oMedicosE.FlgPresencialCM = (string)(oMedicosE.FlgPresencialCM == "" ? "false" : "true");

                        oMedicosE.FlgPresencialLM = Convert.ToString(dr["flg_presencial_lm"]);
                        oMedicosE.FlgPresencialLM = (string)(oMedicosE.FlgPresencialLM == "" ? "false" : "true");

                        oMedicosE.MntTarifaParticular = Convert.ToString(dr["mnt_tarifa_particular"]);
                        oMedicosE.CodProfMedisyn = Convert.ToString(dr["cod_prof_medisyn"]);
                        oMedicosE.CodTipoConsulta = Convert.ToString(dr["cod_tipo_consulta"]);
                        oMedicosE.TipDocIdentidad = Convert.ToString(dr["tipdocidentidad"]);
                        oMedicosE.DscDocIdentidad = Convert.ToString(dr["Dsc_DocIdentidad"]);
                        oMedicosE.TipoColegio = Convert.ToString(dr["tipocolegio"]);
                        oMedicosE.FechaNacimiento = util.ValFecha(dr["fechanacimiento"].ToString());
                        oMedicosE.Telefono = Convert.ToString(dr["telefono"]);


                        break;
                    }
                case 20:
                    {
                        oMedicosE.CodMedico = Convert.ToString(dr["codmedico"]);
                        oMedicosE.NombresMedico = Convert.ToString(dr["nombres"]);
                        oMedicosE.ColMedico = Convert.ToString(dr["colmedico"]);
                        oMedicosE.DocIdentidad = Convert.ToString(dr["docidentidad"]);
                        oMedicosE.Ruc = Convert.ToString(dr["ruc"]);
                        oMedicosE.DscEmail = Convert.ToString(dr["email"]);
                        oMedicosE.DscObservacionSubEspecialidad = Convert.ToString(dr["dsc_observacion_sub_especialidad"]);

                        oMedicosE.FlgTeleConsulta = Convert.ToString(dr["flg_teleconsulta"]);
                        oMedicosE.FlgTeleConsulta = (string)(oMedicosE.FlgTeleConsulta == "" ? "false" : "true");

                        oMedicosE.FlgPresencialJM = Convert.ToString(dr["flg_presencial_jm"]);
                        oMedicosE.FlgPresencialJM = (string)(oMedicosE.FlgPresencialJM == "" ? "false" : "true");

                        oMedicosE.FlgPresencialCM = Convert.ToString(dr["flg_presencial_cm"]);
                        oMedicosE.FlgPresencialCM = (string)(oMedicosE.FlgPresencialCM == "" ? "false" : "true");

                        oMedicosE.FlgPresencialLM = Convert.ToString(dr["flg_presencial_lm"]);
                        oMedicosE.FlgPresencialLM = (string)(oMedicosE.FlgPresencialLM == "" ? "false" : "true");

                        oMedicosE.MntTarifaParticular = Convert.ToString(dr["mnt_tarifa_particular"]);
                        oMedicosE.CodProfMedisyn = Convert.ToString(dr["cod_prof_medisyn"]);
                        oMedicosE.CodTipoConsulta = Convert.ToString(dr["cod_tipo_consulta"]);
                        oMedicosE.TipDocIdentidad = Convert.ToString(dr["tipdocidentidad"]);
                        oMedicosE.DscDocIdentidad = Convert.ToString(dr["Dsc_DocIdentidad"]);
                        oMedicosE.TipoColegio = Convert.ToString(dr["tipocolegio"]);
                        oMedicosE.FechaNacimiento = util.ValFecha(dr["fechanacimiento"].ToString());
                        oMedicosE.Telefono = Convert.ToString(dr["telefono"]);

                        oMedicosE.TotalPages = util.ValInt(dr["totalpages"].ToString());
                        oMedicosE.Sec = util.ValInt(dr["sec"].ToString());

                        oMedicosE.DscSede = Convert.ToString(dr["dsc_sede"]);
                        oMedicosE.DscEspecialidad = Convert.ToString(dr["dsc_especialidad"]);

                        oMedicosE.Estado = util.ValInt(dr["Estado"].ToString());

                        oMedicosE.NombreComercial = Convert.ToString(dr["nombre_comercial"]);
                        oMedicosE.CampoClinico = Convert.ToString(dr["campo_clinico"]);

                        break;
                    }
                case 21:
                {
                        oMedicosE.CodMedico = Convert.ToString(dr["codmedico"]);
                        oMedicosE.NombresMedico = Convert.ToString(dr["nombres"]);
                        oMedicosE.NombreMedico = Convert.ToString(dr["nombre"]);
                        oMedicosE.ApellidoPaternoMedico= Convert.ToString(dr["appaterno"]);
                        oMedicosE.ApellidoMaternoMedico = Convert.ToString(dr["apmaterno"]);
                        oMedicosE.Ruc = Convert.ToString(dr["ruc"]);
                        oMedicosE.TipoColegio = Convert.ToString(dr["tipocolegio"]);
                        oMedicosE.ColMedico = Convert.ToString(dr["colmedico"]);
                        oMedicosE.CMP = Convert.ToString(dr["CMP"]);
                        oMedicosE.DscEmail= Convert.ToString(dr["email"]);
                        oMedicosE.DscDireccion = Convert.ToString(dr["direccion"]);
                        oMedicosE.TipDocIdentidad = Convert.ToString(dr["tipdocidentidad"]);
                        oMedicosE.DocIdentidad = Convert.ToString(dr["docidentidad"]);
                        oMedicosE.RNE = Convert.ToString(dr["RNE"]);
                        oMedicosE.Telefono = Convert.ToString(dr["telefono"]);
                        oMedicosE.Facturar = Convert.ToInt32(dr["facturar"]);
                        //oMedicosE.CardCode = Convert.ToString(dr["cardcode"]);
                break;
                }
            }
            return oMedicosE;
        }

        //Cmendez 03/06/2022
        public List<MedicosE> Sp_Medicos_ConsultaContratoConsultorios(MedicosE pMedicosE)
        {
            IDataReader dr;
            MedicosE oMedicosE = null/* TODO Change to default(_) if this is not a reference type */;
            List<MedicosE> oListar = new List<MedicosE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_ConsultaContratoConsultorios", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pMedicosE.Buscar);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oMedicosE = LlenarEntidad(dr, pMedicosE.Orden);
                            oListar.Add(oMedicosE);
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


        //Fin

        public List<MedicosE> Sp_Medicos_Consulta(MedicosE pMedicosE)
        {
            IDataReader dr;
            MedicosE oMedicosE = null/* TODO Change to default(_) if this is not a reference type */;
            List<MedicosE> oListar = new List<MedicosE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pMedicosE.Buscar);
                        cmd.Parameters.AddWithValue("@key", pMedicosE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pMedicosE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pMedicosE.Orden);
                        cmd.Parameters.AddWithValue("@parXML", pMedicosE.ParXML);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oMedicosE = LlenarEntidad(dr, pMedicosE.Orden);
                            oListar.Add(oMedicosE);
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

        public List<string> Sp_Medicos_ValidaInsert(string parXML)
        {
            IDataReader dr;
            //MedicosE oMedicosE = null/* TODO Change to default(_) if this is not a reference type */;
            List<string> oListError = new List<string>();
            //List<MedicosE> oListar = new List<MedicosE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_ValidaInsert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@parXML", parXML);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oListError.Add(dr["MsgError"].ToString());
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oListError;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Medicos_Update(MedicosE objMedicosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_Update", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@campo", objMedicosE.Campo);
                        cmd.Parameters.AddWithValue("@codigo", objMedicosE.CodMedico);
                        cmd.Parameters.AddWithValue("@nuevovalor", objMedicosE.NuevoValor);
                        cmd.Parameters.AddWithValue("@usr_modifica", objMedicosE.UsrModifica);
                        cmd.Parameters.AddWithValue("@app_modifica", objMedicosE.AppModifica);
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

        public bool Sp_Medico_Update_Desde_SIC(string pCodMedico)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medico_Update_Desde_SIC", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pCodMedico);
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

        public bool Sp_MedicoPago_Update_Desde_SIC(string pCodMedico)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoPago_Update_Desde_SIC", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pCodMedico);
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

        public bool Sp_MedicoSubEspecialidad_Update_Desde_SIC(string pCodMedico)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoSubEspecialidad_Update_Desde_SIC", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_medico", pCodMedico);
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

        public string Sp_Medicos_Insert()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 8).Direction = ParameterDirection.Output;
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            return cmd.Parameters["@codigo"].Value.ToString();
                        }
                        cnn.Close();
                        cmd.Dispose();
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Medicos_Delete(string pCodMedico)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_Delete", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codigo", pCodMedico);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            return true;
                        }

                        cnn.Close();
                        cmd.Dispose();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RespuestaJsonE Sp_Medicoxfirma_Update(string pCodMedico)
        {
            RespuestaJsonE _respuesta = new RespuestaJsonE();
            SqlCommand cmd = null;
            SqlConnection con = null;
            SqlDataReader dr = null;
            try
            {
                con = new SqlConnection(VariablesGlobales.CnnClinica);
                cmd = new SqlCommand("Sp_Medicoxfirma_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codmedico", pCodMedico);
                cmd.Parameters.Add("@status", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;

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
                    _respuesta.message = "MedicosAD/Sp_Medicoxfirma_Update => " + cmd.Parameters["@message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                _respuesta.exito = false;
                _respuesta.message = "MedicosAD/Sp_Medicoxfirma_Update => " + ex.Message;
            }
            finally
            {
                con.Close();
            }
            return _respuesta;
        }

        public bool Sp_Medicos_GrabaFoto(string pCodMedico, string pFoto, string pNombreFoto)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicosFoto_Graba", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pCodMedico);
                        cmd.Parameters.AddWithValue("@fotomedico", pFoto);
                        cmd.Parameters.AddWithValue("@nombrefoto", pNombreFoto);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        cnn.Close();
                        cmd.Dispose();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_Medicos_Update_Agendamiento(MedicosE pMedicosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_Update_Agendamiento", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pMedicosE.CodMedico);

                        cmd.Parameters.AddWithValue("@cod_prof_medisyn", pMedicosE.CodProfMedisyn);
                        cmd.Parameters.AddWithValue("@cod_tipo_consulta", pMedicosE.CodTipoConsulta);
                        cmd.Parameters.AddWithValue("@flg_teleconsulta", pMedicosE.FlgTeleConsulta);
                        cmd.Parameters.AddWithValue("@flg_presencial_jm", pMedicosE.FlgPresencialJM);
                        cmd.Parameters.AddWithValue("@flg_presencial_cm", pMedicosE.FlgPresencialCM);
                        cmd.Parameters.AddWithValue("@flg_presencial_lm", pMedicosE.FlgPresencialLM);
                        cmd.Parameters.AddWithValue("@mnt_tarifa_particular", pMedicosE.MntTarifaParticular);
                        cmd.Parameters.AddWithValue("@dsc_observacion_sub_especialidad", pMedicosE.DscObservacionSubEspecialidad);
                        cmd.Parameters.AddWithValue("@email", pMedicosE.DscEmail);
                        cmd.Parameters.AddWithValue("@urlweb", pMedicosE.UrlWeb);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool GuardarMedicosMantenimiento(MedicoContratoRequestE pMedicosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_med_contrato_alquiler_Insert", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_contrato", pMedicosE.ide_contrato);
                        cmd.Parameters.AddWithValue("@cod_medico", pMedicosE.cod_medico);
                        cmd.Parameters.AddWithValue("@cod_sede", pMedicosE.cod_sede);
                        cmd.Parameters.AddWithValue("@flg_forma_pago", pMedicosE.flg_forma_pago);
                        cmd.Parameters.AddWithValue("@mnt_mensual", pMedicosE.mnt_mensual);
                        cmd.Parameters.AddWithValue("@fec_inicio", pMedicosE.fec_inicio);
                        cmd.Parameters.AddWithValue("@fec_fin", pMedicosE.fec_fin);
                        cmd.Parameters.AddWithValue("@fec_registro", pMedicosE.fec_registro);
                        cmd.Parameters.AddWithValue("@usr_registro", pMedicosE.usr_registro);
                        cmd.Parameters.AddWithValue("@flg_estado", pMedicosE.flg_estado);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Sp_Medicos_ConsultaFoto(string pcodmedico)
        {
            IDataReader dr;
            //MedicosE oMedicosE = null/* TODO Change to default(_) if this is not a reference type */;
            //List<MedicosE> oListar = new List<MedicosE>();
            string fotomedico = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Medicos_ConsultaFoto", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@codmedico", pcodmedico);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            fotomedico = dr["fotomedico"].ToString();
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return fotomedico;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MedicosE> Sp_EmpresaMedico_Consulta(MedicosE pMedicosE)
        {
            IDataReader dr;
            MedicosE oMedicosE = null/* TODO Change to default(_) if this is not a reference type */;
            List<MedicosE> oListar = new List<MedicosE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_EmpresaMedico_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pMedicosE.Buscar);
                        cmd.Parameters.AddWithValue("@key", pMedicosE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pMedicosE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pMedicosE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oMedicosE = LlenarEntidad(dr, 2);
                            oListar.Add(oMedicosE);
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

        public List<MedicoWebE> Sp_MedicosWeb_Consulta()
        {
            IDataReader dr;
            List<MedicoWebE> oListMedicoWebE = new List<MedicoWebE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoWeb_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            MedicoWebE oMedicoWebE = new MedicoWebE();
                            oMedicoWebE.idm = (int)dr["idm"] ;
                            oMedicoWebE.nombres_apellidos = (string)dr["nombres_apellidos"] + "";
                            oMedicoWebE.especialidad = (string)dr["especialidad"] + "";
                            oMedicoWebE.subespecialidad = (string)dr["subespecialidad"] + "";
                            oMedicoWebE.img_medico = (string)dr["img_medico"] + "";
                            oMedicoWebE.online = (int)dr["online"] ;
                            oMedicoWebE.sedes_atencion = (string)dr["sedes_atencion"] + "";
                            oMedicoWebE.palabra_clave = (string)dr["palabra_clave"] + "";//1.0
                            oMedicoWebE.url_medico = (string)dr["url_medico"] + "";//1.0
                            oListMedicoWebE.Add(oMedicoWebE);
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oListMedicoWebE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public MedicoDetalleWebE Sp_MedicoWeb_Detalle_Consulta(int pidm)
        {
            IDataReader dr;
            MedicoDetalleWebE oMedicoDetalleWebE = new MedicoDetalleWebE(); 
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoWeb_Detalle_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@idm", pidm);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oMedicoDetalleWebE.idm = (int)dr["idm"];
                            oMedicoDetalleWebE.nombres = (string)dr["nombres"] + "";
                            oMedicoDetalleWebE.apellidos = (string)dr["apellidos"] + "";
                            oMedicoDetalleWebE.especialidad = (string)dr["especialidad"] + "";
                            oMedicoDetalleWebE.subespecialidad = (string)dr["subespecialidad"] + "";
                            oMedicoDetalleWebE.tipo_atencion = (string)dr["tipo_atencion"] + "";
                            oMedicoDetalleWebE.sedes_atencion = (string)dr["sedes_atencion"] + "";
                            oMedicoDetalleWebE.img_medico = (string)dr["img_medico"] + "";
                            oMedicoDetalleWebE.mas_informacion = (string)dr["mas_informacion"] + "";
                            oMedicoDetalleWebE.trayectoria_formacion = (string)dr["trayectoria_formacion"] + "";
                            oMedicoDetalleWebE.areas_interes = (string)dr["areas_interes"] + "";
                            oMedicoDetalleWebE.online = (int)dr["online"];
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oMedicoDetalleWebE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //1.0 INI
        public MedicoDetalleWebE Sp_MedicoWeb_Detalle_ConsultaV2(string url_medico)
        {
            IDataReader dr;
            MedicoDetalleWebE oMedicoDetalleWebE = new MedicoDetalleWebE();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoWeb_Detalle_ConsultaV2", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@url_medico", url_medico);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oMedicoDetalleWebE.idm = (int)dr["idm"];
                            oMedicoDetalleWebE.nombres = (string)dr["nombres"] + "";
                            oMedicoDetalleWebE.apellidos = (string)dr["apellidos"] + "";
                            oMedicoDetalleWebE.especialidad = (string)dr["especialidad"] + "";
                            oMedicoDetalleWebE.subespecialidad = (string)dr["subespecialidad"] + "";
                            oMedicoDetalleWebE.tipo_atencion = (string)dr["tipo_atencion"] + "";
                            oMedicoDetalleWebE.sedes_atencion = (string)dr["sedes_atencion"] + "";
                            oMedicoDetalleWebE.img_medico = (string)dr["img_medico"] + "";
                            oMedicoDetalleWebE.mas_informacion = (string)dr["mas_informacion"] + "";
                            oMedicoDetalleWebE.trayectoria_formacion = (string)dr["trayectoria_formacion"] + "";
                            oMedicoDetalleWebE.areas_interes = (string)dr["areas_interes"] + "";
                            oMedicoDetalleWebE.online = (int)dr["online"];
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oMedicoDetalleWebE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //1.0 FIN
        public List<EspecialidadWebE> Sp_EspecialidadWeb_Consulta()
        {
            IDataReader dr;
            List<EspecialidadWebE> lstEspecialidadWebE = new List<EspecialidadWebE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_EspecialidadWeb_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            EspecialidadWebE oEspecialidadWebE = new EspecialidadWebE();
                            oEspecialidadWebE.idesp = (int)dr["idesp"];
                            oEspecialidadWebE.especialidad = (string)dr["especialidad"] + "";
                            oEspecialidadWebE.subespecialidad = (string)dr["subespecialidad"] + "";
                            lstEspecialidadWebE.Add(oEspecialidadWebE);
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return lstEspecialidadWebE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EspecialidadDetalleWebE> Sp_EspecialidadDetalleWeb_Consulta(int pesp)
        {
            IDataReader dr;
            List<EspecialidadDetalleWebE> lstEspecialidadDetalleWebE = new List<EspecialidadDetalleWebE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_EspecialidadDetalleWeb_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pesp", pesp);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            EspecialidadDetalleWebE oEspecialidadWebE = new EspecialidadDetalleWebE();
                            oEspecialidadWebE.especialidad = (string)dr["especialidad"] + "";
                            oEspecialidadWebE.sede_atencion = (string)dr["sede_atencion"] + "";
                            lstEspecialidadDetalleWebE.Add(oEspecialidadWebE);
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return lstEspecialidadDetalleWebE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string Sp_MedicoWeb_Usuario(string usuario, string password)
        {
            IDataReader dr;
            string resultado = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_MedicoWeb_Usuario", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            resultado = (string)dr["resultado"] + "";
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return resultado;
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
