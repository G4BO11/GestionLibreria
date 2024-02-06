using Microsoft.EntityFrameworkCore;

namespace GestionLibreriaPrueba.Models;
public class GestionLibreriaContext : DbContext
{
    public GestionLibreriaContext(DbContextOptions<GestionLibreriaContext> options) : base(options)
    {

    }

    public DbSet<Libro> Libros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }


}