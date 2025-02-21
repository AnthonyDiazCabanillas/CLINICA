using Ent.Sql.ClinicaE.RisE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.LogisticaE.ConveniosE;

namespace Dat.Sql.ClinicaAD.RisAD
{
    public class RisOracleRisXmlEventsAD
    {

        private RisOracleRisXmlEventsE LlenarEntidad(IDataReader dr,
                                  RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            RisOracleRisXmlEventsE oRisOracleRisXmlEventsE = new RisOracleRisXmlEventsE();
            switch (pRisOracleRisXmlEventsE.Orden)
            {
                case 1:
                    oRisOracleRisXmlEventsE.CodEmpresa = Convert.ToInt32(dr["cod_empresa"]);
                    oRisOracleRisXmlEventsE.CodSucursal = Convert.ToInt32(dr["cod_sucursal"]);
                    oRisOracleRisXmlEventsE.EventId = Convert.ToString(dr["event_id"]);
                    oRisOracleRisXmlEventsE.EventDesc = Convert.ToString(dr["event_desc"]);
                    oRisOracleRisXmlEventsE.EventDatetime = Convert.ToString(dr["event_datetime"]);
                    oRisOracleRisXmlEventsE.EventTypeId = Convert.ToInt32(dr["event_type_id"]);
                    oRisOracleRisXmlEventsE.OrderStatus = Convert.ToString(dr["order_status"]);
                    oRisOracleRisXmlEventsE.IdPaciente = Convert.ToString(dr["id_paciente"]);
                    oRisOracleRisXmlEventsE.IdPacienteRis = Convert.ToString(dr["id_paciente_ris"]);
                    oRisOracleRisXmlEventsE.RutPaciente = Convert.ToString(dr["rut_paciente"]);
                    oRisOracleRisXmlEventsE.TipoPaciente = Convert.ToString(dr["tipo_paciente"]);
                    oRisOracleRisXmlEventsE.IdAdmision = Convert.ToInt32(dr["id_admision"]);
                    oRisOracleRisXmlEventsE.IdIngreso = Convert.ToInt32(dr["id_ingreso"]);
                    oRisOracleRisXmlEventsE.IdAtencion = Convert.ToInt32(dr["id_atencion"]);
                    oRisOracleRisXmlEventsE.CodPaquete = Convert.ToInt32(dr["cod_paquete"]);
                    oRisOracleRisXmlEventsE.FillerOrderNumber = Convert.ToString(dr["filler_order_number"]);
                    oRisOracleRisXmlEventsE.XmlMsg = Convert.ToString(dr["xml_msg"]);
                    oRisOracleRisXmlEventsE.XmlIntegrationDate = Convert.ToString(dr["xml_integration_date"]);
                    oRisOracleRisXmlEventsE.XmlEventStatus = Convert.ToString(dr["xml_event_status"]);
                    oRisOracleRisXmlEventsE.XmlMessageStatus = Convert.ToString(dr["xml_message_status"]);
                    oRisOracleRisXmlEventsE.XmlUserUpdated = Convert.ToString(dr["xml_user_updated"]);
                    oRisOracleRisXmlEventsE.XmlFlag1 = Convert.ToString(dr["xml_flag1"]);
                    oRisOracleRisXmlEventsE.Fechahoraregistro = Convert.ToString(dr["FechaHoraRegistro"]);
                    oRisOracleRisXmlEventsE.Version = Convert.ToInt32(dr["version"]);
                    oRisOracleRisXmlEventsE.FecTrama = Convert.ToString(dr["fec_trama"]);
                    break;
                case 2:
                    oRisOracleRisXmlEventsE.CodEmpresa = Convert.ToInt32(dr["cod_empresa"]);
                    oRisOracleRisXmlEventsE.CodSucursal = Convert.ToInt32(dr["cod_sucursal"]);
                    oRisOracleRisXmlEventsE.EventId = Convert.ToString(dr["event_id"]);
                    oRisOracleRisXmlEventsE.EventDesc = Convert.ToString(dr["event_desc"]);
                    oRisOracleRisXmlEventsE.EventDatetime = Convert.ToString(dr["event_datetime"]);
                    oRisOracleRisXmlEventsE.EventTypeId = Convert.ToInt32(dr["event_type_id"]);
                    oRisOracleRisXmlEventsE.OrderStatus = Convert.ToString(dr["order_status"]);
                    oRisOracleRisXmlEventsE.IdPaciente = Convert.ToString(dr["id_paciente"]);
                    oRisOracleRisXmlEventsE.IdPacienteRis = Convert.ToString(dr["id_paciente_ris"]);
                    oRisOracleRisXmlEventsE.RutPaciente = Convert.ToString(dr["rut_paciente"]);
                    oRisOracleRisXmlEventsE.TipoPaciente = Convert.ToString(dr["tipo_paciente"]);
                    oRisOracleRisXmlEventsE.IdAdmision = Convert.ToInt32(dr["id_admision"]);
                    oRisOracleRisXmlEventsE.IdIngreso = Convert.ToInt32(dr["id_ingreso"]);
                    oRisOracleRisXmlEventsE.IdAtencion = Convert.ToInt32(dr["id_atencion"]);
                    oRisOracleRisXmlEventsE.CodPaquete = Convert.ToInt32(dr["cod_paquete"]);
                    oRisOracleRisXmlEventsE.FillerOrderNumber = Convert.ToString(dr["filler_order_number"]);
                    oRisOracleRisXmlEventsE.XmlMsg = Convert.ToString(dr["xml_msg"]);
                    oRisOracleRisXmlEventsE.XmlIntegrationDate = Convert.ToString(dr["xml_integration_date"]);
                    oRisOracleRisXmlEventsE.XmlEventStatus = Convert.ToString(dr["xml_event_status"]);
                    oRisOracleRisXmlEventsE.XmlMessageStatus = Convert.ToString(dr["xml_message_status"]);
                    oRisOracleRisXmlEventsE.XmlUserUpdated = Convert.ToString(dr["xml_user_updated"]);
                    oRisOracleRisXmlEventsE.XmlFlag1 = Convert.ToString(dr["xml_flag1"]);
                    oRisOracleRisXmlEventsE.Fechahoraregistro = Convert.ToString(dr["FechaHoraRegistro"]);
                    oRisOracleRisXmlEventsE.Version = Convert.ToInt32(dr["version"]);
                    oRisOracleRisXmlEventsE.FecTrama = Convert.ToString(dr["fec_trama"]);
                    break;
            }

            return oRisOracleRisXmlEventsE;
        }

        public List<RisOracleRisXmlEventsE> Sp_RisOracleRisXmlEvents_Consulta(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            List<RisOracleRisXmlEventsE> oListar = new List<RisOracleRisXmlEventsE>();
            RisOracleRisXmlEventsE oRisOracleRisXmlEventsE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEvents_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@fillerordernumber", pRisOracleRisXmlEventsE.FillerOrderNumber);
                    cmd.Parameters.AddWithValue("@eventtypeid", pRisOracleRisXmlEventsE.EventTypeId);
                    cmd.Parameters.AddWithValue("@buscar", pRisOracleRisXmlEventsE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pRisOracleRisXmlEventsE.Campo);
                    cmd.Parameters.AddWithValue("@numerofilas", pRisOracleRisXmlEventsE.NumeroFila);
                    cmd.Parameters.AddWithValue("@orden", pRisOracleRisXmlEventsE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisOracleRisXmlEventsE = LlenarEntidad(dr, pRisOracleRisXmlEventsE);
                        oListar.Add(oRisOracleRisXmlEventsE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public int Sp_RisOracleRisXmlEvents_Insert(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEvents_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_empresa", pRisOracleRisXmlEventsE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@cod_sucursal", pRisOracleRisXmlEventsE.CodSucursal);
                        cmd.Parameters.AddWithValue("@event_id", pRisOracleRisXmlEventsE.EventId);
                        cmd.Parameters.AddWithValue("@event_desc", pRisOracleRisXmlEventsE.EventDesc);
                        cmd.Parameters.AddWithValue("@event_datetime", pRisOracleRisXmlEventsE.EventDatetime);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisOracleRisXmlEventsE.EventTypeId);
                        cmd.Parameters.AddWithValue("@order_status", pRisOracleRisXmlEventsE.OrderStatus);
                        cmd.Parameters.AddWithValue("@id_paciente", pRisOracleRisXmlEventsE.IdPaciente);
                        cmd.Parameters.AddWithValue("@id_paciente_ris", pRisOracleRisXmlEventsE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@rut_paciente", pRisOracleRisXmlEventsE.RutPaciente);
                        cmd.Parameters.AddWithValue("@tipo_paciente", pRisOracleRisXmlEventsE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@id_admision", pRisOracleRisXmlEventsE.IdAdmision);
                        cmd.Parameters.AddWithValue("@id_ingreso", pRisOracleRisXmlEventsE.IdIngreso);
                        cmd.Parameters.AddWithValue("@id_atencion", pRisOracleRisXmlEventsE.IdAtencion);
                        cmd.Parameters.AddWithValue("@cod_paquete", pRisOracleRisXmlEventsE.CodPaquete);
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisOracleRisXmlEventsE.FillerOrderNumber);
                        cmd.Parameters.AddWithValue("@xml_msg", pRisOracleRisXmlEventsE.XmlMsg);
                        cmd.Parameters.AddWithValue("@xml_integration_date", pRisOracleRisXmlEventsE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@xml_event_status", pRisOracleRisXmlEventsE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@xml_message_status", pRisOracleRisXmlEventsE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@xml_user_updated", pRisOracleRisXmlEventsE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@xml_flag1", pRisOracleRisXmlEventsE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@FechaHoraRegistro", pRisOracleRisXmlEventsE.Fechahoraregistro);
                        cmd.Parameters.AddWithValue("@version", pRisOracleRisXmlEventsE.Version);
                        cmd.Parameters.AddWithValue("@fec_trama", pRisOracleRisXmlEventsE.FecTrama);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@result", ParameterDirection.InputOutput, SqlDbType.Int, 8, pRisOracleRisXmlEventsE.Result));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();

                        if (exito >= 1)
                        {
                            return pRisOracleRisXmlEventsE.Result = Convert.ToInt32(cmd.Parameters["@result"].Value);
                        }

                        cnn.Close();
                        cmd.Dispose();
                        return exito;
                        //if (exito >= 1)
                        //{
                        //    return true;
                        //}
                        //else
                        //{
                        //    return false;
                        //}
                    }
                }
            }
            catch (Exception e)
            {
                //return true;
                throw e = new Exception(e.Message);
            }
        }


        public bool Sp_RisOracleRisXmlEvents_Update(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEvents_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@cod_empresa", pRisOracleRisXmlEventsE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@cod_sucursal", pRisOracleRisXmlEventsE.CodSucursal);
                        cmd.Parameters.AddWithValue("@event_id", pRisOracleRisXmlEventsE.EventId);
                        cmd.Parameters.AddWithValue("@event_desc", pRisOracleRisXmlEventsE.EventDesc);
                        cmd.Parameters.AddWithValue("@event_datetime", pRisOracleRisXmlEventsE.EventDatetime);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisOracleRisXmlEventsE.EventTypeId);
                        cmd.Parameters.AddWithValue("@order_status", pRisOracleRisXmlEventsE.OrderStatus);
                        cmd.Parameters.AddWithValue("@id_paciente", pRisOracleRisXmlEventsE.IdPaciente);
                        cmd.Parameters.AddWithValue("@id_paciente_ris", pRisOracleRisXmlEventsE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@rut_paciente", pRisOracleRisXmlEventsE.RutPaciente);
                        cmd.Parameters.AddWithValue("@tipo_paciente", pRisOracleRisXmlEventsE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@id_admision", pRisOracleRisXmlEventsE.IdAdmision);
                        cmd.Parameters.AddWithValue("@id_ingreso", pRisOracleRisXmlEventsE.IdIngreso);
                        cmd.Parameters.AddWithValue("@id_atencion", pRisOracleRisXmlEventsE.IdAtencion);
                        cmd.Parameters.AddWithValue("@cod_paquete", pRisOracleRisXmlEventsE.CodPaquete);
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisOracleRisXmlEventsE.FillerOrderNumber);
                        cmd.Parameters.AddWithValue("@xml_msg", pRisOracleRisXmlEventsE.XmlMsg);
                        cmd.Parameters.AddWithValue("@xml_integration_date", pRisOracleRisXmlEventsE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@xml_event_status", pRisOracleRisXmlEventsE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@xml_message_status", pRisOracleRisXmlEventsE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@xml_user_updated", pRisOracleRisXmlEventsE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@xml_flag1", pRisOracleRisXmlEventsE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@FechaHoraRegistro", pRisOracleRisXmlEventsE.Fechahoraregistro);
                        cmd.Parameters.AddWithValue("@version", pRisOracleRisXmlEventsE.Version);
                        cmd.Parameters.AddWithValue("@fec_trama", pRisOracleRisXmlEventsE.FecTrama);
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

        public bool Sp_RisOracleRisXmlEvents_UpdatexCampo(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RisOracleRisXmlEvents_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisOracleRisXmlEventsE.CodRisAmbulatorio);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisOracleRisXmlEventsE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisOracleRisXmlEventsE.Campo);
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