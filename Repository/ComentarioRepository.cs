using GestionLibreriaPrueba.Models;
using GestionLibreriaPrueba.Repository;

public class ComentarioRepository : IRepository<Comentario>
{
    private GestionLibreriaContext _context;

    public ComentarioRepository(GestionLibreriaContext context)
    {
        _context = context;
    }
    public async Task Create(Comentario entity) =>
        await _context.Comentarios.AddAsync(entity);

    public Task<IEnumerable<Comentario>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<Comentario> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Save() => await _context.SaveChangesAsync();
}