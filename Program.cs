using GestionLibreriaPrueba.DTO;
using GestionLibreriaPrueba.Models;
using GestionLibreriaPrueba.Repository;
using GestionLibreriaPrueba.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Repository
builder.Services.AddScoped<IRepository<Libro>, LibroRepository>();
builder.Services.AddScoped<IRepository<Autor>, AutorRepository>();
builder.Services.AddScoped<IRepository<Comentario>, ComentarioRepository>();

//Services
builder.Services.AddScoped<ICommonService<LibroDto, LibroInsertDto>, LibroService>();
builder.Services.AddScoped<ICommonService<AutorDto, AutorInsertDto>, AutorService>();
builder.Services.AddScoped<ICommonService<ComentarioDto, ComentarioInsertDto>, ComentarioService>();

//Entity Injeccion
builder.Services.AddDbContext<GestionLibreriaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
