namespace GestionLibreriaPrueba.Services;

public interface ICommonService<TDto, TInsertDto>
{
    Task<IEnumerable<TDto>> Get();
    Task Create(TInsertDto insertDto);
}