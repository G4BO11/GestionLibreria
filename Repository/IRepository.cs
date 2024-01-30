namespace GestionLibreriaPrueba.Repository;

public interface IRepository<TEntity>
{
    Task<IEnumerable<TEntity>> Get();
    Task Create(TEntity entity);
    Task Save();
}