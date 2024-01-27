using Microsoft.EntityFrameworkCore;
namespace GestionLibreriaPrueba.Models;
public class GestionLibreriaContext : DbContext
{
    public GestionLibreriaContext(DbContextOptions<GestionLibreriaContext> options) : base(options)
    {

    }

    DbSet<Libro> Libros { get; set; }
    DbSet<Autor> Autores { get; set; }


}