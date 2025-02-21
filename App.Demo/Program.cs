using Bus.Utilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App.Demo
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();


            //To register all default providers:
            //var host = Host.CreateDefaultBuilder(args).Build();
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var cnxCSF = Program.Configuration.GetSection("ConnectionStrings").Get<CnxCSF>();
            Bus.AgendaClinica.Clinica.VariablesGlobales.LoadConectionString(cnxCSF.CnnClinica, Bus.AgendaClinica.Clinica.VariablesGlobales.ListDataBase.clinica);


            Application.Run(new Form1());


        }
    }



}