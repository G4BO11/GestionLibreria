using GestionLibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLibreriaPrueba.Repository;

public class AutorRepository : IRepository<Autor>
{
    private GestionLibreriaContext _context;

    public AutorRepository(GestionLibreriaContext context)
    {
        _context = context;
    }
    public async Task Create(Autor autor)
        => await _context.Autores.AddAsync(autor);

    public async Task<IEnumerable<Autor>> Get()
        => await _context.Autores.ToListAsync();

    public Task<Autor> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Save()
        => await _context.SaveChangesAsync();
}