using Modulo_UnidadDeportiva.Interfaces;
using Modulo_UnidadDeportiva.services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
//Insersión de dependencias de la sesion
builder.Services.AddSession(
    options => {
        options.IdleTimeout = TimeSpan.FromSeconds(10000);//Tiempo de inactividad antes de cerrar la sesion
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    });

//Insersión de dependencias de los servicios
builder.Services.AddTransient<IAutenticacion, AutenticacionService>();
builder.Services.AddTransient<IDocente, DocenteService>();
builder.Services.AddTransient<IElementosDep, ElementosDepService>();
builder.Services.AddTransient<IMiembroE, MiembroEService>();
builder.Services.AddTransient<IPasante, PasanteService>();
builder.Services.AddTransient<IReportes, ReportesService>();



// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
