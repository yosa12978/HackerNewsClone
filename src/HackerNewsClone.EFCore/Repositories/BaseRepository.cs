using System.ComponentModel;
using HackerNewsClone.Domain.Repositories;
using HackerNewsClone.EFCore.Data;

namespace HackerNewsClone.EFCore.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected BaseContext context;
        public BaseRepository(BaseContext context) 
        {
            this.context = context;
        }

        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(long ID)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == ID);
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

}