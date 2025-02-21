using Bus.Utilities;
using Microsoft.Extensions.Logging.EventLog;
using Microsoft.Extensions.Options;
using System.Configuration;
using System.Reflection;
using WSAgenda;
using static System.Net.Mime.MediaTypeNames;

//IHost host = Host.CreateDefaultBuilder(args)
//    .ConfigureServices(services =>
//    {
//        services.AddHostedService<Worker>();
//    })
//    .Build();

string RutaAccesoEjecutable = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

var CurrentDirectory = Directory.GetCurrentDirectory();
var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile(RutaAccesoEjecutable + "\\appsettings.json");
var configuration = builder.Build();

Bus.AgendaClinica.Clinica.VariablesGlobales.DirrecionLog = Convert.ToString(configuration["LogErrores:RutaCarpeta"]);
Bus.AgendaClinica.Clinica.VariablesGlobales.NombreNoteLog = Convert.ToString(configuration["LogErrores:NombreArchivo"]);
Bus.AgendaClinica.Clinica.VariablesGlobales.NombreServicio = Convert.ToString(configuration["MiServicio:LogName"]);
//var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
Bus.AgendaClinica.Clinica.VariablesGlobales.UserRedQR = Convert.ToString(configuration["RutaDeRedQr:Usuario"]);
Bus.AgendaClinica.Clinica.VariablesGlobales.ClaveRedQR = Convert.ToString(configuration["RutaDeRedQr:Clave"]);


IConfiguration Configuration = builder.Build();
var cnxCSF = Configuration.GetSection("ConnectionStrings").Get<CnxCSF>();
Bus.AgendaClinica.Clinica.VariablesGlobales.LoadConectionString(cnxCSF.CnnClinica, Bus.AgendaClinica.Clinica.VariablesGlobales.ListDataBase.clinica);
Bus.AgendaClinica.Clinica.VariablesGlobales.LoadConectionString(cnxCSF.CnnLogistica, Bus.AgendaClinica.Clinica.VariablesGlobales.ListDataBase.logistica);

MiServicio miServicio = Configuration.GetSection("MiServicio").Get<MiServicio>();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging(options =>
    {
        if (OperatingSystem.IsWindows())
        {
            options.AddFilter<EventLogLoggerProvider>(level => level >= LogLevel.Information);
        }
    }
    )
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        if (OperatingSystem.IsWindows())
        {
            services.Configure<EventLogSettings>(config =>
            {
                if(OperatingSystem.IsWindows())
                {
                    config.LogName = miServicio.LogName;
                    config.SourceName = miServicio.SourceName;
                }
            }
            );
        }
    })
    .UseWindowsService()
    .Build();
await host.RunAsync();



//using Bus.Utilities;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting.WindowsServices;
//using System.Diagnostics;
//using WSAgenda;

//var options = new WebApplicationOptions
//{
//    Args = args,
//    ContentRootPath = WindowsServiceHelpers.IsWindowsService()
//                                     ? AppContext.BaseDirectory : default
//};

//var builder = WebApplication.CreateBuilder(options);
//builder.Services.AddRazorPages();
//builder.Services.AddHostedService<Worker>();
////builder.Services.AddHostedService<ServiceB>();


//builder.Host.UseWindowsService();




//var app = builder.Build();


//IConfiguration Configuration = app.Configuration;
//var cnxCSF = Configuration.GetSection("ConnectionStrings").Get<CnxCSF>();
//Bus.AgendaClinica.Clinica.VariablesGlobales.LoadConectionString(cnxCSF.CnnClinica, Bus.AgendaClinica.Clinica.VariablesGlobales.ListDataBase.clinica);



//app.UseStaticFiles();
//app.UseRouting();
//app.MapRazorPages();
//await app.RunAsync();



