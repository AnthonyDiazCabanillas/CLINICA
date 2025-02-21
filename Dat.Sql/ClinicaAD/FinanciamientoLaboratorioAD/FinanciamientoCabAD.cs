//**********************************************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    Version     Fecha           Autor       Requerimiento
//    1.1         01/04/2024      AROMERO     REQ-2024-006637:  FINANCIAMIENTO LABORATORIO
//***********************************************************************************************************************

using Ent.Sql.ClinicaE.FinanciamientoDetalleE;
using System.Data;
using System.Data.SqlClient;

namespace Dat.Sql.ClinicaAD.FinanciamientoLaboratorioAD
{
    public class FinanciamientoCabAD
    {
        Utilitario util = new Utilitario();
        int IdItem = 1;
        string aseg1 = "NO";
        string aseg2 = "NO";
        string aseg3 = "NO";
        string aseg4 = "NO";
        string aseg5 = "NO";
        string aseg6 = "NO";
        string aseg7 = "NO";
        string aseg8 = "NO";
        string aseg9 = "NO";
        string aseg10 = "NO";
        string aseg11 = "NO";
        string aseg12 = "NO";

        string aseg1Neg = "NO";
        string aseg2Neg = "NO";
        string aseg3Neg = "NO";
        string aseg4Neg = "NO";
        string aseg5Neg = "NO";
        string aseg6Neg = "NO";
        string aseg7Neg = "NO";
        string aseg8Neg = "NO";
        string aseg9Neg = "NO";
        string aseg10Neg = "NO";
        string aseg11Neg = "NO";
        string aseg12Neg = "NO";

        string Codaseg1Neg = "";
        string Codaseg2Neg = "";
        string Codaseg3Neg = "";
        string Codaseg4Neg = "";
        string Codaseg5Neg = "";
        string Codaseg6Neg = "";
        string Codaseg7Neg = "";
        string Codaseg8Neg = "";
        string Codaseg9Neg = "";
        string Codaseg10Neg = "";
        string Codaseg11Neg = "";
        string Codaseg12Neg = "";

        string obsPrincipal = "";
        string obsSecundaria = "";


        //Llena la información para la pantalla de actualizacion de financiamiento
        private FinanciamientoDetalleE LlenarEntidadUpdate(IDataReader dr)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();

            oFinanciamientoDetalleE.Ide_AnalisisxDiagnostico = (string)(dr["ide_analisisxdiagnostico"] + "").Trim();
            oFinanciamientoDetalleE.Ide_Analisis = (string)(dr["ide_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Tipo_Atencion = (string)(dr["ide_tipoatencion"] + "").Trim();
            oFinanciamientoDetalleE.Cod_Diagnostico = (string)(dr["cod_diagnostico"] + "").Trim();
            oFinanciamientoDetalleE.Nombre_Diagnostico = (string)(dr["nombre"] + "").Trim();
            oFinanciamientoDetalleE.Cod_ROE = (string)(dr["cod_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Prueba_ROE = (string)(dr["nombreprueba"] + "").Trim();
            oFinanciamientoDetalleE.CodAseguradora1 = (string)(dr["codaseguradora"] + "").Trim();
            oFinanciamientoDetalleE.Nombre_Aseguradora = (string)(dr["nombreaseguradora"] + "").Trim();
            oFinanciamientoDetalleE.Flag_Estado = (string)(dr["flg_estado"] + "").Trim();

            return oFinanciamientoDetalleE;
        }

        //Llena la información para la pantalla de principal de financiamiento
        private FinanciamientoDetalleE LlenarEntidadDet(IDataReader dr, int pOrden)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();

            
                        oFinanciamientoDetalleE.Item = IdItem;
                        oFinanciamientoDetalleE.Ide_AnalisisxDiagnostico = (string)(dr["ide_analisisxdiagnostico"] + "").Trim();
                        oFinanciamientoDetalleE.Ide_Analisis = (string)(dr["ide_analisis"] + "").Trim();
                        oFinanciamientoDetalleE.Tipo_Atencion = (string)(dr["ide_tipoatencion"] + "").Trim();
                        oFinanciamientoDetalleE.Cod_Diagnostico = (string)(dr["cod_diagnostico"] + "").Trim();
                        oFinanciamientoDetalleE.Nombre_Diagnostico = (string)(dr["nombre"] + "").Trim();
                        oFinanciamientoDetalleE.Cod_Prestacion  = (string)(dr["codprestacion"] + "").Trim();
                        oFinanciamientoDetalleE.Cod_ROE = (string)(dr["cod_analisis"] + "").Trim();
                        oFinanciamientoDetalleE.Prueba_ROE = (string)(dr["nombreprueba"] + "").Trim();

                        if ((string)(dr["codaseguradora"] + "").Trim() == "0121")
                        {
                            aseg1 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0257")
                        {
                            aseg2 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0111")
                        {
                            aseg3 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0013")
                        {
                            aseg4 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0207")
                        {
                            aseg5 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0259")
                        {
                            aseg6 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0019")
                        {
                            aseg7 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0235")
                        {
                            aseg8 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0001")
                        {
                            aseg9 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0053")
                        {
                            aseg10 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0275")
                        {
                            aseg11 = "SI";
                        }
                        if ((string)(dr["codaseguradora"] + "").Trim() == "0205")
                        {
                            aseg12 = "SI";
                        }

                        oFinanciamientoDetalleE.CodAseguradora1 = aseg1;
                        oFinanciamientoDetalleE.CodAseguradora2 = aseg2;
                        oFinanciamientoDetalleE.CodAseguradora3 = aseg3;
                        oFinanciamientoDetalleE.CodAseguradora4 = aseg4;
                        oFinanciamientoDetalleE.CodAseguradora5 = aseg5;
                        oFinanciamientoDetalleE.CodAseguradora6 = aseg6;
                        oFinanciamientoDetalleE.CodAseguradora7 = aseg7;
                        oFinanciamientoDetalleE.CodAseguradora8 = aseg8;
                        oFinanciamientoDetalleE.CodAseguradora9 = aseg9;
                        oFinanciamientoDetalleE.CodAseguradora10 = aseg10;
                        oFinanciamientoDetalleE.CodAseguradora11 = aseg11;
                        oFinanciamientoDetalleE.CodAseguradora12 = aseg12;

                        
            return oFinanciamientoDetalleE;
        }

        //Llena la información para la pantalla de resumen de financiamiento, despues de cargar la data
        private FinanciamientoDetalleE LlenarEntidadDetResumen(FinanciamientoDetalleE item, int pOrden)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();
            
            oFinanciamientoDetalleE.Item = IdItem;
            oFinanciamientoDetalleE.Ide_AnalisisxDiagnostico = item.Ide_AnalisisxDiagnostico.Trim();
            oFinanciamientoDetalleE.Ide_AnalisisTemp = item.Ide_AnalisisTemp.Trim();
            oFinanciamientoDetalleE.Ide_Analisis = item.Ide_Analisis.Trim();
            oFinanciamientoDetalleE.Cod_Diagnostico = item.Cod_Diagnostico.Trim();
            oFinanciamientoDetalleE.Nombre_Diagnostico = item.Nombre_Diagnostico.Trim();
            oFinanciamientoDetalleE.Cod_Prestacion = item.Cod_Prestacion.Trim();
            oFinanciamientoDetalleE.Cod_ROE = item.Cod_ROE.Trim();
            oFinanciamientoDetalleE.Prueba_ROE = item.Prueba_ROE.Trim();            
                        
            if (item.CodAseguradora1.Trim() == "0121")
            {
                aseg1 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0257")
            {
                aseg2 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0111")
            {
                aseg3 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0013")
            {
                aseg4 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0207")
            {
                aseg5 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0259")
            {
                aseg6 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0019")
            {
                aseg7 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0235")
            {
                aseg8 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0001")
            {
                aseg9 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0053")
            {
                aseg10 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0275")
            {
                aseg11 = "SI";
            }
            if (item.CodAseguradora1.Trim() == "0205")
            {
                aseg12 = "SI";
            }

            if (!item.CodAseguradora.Trim().ToUpper().Equals("NO"))
            {
                aseg1Neg = item.CodAseguradora.Trim();
                Codaseg1Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora2.Trim().ToUpper().Equals("NO"))
            {
                aseg2Neg = item.CodAseguradora2.Trim();
                Codaseg2Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora3.Trim().ToUpper().Equals("NO"))
            {
                aseg3Neg = item.CodAseguradora3.Trim();
                Codaseg3Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora4.Trim().ToUpper().Equals("NO"))
            {
                aseg4Neg = item.CodAseguradora4.Trim();
                Codaseg4Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora5.Trim().ToUpper().Equals("NO"))
            {
                aseg5Neg = item.CodAseguradora5.Trim();
                Codaseg5Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora6.Trim().ToUpper().Equals("NO"))
            {
                aseg6Neg = item.CodAseguradora6.Trim();
                Codaseg6Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora7.Trim().ToUpper().Equals("NO"))
            {
                aseg7Neg = item.CodAseguradora7.Trim();
                Codaseg7Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora8.Trim().ToUpper().Equals("NO"))
            {
                aseg8Neg = item.CodAseguradora8.Trim();
                Codaseg8Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora9.Trim().ToUpper().Equals("NO"))
            {
                aseg9Neg = item.CodAseguradora9.Trim();
                Codaseg9Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora10.Trim().ToUpper().Equals("NO"))
            {
                aseg10Neg = item.CodAseguradora10.Trim();
                Codaseg10Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora11.Trim().ToUpper().Equals("NO"))
            {
                aseg11Neg = item.CodAseguradora11.Trim();
                Codaseg11Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            if (!item.CodAseguradora12.Trim().ToUpper().Equals("NO"))
            {
                aseg12Neg = item.CodAseguradora12.Trim();
                Codaseg12Neg = "(" + item.CodAseguradoraMask.Trim() + ") ";
            }

            oFinanciamientoDetalleE.CodAseguradora1 = aseg1Neg.Equals("NO") ? aseg1 : aseg1Neg;
            oFinanciamientoDetalleE.CodAseguradora2 = aseg2Neg.Equals("NO") ? aseg2 : aseg2Neg;
            oFinanciamientoDetalleE.CodAseguradora3 = aseg3Neg.Equals("NO") ? aseg3 : aseg3Neg;  
            oFinanciamientoDetalleE.CodAseguradora4 = aseg4Neg.Equals("NO") ? aseg4 : aseg4Neg;  
            oFinanciamientoDetalleE.CodAseguradora5 = aseg5Neg.Equals("NO") ? aseg5 : aseg5Neg;  
            oFinanciamientoDetalleE.CodAseguradora6 = aseg6Neg.Equals("NO") ? aseg6 : aseg6Neg;  
            oFinanciamientoDetalleE.CodAseguradora7 = aseg7Neg.Equals("NO") ? aseg7 : aseg7Neg;  
            oFinanciamientoDetalleE.CodAseguradora8 = aseg8Neg.Equals("NO") ? aseg8 : aseg8Neg;  
            oFinanciamientoDetalleE.CodAseguradora9 = aseg9Neg.Equals("NO") ? aseg9 : aseg9Neg;  
            oFinanciamientoDetalleE.CodAseguradora10 = aseg10Neg.Equals("NO") ? aseg10 : aseg10Neg; 
            oFinanciamientoDetalleE.CodAseguradora11 = aseg11Neg.Equals("NO") ? aseg11 : aseg11Neg; 
            oFinanciamientoDetalleE.CodAseguradora12 = aseg12Neg.Equals("NO") ? aseg12 : aseg12Neg;

            if (!item.Observacion.Trim().Equals(""))
            {
                obsPrincipal = item.Observacion.Trim();
            }

            if (!item.ObservacionsSecundaria.Trim().Equals(""))
            {
                obsSecundaria = "El campo de la(s) aseguradora(s) " 
                    + Codaseg1Neg + Codaseg2Neg + Codaseg3Neg + Codaseg4Neg + Codaseg5Neg + Codaseg6Neg
                    + Codaseg7Neg + Codaseg8Neg + Codaseg9Neg + Codaseg10Neg + Codaseg11Neg + Codaseg12Neg +
                    " deberia decir SI o NO por lo tanto se consideraron como negativo.";
            }

            oFinanciamientoDetalleE.Observacion = obsPrincipal + " " + obsSecundaria;

            return oFinanciamientoDetalleE;
        }

        //Llena la información para la descarga de analisis con tipo de atencion
        private FinanciamientoDetalleE LlenarEntidadAnalisisAtencion(IDataReader dr, int pOrden)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();

            oFinanciamientoDetalleE.Item = IdItem;
            oFinanciamientoDetalleE.Ide_Analisis = (string)(dr["ide_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Cod_ROE = (string)(dr["cod_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Prueba_ROE = (string)(dr["dsc_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Tipo_Atencion = (string)(dr["ide_tipoatencion"] + "").Trim();
            return oFinanciamientoDetalleE;
        }

        //Llena la información para la pantalla de busqueda de CIE-10
        private FinanciamientoDetalleE LlenarEntidadCIE10(IDataReader dr, int pOrden)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();
                        
            oFinanciamientoDetalleE.Item = IdItem;
            oFinanciamientoDetalleE.Cod_Diagnostico = (string)(dr["cod_diagnostico"] + "").Trim();
            oFinanciamientoDetalleE.Nombre_Diagnostico = (string)(dr["nombre"] + "").Trim(); 
            return oFinanciamientoDetalleE;
        }

        //Llena la información para la pantalla de busqueda de Analisis
        private FinanciamientoDetalleE LlenarEntidadAnalisis(IDataReader dr, int pOrden)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();
            oFinanciamientoDetalleE.Item = IdItem;
            oFinanciamientoDetalleE.Ide_Analisis = (string)(dr["ide_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Tipo_Atencion = (string)(dr["ide_tipoatencion"] + "").Trim();
            oFinanciamientoDetalleE.Cod_ROE = (string)(dr["cod_analisis"] + "").Trim();
            oFinanciamientoDetalleE.Prueba_ROE = (string)(dr["dsc_analisis"] + "").Trim();
            return oFinanciamientoDetalleE;
        }

        //Llena la información para la pantalla de busqueda de Aseguradora
        private FinanciamientoDetalleE LlenarEntidadAseguradora(IDataReader dr, int pOrden)
        {
            FinanciamientoDetalleE oFinanciamientoDetalleE = new FinanciamientoDetalleE();

            oFinanciamientoDetalleE.Item = IdItem;
            oFinanciamientoDetalleE.CodAseguradora1 = (string)(dr["codaseguradora"] + "").Trim();
            oFinanciamientoDetalleE.Nombre_Aseguradora = (string)(dr["nombre"] + "").Trim();
            return oFinanciamientoDetalleE;
        }

        //Consulta la información para la pantalla principal de financiamiento
        public List<FinanciamientoDetalleE> Sp_FinanciamientoLaboratorio(FinanciamientoDetalleE pFinanciamientoDetE)
        {
            IDataReader dr;
            FinanciamientoDetalleE oFinanciamientoDetE = null;
            
            List<FinanciamientoDetalleE> oListar = new List<FinanciamientoDetalleE>();
            List<FinanciamientoDetalleE> oListarFinal = new List<FinanciamientoDetalleE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_FinanciamientoLaboratorio", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pFinanciamientoDetE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pFinanciamientoDetE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();

                        //Enviar la lista en Analisis vs aseguradoras
                        string ideAnalisisTemp = string.Empty;
                        string cie10Temp = string.Empty;  
                        while (dr.Read())
                        {
                            //Si temp es vacio lo salta
                            int count = dr.FieldCount;

                            if (!ideAnalisisTemp.Equals(""))
                            {
                                if (!(ideAnalisisTemp.Equals((string)(dr["ide_analisis"] + "").Trim()) && cie10Temp.Equals((string)(dr["cod_diagnostico"] + "").Trim())))
                                {
                                    //Si ide temp es diferente al dr nuevo                                    
                                    oListar.Add(oFinanciamientoDetE);
                                    IdItem = IdItem + 1;
                                    aseg1 = "NO";
                                    aseg2 = "NO";
                                    aseg3 = "NO";
                                    aseg4 = "NO";
                                    aseg5 = "NO";
                                    aseg6 = "NO";
                                    aseg7 = "NO";
                                    aseg8 = "NO";
                                    aseg9 = "NO";
                                    aseg10 = "NO";
                                    aseg11 = "NO";
                                    aseg12 = "NO";
                                }
                            }
                              

                            oFinanciamientoDetE = LlenarEntidadDet(dr, pFinanciamientoDetE.Orden);
                            ideAnalisisTemp = oFinanciamientoDetE.Ide_Analisis;
                            cie10Temp = oFinanciamientoDetE.Cod_Diagnostico;
                        }
                        //Agrega el ultimo analisis de la consulta
                        oListar.Add(oFinanciamientoDetE);

                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        int countlist = oListar.Count();

                        
                        if (countlist > pFinanciamientoDetE.NumeroLineas) {
                            oListar = oListar.OrderBy(item => item.Item).Take(pFinanciamientoDetE.NumeroLineas).ToList();
                        }

                        if (oListar[0]==null) {
                            oListar.Clear();
                        }
                        
                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta la información para la pantalla busqueda de CIE-10
        public List<FinanciamientoDetalleE> Sp_FinanciamientoLaboratorio_CIE10(FinanciamientoDetalleE pFinanciamientoDetE)
        {
            IDataReader dr;
            FinanciamientoDetalleE oFinanciamientoDetE = null;

            List<FinanciamientoDetalleE> oListar = new List<FinanciamientoDetalleE>();
            List<FinanciamientoDetalleE> oListarFinal = new List<FinanciamientoDetalleE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_FinanciamientoLaboratorio", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pFinanciamientoDetE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pFinanciamientoDetE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        string ideAnalisisTemp = string.Empty;
                        string cie10Temp = string.Empty;
                        while (dr.Read())
                        {
                            oFinanciamientoDetE = LlenarEntidadCIE10(dr, pFinanciamientoDetE.Orden);
                            oListar.Add(oFinanciamientoDetE);
                            IdItem = IdItem + 1;

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

        //Consulta la información para la pantalla busqueda de Analisis
        public List<FinanciamientoDetalleE> Sp_FinanciamientoLaboratorio_Analisis(FinanciamientoDetalleE pFinanciamientoDetE)
        {
            IDataReader dr;
         
            FinanciamientoDetalleE oFinanciamientoDetE = null;

            List<FinanciamientoDetalleE> oListar = new List<FinanciamientoDetalleE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_FinanciamientoLaboratorio", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pFinanciamientoDetE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pFinanciamientoDetE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        string ideAnalisisTemp = string.Empty;
                        string cie10Temp = string.Empty;
                        while (dr.Read())
                        {
                            oFinanciamientoDetE = LlenarEntidadAnalisis(dr, pFinanciamientoDetE.Orden);
                            oListar.Add(oFinanciamientoDetE);
                            IdItem = IdItem + 1;
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

        //Consulta la información para la pantalla busqueda de Aseguradora
        public List<FinanciamientoDetalleE> Sp_FinanciamientoLaboratorio_Aseguradora(FinanciamientoDetalleE pFinanciamientoDetE)
        {
            IDataReader dr;
           
            FinanciamientoDetalleE oFinanciamientoDetE = null;

            List<FinanciamientoDetalleE> oListar = new List<FinanciamientoDetalleE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_FinanciamientoLaboratorio", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pFinanciamientoDetE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pFinanciamientoDetE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        string ideAnalisisTemp = string.Empty;
                        string cie10Temp = string.Empty;
                        while (dr.Read())
                        {
                            oFinanciamientoDetE = LlenarEntidadAseguradora(dr, pFinanciamientoDetE.Orden);
                            oListar.Add(oFinanciamientoDetE);
                            IdItem = IdItem + 1;
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

        //Consulta la información para la pantalla de actualización de financiamiento
        public List<FinanciamientoDetalleE> Sp_FinanciamientoLaboratorio_Consulta_Update(FinanciamientoDetalleE pFinanciamientoDetE)
        {
            IDataReader dr;
            
            FinanciamientoDetalleE oFinanciamientoUpdate = new FinanciamientoDetalleE();

            List<FinanciamientoDetalleE> oListar = new List<FinanciamientoDetalleE>();
            List<FinanciamientoDetalleE> oListarFinal = new List<FinanciamientoDetalleE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_FinanciamientoLaboratorio", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pFinanciamientoDetE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pFinanciamientoDetE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oFinanciamientoUpdate = LlenarEntidadUpdate(dr);
                            oListar.Add(oFinanciamientoUpdate);
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        int countlist = oListar.Count();


                        if (countlist > pFinanciamientoDetE.NumeroLineas)
                        {
                            oListar = oListar.OrderBy(item => item.Item).Take(pFinanciamientoDetE.NumeroLineas).ToList();
                        }

                        if (oListar.Any()) {
                            if (oListar[0] == null)
                            {
                                oListar.Clear();
                            }
                        }
                            

                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Registro masivo o individual de analisis por diagnostico
        public List<FinanciamientoDetalleE> Sp_Financiamiento_Insert_Masivo(List<FinanciamientoDetalleE> listFinanciamiento, int usrModifica)
        {
            int xReturn;
            int validacion=0;
            string ideAnalisis="";
            string codprestacion = "";
            try
            {
                FinanciamientoDetalleE oFinanciamientoDetE = null;
                List<FinanciamientoDetalleE> oListarResumen = new List<FinanciamientoDetalleE>();
                List<FinanciamientoDetalleE> oListarLog = new List<FinanciamientoDetalleE>();
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Financiamiento_Insert_Masivo", cnn))
                    {
                        
                        foreach (var item in listFinanciamiento)
                        {
                            FinanciamientoDetalleE oFinanciamientoLog = new FinanciamientoDetalleE();

                            //Validar campos vacios, sino inserta
                            if (item.Cod_Diagnostico.Trim().Equals(""))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.Observacion = "El campo CIE-10 esta vacio.";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (item.Ide_Analisis.Trim().Equals(""))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.Observacion = "El campo Análisis esta vacio.";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (item.CodAseguradora1.Trim().Equals(""))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.Observacion = "Todas las aseguradoras estan en negativo.";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora = item.CodAseguradora;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora2.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora2 = item.CodAseguradora2;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora3.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora3 = item.CodAseguradora3;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora4.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora4 = item.CodAseguradora4;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora5.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora5 = item.CodAseguradora5;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora6.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora6 = item.CodAseguradora6;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora7.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora7 = item.CodAseguradora7;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora8.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora8 = item.CodAseguradora8;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora9.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora9 = item.CodAseguradora9;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora10.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora10 = item.CodAseguradora10;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora11.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora11 = item.CodAseguradora11;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else if (!item.CodAseguradora12.ToString().ToUpper().Equals("NO"))
                            {
                                //Si hay campos vacios agrega a la lista log
                                oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                oFinanciamientoLog.CodAseguradora12 = item.CodAseguradora12;
                                oFinanciamientoLog.CodAseguradoraMask = item.CodAseguradoraMask;
                                oFinanciamientoLog.ObservacionsSecundaria = "SI";
                                oListarLog.Add(oFinanciamientoLog);
                            }
                            else {
                                cmd.CommandType = CommandType.StoredProcedure;
                                // Parametros del Store                                
                                cmd.Parameters.AddWithValue("@cod_diagnostico", item.Cod_Diagnostico);
                                cmd.Parameters.AddWithValue("@ide_analisis", item.Ide_Analisis);
                                cmd.Parameters.AddWithValue("@codanalisis", item.Cod_ROE);
                                cmd.Parameters.AddWithValue("@codaseguradora", item.CodAseguradora1);
                                cmd.Parameters.AddWithValue("@usr_registra", usrModifica);
                                cmd.Parameters.AddWithValue("@usr_modifica", usrModifica);
                                cmd.Parameters.AddWithValue("@return", "").Direction = ParameterDirection.ReturnValue;
                                cmd.Parameters.Add(VariablesGlobales.ParametroSql("@codprestacion", ParameterDirection.InputOutput, SqlDbType.VarChar, 9, codprestacion));
                                //cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_analisis_out", ParameterDirection.InputOutput, SqlDbType.VarChar, 11, ideAnalisis));
                                cmd.Parameters.Add(VariablesGlobales.ParametroSql("@validacion", ParameterDirection.InputOutput, SqlDbType.Int,11, validacion)); 
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                xReturn = System.Convert.ToInt32(cmd.Parameters["@return"].Value);
                                codprestacion = cmd.Parameters["@codprestacion"].Value + "";
                                //ideAnalisis = cmd.Parameters["@ide_analisis_out"].Value + "";
                                validacion = System.Convert.ToInt32(cmd.Parameters["@validacion"].Value);
                                cmd.Parameters.Clear();
                                cnn.Close();
                                cmd.Dispose();

                                //Validaciones en BD
                                if (validacion == 1) {
                                    oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                    oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;                                    
                                    oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                    oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                    oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                    oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                    oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                    oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                    oFinanciamientoLog.Observacion = "El analisis no existe.";
                                    oListarLog.Add(oFinanciamientoLog);
                                }
                                if (validacion == 2)
                                {
                                    oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                    oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                    oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                    oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                    oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                    oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                    oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                    oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                    oFinanciamientoLog.Observacion = "El diagnostico no existe.";
                                    oListarLog.Add(oFinanciamientoLog);
                                }                                
                                if (validacion == 3)
                                {
                                    oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                    oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                    oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                    oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                    oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                    oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                    oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                    oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                    oFinanciamientoLog.Observacion = "Aseguradora no existe.";
                                    oListarLog.Add(oFinanciamientoLog);
                                }
                                if (validacion == 4)
                                {
                                    oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                    oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                    oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                    oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                    oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                    oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                    oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                    oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                    oFinanciamientoLog.Observacion = "Aseguradora no esta activa.";
                                    oListarLog.Add(oFinanciamientoLog);
                                }
                                if (validacion == 5)
                                {
                                    oFinanciamientoLog.Ide_AnalisisTemp = item.Ide_AnalisisTemp;
                                    oFinanciamientoLog.Ide_Analisis = item.Ide_Analisis;
                                    oFinanciamientoLog.Cod_Diagnostico = item.Cod_Diagnostico;
                                    oFinanciamientoLog.Nombre_Diagnostico = item.Nombre_Diagnostico;
                                    oFinanciamientoLog.Cod_Prestacion = codprestacion;
                                    oFinanciamientoLog.Cod_ROE = item.Cod_ROE;
                                    oFinanciamientoLog.Prueba_ROE = item.Prueba_ROE;
                                    oFinanciamientoLog.CodAseguradora1 = item.CodAseguradora1;
                                    oFinanciamientoLog.Observacion = "El registro ya existe.";
                                    oListarLog.Add(oFinanciamientoLog);
                                }
                            }                            
                        }
                    }
                }

                //Antes de enviar la lista con observaciones ordenarla en Analisis vs aseguradoras
                string ideAnalisisTemp = string.Empty;
                string cie10Temp = string.Empty;
                foreach (var item in oListarLog)
                {
                    if (!ideAnalisisTemp.Equals(""))
                    {
                        if(!(ideAnalisisTemp.Equals(item.Ide_AnalisisTemp.Trim()) && cie10Temp.Equals(item.Cod_Diagnostico.Trim())))
                        {
                            //Si ide temp es diferente al dr nuevo                                    
                            oListarResumen.Add(oFinanciamientoDetE);
                            IdItem = IdItem + 1;
                            aseg1 = "NO";
                            aseg2 = "NO";
                            aseg3 = "NO";
                            aseg4 = "NO";
                            aseg5 = "NO";
                            aseg6 = "NO";
                            aseg7 = "NO";
                            aseg8 = "NO";
                            aseg9 = "NO";
                            aseg10 = "NO";
                            aseg11 = "NO";
                            aseg12 = "NO";
                            aseg1Neg = "NO";
                            aseg2Neg = "NO";
                            aseg3Neg = "NO";
                            aseg4Neg = "NO";
                            aseg5Neg = "NO";
                            aseg6Neg = "NO";
                            aseg7Neg = "NO";
                            aseg8Neg = "NO";
                            aseg9Neg = "NO";
                            aseg10Neg = "NO";
                            aseg11Neg = "NO";
                            aseg12Neg = "NO";
                            Codaseg1Neg = "";
                            Codaseg2Neg = "";
                            Codaseg3Neg = "";
                            Codaseg4Neg = "";
                            Codaseg5Neg = "";
                            Codaseg6Neg = "";
                            Codaseg7Neg = "";
                            Codaseg8Neg = "";
                            Codaseg9Neg = "";
                            Codaseg10Neg = "";
                            Codaseg11Neg = "";
                            Codaseg12Neg = "";
                            obsPrincipal = "";
                            obsSecundaria = "";
                        }
                    }


                    oFinanciamientoDetE = LlenarEntidadDetResumen(item, 0);

                    ideAnalisisTemp = oFinanciamientoDetE.Ide_AnalisisTemp;
                    cie10Temp = oFinanciamientoDetE.Cod_Diagnostico;
                }
                //Agrega el ultimo analisis de la consulta
                oListarResumen.Add(oFinanciamientoDetE);

                if (oListarResumen[0] == null)
                {
                    oListarResumen.Clear();
                }
                return oListarResumen;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Actualizacoón de estado de analisis por diagnostico
        public bool Sp_Financiamiento_Update(List<FinanciamientoDetalleE> listFinanciamiento, int usrModifica)
        {
            int status = 0;
            bool resultado = false;
            try
            {

                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Financiamiento_Update", cnn))
                    {

                        foreach (var item in listFinanciamiento) {
                            cmd.CommandType = CommandType.StoredProcedure;
                            // Parametros del Store
                            cmd.Parameters.AddWithValue("@ide_analisisxDiagnostico", item.Ide_AnalisisxDiagnostico);
                            cmd.Parameters.AddWithValue("@usr_modifica", usrModifica);
                            cmd.Parameters.AddWithValue("@flag_estado", item.Flag_Estado);
                            cmd.Parameters.Add("@status", SqlDbType.Int, 1).Direction = ParameterDirection.Output;
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            status = System.Convert.ToInt32(cmd.Parameters["@status"].Value);
                            cmd.Parameters.Clear();
                            cnn.Close();
                            cmd.Dispose();

                            if (status == 1)
                            {
                                resultado = true;
                            }
                            else {
                                resultado = false;
                            }

                        }                        
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consulta de analisis para plantilla por codigo y descripcion mas atenciones
        public List<FinanciamientoDetalleE> Sp_FinanciamientoLaboratorio_AnalisisXAtencion(FinanciamientoDetalleE pFinanciamientoDetE)
        {
            IDataReader dr;
            FinanciamientoDetalleE oFinanciamientoDetE = null;

            List<FinanciamientoDetalleE> oListar = new List<FinanciamientoDetalleE>();
            List<FinanciamientoDetalleE> oListarFinal = new List<FinanciamientoDetalleE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_FinanciamientoLaboratorio", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pFinanciamientoDetE.Buscar);
                        cmd.Parameters.AddWithValue("@orden", pFinanciamientoDetE.Orden);

                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        string ideAnalisisTemp = string.Empty;
                        string cie10Temp = string.Empty;
                        while (dr.Read())
                        {
                            oFinanciamientoDetE = LlenarEntidadAnalisisAtencion(dr, pFinanciamientoDetE.Orden);
                            oListar.Add(oFinanciamientoDetE);
                            IdItem = IdItem + 1;

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
    }
}
