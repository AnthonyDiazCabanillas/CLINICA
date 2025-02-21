using Bus.Clinica;

namespace WF.RisCopyService
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


            VarGlobal.LoadConectionString("cnnClinicaSql", Bus.Clinica.VarGlobal.ListDataBase.clinica);
            VarGlobal.LoadConectionString("cnnLogisticaSql", Bus.Clinica.VarGlobal.ListDataBase.logistica);
            VarGlobal.LoadConectionString("cnnRisClinicaSql", Bus.Clinica.VarGlobal.ListDataBase.risclinica);
            //VarGlobal.LoadConectionString("cnnMedisynOracle", Bus.Clinica.VarGlobal.ListDataBase.medisyn);

            Application.Run(new Form1());
        }
    }
}