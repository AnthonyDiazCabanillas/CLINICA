//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha			 Autor        Requerimiento
//    1.0			  20/12/2024     HVIDAL       REQ 2024-021955 NEONATOLOGIA (Agregar Swagger)
//****************************************************************************************
using Api.Clinica.Data;

var builder = WebApplication.CreateBuilder(args);

//Nombre de política CORS
var _politicaPermitida = "PoliticaCORS"; 

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Habilitar CORS in .NET CORE Web API 6.0 para permitir que otros sitios realicen solicitudes de origen cruzado a su aplicación. Colocar * para todos los sitios permitidos.
builder.Services.AddCors(p => p.AddPolicy(_politicaPermitida, buil=>buil.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()));



var app = builder.Build();
IConfiguration configuration = app.Services.GetRequiredService<IConfiguration>();
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnClinica"], Bus.Clinica.VarGlobal.ListDataBase.clinica);
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnLogistica"], Bus.Clinica.VarGlobal.ListDataBase.logistica);
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnSeguridad"], Bus.Clinica.VarGlobal.ListDataBase.seguridad);
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnCitasSanFelipe"], Bus.Clinica.VarGlobal.ListDataBase.CitasSanFelipe);


MetaGlobal.IdeModuloSistemaPrincipal = configuration["Plataforma:Sistema"];
MetaGlobal.NameSistema = configuration["Plataforma:Sistema"];
MetaGlobal.VersionPublicacion = configuration["Plataforma:Version"];

builder.Environment.ApplicationName = MetaGlobal.NameSistema + " - " + MetaGlobal.VersionPublicacion;

// Configure the HTTP request pipeline.
//INI 1.0
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
//FIN 1.0
{
    app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Se agrega el nombre de la política que sirve para habilitar Cross-Origin Requests (CORS)
app.UseCors(_politicaPermitida);

app.Run();
