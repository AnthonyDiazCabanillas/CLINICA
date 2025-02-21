namespace App.SemaforoEmergencias
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            
            Bus.Clinica.VarGlobal.LoadConectionString("cnnClinica", Bus.Clinica.VarGlobal.ListDataBase.clinica);
            Application.Run(new frmSemaforo());            
        }
    }
}