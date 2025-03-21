using Microsoft.EntityFrameworkCore;
using P.Final.Components;
using POS.Api.Data;
using System.Net.Http;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers();

builder.Services.AddDbContext<Contexto>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<EstadoCompartido>();

//Esto es para que en navegador no diga "no es seguro"
var handler = new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
};

//Esta es una injeccion de dependencias
builder.Services.AddSingleton(new HttpClient(handler)
{
    BaseAddress = new Uri("https://localhost:7252")
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseRouting();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); 
});

app.Run();
