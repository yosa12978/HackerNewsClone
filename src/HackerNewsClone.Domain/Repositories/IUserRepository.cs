using HackerNewsClone.Domain.Entities;

namespace HackerNewsClone.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool IsEmailTaken(string email);
        bool IsUserExist(string email, string password);
    }
}