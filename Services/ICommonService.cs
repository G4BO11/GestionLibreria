namespace GestionLibreriaPrueba.Services;

public interface ICommonService<TDto, TInsertDto>
{
    Task<IEnumerable<TDto>> Get();
    Task<TDto> GetById(int id);
    Task Create(TInsertDto insertDto);
}