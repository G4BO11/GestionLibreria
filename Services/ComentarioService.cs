using GestionLibreriaPrueba.Models;
using GestionLibreriaPrueba.Repository;
namespace GestionLibreriaPrueba.Services;

public class ComentarioService : ICommonService<ComentarioDto, ComentarioInsertDto>
{
    private IRepository<Comentario> _comentarioRepository;

    public ComentarioService(IRepository<Comentario> comentarioRepository)
    {
        _comentarioRepository = comentarioRepository;
    }
    public async Task Create(ComentarioInsertDto insertDto)
    {
        Comentario comentario = new()
        {
            ComentarioContenido = insertDto.Contenido,
            ComentarioFecha = insertDto.Fecha,
            LibroID = insertDto.LibroID
        };

        await _comentarioRepository.Create(comentario);
        await _comentarioRepository.Save();
    }

    public Task<IEnumerable<ComentarioDto>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<ComentarioDto> GetById(int id)
    {
        throw new NotImplementedException();
    }
}