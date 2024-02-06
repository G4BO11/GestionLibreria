namespace GestionLibreriaPrueba.Repository;

public interface IRepository<TEntity>
{
    Task<IEnumerable<TEntity>> Get();
    Task<TEntity> GetById(int id);
    Task Create(TEntity entity);
    Task Save();
}