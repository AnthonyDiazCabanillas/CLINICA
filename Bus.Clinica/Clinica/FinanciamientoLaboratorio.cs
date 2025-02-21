//**********************************************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    Version     Fecha           Autor       Requerimiento
//    1.1         01/04/2024      AROMERO     REQ-2024-006637:  FINANCIAMIENTO LABORATORIO
//***********************************************************************************************************************

using Ent.Sql.ClinicaE.FinanciamientoDetalleE;
using Dat.Sql.ClinicaAD.FinanciamientoLaboratorioAD;

namespace Bus.Clinica
{
    public class FinanciamientoLaboratorio
    {
        public List<FinanciamientoDetalleE> Financiamiento_ConsultaDetalle(FinanciamientoDetalleE oFinanciamientoDetE)
        {
            List<FinanciamientoDetalleE> oList = new List<FinanciamientoDetalleE>();
            oList = new FinanciamientoCabAD().Sp_FinanciamientoLaboratorio(oFinanciamientoDetE);
            return oList;
        }

        public List<FinanciamientoDetalleE> Financiamiento_Consulta_Update(FinanciamientoDetalleE oFinanciamientoDetE)
        {
            List<FinanciamientoDetalleE> oList = new List<FinanciamientoDetalleE>();
            oList = new FinanciamientoCabAD().Sp_FinanciamientoLaboratorio_Consulta_Update(oFinanciamientoDetE);
            return oList;
        }

        public List<FinanciamientoDetalleE> Financiamiento_ConsultaCIE10(FinanciamientoDetalleE oFinanciamientoDetE)
        {
            List<FinanciamientoDetalleE> oList = new List<FinanciamientoDetalleE>();
            oList = new FinanciamientoCabAD().Sp_FinanciamientoLaboratorio_CIE10(oFinanciamientoDetE);
            return oList;
        }

        public List<FinanciamientoDetalleE> Financiamiento_ConsultaAnalisis(FinanciamientoDetalleE oFinanciamientoDetE)
        {
            List<FinanciamientoDetalleE> oList = new List<FinanciamientoDetalleE>();
            oList = new FinanciamientoCabAD().Sp_FinanciamientoLaboratorio_Analisis(oFinanciamientoDetE);
            return oList;
        }

        public List<FinanciamientoDetalleE> Financiamiento_ConsultaAseguradora(FinanciamientoDetalleE oFinanciamientoDetE)
        {
            List<FinanciamientoDetalleE> oList = new List<FinanciamientoDetalleE>();
            oList = new FinanciamientoCabAD().Sp_FinanciamientoLaboratorio_Aseguradora(oFinanciamientoDetE);
            return oList;
        }

        public List<FinanciamientoDetalleE> insertarFinanciamientomasivo(List<FinanciamientoDetalleE> oListaFinanciamientoE, int usrModifica)
        {
            List<FinanciamientoDetalleE> oListResult = new List<FinanciamientoDetalleE>();
            oListResult = new FinanciamientoCabAD().Sp_Financiamiento_Insert_Masivo(oListaFinanciamientoE, usrModifica);
            return oListResult;
        }

        public bool ActualizarFinanciamiento(List<FinanciamientoDetalleE> oListaFinanciamientoE, int usrModifica)
        {
            bool xResult = false;
            xResult = new FinanciamientoCabAD().Sp_Financiamiento_Update(oListaFinanciamientoE, usrModifica);
            return xResult;
        }

        public List<FinanciamientoDetalleE> Financiamiento_ConsultaAnalisisxCodigo(FinanciamientoDetalleE oFinanciamientoDetE)
        {
            List<FinanciamientoDetalleE> oList = new List<FinanciamientoDetalleE>();
            oList = new FinanciamientoCabAD().Sp_FinanciamientoLaboratorio_AnalisisXAtencion(oFinanciamientoDetE);
            return oList;
        }
    }
}

