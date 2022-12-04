using System.Net.Mime;
using System.ComponentModel;
using HackerNewsClone.Domain.Repositories;
using HackerNewsClone.EFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace HackerNewsClone.EFCore.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected BaseContext context;
        public BaseRepository(BaseContext context) 
        {
            this.context = context;
        }

        public async Task<T> Create(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(long ID)
        {
            T? ent = await context.Set<T>().FindAsync(ID);
            context.Set<T>().Remove(ent);
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByID(long ID)
        {
            return await context.Set<T>().FindAsync(ID);
        }

        public async Task<T> Update(T entity)
        {
            var res =  context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
            return res.Entity;
        }
    }

}