using GestionLibreriaPrueba.DTO;
using GestionLibreriaPrueba.Models;
using GestionLibreriaPrueba.Repository;

namespace GestionLibreriaPrueba.Services;

public class LibroService : ICommonService<LibroDto, LibroInsertDto>
{
    private readonly IRepository<Libro> _libroRepository;

    public LibroService(IRepository<Libro> libroRepository)
    {
        _libroRepository = libroRepository;
    }
    public async Task Create(LibroInsertDto insertDto)
    {
        Libro libro = new()
        {
            LibTitulo = insertDto.Titulo,
            LibGenero = insertDto.Genero,
            AutorID = insertDto.AutorId
        };

        await _libroRepository.Create(libro);
        await _libroRepository.Save();
    }

    public async Task<IEnumerable<LibroDto>> Get()
    {
        var libros = await _libroRepository.Get();

        return libros.Select(l => new LibroDto()
        {
            Id = l.LibroID,
            Titulo = l.LibTitulo,
            Genero = l.LibGenero,
            AutorId = l.Autor.AutorId,
            AutorNombre = l.Autor.Nombre
        });
    }

}