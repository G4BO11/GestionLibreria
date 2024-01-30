using GestionLibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLibreriaPrueba.Repository;

public class LibroRepository : IRepository<Libro>
{
    private GestionLibreriaContext _context;

    public LibroRepository(GestionLibreriaContext context)
    {
        _context = context;
    }
    public async Task Create(Libro libro)
        => await _context.Libros.AddAsync(libro);

    public async Task<IEnumerable<Libro>> Get() =>
        await _context.Libros.Include(l => l.Autor).ToListAsync();

    public async Task Save()
        => await _context.SaveChangesAsync();
}