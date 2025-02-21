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
    public class RisOracleRisXmlEventsCompletadoAD
    {
        private RisOracleRisXmlEventsCompletadoE LlenarEntidad(IDataReader dr,
                                  RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            RisOracleRisXmlEventsCompletadoE oRisOracleRisXmlEventsCompletadoE = new RisOracleRisXmlEventsCompletadoE();
            switch (pRisOracleRisXmlEventsCompletadoE.Orden)
            {
                case 1:
                    oRisOracleRisXmlEventsCompletadoE.FlagProcesado = Convert.ToString(dr["flag_procesado"]);
                    oRisOracleRisXmlEventsCompletadoE.CodEmpresa = Convert.ToInt32(dr["cod_empresa"]);
                    oRisOracleRisXmlEventsCompletadoE.CodSucursal = Convert.ToInt32(dr["cod_sucursal"]);
                    oRisOracleRisXmlEventsCompletadoE.EventId = Convert.ToString(dr["event_id"]);
                    oRisOracleRisXmlEventsCompletadoE.EventDesc = Convert.ToString(dr["event_desc"]);
                    oRisOracleRisXmlEventsCompletadoE.EventDatetime = Convert.ToString(dr["event_datetime"]);
                    oRisOracleRisXmlEventsCompletadoE.EventTypeId = Convert.ToInt32(dr["event_type_id"]);
                    oRisOracleRisXmlEventsCompletadoE.OrderStatus = Convert.ToString(dr["order_status"]);
                    oRisOracleRisXmlEventsCompletadoE.IdPaciente = Convert.ToString(dr["id_paciente"]);
                    oRisOracleRisXmlEventsCompletadoE.IdPacienteRis = Convert.ToString(dr["id_paciente_ris"]);
                    oRisOracleRisXmlEventsCompletadoE.RutPaciente = Convert.ToString(dr["rut_paciente"]);
                    oRisOracleRisXmlEventsCompletadoE.TipoPaciente = Convert.ToString(dr["tipo_paciente"]);
                    oRisOracleRisXmlEventsCompletadoE.IdAdmision = Convert.ToInt32(dr["id_admision"]);
                    oRisOracleRisXmlEventsCompletadoE.IdIngreso = Convert.ToInt32(dr["id_ingreso"]);
                    oRisOracleRisXmlEventsCompletadoE.IdAtencion = Convert.ToInt32(dr["id_atencion"]);
                    oRisOracleRisXmlEventsCompletadoE.CodPaquete = Convert.ToInt32(dr["cod_paquete"]);
                    oRisOracleRisXmlEventsCompletadoE.FillerOrderNumber = Convert.ToString(dr["filler_order_number"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlMsg = Convert.ToString(dr["xml_msg"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlIntegrationDate = Convert.ToString(dr["xml_integration_date"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlEventStatus = Convert.ToString(dr["xml_event_status"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlMessageStatus = Convert.ToString(dr["xml_message_status"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlUserUpdated = Convert.ToString(dr["xml_user_updated"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlFlag1 = Convert.ToString(dr["xml_flag1"]);
                    oRisOracleRisXmlEventsCompletadoE.CodrisCompletado = Convert.ToInt32(dr["codris_completado"]);
                    break;

                case 2:
                    oRisOracleRisXmlEventsCompletadoE.CodrisCompletado = Convert.ToInt32(dr["codris_completado"]);
                    oRisOracleRisXmlEventsCompletadoE.XmlMsg = Convert.ToString(dr["xml_msg"]);
                    oRisOracleRisXmlEventsCompletadoE.IdPaciente = Convert.ToString(dr["id_paciente"]);
                    oRisOracleRisXmlEventsCompletadoE.RutPaciente = Convert.ToString(dr["rut_paciente"]);
                    break;
            }

            return oRisOracleRisXmlEventsCompletadoE;
        }

        public List<RisOracleRisXmlEventsCompletadoE> Sp_RisOracleRisXmlEventsCompletado_Consulta(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            List<RisOracleRisXmlEventsCompletadoE> oListar = new List<RisOracleRisXmlEventsCompletadoE>();
            RisOracleRisXmlEventsCompletadoE oRisOracleRisXmlEventsCompletadoE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsCompletado_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@codris_completado", pRisOracleRisXmlEventsCompletadoE.CodrisCompletado);
                    cmd.Parameters.AddWithValue("@buscar", pRisOracleRisXmlEventsCompletadoE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pRisOracleRisXmlEventsCompletadoE.Campo);
                    cmd.Parameters.AddWithValue("@numerofilas", pRisOracleRisXmlEventsCompletadoE.NumeroFilas);
                    cmd.Parameters.AddWithValue("@orden", pRisOracleRisXmlEventsCompletadoE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisOracleRisXmlEventsCompletadoE = LlenarEntidad(dr, pRisOracleRisXmlEventsCompletadoE);
                        oListar.Add(oRisOracleRisXmlEventsCompletadoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_RisOracleRisXmlEventsCompletado_Insert(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsCompletado_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@flag_procesado", pRisOracleRisXmlEventsCompletadoE.FlagProcesado);
                        cmd.Parameters.AddWithValue("@cod_empresa", pRisOracleRisXmlEventsCompletadoE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@cod_sucursal", pRisOracleRisXmlEventsCompletadoE.CodSucursal);
                        cmd.Parameters.AddWithValue("@event_id", pRisOracleRisXmlEventsCompletadoE.EventId);
                        cmd.Parameters.AddWithValue("@event_desc", pRisOracleRisXmlEventsCompletadoE.EventDesc);
                        cmd.Parameters.AddWithValue("@event_datetime", pRisOracleRisXmlEventsCompletadoE.EventDatetime);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisOracleRisXmlEventsCompletadoE.EventTypeId);
                        cmd.Parameters.AddWithValue("@order_status", pRisOracleRisXmlEventsCompletadoE.OrderStatus);
                        cmd.Parameters.AddWithValue("@id_paciente", pRisOracleRisXmlEventsCompletadoE.IdPaciente);
                        cmd.Parameters.AddWithValue("@id_paciente_ris", pRisOracleRisXmlEventsCompletadoE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@rut_paciente", pRisOracleRisXmlEventsCompletadoE.RutPaciente);
                        cmd.Parameters.AddWithValue("@tipo_paciente", pRisOracleRisXmlEventsCompletadoE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@id_admision", pRisOracleRisXmlEventsCompletadoE.IdAdmision);
                        cmd.Parameters.AddWithValue("@id_ingreso", pRisOracleRisXmlEventsCompletadoE.IdIngreso);
                        cmd.Parameters.AddWithValue("@id_atencion", pRisOracleRisXmlEventsCompletadoE.IdAtencion);
                        cmd.Parameters.AddWithValue("@cod_paquete", pRisOracleRisXmlEventsCompletadoE.CodPaquete);
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisOracleRisXmlEventsCompletadoE.FillerOrderNumber);
                        cmd.Parameters.AddWithValue("@xml_msg", pRisOracleRisXmlEventsCompletadoE.XmlMsg);
                        cmd.Parameters.AddWithValue("@xml_integration_date", pRisOracleRisXmlEventsCompletadoE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@xml_event_status", pRisOracleRisXmlEventsCompletadoE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@xml_message_status", pRisOracleRisXmlEventsCompletadoE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@xml_user_updated", pRisOracleRisXmlEventsCompletadoE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@xml_flag1", pRisOracleRisXmlEventsCompletadoE.XmlFlag1);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codris_completado", ParameterDirection.InputOutput, SqlDbType.Int, 8, pRisOracleRisXmlEventsCompletadoE.CodrisCompletado.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pRisOracleRisXmlEventsCompletadoE.CodrisCompletado = Convert.ToInt32(cmd.Parameters["@codris_completado"].Value);
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


        public bool Sp_RisOracleRisXmlEventsCompletado_Update(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsCompletado_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@flag_procesado", pRisOracleRisXmlEventsCompletadoE.FlagProcesado);
                        cmd.Parameters.AddWithValue("@cod_empresa", pRisOracleRisXmlEventsCompletadoE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@cod_sucursal", pRisOracleRisXmlEventsCompletadoE.CodSucursal);
                        cmd.Parameters.AddWithValue("@event_id", pRisOracleRisXmlEventsCompletadoE.EventId);
                        cmd.Parameters.AddWithValue("@event_desc", pRisOracleRisXmlEventsCompletadoE.EventDesc);
                        cmd.Parameters.AddWithValue("@event_datetime", pRisOracleRisXmlEventsCompletadoE.EventDatetime);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisOracleRisXmlEventsCompletadoE.EventTypeId);
                        cmd.Parameters.AddWithValue("@order_status", pRisOracleRisXmlEventsCompletadoE.OrderStatus);
                        cmd.Parameters.AddWithValue("@id_paciente", pRisOracleRisXmlEventsCompletadoE.IdPaciente);
                        cmd.Parameters.AddWithValue("@id_paciente_ris", pRisOracleRisXmlEventsCompletadoE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@rut_paciente", pRisOracleRisXmlEventsCompletadoE.RutPaciente);
                        cmd.Parameters.AddWithValue("@tipo_paciente", pRisOracleRisXmlEventsCompletadoE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@id_admision", pRisOracleRisXmlEventsCompletadoE.IdAdmision);
                        cmd.Parameters.AddWithValue("@id_ingreso", pRisOracleRisXmlEventsCompletadoE.IdIngreso);
                        cmd.Parameters.AddWithValue("@id_atencion", pRisOracleRisXmlEventsCompletadoE.IdAtencion);
                        cmd.Parameters.AddWithValue("@cod_paquete", pRisOracleRisXmlEventsCompletadoE.CodPaquete);
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisOracleRisXmlEventsCompletadoE.FillerOrderNumber);
                        cmd.Parameters.AddWithValue("@xml_msg", pRisOracleRisXmlEventsCompletadoE.XmlMsg);
                        cmd.Parameters.AddWithValue("@xml_integration_date", pRisOracleRisXmlEventsCompletadoE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@xml_event_status", pRisOracleRisXmlEventsCompletadoE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@xml_message_status", pRisOracleRisXmlEventsCompletadoE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@xml_user_updated", pRisOracleRisXmlEventsCompletadoE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@xml_flag1", pRisOracleRisXmlEventsCompletadoE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@codris_completado", pRisOracleRisXmlEventsCompletadoE.CodrisCompletado);
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


        public bool Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codris_completado", pRisOracleRisXmlEventsCompletadoE.CodrisCompletado);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisOracleRisXmlEventsCompletadoE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisOracleRisXmlEventsCompletadoE.Campo);
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