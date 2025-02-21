using Ent.Sql.ClinicaE.PacientesE;
using Ent.Sql.ClinicaE.PresotorE;
using Ent.Sql.ClinicaE.RisE;
using Ent.Sql.RisClinicaE.PDFDocumentE;
using Ent.Sql.RisClinicaE.RisXmlEventsE;
using Bus.Clinica.Clinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Dat.Sql.ClinicaAD.PresotorAD;
using Dat.Sql.RisClinicaAD.PDFDocumentAD;
using Ent.Sql.ClinicaE.RceE;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Drawing;
using Bus.Clinica;
using System.Diagnostics.Metrics;

namespace Bus.RisClinica.RisClinica
{
    public class GeneralesRisCopyService
    {
        bool Result = false;
        RisXmlEventsE oRisXmlEvents = new RisXmlEventsE();
        List<RisXmlEventsE> oListRisXmlEvents = new List<RisXmlEventsE>();

        RisOracleRisXmlEventsE oRisOracleRisXmlEvents = new RisOracleRisXmlEventsE();
        List<RisOracleRisXmlEventsE> oListRisOracleRisXmlEvents = new List<RisOracleRisXmlEventsE>();

        RisAgendamientoAmbulatorioE oRisAgendamientoAmbulatorio = new RisAgendamientoAmbulatorioE();
        List<RisAgendamientoAmbulatorioE> oListRisAgendamientoAmbulatorio = new List<RisAgendamientoAmbulatorioE>();

        PacientesE oPacientes = new PacientesE();
        List<PacientesE> oListaPacientes = new List<PacientesE>();

        RisOracleRisXmlEventsAmbulatorioE oRisOracleRisXmlEventsAmbulatorio = new RisOracleRisXmlEventsAmbulatorioE();
        List<RisOracleRisXmlEventsAmbulatorioE> oListRisOracleRisXmlEventsAmbulatorio = new List<RisOracleRisXmlEventsAmbulatorioE>();

        RisPrestacionVsSalasE oRisPrestacionVsSalas = new RisPrestacionVsSalasE();
        List<RisPrestacionVsSalasE> oListRisPrestacionVsSalasE = new List<RisPrestacionVsSalasE>();

        RisOracleRisXmlEventsCompletadoE oRisOracleRisXmlEventsCompletado = new RisOracleRisXmlEventsCompletadoE();
        List<RisOracleRisXmlEventsCompletadoE> oListRisOracleRisXmlEventsCompletado = new List<RisOracleRisXmlEventsCompletadoE>();

        PresotorE oPresotor = new PresotorE();
        List<PresotorE> oListPresotor = new List<PresotorE>();

        RisExamenCompletadoE oRisExamenCompletado = new RisExamenCompletadoE();
        List<RisExamenCompletadoE> oListRisExamenCompletado = new List<RisExamenCompletadoE>();

        PDFDocumentE oPdfDocumentE = new PDFDocumentE();
        List<PDFDocumentE> oListPdfDocument = new List<PDFDocumentE>();

        RisOraclePDFDocumentE oRisOraclePDFDocument = new RisOraclePDFDocumentE();

        #region CopiarRis
        public void Prueba()
        {
            string path = @"C:\ServiceTest\";
            //Creamos el directorio
            Directory.CreateDirectory(path);
            //Establecemos la ubicación del fichero de texto
            path += "output.txt";
            //Escribimos en el fichero
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"Hello world from the {DateTime.Now}");
            }
            //Se ejecutará cada 1000 ms = 1 segundo
        }

        public void CopiarRis()
        {
            int cont = 0, cont1 = 0;
            try
            {
                oListRisXmlEvents = new Bus.RisClinica.RisClinica.RisXmlEvents().Sp_RISXMLEVENTS_Consulta(new RisXmlEventsE("", "", "2023-03-11 00:00:00.000", 0, 2));
                for (int i = 0; i < oListRisXmlEvents.Count; i++)
                {
                    try
                    {
                        #region Grabar Clinica - RisOracleRisXmlEvents
                        try
                        {
                            oRisOracleRisXmlEvents.CodEmpresa = oListRisXmlEvents[i].CodEmpresa;
                            oRisOracleRisXmlEvents.CodSucursal = oListRisXmlEvents[i].CodSucursal;
                            oRisOracleRisXmlEvents.EventId = oListRisXmlEvents[i].EventId;
                            oRisOracleRisXmlEvents.EventDesc = oListRisXmlEvents[i].EventDesc;
                            oRisOracleRisXmlEvents.EventDatetime = oListRisXmlEvents[i].EventDateTime;
                            oRisOracleRisXmlEvents.EventTypeId = oListRisXmlEvents[i].EventTypeId;
                            oRisOracleRisXmlEvents.OrderStatus = oListRisXmlEvents[i].OrderStatus;
                            oRisOracleRisXmlEvents.IdPaciente = oListRisXmlEvents[i].IdPaciente;
                            oRisOracleRisXmlEvents.IdPacienteRis = oListRisXmlEvents[i].IdPacienteRis;
                            oRisOracleRisXmlEvents.RutPaciente = oListRisXmlEvents[i].RutPaciente;
                            oRisOracleRisXmlEvents.TipoPaciente = oListRisXmlEvents[i].TipoPaciente;
                            oRisOracleRisXmlEvents.IdAdmision = oListRisXmlEvents[i].IdAdmision;
                            oRisOracleRisXmlEvents.IdIngreso = oListRisXmlEvents[i].IdIngreso;
                            oRisOracleRisXmlEvents.IdAtencion = oListRisXmlEvents[i].IdAtencion;
                            oRisOracleRisXmlEvents.CodPaquete = oListRisXmlEvents[i].CodPaquete;
                            oRisOracleRisXmlEvents.FillerOrderNumber = oListRisXmlEvents[i].FillerOrderInt;
                            oRisOracleRisXmlEvents.XmlMsg = oListRisXmlEvents[i].XmlMsg;
                            oRisOracleRisXmlEvents.XmlIntegrationDate = oListRisXmlEvents[i].XmlIntegrationDate;
                            oRisOracleRisXmlEvents.XmlEventStatus = oListRisXmlEvents[i].XmlEventStatus;
                            oRisOracleRisXmlEvents.XmlMessageStatus = oListRisXmlEvents[i].XmlMessageStatus;
                            oRisOracleRisXmlEvents.XmlUserUpdated = oListRisXmlEvents[i].XmlUserUpdated;
                            oRisOracleRisXmlEvents.XmlFlag1 = oListRisXmlEvents[i].XmlFlag1;
                            oRisOracleRisXmlEvents.Version = oListRisXmlEvents[i].Version;

                            int result;

                            result = new Ris().GrabarDatos_RisOracleRisXmlEvents(oRisOracleRisXmlEvents);

                            if (result == 1) //REGISTRO EXITO
                            {

                                GrabarLog("RisOracleRisXmlEvents", "Se Grabaron correctamente RisOracleRisXmlEvents - FillerOrderNumber=" + oRisOracleRisXmlEvents.FillerOrderNumber + " ID Tipo Evento =" + oRisOracleRisXmlEvents.EventTypeId.ToString());
                                //GrabarLog("Se Grabaron los Datos Clinica - RisOracleRisXmlEvents de manera exitosa:", "FillerOrderNumber=" + oRisOracleRisXmlEvents.FillerOrderNumber + " ID Tipo Evento =" + oRisOracleRisXmlEvents.EventTypeId);
                            }
                            //else if (result == 2) //YA ESTA REGISTRADO
                            //{
                            //    EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Ya existe orden", "Ya existe orden:" + oRisOracleRisXmlEvents.FillerOrderNumber + "-" + oRisOracleRisXmlEvents.EventTypeId));
                            //    GrabarLog("Error al GrabarDatos Clinica - RisOracleRisXmlEvents. Ya existe orden:", "FillerOrderNumber=" + oRisOracleRisXmlEvents.FillerOrderNumber + "-" + " ID Tipo Evento =" + oRisOracleRisXmlEvents.EventTypeId);
                            //}
                            //else //ERROR
                            //{
                            //    EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : ERROR al registrar en la tabla Clinica-RisOracleRisXmlEvents:", " ERROR al registrar en la tabla RisXmlEvents:" + oRisOracleRisXmlEvents.FillerOrderNumber + " - " + oRisOracleRisXmlEvents.EventTypeId + " " + result));
                            //    GrabarLog("Error al GrabarDatos Clinica - RisOracleRisXmlEvents", result + oRisOracleRisXmlEvents.FillerOrderNumber + "-" + oRisOracleRisXmlEvents.EventTypeId);
                            //}
                        }
                        catch (Exception ex)
                        {
                            EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : ERROR al registrar en la tabla Clinica-RisOracleRisXmlEvents: ", " ERROR al registrar en la tabla RisXmlEvents:" + oRisOracleRisXmlEvents.FillerOrderNumber + " - " + oRisOracleRisXmlEvents.EventTypeId + " " + ex.Message.ToString()));
                            GrabarLog("Error al GrabarDatos Clinica - RisOracleRisXmlEvents. Ya existe orden:", oRisOracleRisXmlEvents.FillerOrderNumber + "-" + oRisOracleRisXmlEvents.EventTypeId);
                        }
                        #endregion

                        #region Grabar Eventos 1012 - 1090 - 1014
                        try
                        {
                            #region Gabar Eventos 1012, 1090, 1014 en Clinica - RisOracleRisXmlEventsAmbulatorio
                            if (oListRisXmlEvents[i].TipoPaciente == "3" || oListRisXmlEvents[i].TipoPaciente == "1")
                            {
                                if (oListRisXmlEvents[i].EventTypeId == 1012 || oListRisXmlEvents[i].EventTypeId == 1090 || oListRisXmlEvents[i].EventTypeId == 1014)
                                {
                                    oRisOracleRisXmlEventsAmbulatorio.FlagProcesado = "N";
                                    oRisOracleRisXmlEventsAmbulatorio.CodEmpresa = oListRisXmlEvents[i].CodEmpresa;
                                    oRisOracleRisXmlEventsAmbulatorio.CodSucursal = oListRisXmlEvents[i].CodSucursal;
                                    oRisOracleRisXmlEventsAmbulatorio.EventId = oListRisXmlEvents[i].EventId;
                                    oRisOracleRisXmlEventsAmbulatorio.EventDesc = oListRisXmlEvents[i].EventDesc;
                                    oRisOracleRisXmlEventsAmbulatorio.EventDatetime = oListRisXmlEvents[i].EventDateTime;
                                    oRisOracleRisXmlEventsAmbulatorio.EventTypeId = oListRisXmlEvents[i].EventTypeId;
                                    oRisOracleRisXmlEventsAmbulatorio.OrderStatus = oListRisXmlEvents[i].OrderStatus;
                                    oRisOracleRisXmlEventsAmbulatorio.IdPaciente = oListRisXmlEvents[i].IdPaciente;
                                    oRisOracleRisXmlEventsAmbulatorio.IdPacienteRis = oListRisXmlEvents[i].IdPacienteRis;
                                    oRisOracleRisXmlEventsAmbulatorio.RutPaciente = oListRisXmlEvents[i].RutPaciente;
                                    oRisOracleRisXmlEventsAmbulatorio.TipoPaciente = oListRisXmlEvents[i].TipoPaciente;
                                    oRisOracleRisXmlEventsAmbulatorio.IdAdmision = oListRisXmlEvents[i].IdAdmision;
                                    oRisOracleRisXmlEventsAmbulatorio.IdIngreso = oListRisXmlEvents[i].IdIngreso;
                                    oRisOracleRisXmlEventsAmbulatorio.IdAtencion = oListRisXmlEvents[i].IdAtencion;
                                    oRisOracleRisXmlEventsAmbulatorio.CodPaquete = oListRisXmlEvents[i].CodPaquete;
                                    oRisOracleRisXmlEventsAmbulatorio.FillerOrderNumber = oListRisXmlEvents[i].FillerOrderInt;
                                    oRisOracleRisXmlEventsAmbulatorio.XmlMsg = oListRisXmlEvents[i].XmlMsg;
                                    oRisOracleRisXmlEventsAmbulatorio.XmlIntegrationDate = oListRisXmlEvents[i].XmlIntegrationDate;
                                    oRisOracleRisXmlEventsAmbulatorio.XmlEventStatus = oListRisXmlEvents[i].XmlEventStatus;
                                    oRisOracleRisXmlEventsAmbulatorio.XmlMessageStatus = oListRisXmlEvents[i].XmlMessageStatus;
                                    oRisOracleRisXmlEventsAmbulatorio.XmlUserUpdated = oListRisXmlEvents[i].XmlUserUpdated;
                                    oRisOracleRisXmlEventsAmbulatorio.XmlFlag1 = oListRisXmlEvents[i].XmlFlag1;
                                    oRisOracleRisXmlEventsAmbulatorio.Version = oListRisXmlEvents[i].Version;

                                    new Ris().GrabarDatos_RisOracleRisXmlEventsAmbulatorio(oRisOracleRisXmlEventsAmbulatorio);
                                }
                            }
                            #endregion

                            #region Gabar Evento 1090 - Agenda Cancelada
                            if (oListRisXmlEvents[i].EventTypeId == 1090 && oListRisXmlEvents[i].TipoPaciente != "3")
                            { CancelarAgenda(0, oListRisXmlEvents[i].XmlMsg.Replace("'", ""), "0", "0"); }
                            #endregion
                        }
                        catch (Exception ex)
                        {
                            oRisXmlEvents.FillerOrderInt = oListRisXmlEvents[i].FillerOrderInt;
                            oRisXmlEvents.Version = oListRisXmlEvents[i].Version;
                            oRisXmlEvents.EventTypeId = oListRisXmlEvents[i].EventTypeId;
                            oRisXmlEvents.Campo = "FLG_PROCESADO";
                            oRisXmlEvents.NuevoValor = "0";

                            new Bus.RisClinica.RisClinica.RisXmlEvents().Sp_RISXMLEVENTS_UpdatexCampo(oRisXmlEvents);
                            GrabarLog("ERROR al Grabar Clinica - RisOracleRisXmlEventsAmbulatorio", ex.Message.ToString() + " Número de Registros = " + oListRisXmlEvents[i].FillerOrderInt + " ID Tipo Evento= " + oListRisXmlEvents[i].EventTypeId);
                        }
                        #endregion

                        #region Actualiza estado Agenda Completado
                        try
                        {
                            new Ris().Sp_RceRecetaImagenDetEstadoRisPacs_Update(oListRisXmlEvents[i].FillerOrderInt, Convert.ToString(oListRisXmlEvents[i].EventTypeId));
                            GrabarLog("ORDENADO COMPLETADO ESTADOS " + oListRisXmlEvents[i].FillerOrderInt, "Se actualizo estado " + oListRisXmlEvents[i].EventTypeId);
                        }
                        catch (Exception ex)
                        { GrabarLog("ORDENADO COMPLETADO ERROR :" + oListRisXmlEvents[i].FillerOrderInt + " X", ex.Message.ToString() + " Estado = " + oListRisXmlEvents[i].EventTypeId.ToString()); }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        oRisXmlEvents.FillerOrderInt = oListRisXmlEvents[i].FillerOrderInt;
                        oRisXmlEvents.Version = oListRisXmlEvents[i].Version;
                        oRisXmlEvents.EventTypeId = oListRisXmlEvents[i].EventTypeId;
                        oRisXmlEvents.Campo = "FLG_PROCESADO";
                        oRisXmlEvents.NuevoValor = "0";

                        new Bus.RisClinica.RisClinica.RisXmlEvents().Sp_RISXMLEVENTS_UpdatexCampo(oRisXmlEvents);
                        GrabarLog("ERROR se actualizó estado en la tabla His(RisXmlEvents)", ex.Message.ToString() + " Estado=" + oRisXmlEvents.NuevoValor + " Codigo=" + oRisXmlEvents.FillerOrderInt);
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = NombreMetodo();
                txt = "RISPACS : ERROR al ejecutar el metodo " + txt;
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", txt, ex.Message.ToString()));
                GrabarLog(txt, ex.Message.ToString());
            }
        }
        #endregion

        #region FormatearXMLAgendamiento
        public void FormatearXMLAgendamiento()
        {
            try
            {
                oListRisOracleRisXmlEventsAmbulatorio = new Ris().Sp_RisOracleRisXmlEventsAmbulatorio_Consulta(new RisOracleRisXmlEventsAmbulatorioE(0, "", "", 0, 2));

                for (int i = 0; i < oListRisOracleRisXmlEventsAmbulatorio.Count; i++)
                {
                    if (oListRisOracleRisXmlEventsAmbulatorio[i].EventTypeId == 1012) //-->AGENDA
                    {
                        if (oListRisOracleRisXmlEventsAmbulatorio[i].Version == 1)
                        { Agendamiento(oListRisOracleRisXmlEventsAmbulatorio[i].CodrisAmbulatorio, oListRisOracleRisXmlEventsAmbulatorio[i].XmlMsg, oListRisOracleRisXmlEventsAmbulatorio[i].IdPaciente, oListRisOracleRisXmlEventsAmbulatorio[i].RutPaciente); }
                        else
                        { ActualizarAgenda(oListRisOracleRisXmlEventsAmbulatorio[i].CodrisAmbulatorio, oListRisOracleRisXmlEventsAmbulatorio[i].XmlMsg, oListRisOracleRisXmlEventsAmbulatorio[i].IdPaciente, oListRisOracleRisXmlEventsAmbulatorio[i].RutPaciente); }
                    }
                    else if (oListRisOracleRisXmlEventsAmbulatorio[i].EventTypeId == 1090) //-->CANCELA
                    { CancelarAgenda(oListRisOracleRisXmlEventsAmbulatorio[i].CodrisAmbulatorio, oListRisOracleRisXmlEventsAmbulatorio[i].XmlMsg, oListRisOracleRisXmlEventsAmbulatorio[i].IdPaciente, oListRisOracleRisXmlEventsAmbulatorio[i].RutPaciente); }
                    else //-->ACTUALIZA = 1014
                    { ActualizarAgenda(oListRisOracleRisXmlEventsAmbulatorio[i].CodrisAmbulatorio, oListRisOracleRisXmlEventsAmbulatorio[i].XmlMsg, oListRisOracleRisXmlEventsAmbulatorio[i].IdPaciente, oListRisOracleRisXmlEventsAmbulatorio[i].RutPaciente); }
                }
            }
            catch (Exception ex)
            {
                string txt = NombreMetodo();
                txt = "RISPACS : Error al ejecutar el metodo " + txt;
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", txt, ex.Message.ToString()));
                GrabarLog(txt, ex.Message.ToString());
            }
            EliminarReservasAntiguas();
        }
        #endregion

        #region CopiarRISCompletado
        public void CopiarRISCompletado()
        {
            try
            {
                for (int i = 0; i < oListRisXmlEvents.Count; i++)
                {
                    if (oListRisXmlEvents[i].EventTypeId == 1011)
                    {
                        oRisOracleRisXmlEventsCompletado.FlagProcesado = "N";
                        oRisOracleRisXmlEventsCompletado.CodEmpresa = oListRisXmlEvents[i].CodEmpresa;
                        oRisOracleRisXmlEventsCompletado.CodSucursal = oListRisXmlEvents[i].CodSucursal;
                        oRisOracleRisXmlEventsCompletado.EventId = oListRisXmlEvents[i].EventId;
                        oRisOracleRisXmlEventsCompletado.EventDesc = oListRisXmlEvents[i].EventDesc;
                        oRisOracleRisXmlEventsCompletado.EventDatetime = oListRisXmlEvents[i].EventDateTime;
                        oRisOracleRisXmlEventsCompletado.EventTypeId = oListRisXmlEvents[i].EventTypeId;
                        oRisOracleRisXmlEventsCompletado.OrderStatus = oListRisXmlEvents[i].OrderStatus;
                        oRisOracleRisXmlEventsCompletado.IdPaciente = oListRisXmlEvents[i].IdPaciente;
                        oRisOracleRisXmlEventsCompletado.IdPacienteRis = oListRisXmlEvents[i].IdPacienteRis;
                        oRisOracleRisXmlEventsCompletado.RutPaciente = oListRisXmlEvents[i].RutPaciente;
                        oRisOracleRisXmlEventsCompletado.TipoPaciente = oListRisXmlEvents[i].TipoPaciente;
                        oRisOracleRisXmlEventsCompletado.IdAdmision = oListRisXmlEvents[i].IdAdmision;
                        oRisOracleRisXmlEventsCompletado.IdIngreso = oListRisXmlEvents[i].IdIngreso;
                        oRisOracleRisXmlEventsCompletado.IdAtencion = oListRisXmlEvents[i].IdAtencion;
                        oRisOracleRisXmlEventsCompletado.CodPaquete = oListRisXmlEvents[i].CodPaquete;
                        oRisOracleRisXmlEventsCompletado.FillerOrderNumber = oListRisXmlEvents[i].FillerOrderInt;
                        oRisOracleRisXmlEventsCompletado.XmlMsg = oListRisXmlEvents[i].XmlMsg;
                        oRisOracleRisXmlEventsCompletado.XmlIntegrationDate = oListRisXmlEvents[i].XmlIntegrationDate;
                        oRisOracleRisXmlEventsCompletado.XmlEventStatus = oListRisXmlEvents[i].XmlEventStatus;
                        oRisOracleRisXmlEventsCompletado.XmlMessageStatus = oListRisXmlEvents[i].XmlMessageStatus;
                        oRisOracleRisXmlEventsCompletado.XmlUserUpdated = oListRisXmlEvents[i].XmlUserUpdated;
                        oRisOracleRisXmlEventsCompletado.XmlFlag1 = oListRisXmlEvents[i].XmlFlag1;

                        try
                        { new Ris().Sp_RisOracleRisXmlEventsCompletado_Insert(oRisOracleRisXmlEventsCompletado); }
                        catch (Exception ex)
                        {
                            EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al ejecutar el metodo CopiarRISCompletado", ex.Message.ToString()));
                            GrabarLog("Error al ejecutar el metodo CopiarRISCompletado", ex.Message.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = NombreMetodo();
                txt = "RISPACS : Error al ejecutar el metodo " + txt;
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", txt, ex.Message.ToString()));
                GrabarLog(txt, ex.Message.ToString());
                //GrabarLog("Error al ejecutar el metodo oracle para CopiarRISCompletado", ex.Message)
            }
        }
        #endregion

        #region FormatearXMLCompletado
        public void FormatearXMLCompletado()
        {
            try
            {
                oListRisOracleRisXmlEventsCompletado = new Ris().Sp_RisOracleRisXmlEventsCompletado_Consulta(new RisOracleRisXmlEventsCompletadoE(0, "", "", 0, 2));
                for (int i = 0; i < oListRisOracleRisXmlEventsCompletado.Count; i++)
                { Completados(oListRisOracleRisXmlEventsCompletado[i].CodrisCompletado.ToString(), oListRisOracleRisXmlEventsCompletado[i].XmlMsg, oListRisOracleRisXmlEventsCompletado[i].IdPaciente, oListRisOracleRisXmlEventsCompletado[i].RutPaciente); }
            }
            catch (Exception ex)
            {
                string txt = NombreMetodo();
                txt = "RISPACS : Error al ejecutar el metodo " + txt;
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", txt, ex.Message.ToString()));
                GrabarLog(txt, ex.Message.ToString());
            }
        }
        #endregion

        #region CopiarPDF
        public void CopiarPDF()
        {
            int cont = 0;
            try
            {
                oListPdfDocument = new Ris().Sp_PDFDOCUMENT_Consulta(new PDFDocumentE("", "", 0, 2));
                for (int i = 0; i < oListPdfDocument.Count; i++)
                {
                    //ValidarExistePresotor - oListPresotor
                    ValidarExistePresotor(new PresotorE(oListPdfDocument[i].ORDERPLACER, "", "", 0, 2));

                    //ValidarExisteAgenda - oListRisAgendamientoAmbulatorio
                    ValidarExisteAgenda(new RisAgendamientoAmbulatorioE(oListPdfDocument[i].ORDERPLACER, "", "", 25, 2));

                    if (oListPresotor.Count == 1 || oListRisAgendamientoAmbulatorio.Count == 1)
                    {

                        oRisOraclePDFDocument.SpsIdKey = oListPdfDocument[i].SPSIDKEY;
                        oRisOraclePDFDocument.PdfDate = oListPdfDocument[i].PDFDATE;
                        oRisOraclePDFDocument.Description = oListPdfDocument[i].DESCRIPTION;
                        oRisOraclePDFDocument.Contents = oListPdfDocument[i].CONTENTS;
                        oRisOraclePDFDocument.Codpresotor = oListPdfDocument[i].ORDERPLACER;
                        oRisOraclePDFDocument.DocExtension = oListPdfDocument[i].DOCEXTENSION;
                        oRisOraclePDFDocument.PdfTime = oListPdfDocument[i].PDFTIME;
                        oRisOraclePDFDocument.Colmedico = oListPdfDocument[i].CODMEDICO;
                        oRisOraclePDFDocument.Version = oListPdfDocument[i].VERSION;
                        oRisOraclePDFDocument.PdfTime = oListPdfDocument[i].PDFTIME;

                        #region GrabarPDF RisClinica -> Clinica
                        try
                        {
                            new Ris().GrabarDatos_RisOraclePdfDocument(oRisOraclePDFDocument);
                            GrabarLog("CopiarPDF", "Se Grabó de manera exitosa en la tabla RisOraclePdfDocument - OrderPlacer= " + oRisOraclePDFDocument.Codpresotor);

                            ActualizarEstadoPDF(new PDFDocumentE("1", "estado", oListPdfDocument[i].ORDERPLACER, oListPdfDocument[i].SPSIDKEY));
                            oListRisAgendamientoAmbulatorio = new List<RisAgendamientoAmbulatorioE>();
                        }
                        catch (Exception ex)
                        { GrabarLog("Error en funcion CopiarPDF - GrabarDatos_RisOraclePdfDocument(Insertar el PDF en la tabla Maestra de Clinica)", ex.Message.ToString() + " OrderPlacer= " + oRisOraclePDFDocument.Codpresotor); }
                        #endregion

                        #region  FormatearPDFaClinica
                        if (oListPresotor.Count == 1)
                        {
                            try
                            {
                                new Ris().Sp_RisCopiar_PDF(oRisOraclePDFDocument);
                                oListPresotor = new List<PresotorE>();
                                oListRisAgendamientoAmbulatorio = new List<RisAgendamientoAmbulatorioE>();
                            }
                            catch (Exception ex)
                            {
                                GrabarLog("Error en funcion CopiarPDF - Sp_RisCopiar_PDF(Insertar el PDF en la tablas presotor_estados, presotor_doc y presotor_pdf) - Cod.Presotor" + oRisOraclePDFDocument.Codpresotor, ex.Message.ToString());
                                new Ris().GrabarLogPDF(oListPdfDocument[i].ORDERPLACER, oListPdfDocument[i].VERSION.ToString());
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        if (oListPdfDocument[i].ESTADO == 0)
                        {
                            ActualizarEstadoPDF(new PDFDocumentE("2", "estado", oListPdfDocument[i].ORDERPLACER, oListPdfDocument[i].SPSIDKEY));
                            EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "PDF", oListPdfDocument[i].ORDERPLACER, oListPdfDocument[i].SPSIDKEY, "RISPACS : Error no esta registrada la orden en clinica", "OrderPlacer = " + oListPdfDocument[i].ORDERPLACER));
                            GrabarLog("No existe Orden en clinica NRO " + oListPdfDocument[i].ORDERPLACER, "Servicio OrderPlacer " + oListPdfDocument[i].ORDERPLACER + " NO EXISTE.");
                        }
                        else
                        {
                            GrabarLog("Orden clinica NRO " + oListPdfDocument[i].ORDERPLACER, "OrderPlacer " + oListPdfDocument[i].ORDERPLACER + " sigue sin existir.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = NombreMetodo();
                txt = "RISPACS : Error al ejecutar el metodo " + txt;
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", txt, ex.Message.ToString()));
                GrabarLog(txt, ex.Message.ToString());
            }

        }
        #endregion



        #region Completados
        public void Completados(string pCodRisCompletado, string pXmlString, string pCodPacienteEnvio, string pDocPacienteEnvio)
        {
            XmlDocument Xml;
            XmlNodeList NodoTotalRegistros, NodoDetalleExamenes;

            int TotalRegistros;
            int cont = 0, cont1;
            string xPrestacion = "", xDscPrestacion = "", xStatus = "", xPacs = "", xSala = "";

            try
            {
                #region Obtener el Detalle del XML - Ejemplo
                //Estructura ANTIGUA
                //---------------------------------------------
                // <PROCEDURE_CODE>003440405</PROCEDURE_CODE>
                // <PROCEDURE_DESCRIPTION>RX 1 CLAVICULA</PROCEDURE_DESCRIPTION>
                // <SPS_ID>9275000041197</SPS_ID>
                // <SEQUENCE_ID>1</SEQUENCE_ID>
                // <PACS_SPS_ID>9275000041197</PACS_SPS_ID>
                // <ROOM_CODE>RX1</ROOM_CODE>
                // <STATUS>Realizado</STATUS>
                // <ORDER_PLACER>R00174780001</ORDER_PLACER>
                //---------------------------------------------
                // 8 Lineas

                // Estructura NUEVA 2018
                //---------------------------------------------
                //<REQUESTED_PROCEDURE>
                //	<PAID_FLAG>N</PAID_FLAG>
                //	<START_DATETIME>20181214152356</START_DATETIME>
                //	<STATUS_KEY>100</STATUS_KEY>
                //	<PACS_SPS_ID>9275007637859</PACS_SPS_ID>
                //	<PROCEDURE_CODE>003440403</PROCEDURE_CODE>
                //	<PROCEDURE_DESCRIPTION>RX 1 TORAX F</PROCEDURE_DESCRIPTION>
                //	<ROOM_CODE>RX2</ROOM_CODE>
                //	<STATUS>Examen Hecho</STATUS>
                //</REQUESTED_PROCEDURE>
                //---------------------------------------------
                // 8 Lineas
                #endregion

                //Para cargar desde una variable
                Xml = new XmlDocument();
                pXmlString = pXmlString.Replace("^", "");
                pXmlString = pXmlString.Replace("'", "");
                Xml.LoadXml(pXmlString);

                //' Contar la cantidad de Detalles
                NodoTotalRegistros = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE/PROCEDURE_CODE");
                TotalRegistros = NodoTotalRegistros.Count;


                XmlNodeList NodoCodPresotor;
                string codPrestor = "";

                #region Obtener el Código de Presotor
                NodoCodPresotor = Xml.SelectNodes("/SENDEVENT/VISIT/ORDER_PLACER_NUMBER");
                foreach (XmlNode outerNode in NodoCodPresotor)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { codPrestor = InnerNode.InnerText.Trim(); }

                }
                #endregion

                ValidarExistePresotor(new PresotorE(codPrestor, "", "", 0, 2));

                NodoDetalleExamenes = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE");

                oRisExamenCompletado.CodrisCompletado = Convert.ToInt32(pCodRisCompletado);
                oRisExamenCompletado.Fecha = "";


                foreach (XmlNode outerNode in NodoDetalleExamenes)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    {
                        cont++;
                        if (InnerNode.Name == "PROCEDURE_CODE")
                        { xPrestacion = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "PROCEDURE_DESCRIPTION")
                        { xDscPrestacion = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "PACS_SPS_ID")
                        { xPacs = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "ROOM_CODE")
                        { xSala = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "STATUS")
                        {
                            oRisExamenCompletado.Codprestacion = xPrestacion;
                            oRisExamenCompletado.Nombre = xDscPrestacion;
                            oRisExamenCompletado.SpsId = xPacs;
                            oRisExamenCompletado.PacsSpsId = xPacs;
                            oRisExamenCompletado.Codsala = xSala;
                            oRisExamenCompletado.Status = InnerNode.InnerText.Trim();
                            oRisExamenCompletado.Codpresotor = codPrestor;
                            cont = 0;
                        }
                    }
                }
                oRisExamenCompletado.Estado = "A";

                if (oListPresotor.Count == 1)
                {
                    if (new Ris().Sp_RisExamenCompletado_Insert(oRisExamenCompletado))
                    {
                        GrabarLog("Examen completo registrado correctamente", "Codigo=" + codPrestor + "Documento=" + pDocPacienteEnvio);
                        ActualizarEstadoAgendamientoCompletado(Convert.ToInt32(pCodRisCompletado), "S");
                    }
                    else
                    {
                        ActualizarEstadoAgendamientoCompletado(Convert.ToInt32(pCodRisCompletado), "X");
                        EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al Registrar Examen completo", "Codigo" + codPrestor + "Documento" + pDocPacienteEnvio));
                        GrabarLog("Error al Registrar Examen completo", "Codigo" + codPrestor + "Documento" + pDocPacienteEnvio);
                    }
                }
                else
                { ActualizarEstadoAgendamientoCompletado(Convert.ToInt32(pCodRisCompletado), "X"); }
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al copiar XML formateado Completado", ex.Message.ToString()));
                GrabarLog("Error al copiar XML formateado Completado", ex.Message.ToString());
            }

        }
        #endregion

        #region CancelarAgenda
        public void CancelarAgenda(int pCodRisAmbulatorio, string pXmlString, string pCodPacienteEnvio, string pDocPacienteEnvio)
        {
            XmlDocument Xml;

            //NodoTotalRegistros    --> Para obtener la Cantidad de Registros.
            //NodoCodPaciente       --> Para obtener el Código de Paciente.
            //NodoVersion           --> Para obtener la version 
            //NodoDetalleExamenes   --> Para obtener los Datos de los Examenes.

            XmlNodeList NodoTotalRegistros, NodoCodPaciente, NodoVersion, NodoDetalleExamenes, NodoPresotor;
            string CodPaciente = "", Cprestacion, Version, OrderPlacer = "", StatusKey = "", xPresotor = "";
            int TotalRegistros = 0;

            try
            {
                #region Detalle del XML - Ejemplo
                //---------------------------------------------
                //Estructura nueva version 2018
                //<PAID_FLAG>N</PAID_FLAG>
                //<START_DATETIME>20180704101500</START_DATETIME>
                //<STATUS_KEY>40</STATUS_KEY>
                //<PACS_SPS_ID>9275007636558</PACS_SPS_ID>
                //<PROCEDURE_CODE>003440501</PROCEDURE_CODE>
                //<PROCEDURE_DESCRIPTION>RX ABDOMEN SIMPLE</PROCEDURE_DESCRIPTION>
                //<ROOM_CODE>RX2</ROOM_CODE>
                //<VERSION>2</VERSION>
                //<STATUS>Agendado</STATUS>
                //---------------------------------------------
                // 8 Lineas
                #endregion

                Xml = new XmlDocument();

                //Para cargar desde una variable
                pXmlString = pXmlString.Replace("^", "");
                pXmlString = pXmlString.Replace("'", "");
                Xml.LoadXml(pXmlString);

                NodoTotalRegistros = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE/PROCEDURE_CODE");
                TotalRegistros = NodoTotalRegistros.Count;

                #region Obtener el Código de Paciente
                NodoCodPaciente = Xml.SelectNodes("/SENDEVENT/PATIENT/PATIENT_ID");
                foreach (XmlNode outerNode in NodoCodPaciente)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { CodPaciente = InnerNode.InnerText.Trim(); }
                }
                #endregion

                NodoDetalleExamenes = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE");
                int cont = 0;

                ValidarExisteAgenda(new RisAgendamientoAmbulatorioE(pCodRisAmbulatorio.ToString(), "", "", 25, 2));

                #region Obtener CodPaciente
                foreach (XmlNode outerNode in NodoCodPaciente)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { CodPaciente = InnerNode.InnerText.Trim(); }
                }

                ValidarExistePaciente(new PacientesE(4, CodPaciente, 25));
                #endregion

                #region Obtener  Version
                NodoVersion = Xml.SelectNodes("/SENDEVENT/VERSION");
                foreach (XmlNode outerNode in NodoVersion)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { Version = InnerNode.InnerText.Trim(); }
                }
                #endregion

                #region Obtener  presotor
                NodoPresotor = Xml.SelectNodes("/SENDEVENT/VISIT/ORDER_PLACER_NUMBER");
                foreach (XmlNode outerNode in NodoPresotor)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { xPresotor = InnerNode.InnerText.Trim(); }
                }
                #endregion

                #region Obtener  Codprestacion, OrderPlaces y StatusKey
                foreach (XmlNode outerNode in NodoDetalleExamenes)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    {
                        cont = cont + 1;
                        if (InnerNode.Name == "PROCEDURE_CODE")
                        { Cprestacion = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "PACS_SPS_ID")
                        { OrderPlacer = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "STATUS_KEY")
                        { StatusKey = InnerNode.InnerText.Trim(); }
                    }
                }
                #endregion

                #region Insertar Agenda Cancelada y Actualizar Estado
                try
                {
                    new Ris().Sp_RisAgendamientoAmbulatorio_Cancela(new RisAgendamientoAmbulatorioE(OrderPlacer, StatusKey, xPresotor));
                    ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "S");
                    GrabarLog("Cancelar Agendamiento OK", "Cancelar actualizada Correctamente: Order = " + OrderPlacer + "/Key = " + StatusKey + "--" + xPresotor);
                }
                catch (Exception ex)
                {
                    GrabarLog("ERROR - Cancelar Agendamiento", "Order = " + OrderPlacer + "/Key = " + StatusKey + " /Presotor = " + xPresotor);
                    ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "N");
                }
                #endregion
            }
            catch (Exception ex)
            {
                new EnvioCorreo().Sp_Ris_EnvioCorreo(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : ERROR al cancelar XML formateado Agendamiento", ex.Message.ToString()));
                GrabarLog("ERROR al cancelar XML formateado Agendamiento - Orden:" + OrderPlacer, ex.Message.ToString());
            }
        }
        #endregion

        #region Agendamiento
        public void Agendamiento(int pCodRisAmbulatorio, string pXmlString, string pCodPacienteEnvio, string pDocPacienteEnvio)
        {
            XmlDocument Xml;

            //NodoTotalRegistros    --> Para obtener la Cantidad de Registros.
            //NodoCodPaciente       --> Para obtener el Código de Paciente.
            //NodoVersion           --> Para obtener la version 
            //NodoDetalleExamenes   --> Para obtener los Datos de los Examenes.

            XmlNodeList NodoTotalRegistros, NodoCodPaciente, NodoVersion, NodoDetalleExamenes, NodoReceta;
            string CodPaciente = "", Version = "";
            string? Cprestacion = "", SPS_AGENDA = "", Fecha = "", cSala = "", CFecha = "", flgPagado = "", STATUS_KEY = "", PROCEDURE_DESCRIPTION = "", STATUS = "";
            int TotalRegistros = 0;

            try
            {
                #region Obtener el Detalle del XML - Ejemplo
                //Obtener el Detalle de los Exámenes
                //---------------------------------------------
                //Estructura nueva version 2018
                //<PAID_FLAG>N</PAID_FLAG>                        ->1
                //<START_DATETIME>20180704101500</START_DATETIME> ->2
                //<STATUS_KEY>40</STATUS_KEY>                     ->3
                //<PACS_SPS_ID>9275007636558</PACS_SPS_ID>        ->4
                //<PROCEDURE_CODE>003440501</PROCEDURE_CODE>      ->5
                //<PROCEDURE_DESCRIPTION>RX ABDOMEN SIMPLE</PROCEDURE_DESCRIPTION> ->6
                //<ROOM_CODE>RX2</ROOM_CODE>                      ->7
                //<VERSION>2</VERSION>                            ->8
                //<STATUS>Agendado</STATUS>                       ->9
                //---------------------------------------------
                // 8 Lineas
                #endregion

                //Para cargar desde una variable
                Xml = new XmlDocument();
                pXmlString = pXmlString.Replace("^", "");
                pXmlString = pXmlString.Replace("'", "");
                Xml.LoadXml(pXmlString);

                //Contar la cantidad de Detalles
                NodoTotalRegistros = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE/PROCEDURE_CODE");
                TotalRegistros = NodoTotalRegistros.Count;

                #region Obtener el Código de Paciente
                NodoCodPaciente = Xml.SelectNodes("/SENDEVENT/PATIENT/PATIENT_ID");
                foreach (XmlNode outerNode in NodoCodPaciente)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { CodPaciente = InnerNode.InnerText.Trim(); }
                }
                #endregion

                NodoDetalleExamenes = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE");

                //ORDER_PLACER_NUMBER
                int cont = 0; //Cuenta y separa las 8 lineas

                ValidarExisteAgenda(new RisAgendamientoAmbulatorioE(pCodRisAmbulatorio.ToString(), "", "", 25, 2));

                #region Obtener  la Version
                NodoVersion = Xml.SelectNodes("/SENDEVENT/VERSION");
                foreach (XmlNode outerNode in NodoVersion)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { Version = InnerNode.InnerText.Trim(); }
                }
                #endregion

                #region Obtener el IDRECETA - PRE-ORDENADO 
                string IdeReceta = "";
                NodoReceta = Xml.SelectNodes("/SENDEVENT/VISIT/ORDER_PLACER_NUMBER");
                foreach (XmlNode outerNode in NodoReceta)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    {
                        IdeReceta = InnerNode.InnerText.Trim();
                        IdeReceta = IdeReceta.Substring(3);
                    }
                }
                #endregion

                #region Obtener el Código de Paciente
                foreach (XmlNode outerNode in NodoCodPaciente)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { CodPaciente = InnerNode.InnerText.Trim(); }
                }
                #endregion

                //ValidarExistePaciente
                ValidarExistePaciente(new PacientesE(4, CodPaciente, 25));

                foreach (XmlNode outerNode in NodoDetalleExamenes)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    {
                        cont++;
                        if (cont == 1)
                        { flgPagado = InnerNode.InnerText.Trim(); }
                        if (cont == 2)
                        {
                            Fecha = InnerNode.InnerText.Trim();
                            CFecha = Fecha.Substring(0, 4) + "-" + Fecha.Substring(4, 2) + "-" + Fecha.Substring(6, 2) + "T" + Fecha.Substring(8, 2) + ":" + Fecha.Substring(10, 2) + ":" + Fecha.Substring(12, 2) + "-05:00";
                        }
                        if (cont == 3)
                        { STATUS_KEY = InnerNode.InnerText.Trim(); }
                        if (cont == 4)
                        { SPS_AGENDA = InnerNode.InnerText.Trim(); }
                        if (cont == 5)
                        { Cprestacion = InnerNode.InnerText.Trim(); }
                        if (cont == 6)
                        { PROCEDURE_DESCRIPTION = InnerNode.InnerText.Trim(); }
                        if (cont == 7)
                        { cSala = InnerNode.InnerText.Trim(); }
                        if (cont == 8)
                        { STATUS = InnerNode.InnerText.Trim(); }
                        //if (cont == 9)
                        //{ STATUS = InnerNode.InnerText.Trim(); }
                    }
                }

                ValidarExisteSalaPrestacion(new RisPrestacionVsSalasE(cSala, Cprestacion, 2));


                if (oListaPacientes.Count != 0 && oListRisPrestacionVsSalasE.Count == 1)
                {
                    oRisAgendamientoAmbulatorio.CodrisAmbulatorio = pCodRisAmbulatorio;//1
                    oRisAgendamientoAmbulatorio.Codpaciente = CodPaciente; //2
                    oRisAgendamientoAmbulatorio.IdeRecetadet = IdeReceta;//3
                    oRisAgendamientoAmbulatorio.SequenceId = "1";//4
                    oRisAgendamientoAmbulatorio.FlgPagado = flgPagado;///4.1
                    oRisAgendamientoAmbulatorio.StartDatetime = CFecha;///4.2
                    oRisAgendamientoAmbulatorio.StatusKey = STATUS_KEY;///4.3
                    oRisAgendamientoAmbulatorio.SpsId = SPS_AGENDA;//-->4.4
                    oRisAgendamientoAmbulatorio.Codprestacion = Cprestacion; //4.5
                    oRisAgendamientoAmbulatorio.Nombre = PROCEDURE_DESCRIPTION;//4.6
                    oRisAgendamientoAmbulatorio.Codsala = cSala;//4.7 
                    oRisAgendamientoAmbulatorio.Status = STATUS;///4.8 ?
                    oRisAgendamientoAmbulatorio.Codpresotor = "";//4.9 ok
                    oRisAgendamientoAmbulatorio.Estado = "A";//4.10 ok


                    if (new Ris().GrabarDatos_RisAgendamientoAmbulatorio(oRisAgendamientoAmbulatorio))
                    {
                        GrabarLog("Se Graba RisAgendamientoAmbulatorio de manera correcta ", "CodigoRisAmbulatorio:" + pCodRisAmbulatorio + " CodPaciente:" + CodPaciente);
                        if (IdeReceta != "")
                        {
                            try
                            {
                                new Ris().Sp_RceRecetaImagenDet_UpdatexCampo(new RceRecetaImagenDetE(Convert.ToInt32(IdeReceta), SPS_AGENDA, "sps_id"));
                                GrabarLog("ORDENADO  IdeReceta=" + IdeReceta, "Se actualizo la agenda " + SPS_AGENDA + "para el ordenado " + IdeReceta);
                            }
                            catch (Exception ex)
                            { GrabarLog("ERROR ORDENADO  IdeReceta=" + IdeReceta, "Se actualizo la agenda " + SPS_AGENDA + "para el ordenado " + IdeReceta); }
                        }
                        ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "S");
                    }
                    else
                    {
                        ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "X");
                        EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS :ERROR al grabar RisAgendamientoAmbulatorio", "CodigoRisAmbulatorio:" + pCodRisAmbulatorio + " CodPaciente:" + CodPaciente));
                        GrabarLog("ERROR al grabar RisAgendamientoAmbulatorio", "CodigoRisAmbulatorio:" + pCodRisAmbulatorio + " CodPaciente:" + CodPaciente);
                    }
                }
                else
                {
                    ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "X");
                    EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "AGV", CodPaciente, pDocPacienteEnvio, "RISPACS : Error al agendar ", oListaPacientes.Count.ToString() + "" + oListRisPrestacionVsSalasE.Count));

                    GrabarLog("Error al agendar: " + CodPaciente, "Paciente=" + oListaPacientes.Count.ToString() + "Sala=" + oListRisPrestacionVsSalasE.Count);
                    //GrabarLog("Error al agendar: " + CodPacienteEnvio, ExistePaciente & " " & ExisteSala)
                    oListaPacientes = new List<PacientesE>();
                    oListRisPrestacionVsSalasE = new List<RisPrestacionVsSalasE>();
                }
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al copiar XML formateado Agendamiento", ex.Message.ToString()));
                GrabarLog("Error al copiar XML formateado Agendamiento - Orden:" + SPS_AGENDA + " CodRisAmbulatorio:" + pCodRisAmbulatorio, ex.Message.ToString());
            }
        }
        #endregion

        #region ActualizarAgenda
        public void ActualizarAgenda(int pCodRisAmbulatorio, string pXmlString, string pCodPacienteEnvio, string pDocPacienteEnvio)
        {
            XmlDocument Xml;

            //NodoTotalRegistros    --> Para obtener la Cantidad de Registros.
            //NodoCodPaciente       --> Para obtener el Código de Paciente.
            //NodoVersion           --> Para obtener la version 
            //NodoDetalleExamenes   --> Para obtener los Datos de los Examenes.

            XmlNodeList NodoTotalRegistros, NodoCodPaciente, NodoVersion, NodoDetalleExamenes;
            string CodPaciente = "";
            string Cprestaciones = "", Fecha = "", CFecha = "", cSala = "", Version = "", OrderPlacer = "", StatusKey = "";
            int TotalRegistros = 0;

            try
            {
                //Obtener el Detalle de los Exámenes
                //---------------------------------------------
                //Estructura nueva version 2018
                //<PAID_FLAG>N</PAID_FLAG>
                //<START_DATETIME>20180704101500</START_DATETIME>
                //<STATUS_KEY>40</STATUS_KEY>
                //<PACS_SPS_ID>9275007636558</PACS_SPS_ID>
                //<PROCEDURE_CODE>003440501</PROCEDURE_CODE>
                //<PROCEDURE_DESCRIPTION>RX ABDOMEN SIMPLE</PROCEDURE_DESCRIPTION>
                //<ROOM_CODE>RX2</ROOM_CODE>
                //<VERSION>2</VERSION>
                //<STATUS>Agendado</STATUS>
                //---------------------------------------------
                // 8 Lineas
                //Cuenta y separa las 8 lineas
                int cont = 0;

                //Para cargar desde una variable
                Xml = new XmlDocument();
                pXmlString = pXmlString.Replace("^", "");
                pXmlString = pXmlString.Replace("'", "");
                Xml.LoadXml(pXmlString);

                //Contar la cantidad de Detalles
                NodoTotalRegistros = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE/PROCEDURE_CODE");
                TotalRegistros = NodoTotalRegistros.Count;

                #region  Obtener el Código de Paciente
                NodoCodPaciente = Xml.SelectNodes("/SENDEVENT/PATIENT/PATIENT_ID");
                foreach (XmlNode outerNode in NodoCodPaciente)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { CodPaciente = InnerNode.InnerText.Trim(); }
                }
                #endregion

                NodoDetalleExamenes = Xml.SelectNodes("/SENDEVENT/REQUESTED_PROCEDURE");

                ValidarExisteAgenda(new RisAgendamientoAmbulatorioE(pCodRisAmbulatorio.ToString(), "", "", 25, 2));

                #region  Obtener el Código de Paciente
                foreach (XmlNode outerNode in NodoCodPaciente)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { CodPaciente = InnerNode.InnerText.Trim(); }
                }
                #endregion

                ValidarExistePaciente(new PacientesE(4, CodPaciente, 25));

                #region Obtener  la version
                NodoVersion = Xml.SelectNodes("/SENDEVENT/VERSION");
                foreach (XmlNode outerNode in NodoVersion)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    { Version = InnerNode.InnerText.Trim(); }
                }
                #endregion 

                #region Obtener  Fecha, Prestaciones, Sala, OrderPlacer, StatusKey
                foreach (XmlNode outerNode in NodoDetalleExamenes)
                {
                    foreach (XmlNode InnerNode in outerNode.ChildNodes)
                    {
                        cont++;
                        if (InnerNode.Name == "START_DATETIME")
                        {
                            Fecha = InnerNode.InnerText.Trim();
                            CFecha = Fecha.Substring(0, 4) + "-" + Fecha.Substring(4, 2) + "-" + Fecha.Substring(6, 2) + "T" + Fecha.Substring(8, 2) + ":" + Fecha.Substring(10, 2) + ":" + Fecha.Substring(12, 2) + "-05:00";
                        }
                        if (InnerNode.Name == "PROCEDURE_CODE")
                        { Cprestaciones = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "ROOM_CODE")
                        { cSala = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "PACS_SPS_ID")
                        { OrderPlacer = InnerNode.InnerText.Trim(); }
                        if (InnerNode.Name == "STATUS_KEY")
                        { StatusKey = InnerNode.InnerText.Trim(); }
                    }
                }
                #endregion

                ValidarExisteSalaPrestacion(new RisPrestacionVsSalasE(cSala, Cprestaciones, 2));

                oRisAgendamientoAmbulatorio.Codsala = cSala;
                oRisAgendamientoAmbulatorio.StartDatetime = Fecha;
                oRisAgendamientoAmbulatorio.Version = Convert.ToInt32(Version.Substring(0, 1));
                oRisAgendamientoAmbulatorio.SpsId = OrderPlacer;
                oRisAgendamientoAmbulatorio.StatusKey = StatusKey;

                try
                {
                    if (StatusKey.Length == 2)
                    { new Ris().Sp_RisAgendamientoAmbulatorio_Actualiza(oRisAgendamientoAmbulatorio); }
                    ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "S");
                    GrabarLog("Actualizar Agendamiento XML", "Agenda actualizada Correctamente: " + OrderPlacer + " /Version:" + Version + " /Key:" + StatusKey + " /Sala:" + cSala + " /Estado:S");
                }
                catch (Exception ex)
                {
                    ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "N");
                    GrabarLog("ERROR Actualizar Agendamiento XML", ex.Message.ToString() + " Agenda: " + OrderPlacer + "/ Version:" + Version + "/Key:" + StatusKey + "/Sala:" + cSala);
                }

            }
            catch (Exception ex)
            {
                ActualizarEstadoAgendamiento(pCodRisAmbulatorio, "X");
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al copiar XML formateado Agendamiento Actualizar", ex.Message.ToString()));
                GrabarLog("Error al copiar XML formateado Actualizar Agendamiento - Orden:" + OrderPlacer + " CodRisAmbulatorio:" + pCodRisAmbulatorio, ex.Message.ToString());
            }
        }
        #endregion

        #region ActualizarEstadoPDF
        public void ActualizarEstadoPDF(PDFDocumentE pPDFDocument)
        {
            try
            {
                new Ris().Sp_PDFDOCUMENT_UpdatexCampo(pPDFDocument);
                GrabarLog("Se actualizo el estado de PDF - Ris_Clinica OrderPlacer= " + pPDFDocument.ORDERPLACER, "al estado: 1");
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al actualizar el estado del PDF en Ris_Clinica", ex.Message.ToString()));
                GrabarLog("Error en funcion ActualizarEstadoPDF - Sp_PDFDOCUMENT_UpdatexCampo(Actualiza el Estado)", ex.Message.ToString() + " OrderPlacer= " + pPDFDocument.ORDERPLACER);
            }
        }
        #endregion

        #region EliminarReservasAntiguas
        public void EliminarReservasAntiguas()
        {
            try
            { new Ris().Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo(); }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al cancelar Reservas Antiguas", ex.Message.ToString()));
                GrabarLog("Error al cancelar Reservas Antiguas", ex.Message.ToString());
            }
        }
        #endregion



        #region ValidarExisteSalaPrestacion
        public void ValidarExisteSalaPrestacion(RisPrestacionVsSalasE pRisPrestacionVsSalas)
        {
            try
            {
                oListRisPrestacionVsSalasE = new Ris().Sp_RisPrestacionVsSalas_Consulta(pRisPrestacionVsSalas);
                //GrabarLog("Consulta sala: OrderPlacer existe", pRisPrestacionVsSalas.Codprestacion + " -- " + pRisPrestacionVsSalas.Codsala);
            }
            catch (Exception ex)
            { GrabarLog("Error al consultar Sala: " + pRisPrestacionVsSalas.Codprestacion, ex.Message.ToString()); }
        }
        #endregion

        #region ValidarExistePaciente
        public void ValidarExistePaciente(PacientesE pPacientes)
        {
            try
            {
                oListaPacientes = new Bus.Clinica.Pacientes().ConsultaPacientes(pPacientes);
            }
            catch (Exception ex)
            {
                GrabarLog("Error al consultar Pacientes: " + pPacientes.CodPaciente, ex.Message.ToString());
            }
        }
        #endregion

        #region ValidarExistePresotor
        public void ValidarExistePresotor(PresotorE pPresotor)
        {
            try
            {
                oListPresotor = new Presotor().Sp_Presotor_ConsultaV2(pPresotor);
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : No existe OrderPlacer", ex.Message.ToString()));
                GrabarLog("Error al consultar el OrderPlacer " + pPresotor.CodPresotor, ex.Message.ToString());
            }
        }
        #endregion

        #region ValidarExisteAgenda
        public void ValidarExisteAgenda(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorio)
        {
            try
            {
                oListRisAgendamientoAmbulatorio = new Ris().Sp_RisAgendamientoAmbulatorio_Consulta(pRisAgendamientoAmbulatorio);
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : No existe OrderPlacer", ex.Message.ToString()));
                GrabarLog("Error al consultar el Agenda: " + pRisAgendamientoAmbulatorio.PacsSpsId, ex.Message.ToString());
            }
        }
        #endregion



        #region ActualizarEstadoAgendamiento
        public void ActualizarEstadoAgendamiento(int pCodRisAmbulatorio, string pEstado)
        {
            try
            {
                new Ris().Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo(new RisOracleRisXmlEventsAmbulatorioE(pCodRisAmbulatorio, pEstado, "flag_procesado"));
                //''GrabarLog("Se actualizó estado en la tabla Agendamiento(RisOracleRisXmlEventsAmbulatorio)", "Estado=" + pEstado + " Codigo=" + pCodRisAmbulatorio);
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al actualizar el estado en la tabla Agendamiento(RisOracleRisXmlEventsAmbulatorio)", ex.Message.ToString() + " " + pCodRisAmbulatorio));
                GrabarLog("Error al actualizar el estado en la tabla Agendamiento(RisOracleRisXmlEventsAmbulatorio)", ex.Message.ToString() + " Codigo=" + pCodRisAmbulatorio);
            }
        }
        #endregion
        #region ActualizarEstadoAgendamientoCompletado
        public void ActualizarEstadoAgendamientoCompletado(int pCodRisAmbulatorio, string pEstado)
        {
            try
            {
                new Ris().Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo(new RisOracleRisXmlEventsCompletadoE(pCodRisAmbulatorio, pEstado, "flag_procesado"));
                GrabarLog("Se actualizó estado en la tabla (RisOracleRisXmlEventsCompletado)", "Estado=" + pEstado + " Codigo=" + pCodRisAmbulatorio);
            }
            catch (Exception ex)
            {
                EnviarCorreoDetalle(new RisEnvioCorreoE("ADM", "SYS", "", "", "RISPACS : Error al actualizar el estado en la tabla Agendamiento(RisOracleRisXmlEventsCompletado)", ex.Message.ToString() + " " + pCodRisAmbulatorio));
                GrabarLog("Error al actualizar el estado en la tabla(RisOracleRisXmlEventsAmbulatorio)", ex.Message.ToString() + " Codigo=" + pCodRisAmbulatorio);
            }
        }
        #endregion

        #region GrabarLog
        public void GrabarLog(string pCuerpo, string pError)
        {
            try
            {
                string path = @"C:\ris_xml_events_logs\";
                //Creamos el directorio
                Directory.CreateDirectory(path);
                //Establecemos la ubicación del fichero de texto
                path += DateTime.Now.ToString("yyyyMMdd") + ".txt";

                //Escribimos en el fichero
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff") + " - " + pCuerpo + " - " + pError);
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region EnviarCorreoDetalle
        public void EnviarCorreoDetalle(RisEnvioCorreoE pRisEnvioCorreoE)
        {
            try
            { new EnvioCorreo().Sp_Ris_EnvioCorreo(pRisEnvioCorreoE); }
            catch (Exception ex)
            { GrabarLog("Error al ejecutar Sp_Ris_EnvioCorreo", ex.Message.ToString()); }
        }
        #endregion

        #region NombreMetodo
        public static string NombreMetodo()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);

            return stackFrame.GetMethod().Name;
        }
        #endregion
    }
}
