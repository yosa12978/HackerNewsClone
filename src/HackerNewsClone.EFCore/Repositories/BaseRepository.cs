using System.ComponentModel;
using HackerNewsClone.Domain.Repositories;
using HackerNewsClone.EFCore.Data;

namespace HackerNewsClone.EFCore.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
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
            throw new NotImplementedException();
        }

        public T GetByID(long ID)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

}