using Bus.Utilities;
using System.Configuration;
using System.IO;

//using Microsoft.Extensions.Configuration;

namespace Bus.Clinica
{
    public class VarGlobal
    {
        #region CnnClinica
        private static string _CnnClinica = "";
        public static string CnnClinica
        { get { return _CnnClinica; } }
        #endregion

        #region CnnLogistica
        private static string _CnnLogistica = "";
        public static string CnnLogistica
        { get { return _CnnLogistica; } }
        #endregion

        #region CnnSeguridad
        private static string _CnnSeguridad = "";
        public static string CnnSeguridad
        { get { return _CnnSeguridad; } }
        #endregion

        #region CnnRisClinica
        private static string _CnnRisClinica = "";
        public static string CnnRisClinica
        { get { return _CnnClinica; } }
        #endregion

        #region CnnMedisynOracle
        private string _CnnMedisynOracle = "";
        public string CnnMedisynOracle
        { get { return _CnnMedisynOracle; } }
        #endregion

        #region CnnCitasSanFelipe
        private static string _CnnCitasSanFelipe = "";
        public static string CnnCitasSanFelipe
        { get { return _CnnCitasSanFelipe; } }
        #endregion

        #region ListDataBase
        /// <summary>
        /// Lista Numerada con las Bases de Datos disponibles a conectar en SQL Server.
        /// </summary>
        public enum ListDataBase
        {
            clinica = 1,
            logistica = 2,
            seguridad = 3,
            dw_clinica = 4,
            CitasSanFelipe = 5,
            risclinica = 6,

            medisyn = 11
        }
        #endregion

        #region LoadConectionString
        /// <summary>
        /// Cargar e iniciar la cadena de conection sobre la Base de Datos a la cual se va a trabajar.
        /// </summary>
        /// <param name="pNameConectionString">Nombre de la Cadena de conexión del App.Config o Web.Config.</param>
        /// <param name="pDataBaseServer">"Base de Datos sobre la cual se trabajara."</param>
        public static void LoadConectionString(string pNameConectionString, ListDataBase pDataBaseServer)
        {
            string StringConection = "";
            if (pNameConectionString.ToLower().IndexOf("cnn") == -1)
                StringConection = pNameConectionString; //ConfigurationManager.ConnectionStrings[pNameConectionString].ConnectionString;
            else
                StringConection = ConfigurationManager.ConnectionStrings[pNameConectionString].ConnectionString;

            //Verificar si la cadena esta encriptada, si esta encriptada la desencriptamos.
            if (StringConection.ToLower().IndexOf("data source") == -1)
                StringConection = Criptography.DecryptConectionString(StringConection);

            ConnectionsString.Server = getDataString("source", StringConection);
            ConnectionsString.DataBase = getDataString("catalog", StringConection);
            ConnectionsString.UserServer = getDataString("id", StringConection);
            ConnectionsString.PasswordServer = getDataString("password", StringConection);

            switch (pDataBaseServer)
            {
                case ListDataBase.clinica:
                    _CnnClinica = StringConection;
                    Dat.Sql.VariablesGlobales.CnnClinica = _CnnClinica;
                    break;
                case ListDataBase.logistica:
                    _CnnLogistica = StringConection;
                    Dat.Sql.VariablesGlobales.CnnLogistica = _CnnLogistica;
                    break;
                case ListDataBase.seguridad:
                    _CnnSeguridad = StringConection;
                    Dat.Sql.VariablesGlobales.CnnSeguridad = _CnnSeguridad;
                    break;
                case ListDataBase.dw_clinica:
                    break;
                case ListDataBase.risclinica:
                    _CnnRisClinica = StringConection;
                    Dat.Sql.VariablesGlobales.CnnRisClinica = _CnnRisClinica;
                    break;
                case ListDataBase.medisyn:
                    break;
                case ListDataBase.CitasSanFelipe:
                    _CnnCitasSanFelipe = StringConection;
                    Dat.Sql.VariablesGlobales.CnnCitasSanFelipe = _CnnCitasSanFelipe;
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region getDataString
        /// <summary>
        /// Obtener el valor del parametro de la cadena de conexion.
        /// </summary>
        /// <param name="pParametro">Nombre del Parámetro</param>
        /// <param name="pCadenaConexion">Cadena completa del app.config o web.config</param>
        /// <returns></returns>
        public static string getDataString(string pParametro, string pCadenaConexion)
        {
            string result = "";
            int index = pCadenaConexion.ToUpper().IndexOf(pParametro.ToUpper()) + pParametro.Length + 1;
            int length = 0;
            if (pCadenaConexion.IndexOf(";", index) == -1)
                length = pCadenaConexion.Length - index;
            else
                length = pCadenaConexion.IndexOf(";", index) - index;

            result = pCadenaConexion.Substring(index, length);
            if (result.IndexOf("= ") >= 0)
                result = result.Substring(2);

            return result;
        }
        #endregion

        #region AppOrigen
        /// <summary>
        /// Aplicacion origen para guardar en campos de auditoria
        /// </summary>
        public enum AppOrigen
        {
            Sic = 1,
            His = 2,
            ApiHis = 3,
        }
        #endregion
        
        #region Log
        public static string? DirrecionLog { get; set; } = "";
        public static string? NombreNoteLog { get; set; } = "";
        public static string? NombreServicio { get; set; } = "";
        public static string? RutaInstalacion { get; set; } = "";
        public static void Grabar_log(string? pMensaje, string? pMetodo)
        {
            try
            {
                string? pathDirectory = DirrecionLog;
                string? NameFileLog = NombreNoteLog;

                if (!string.IsNullOrEmpty(NameFileLog))
                { NameFileLog = NombreServicio+ " - " + DateTime.Now.ToString("yyyyMMdd") + ".txt"; }
                else
                { NameFileLog = DateTime.Now.ToString("yyyyMMdd") + ".txt"; }

                if (string.IsNullOrEmpty(pathDirectory))
                { pathDirectory = "C:\\Logs"; }

                string pathLog = pathDirectory + "\\" + NameFileLog;

                if (!Directory.Exists(pathDirectory))
                { Directory.CreateDirectory(pathDirectory); }

                TextWriter xFile = new StreamWriter(pathLog, true);
                xFile.WriteLine("FECHA Y HORA: " + DateTime.Now.ToString());
                xFile.WriteLine("MENSAJE: " + pMensaje);
                xFile.WriteLine("METODO: " + pMetodo + "\n");
                xFile.Close();
            }
            catch (Exception ex) { }
        }
        #endregion

        public static double IGV { get; set; }=0;
        public static void LoadIGV()
        {
            Dat.Sql.ClinicaAD.OtrosAD.TablasAD objTablasAD = new Dat.Sql.ClinicaAD.OtrosAD.TablasAD();
            List<Ent.Sql.ClinicaE.OtrosE.TablasE> oListTablasE = new List<Ent.Sql.ClinicaE.OtrosE.TablasE>();
            oListTablasE = objTablasAD.Sp_Tablas_Consulta(new Ent.Sql.ClinicaE.OtrosE.TablasE("IMPUESTOS", "01", 50, 1, -1));
            if (oListTablasE.Count > 0)
                IGV = Math.Round(oListTablasE[0].Valor/100,2); // Obtener IGV
        }
    }
}