namespace HackerNewsClone.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T GetByID(long ID);
        T Create(T entity);
        T Update(T entity);
        void Delete(long ID);
    }
}