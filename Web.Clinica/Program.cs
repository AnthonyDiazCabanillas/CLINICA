
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Web.Clinica.Data;
using Microsoft.Extensions.Configuration;
//Agregado para el Login
//Camb 19/04/2022
using Microsoft.AspNetCore.Authentication.Cookies;
//---------------------

using Radzen;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Components.Authorization;

using Microsoft.EntityFrameworkCore;

using System;
using Web.Clinica.Services;
using Microsoft.AspNetCore.Mvc;
using Ent.Sql.ClinicaE.FinanciamientoDetalleE;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<ListaSerializadaService>(); //10/06/2024

//Agregado para el Login
//Camb 19/04/2022
builder.Services.AddControllers();
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
//---------------------
//builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();


////Agregado para el Login desde fuera
////Camb 09/01/2023
//builder.Services.AddScoped<IdentityInformation>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.Cookie.Name = "myauth";
            options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
            options.EventsType = typeof(Web.Clinica.Controllers.CookieAuthenticationEvents);
        });
builder.Services.AddScoped<Web.Clinica.Controllers.CookieAuthenticationEvents>();


//builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
//builder.Services.AddScoped<HttpContextAccessor>();
//builder.Services.AddTransient<IUserRepository, UserRepository>();

//builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddScoped<IHostEnvironmentAuthenticationStateProvider>(sp =>
{
    // this is safe because 
    //     the `RevalidatingIdentityAuthenticationStateProvider` extends the `ServerAuthenticationStateProvider`
    var provider = (ServerAuthenticationStateProvider)sp.GetRequiredService<AuthenticationStateProvider>();
    return provider;
});
//---------------------



//Agregado para el razen
//Camb 09/01/2023
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
//---------------------


var app = builder.Build();

IConfiguration configuration = app.Services.GetRequiredService<IConfiguration>();
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnClinica"], Bus.Clinica.VarGlobal.ListDataBase.clinica);
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnLogistica"], Bus.Clinica.VarGlobal.ListDataBase.logistica);
Bus.Clinica.VarGlobal.LoadConectionString(configuration["ConnectionStrings:CnnSeguridad"], Bus.Clinica.VarGlobal.ListDataBase.seguridad);
Web.Clinica.MetaGlobal.IdeModuloSistemaPrincipal = configuration["Plataforma:Sistema"];
Web.Clinica.MetaGlobal.NameSistema = configuration["Plataforma:Sistema"];
Web.Clinica.MetaGlobal.VersionPublicacion = configuration["Plataforma:Version"];
Web.Clinica.MetaGlobal.RutaApiClinica = configuration["Plataforma:RutaAPI"];
Web.Clinica.MetaGlobal.RutaApiAgendaSoftvan = configuration["Plataforma:RutaApiAgendaSoftvan"];

builder.Environment.ApplicationName = Web.Clinica.MetaGlobal.NameSistema + " - " + Web.Clinica.MetaGlobal.VersionPublicacion;


Dat.Sql.VariablesGlobales.Clinica_AsignaSede();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//Agregado para el Login
//Camb 19/04/2022
app.UseAuthentication();
app.UseAuthorization();
//---------------------

//jrra prueba 01/01/2023
app.MapRazorPages();
app.MapDefaultControllerRoute();
//---------------------



app.MapBlazorHub();
//Agregado para el Login
//Camb 19/04/2022
app.MapControllers();
//---------------------
app.MapFallbackToPage("/_Host");

app.Run();
