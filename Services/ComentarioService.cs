using GestionLibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

public class ComentarioService
{
    private readonly GestionLibreriaContext _context;

    public ComentarioService(GestionLibreriaContext context)
    {
        _context = context;
    }

    public async Task<DetalleLibroViewModel> GetComentarioById(int id)
    {
        var libro = await _context.Libros
                                    .Include(l => l.Autor)
                                    .FirstOrDefaultAsync(l => l.LibroID == id);
        var comentarios = await _context.Comentarios.Where(c => c.LibroID == id).ToListAsync();

        var viewModel = new DetalleLibroViewModel
        {
            Libro = libro,
            Comentarios = comentarios
        };

        return viewModel;
    }
}