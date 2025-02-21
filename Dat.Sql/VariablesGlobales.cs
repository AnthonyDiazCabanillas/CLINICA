using Ent.Sql.CitaE.SedeE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dat.Sql.CitaAD.SedeAD;

namespace Dat.Sql
{
    public static class VariablesGlobales
    {

        #region CnnClinica
        /// <summary>
        /// Conection string a clinica
        /// </summary>
        public static string CnnClinica = "";
        #endregion

        #region CnnLogistica
        /// <summary>
        /// Conection string a logistica
        /// </summary>
        public static string CnnLogistica = "";
        #endregion

        #region CnnSeguridad
        /// <summary>
        /// Conection string a logistica
        /// </summary>
        public static string CnnSeguridad = "";
        #endregion

        #region CnnRisClinica
        /// <summary>
        /// Conection string a logistica
        /// </summary>
        public static string CnnRisClinica = "";
        #endregion

        #region CnnCitasSanFelipe
        /// <summary>
        /// Conection string a citas_san_felipe
        /// </summary>
        public static string CnnCitasSanFelipe = "";
        #endregion

        #region Variables Globales
        /// <summary>
        /// Conection string a logistica
        /// </summary>
        public static int IdeClinica = 1;
        public static ClinicaE ClinicaE = new ClinicaE();
        #endregion



        private static List<ClinicaE> lstClinica = new List<ClinicaE>();
        private static void Clinica_ObtieneSedes()
        {
            lstClinica = new SedeAD().Sp_Clinica_Consulta(new ClinicaE());
        }

        public static void Clinica_AsignaSede()
        {
            if (lstClinica.Count == 0) Clinica_ObtieneSedes();
            Dat.Sql.VariablesGlobales.ClinicaE = lstClinica.FirstOrDefault(x => x.IDClinica == IdeClinica);
        }


        /// <summary>
        ///     ''' Permite enviar los tipos de parametros hacia SQL con valor de retorno para los parametros de salida.
        ///     ''' </summary>
        ///     ''' <param name="pNombreParametro">Nombre del parámetro que esta en el store</param>
        ///     ''' <param name="pDireccion">Entrada o Salida del parámetro</param>
        ///     ''' <param name="pSqlDBType">Tipo de Dato del store</param>
        ///     ''' <param name="pSize">Tamaño en caso sea un varchar</param>
        ///     ''' <param name="pValor">El campo el cual se está enviando</param>
        ///     ''' <returns></returns>
        public static SqlParameter ParametroSql(string pNombreParametro, ParameterDirection pDireccion, SqlDbType pSqlDBType, int pSize, object pValor)
        {
            //var _SqlParameter = new SqlParameter(pNombreParametro, pSqlDBType, pSize, pDireccion);
            var _SqlParameter = new SqlParameter(pNombreParametro, pSqlDBType, pSize);
            _SqlParameter.Value = pValor;
            _SqlParameter.Direction = pDireccion;
            return _SqlParameter;
        }

        public static bool ExecuteQueryString(string pQueryString)
        {
            int exito = 0;
            bool xResult = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand(pQueryString, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        exito = cmd.ExecuteNonQuery();
                        xResult = (exito >= 1 ? true : false);
                        cmd.Dispose();
                        cnn.Close();
                        cnn.Close();
                    }
                }

                return xResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ExecuteQueryStringDT(string pQueryString)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand(pQueryString, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        ad.Dispose();
                        cmd.Dispose();
                        cnn.Close();
                        cnn.Close();
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public enum ListTipoPagoOrdenBot
        {
            Reserva = 1,
            Farmacia = 2,
            ReprogramarCitas = 3,
            MantenimientoMedicos = 4,
            PantallaCitasReservadas = 5,
            RecuperarContrasenia = 6,
            PreAdmision_EnviarCorreo = 11,
            PreAdmision_SeguimientoDigital = 12
        }

    }
}