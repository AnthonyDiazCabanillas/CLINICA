using Ent.Sql.ClinicaE.RisE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RisAD
{
    public class RisOracleRisXmlEventsAmbulatorioAD
    {
        private RisOracleRisXmlEventsAmbulatorioE LlenarEntidad(IDataReader dr,
                                  RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            RisOracleRisXmlEventsAmbulatorioE oRisOracleRisXmlEventsAmbulatorioE = new RisOracleRisXmlEventsAmbulatorioE();
            switch (pRisOracleRisXmlEventsAmbulatorioE.Orden)
            {
                case 1:
                    oRisOracleRisXmlEventsAmbulatorioE.FlagProcesado = Convert.ToString(dr["flag_procesado"]);
                    oRisOracleRisXmlEventsAmbulatorioE.CodEmpresa = Convert.ToInt32(dr["cod_empresa"]);
                    oRisOracleRisXmlEventsAmbulatorioE.CodSucursal = Convert.ToInt32(dr["cod_sucursal"]);
                    oRisOracleRisXmlEventsAmbulatorioE.EventId = Convert.ToString(dr["event_id"]);
                    oRisOracleRisXmlEventsAmbulatorioE.EventDesc = Convert.ToString(dr["event_desc"]);
                    oRisOracleRisXmlEventsAmbulatorioE.EventDatetime = Convert.ToString(dr["event_datetime"]);
                    oRisOracleRisXmlEventsAmbulatorioE.EventTypeId = Convert.ToInt32(dr["event_type_id"]);
                    oRisOracleRisXmlEventsAmbulatorioE.OrderStatus = Convert.ToString(dr["order_status"]);
                    oRisOracleRisXmlEventsAmbulatorioE.IdPaciente = Convert.ToString(dr["id_paciente"]);
                    oRisOracleRisXmlEventsAmbulatorioE.IdPacienteRis = Convert.ToString(dr["id_paciente_ris"]);
                    oRisOracleRisXmlEventsAmbulatorioE.RutPaciente = Convert.ToString(dr["rut_paciente"]);
                    oRisOracleRisXmlEventsAmbulatorioE.TipoPaciente = Convert.ToString(dr["tipo_paciente"]);
                    oRisOracleRisXmlEventsAmbulatorioE.IdAdmision = Convert.ToInt32(dr["id_admision"]);
                    oRisOracleRisXmlEventsAmbulatorioE.IdIngreso = Convert.ToInt32(dr["id_ingreso"]);
                    oRisOracleRisXmlEventsAmbulatorioE.IdAtencion = Convert.ToInt32(dr["id_atencion"]);
                    oRisOracleRisXmlEventsAmbulatorioE.CodPaquete = Convert.ToInt32(dr["cod_paquete"]);
                    oRisOracleRisXmlEventsAmbulatorioE.FillerOrderNumber = Convert.ToString(dr["filler_order_number"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlMsg = Convert.ToString(dr["xml_msg"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlIntegrationDate = Convert.ToString(dr["xml_integration_date"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlEventStatus = Convert.ToString(dr["xml_event_status"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlMessageStatus = Convert.ToString(dr["xml_message_status"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlUserUpdated = Convert.ToString(dr["xml_user_updated"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlFlag1 = Convert.ToString(dr["xml_flag1"]);
                    oRisOracleRisXmlEventsAmbulatorioE.Version = Convert.ToInt32(dr["version"]);
                    oRisOracleRisXmlEventsAmbulatorioE.FecTrama = Convert.ToString(dr["fec_trama"]);
                    oRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio = Convert.ToInt32(dr["codris_ambulatorio"]);
                    break;
                case 2:
                    oRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio = Convert.ToInt32(dr["codris_ambulatorio"]);
                    oRisOracleRisXmlEventsAmbulatorioE.XmlMsg = Convert.ToString(dr["xml_msg"]);
                    oRisOracleRisXmlEventsAmbulatorioE.IdPaciente = Convert.ToString(dr["id_paciente"]);
                    oRisOracleRisXmlEventsAmbulatorioE.RutPaciente = Convert.ToString(dr["rut_paciente"]);
                    oRisOracleRisXmlEventsAmbulatorioE.Version = Convert.ToInt32(dr["version"]);
                    oRisOracleRisXmlEventsAmbulatorioE.EventTypeId = Convert.ToInt32(dr["event_type_id"]);
                    break;
            }

            return oRisOracleRisXmlEventsAmbulatorioE;
        }

        public List<RisOracleRisXmlEventsAmbulatorioE> Sp_RisOracleRisXmlEventsAmbulatorio_Consulta(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            List<RisOracleRisXmlEventsAmbulatorioE> oListar = new List<RisOracleRisXmlEventsAmbulatorioE>();
            RisOracleRisXmlEventsAmbulatorioE oRisOracleRisXmlEventsAmbulatorioE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsAmbulatorio_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@codris_ambulatorio", pRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio);
                    cmd.Parameters.AddWithValue("@buscar", pRisOracleRisXmlEventsAmbulatorioE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pRisOracleRisXmlEventsAmbulatorioE.Campo);
                    cmd.Parameters.AddWithValue("@numerofilas", pRisOracleRisXmlEventsAmbulatorioE.NumeroFilas);
                    cmd.Parameters.AddWithValue("@orden", pRisOracleRisXmlEventsAmbulatorioE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisOracleRisXmlEventsAmbulatorioE = LlenarEntidad(dr, pRisOracleRisXmlEventsAmbulatorioE);
                        oListar.Add(oRisOracleRisXmlEventsAmbulatorioE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_RisOracleRisXmlEventsAmbulatorio_Insert(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsAmbulatorio_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@flag_procesado", pRisOracleRisXmlEventsAmbulatorioE.FlagProcesado);
                        cmd.Parameters.AddWithValue("@cod_empresa", pRisOracleRisXmlEventsAmbulatorioE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@cod_sucursal", pRisOracleRisXmlEventsAmbulatorioE.CodSucursal);
                        cmd.Parameters.AddWithValue("@event_id", pRisOracleRisXmlEventsAmbulatorioE.EventId);
                        cmd.Parameters.AddWithValue("@event_desc", pRisOracleRisXmlEventsAmbulatorioE.EventDesc);
                        cmd.Parameters.AddWithValue("@event_datetime", pRisOracleRisXmlEventsAmbulatorioE.EventDatetime);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisOracleRisXmlEventsAmbulatorioE.EventTypeId);
                        cmd.Parameters.AddWithValue("@order_status", pRisOracleRisXmlEventsAmbulatorioE.OrderStatus);
                        cmd.Parameters.AddWithValue("@id_paciente", pRisOracleRisXmlEventsAmbulatorioE.IdPaciente);
                        cmd.Parameters.AddWithValue("@id_paciente_ris", pRisOracleRisXmlEventsAmbulatorioE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@rut_paciente", pRisOracleRisXmlEventsAmbulatorioE.RutPaciente);
                        cmd.Parameters.AddWithValue("@tipo_paciente", pRisOracleRisXmlEventsAmbulatorioE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@id_admision", pRisOracleRisXmlEventsAmbulatorioE.IdAdmision);
                        cmd.Parameters.AddWithValue("@id_ingreso", pRisOracleRisXmlEventsAmbulatorioE.IdIngreso);
                        cmd.Parameters.AddWithValue("@id_atencion", pRisOracleRisXmlEventsAmbulatorioE.IdAtencion);
                        cmd.Parameters.AddWithValue("@cod_paquete", pRisOracleRisXmlEventsAmbulatorioE.CodPaquete);
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisOracleRisXmlEventsAmbulatorioE.FillerOrderNumber);
                        cmd.Parameters.AddWithValue("@xml_msg", pRisOracleRisXmlEventsAmbulatorioE.XmlMsg);
                        cmd.Parameters.AddWithValue("@xml_integration_date", pRisOracleRisXmlEventsAmbulatorioE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@xml_event_status", pRisOracleRisXmlEventsAmbulatorioE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@xml_message_status", pRisOracleRisXmlEventsAmbulatorioE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@xml_user_updated", pRisOracleRisXmlEventsAmbulatorioE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@xml_flag1", pRisOracleRisXmlEventsAmbulatorioE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@version", pRisOracleRisXmlEventsAmbulatorioE.Version);
                        cmd.Parameters.AddWithValue("@fec_trama", pRisOracleRisXmlEventsAmbulatorioE.FecTrama);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codris_ambulatorio", ParameterDirection.InputOutput, SqlDbType.Int, 8, pRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio = Convert.ToInt32(cmd.Parameters["@codris_ambulatorio"].Value);
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


        public bool Sp_RisOracleRisXmlEventsAmbulatorio_Update(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsAmbulatorio_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@flag_procesado", pRisOracleRisXmlEventsAmbulatorioE.FlagProcesado);
                        cmd.Parameters.AddWithValue("@cod_empresa", pRisOracleRisXmlEventsAmbulatorioE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@cod_sucursal", pRisOracleRisXmlEventsAmbulatorioE.CodSucursal);
                        cmd.Parameters.AddWithValue("@event_id", pRisOracleRisXmlEventsAmbulatorioE.EventId);
                        cmd.Parameters.AddWithValue("@event_desc", pRisOracleRisXmlEventsAmbulatorioE.EventDesc);
                        cmd.Parameters.AddWithValue("@event_datetime", pRisOracleRisXmlEventsAmbulatorioE.EventDatetime);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisOracleRisXmlEventsAmbulatorioE.EventTypeId);
                        cmd.Parameters.AddWithValue("@order_status", pRisOracleRisXmlEventsAmbulatorioE.OrderStatus);
                        cmd.Parameters.AddWithValue("@id_paciente", pRisOracleRisXmlEventsAmbulatorioE.IdPaciente);
                        cmd.Parameters.AddWithValue("@id_paciente_ris", pRisOracleRisXmlEventsAmbulatorioE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@rut_paciente", pRisOracleRisXmlEventsAmbulatorioE.RutPaciente);
                        cmd.Parameters.AddWithValue("@tipo_paciente", pRisOracleRisXmlEventsAmbulatorioE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@id_admision", pRisOracleRisXmlEventsAmbulatorioE.IdAdmision);
                        cmd.Parameters.AddWithValue("@id_ingreso", pRisOracleRisXmlEventsAmbulatorioE.IdIngreso);
                        cmd.Parameters.AddWithValue("@id_atencion", pRisOracleRisXmlEventsAmbulatorioE.IdAtencion);
                        cmd.Parameters.AddWithValue("@cod_paquete", pRisOracleRisXmlEventsAmbulatorioE.CodPaquete);
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisOracleRisXmlEventsAmbulatorioE.FillerOrderNumber);
                        cmd.Parameters.AddWithValue("@xml_msg", pRisOracleRisXmlEventsAmbulatorioE.XmlMsg);
                        cmd.Parameters.AddWithValue("@xml_integration_date", pRisOracleRisXmlEventsAmbulatorioE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@xml_event_status", pRisOracleRisXmlEventsAmbulatorioE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@xml_message_status", pRisOracleRisXmlEventsAmbulatorioE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@xml_user_updated", pRisOracleRisXmlEventsAmbulatorioE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@xml_flag1", pRisOracleRisXmlEventsAmbulatorioE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@version", pRisOracleRisXmlEventsAmbulatorioE.Version);
                        cmd.Parameters.AddWithValue("@fec_trama", pRisOracleRisXmlEventsAmbulatorioE.FecTrama);
                        cmd.Parameters.AddWithValue("@codris_ambulatorio", pRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio);
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


        public bool Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_ambulatorio", pRisOracleRisXmlEventsAmbulatorioE.CodrisAmbulatorio);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisOracleRisXmlEventsAmbulatorioE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisOracleRisXmlEventsAmbulatorioE.Campo);
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