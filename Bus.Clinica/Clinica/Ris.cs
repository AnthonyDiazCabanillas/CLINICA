using Dat.Sql.ClinicaAD.LogAD;
using Dat.Sql.ClinicaAD.RceAD;
using Dat.Sql.ClinicaAD.RisAD;
using Dat.Sql.RisClinicaAD.PDFDocumentAD;
using Ent.Sql.ClinicaE.RceE;
using Ent.Sql.ClinicaE.RisE;
using Ent.Sql.RisClinicaE.PDFDocumentE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica.Clinica
{
    public class Ris
    {
        #region RisOracleRisXmlEvents 
        public List<RisOracleRisXmlEventsE> Sp_RisOracleRisXmlEvents_Consulta(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            { return new RisOracleRisXmlEventsAD().Sp_RisOracleRisXmlEvents_Consulta(pRisOracleRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public int GrabarDatos_RisOracleRisXmlEvents(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            { return new RisOracleRisXmlEventsAD().Sp_RisOracleRisXmlEvents_Insert(pRisOracleRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEvents_Update(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            { return new RisOracleRisXmlEventsAD().Sp_RisOracleRisXmlEvents_Update(pRisOracleRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEvents_UpdatexCampo(RisOracleRisXmlEventsE pRisOracleRisXmlEventsE)
        {
            try
            { return new RisOracleRisXmlEventsAD().Sp_RisOracleRisXmlEvents_UpdatexCampo(pRisOracleRisXmlEventsE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RisAgendamientoAmbulatorio 
        public List<RisAgendamientoAmbulatorioE> Sp_RisAgendamientoAmbulatorio_Consulta(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_Consulta(pRisAgendamientoAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos_RisAgendamientoAmbulatorio(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_Insert(pRisAgendamientoAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisAgendamientoAmbulatorio_Update(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_Update(pRisAgendamientoAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisAgendamientoAmbulatorio_UpdatexCampo(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_UpdatexCampo(pRisAgendamientoAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisAgendamientoAmbulatorio_Cancela(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_Cancela(pRisAgendamientoAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_RisAgendamientoAmbulatorio_Actualiza(RisAgendamientoAmbulatorioE pRisAgendamientoAmbulatorioE)
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_Actualiza(pRisAgendamientoAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo()
        {
            try
            { return new RisAgendamientoAmbulatorioAD().Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo(); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RisOracleRisXmlEventsAmbulatorio
        public List<RisOracleRisXmlEventsAmbulatorioE> Sp_RisOracleRisXmlEventsAmbulatorio_Consulta(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            { return new RisOracleRisXmlEventsAmbulatorioAD().Sp_RisOracleRisXmlEventsAmbulatorio_Consulta(pRisOracleRisXmlEventsAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos_RisOracleRisXmlEventsAmbulatorio(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            { return new RisOracleRisXmlEventsAmbulatorioAD().Sp_RisOracleRisXmlEventsAmbulatorio_Insert(pRisOracleRisXmlEventsAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEventsAmbulatorio_Insert(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            { return new RisOracleRisXmlEventsAmbulatorioAD().Sp_RisOracleRisXmlEventsAmbulatorio_Insert(pRisOracleRisXmlEventsAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEventsAmbulatorio_Update(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            { return new RisOracleRisXmlEventsAmbulatorioAD().Sp_RisOracleRisXmlEventsAmbulatorio_Update(pRisOracleRisXmlEventsAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo(RisOracleRisXmlEventsAmbulatorioE pRisOracleRisXmlEventsAmbulatorioE)
        {
            try
            { return new RisOracleRisXmlEventsAmbulatorioAD().Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo(pRisOracleRisXmlEventsAmbulatorioE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RceRecetaImagenDetEstadoRisPacs
        public bool Sp_RceRecetaImagenDetEstadoRisPacs_Update(string pSpsIdKey, string pEventTypeId)
        {
            try
            { return new RceRecetaImagenDetEstadoRisPacsAD().Sp_RceRecetaImagenDetEstadoRisPacs_Update(pSpsIdKey, pEventTypeId); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RisPrestacionVsSalas
        public List<RisPrestacionVsSalasE> Sp_RisPrestacionVsSalas_Consulta(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            { return new RisPrestacionVsSalasAD().Sp_RisPrestacionVsSalas_Consulta(pRisPrestacionVsSalasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos_RisPrestacionVsSalas(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            { return new RisPrestacionVsSalasAD().Sp_RisPrestacionVsSalas_Insert(pRisPrestacionVsSalasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisPrestacionVsSalas_Insert(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            { return new RisPrestacionVsSalasAD().Sp_RisPrestacionVsSalas_Insert(pRisPrestacionVsSalasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisPrestacionVsSalas_Update(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            { return new RisPrestacionVsSalasAD().Sp_RisPrestacionVsSalas_Update(pRisPrestacionVsSalasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisPrestacionVsSalas_UpdatexCampo(RisPrestacionVsSalasE pRisPrestacionVsSalasE)
        {
            try
            { return new RisPrestacionVsSalasAD().Sp_RisPrestacionVsSalas_UpdatexCampo(pRisPrestacionVsSalasE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RceRecetaImagenDet
        public bool Sp_RceRecetaImagenDet_UpdatexCampo(RceRecetaImagenDetE pRceRecetaImagenDetE)
        {
            try
            { return new RceRecetaImagenDetAD().Sp_RceRecetaImagenDet_UpdatexCampo(pRceRecetaImagenDetE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RisOracleRisXmlEventsCompletado
        public List<RisOracleRisXmlEventsCompletadoE> Sp_RisOracleRisXmlEventsCompletado_Consulta(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            { return new RisOracleRisXmlEventsCompletadoAD().Sp_RisOracleRisXmlEventsCompletado_Consulta(pRisOracleRisXmlEventsCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos_RisOracleRisXmlEventsCompletado(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            { return new RisOracleRisXmlEventsCompletadoAD().Sp_RisOracleRisXmlEventsCompletado_Insert(pRisOracleRisXmlEventsCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEventsCompletado_Insert(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            { return new RisOracleRisXmlEventsCompletadoAD().Sp_RisOracleRisXmlEventsCompletado_Insert(pRisOracleRisXmlEventsCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEventsCompletado_Update(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            { return new RisOracleRisXmlEventsCompletadoAD().Sp_RisOracleRisXmlEventsCompletado_Update(pRisOracleRisXmlEventsCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo(RisOracleRisXmlEventsCompletadoE pRisOracleRisXmlEventsCompletadoE)
        {
            try
            { return new RisOracleRisXmlEventsCompletadoAD().Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo(pRisOracleRisXmlEventsCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RisExamenCompletado
        public List<RisExamenCompletadoE> Sp_RisExamenCompletado_Consulta(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            { return new RisExamenCompletadoAD().Sp_RisExamenCompletado_Consulta(pRisExamenCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            { return new RisExamenCompletadoAD().Sp_RisExamenCompletado_Insert(pRisExamenCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisExamenCompletado_Insert(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            { return new RisExamenCompletadoAD().Sp_RisExamenCompletado_Insert(pRisExamenCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisExamenCompletado_Update(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            { return new RisExamenCompletadoAD().Sp_RisExamenCompletado_Update(pRisExamenCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_RisExamenCompletado_UpdatexCampo(RisExamenCompletadoE pRisExamenCompletadoE)
        {
            try
            { return new RisExamenCompletadoAD().Sp_RisExamenCompletado_UpdatexCampo(pRisExamenCompletadoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region PDFDocument
        public List<PDFDocumentE> Sp_PDFDOCUMENT_Consulta(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            { return new PDFDocumentAD().Sp_PDFDOCUMENT_Consulta(pPDFDOCUMENTE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool GrabarDatos_PDFDOCUMENT(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            { return new PDFDocumentAD().Sp_PDFDOCUMENT_Insert(pPDFDOCUMENTE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_PDFDOCUMENT_Insert(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            { return new PDFDocumentAD().Sp_PDFDOCUMENT_Insert(pPDFDOCUMENTE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_PDFDOCUMENT_Update(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            { return new PDFDocumentAD().Sp_PDFDOCUMENT_Update(pPDFDOCUMENTE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_PDFDOCUMENT_UpdatexCampo(PDFDocumentE pPDFDOCUMENTE)
        {
            try
            { return new PDFDocumentAD().Sp_PDFDOCUMENT_UpdatexCampo(pPDFDOCUMENTE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region RisOraclePDFDocument
        public bool GrabarDatos_RisOraclePdfDocument(RisOraclePDFDocumentE pRisOraclePdfDocument)
        {
            try
            { return new RisOraclePDFDocument().Sp_RisOraclePdfDocument_Insert(pRisOraclePdfDocument); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_RisCopiar_PDF(RisOraclePDFDocumentE pRisOraclePdfDocument)
        {
            try
            { return new RisOraclePDFDocument().Sp_RisCopiar_PDF(pRisOraclePdfDocument); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

        #region GrabarLogPDF
        public bool GrabarLogPDF(string OrderPLacer, string Version)
        {
            try
            { return new PDFDocumentLog().Sp_Pdf_Document_Log_Insert(OrderPLacer, Version); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        #endregion

    }
}



