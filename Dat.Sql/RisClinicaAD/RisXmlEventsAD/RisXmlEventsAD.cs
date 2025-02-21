using Ent.Sql.RisClinicaE.RisXmlEventsE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.RisClinicaAD.RisXmlEventsAD
{
    public class RisXmlEventsAD
    {
        private RisXmlEventsE LlenarEntidad(IDataReader dr, RisXmlEventsE pRisXmlEventsE)
        {
            RisXmlEventsE oRisXmlEventsE = new RisXmlEventsE();
            switch (pRisXmlEventsE.Orden)
            {
                case 1:
                    oRisXmlEventsE.CodEmpresa = Convert.ToInt32(dr["COD_EMPRESA"]);
                    oRisXmlEventsE.CodSucursal = Convert.ToInt32(dr["COD_SUCURSAL"]);
                    oRisXmlEventsE.EventId = Convert.ToString(dr["EVENT_ID"]);
                    oRisXmlEventsE.EventDesc = Convert.ToString(dr["EVENT_DESC"]);
                    oRisXmlEventsE.EventDateTime = Convert.ToString(dr["EVENT_DATETIME"]);
                    oRisXmlEventsE.EventTypeId = Convert.ToInt32(dr["EVENT_TYPE_ID"]);
                    oRisXmlEventsE.OrderStatus = Convert.ToString(dr["ORDER_STATUS"]);
                    oRisXmlEventsE.IdPaciente = Convert.ToString(dr["ID_PACIENTE"]);
                    oRisXmlEventsE.IdPacienteRis = Convert.ToString(dr["ID_PACIENTE_RIS"]);
                    oRisXmlEventsE.RutPaciente = Convert.ToString(dr["RUT_PACIENTE"]);
                    oRisXmlEventsE.TipoPaciente = Convert.ToString(dr["TIPO_PACIENTE"]);
                    oRisXmlEventsE.IdAdmision = Convert.ToInt32(dr["ID_ADMISION"]);
                    oRisXmlEventsE.IdIngreso = Convert.ToInt32(dr["ID_INGRESO"]);
                    oRisXmlEventsE.IdAtencion = Convert.ToInt32(dr["ID_ATENCION"]);
                    oRisXmlEventsE.CodPaquete = Convert.ToInt32(dr["COD_PAQUETE"]);
                    oRisXmlEventsE.FillerOrderInt = Convert.ToString(dr["FILLER_ORDER_NUMBER"]);
                    oRisXmlEventsE.XmlMsg = Convert.ToString(dr["XML_MSG"]);
                    oRisXmlEventsE.XmlIntegrationDate = Convert.ToString(dr["XML_INTEGRATION_DATE"]);
                    oRisXmlEventsE.XmlEventStatus = Convert.ToString(dr["XML_EVENT_STATUS"]);
                    oRisXmlEventsE.XmlMessageStatus = Convert.ToString(dr["XML_MESSAGE_STATUS"]);
                    oRisXmlEventsE.XmlUserUpdated = Convert.ToString(dr["XML_USER_UPDATED"]);
                    oRisXmlEventsE.XmlFlag1 = Convert.ToString(dr["XML_FLAG1"]);
                    oRisXmlEventsE.Version = Convert.ToInt32(dr["VERSION"]);
                    oRisXmlEventsE.FlgProcesado = Convert.ToString(dr["FLG_PROCESADO"]);
                    break;
                case 2:
                    oRisXmlEventsE.CodEmpresa = Convert.ToInt32(dr["COD_EMPRESA"]);
                    oRisXmlEventsE.CodSucursal = Convert.ToInt32(dr["COD_SUCURSAL"]);
                    oRisXmlEventsE.EventId = Convert.ToString(dr["EVENT_ID"]);
                    oRisXmlEventsE.EventDesc = Convert.ToString(dr["EVENT_DESC"]);
                    oRisXmlEventsE.EventDateTime = Convert.ToString(dr["EVENT_DATETIME"]);
                    oRisXmlEventsE.EventTypeId = Convert.ToInt32(dr["EVENT_TYPE_ID"]);
                    oRisXmlEventsE.OrderStatus = Convert.ToString(dr["ORDER_STATUS"]);
                    oRisXmlEventsE.IdPaciente = Convert.ToString(dr["ID_PACIENTE"]);
                    oRisXmlEventsE.IdPacienteRis = Convert.ToString(dr["ID_PACIENTE_RIS"]);
                    oRisXmlEventsE.RutPaciente = Convert.ToString(dr["RUT_PACIENTE"]);
                    oRisXmlEventsE.TipoPaciente = Convert.ToString(dr["TIPO_PACIENTE"]);
                    oRisXmlEventsE.IdAdmision = Convert.ToInt32(dr["ID_ADMISION"]);
                    oRisXmlEventsE.IdIngreso = Convert.ToInt32(dr["ID_INGRESO"]);
                    oRisXmlEventsE.IdAtencion = Convert.ToInt32(dr["ID_ATENCION"]);
                    oRisXmlEventsE.CodPaquete = Convert.ToInt32(dr["COD_PAQUETE"]);
                    oRisXmlEventsE.FillerOrderInt = Convert.ToString(dr["FILLER_ORDER_NUMBER"]);
                    oRisXmlEventsE.XmlMsg = Convert.ToString(dr["XML_MSG"]);
                    oRisXmlEventsE.XmlIntegrationDate = Convert.ToString(dr["XML_INTEGRATION_DATE"]);
                    oRisXmlEventsE.XmlEventStatus = Convert.ToString(dr["XML_EVENT_STATUS"]);
                    oRisXmlEventsE.XmlMessageStatus = Convert.ToString(dr["XML_MESSAGE_STATUS"]);
                    oRisXmlEventsE.XmlUserUpdated = Convert.ToString(dr["XML_USER_UPDATED"]);
                    oRisXmlEventsE.XmlFlag1 = Convert.ToString(dr["XML_FLAG1"]);
                    oRisXmlEventsE.Version = Convert.ToInt32(dr["VERSION"]);
                    oRisXmlEventsE.FlgProcesado = Convert.ToString(dr["FLG_PROCESADO"]);
                    break;
            }
            return oRisXmlEventsE;
        }

        public List<RisXmlEventsE> Sp_RisXmlEvents_Consulta(RisXmlEventsE pRisXmlEventsE)
        {
            List<RisXmlEventsE> oListar = new List<RisXmlEventsE>();
            RisXmlEventsE oRisXmlEventsE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_RISXMLEVENTS_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pRisXmlEventsE.Buscar);
                    cmd.Parameters.AddWithValue("@campo", pRisXmlEventsE.Campo);
                    cmd.Parameters.AddWithValue("@fecha", pRisXmlEventsE.Fecha);
                    cmd.Parameters.AddWithValue("@numerofilas", pRisXmlEventsE.NumeroFila);
                    cmd.Parameters.AddWithValue("@orden", pRisXmlEventsE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oRisXmlEventsE = LlenarEntidad(dr, pRisXmlEventsE);
                        oListar.Add(oRisXmlEventsE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public bool Sp_RisXmlEvents_Insert(RisXmlEventsE pRisXmlEventsE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RISXMLEVENTS_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@COD_EMPRESA", pRisXmlEventsE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@COD_SUCURSAL", pRisXmlEventsE.CodSucursal);
                        cmd.Parameters.AddWithValue("@EVENT_ID", pRisXmlEventsE.EventId);
                        cmd.Parameters.AddWithValue("@EVENT_DESC", pRisXmlEventsE.EventDesc);
                        cmd.Parameters.AddWithValue("@EVENT_DATETIME", pRisXmlEventsE.EventDateTime);
                        cmd.Parameters.AddWithValue("@EVENT_TYPE_ID", pRisXmlEventsE.EventTypeId);
                        cmd.Parameters.AddWithValue("@ORDER_STATUS", pRisXmlEventsE.OrderStatus);
                        cmd.Parameters.AddWithValue("@ID_PACIENTE", pRisXmlEventsE.IdPaciente);
                        cmd.Parameters.AddWithValue("@ID_PACIENTE_RIS", pRisXmlEventsE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@RUT_PACIENTE", pRisXmlEventsE.RutPaciente);
                        cmd.Parameters.AddWithValue("@TIPO_PACIENTE", pRisXmlEventsE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@ID_ADMISION", pRisXmlEventsE.IdAdmision);
                        cmd.Parameters.AddWithValue("@ID_INGRESO", pRisXmlEventsE.IdIngreso);
                        cmd.Parameters.AddWithValue("@ID_ATENCION", pRisXmlEventsE.IdAtencion);
                        cmd.Parameters.AddWithValue("@COD_PAQUETE", pRisXmlEventsE.CodPaquete);
                        cmd.Parameters.AddWithValue("@FILLER_ORDER_NUMBER", pRisXmlEventsE.FillerOrderInt);
                        cmd.Parameters.AddWithValue("@XML_MSG", pRisXmlEventsE.XmlMsg);
                        cmd.Parameters.AddWithValue("@XML_INTEGRATION_DATE", pRisXmlEventsE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@XML_EVENT_STATUS", pRisXmlEventsE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@XML_MESSAGE_STATUS", pRisXmlEventsE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@XML_USER_UPDATED", pRisXmlEventsE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@XML_FLAG1", pRisXmlEventsE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@FLG_PROCESADO", pRisXmlEventsE.FlgProcesado);
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


        public bool Sp_RisXmlEvents_Update(RisXmlEventsE pRisXmlEventsE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RISXMLEVENTS_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@COD_EMPRESA", pRisXmlEventsE.CodEmpresa);
                        cmd.Parameters.AddWithValue("@COD_SUCURSAL", pRisXmlEventsE.CodSucursal);
                        cmd.Parameters.AddWithValue("@EVENT_ID", pRisXmlEventsE.EventId);
                        cmd.Parameters.AddWithValue("@EVENT_DESC", pRisXmlEventsE.EventDesc);
                        cmd.Parameters.AddWithValue("@EVENT_DATETIME", pRisXmlEventsE.EventDateTime);
                        cmd.Parameters.AddWithValue("@EVENT_TYPE_ID", pRisXmlEventsE.EventTypeId);
                        cmd.Parameters.AddWithValue("@ORDER_STATUS", pRisXmlEventsE.OrderStatus);
                        cmd.Parameters.AddWithValue("@ID_PACIENTE", pRisXmlEventsE.IdPaciente);
                        cmd.Parameters.AddWithValue("@ID_PACIENTE_RIS", pRisXmlEventsE.IdPacienteRis);
                        cmd.Parameters.AddWithValue("@RUT_PACIENTE", pRisXmlEventsE.RutPaciente);
                        cmd.Parameters.AddWithValue("@TIPO_PACIENTE", pRisXmlEventsE.TipoPaciente);
                        cmd.Parameters.AddWithValue("@ID_ADMISION", pRisXmlEventsE.IdAdmision);
                        cmd.Parameters.AddWithValue("@ID_INGRESO", pRisXmlEventsE.IdIngreso);
                        cmd.Parameters.AddWithValue("@ID_ATENCION", pRisXmlEventsE.IdAtencion);
                        cmd.Parameters.AddWithValue("@COD_PAQUETE", pRisXmlEventsE.CodPaquete);
                        cmd.Parameters.AddWithValue("@FILLER_ORDER_NUMBER", pRisXmlEventsE.FillerOrderInt);
                        cmd.Parameters.AddWithValue("@XML_MSG", pRisXmlEventsE.XmlMsg);
                        cmd.Parameters.AddWithValue("@XML_INTEGRATION_DATE", pRisXmlEventsE.XmlIntegrationDate);
                        cmd.Parameters.AddWithValue("@XML_EVENT_STATUS", pRisXmlEventsE.XmlEventStatus);
                        cmd.Parameters.AddWithValue("@XML_MESSAGE_STATUS", pRisXmlEventsE.XmlMessageStatus);
                        cmd.Parameters.AddWithValue("@XML_USER_UPDATED", pRisXmlEventsE.XmlUserUpdated);
                        cmd.Parameters.AddWithValue("@XML_FLAG1", pRisXmlEventsE.XmlFlag1);
                        cmd.Parameters.AddWithValue("@FLG_PROCESADO", pRisXmlEventsE.FlgProcesado);
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


        public bool Sp_RisXmlEvents_UpdatexCampo(RisXmlEventsE pRisXmlEventsE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnRisClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_RISXMLEVENTS_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@filler_order_number", pRisXmlEventsE.FillerOrderInt);
                        cmd.Parameters.AddWithValue("@event_type_id", pRisXmlEventsE.EventTypeId);
                        cmd.Parameters.AddWithValue("@version", pRisXmlEventsE.Version);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pRisXmlEventsE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pRisXmlEventsE.Campo);
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
