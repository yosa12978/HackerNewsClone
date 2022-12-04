namespace HackerNewsClone.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T?> GetByID(long ID);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(long ID);
    }
}