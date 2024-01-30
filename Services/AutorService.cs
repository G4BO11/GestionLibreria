using GestionLibreriaPrueba.DTO;
using GestionLibreriaPrueba.Models;
using GestionLibreriaPrueba.Repository;

namespace GestionLibreriaPrueba.Services;

public class AutorService : ICommonService<AutorDto, AutorInsertDto>
{
    private readonly IRepository<Autor> _autorService;

    public AutorService(IRepository<Autor> autorService)
    {
        _autorService = autorService;
    }
    public async Task Create(AutorInsertDto insertDto)
    {
        Autor autor = new()
        {
            Nombre = insertDto.Nombre
        };

        await _autorService.Create(autor);
        await _autorService.Save();
    }

    public async Task<IEnumerable<AutorDto>> Get()
    {
        var autores = await _autorService.Get();

        return autores.Select(a => new AutorDto()
        {
            Id = a.AutorId,
            Nombre = a.Nombre
        });
    }
}
