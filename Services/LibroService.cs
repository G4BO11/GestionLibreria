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
            LibDescripcion = insertDto.Descripcion,
            LibAnno = insertDto.Anno,
            LibEditorial = insertDto.Editorial,
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
            Descripcion = l.LibDescripcion,
            Editorial = l.LibEditorial,
            Anno = l.LibAnno,
            AutorId = l.Autor.AutorId,
            AutorNombre = l.Autor.Nombre
        });
    }

    public async Task<LibroDto> GetById(int id)
    {
        var libro = await _libroRepository.GetById(id);

        var libroDto = new LibroDto()
        {
            Id = libro.LibroID,
            Titulo = libro.LibTitulo,
            Genero = libro.LibGenero,
            Descripcion = libro.LibDescripcion,
            Editorial = libro.LibEditorial,
            Anno = libro.LibAnno,
            AutorId = libro.Autor.AutorId,
            AutorNombre = libro.Autor.Nombre,
            ListComentarios = libro.Comentarios
        };

        return libroDto;
    }
}