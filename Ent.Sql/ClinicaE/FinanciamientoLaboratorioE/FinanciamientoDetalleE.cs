//**********************************************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    Version     Fecha           Autor       Requerimiento
//    1.1         01/04/2024      AROMERO     REQ-2024-006637:  FINANCIAMIENTO LABORATORIO
//***********************************************************************************************************************

namespace Ent.Sql.ClinicaE.FinanciamientoDetalleE
{
    public class FinanciamientoDetalleE
    {
        public int Orden { get; set; } = 0;
        public int Item { get; set; } = 0;
        public string Ide_AnalisisxDiagnostico { get; set; } = "";
        public string Ide_Analisis { get; set; } = "";
        public string Cod_Diagnostico { get; set; } = "";
        public string Nombre_Diagnostico { get; set; } = "";
        public string Cod_Prestacion { get; set; } = "";
        public string Cod_ROE { get; set; } = "";
        public string Prueba_ROE { get; set; } = "";
        public string CodAseguradora { get; set; } = "NO";
        public string CodAseguradoraMask { get; set; } = "NO";
        public string CodAseguradora1 { get; set; } = "NO";
        public string CodAseguradora2 { get; set; } = "NO";
        public string CodAseguradora3 { get; set; } = "NO";
        public string CodAseguradora4 { get; set; } = "NO";
        public string CodAseguradora5 { get; set; } = "NO";
        public string CodAseguradora6 { get; set; } = "NO";
        public string CodAseguradora7 { get; set; } = "NO";
        public string CodAseguradora8 { get; set; } = "NO";
        public string CodAseguradora9 { get; set; } = "NO";
        public string CodAseguradora10 { get; set; } = "NO";
        public string CodAseguradora11 { get; set; } = "NO";
        public string CodAseguradora12 { get; set; } = "NO";
        public string Observacion { get; set; } = "";
        public string ObservacionsSecundaria { get; set; } = "";
        public string Ide_AnalisisTemp { get; set; } = "";
        public string Nombre_Aseguradora { get; set; } = "";
        public string Flag_Estado { get; set; } = "";
        public string Tipo_Atencion { get; set; } = "";

        public string Buscar { get; set; } = "";
        public int Key { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public FinanciamientoDetalleE() { }        

        #region Sp_Financiamiento_Consulta
        /// <summary>
        ///         ''' [Sp_Financiamiento_Consulta]
        ///         ''' </summary>
        ///         ''' <param name="pBuscar"></param>
        ///         ''' <param name="pKey"></param>
        ///         ''' <param name="pNumeroLineas"></param>
        ///         ''' <param name="pOrden"></param>
        public FinanciamientoDetalleE(string pBuscar, int pKey, int pNumeroLineas, int pOrden)
        {
            Buscar = pBuscar;
            Key = pKey;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion
    }

    public class FinanciamientoBuscaE
    {
        private string _buscar { get; set; } = "";
        public string Buscar {
            get => _buscar;
            set => _buscar = value?.ToUpper();
        } 
    }   
}
