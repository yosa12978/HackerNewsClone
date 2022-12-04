using HackerNewsClone.Domain.Entities;

namespace HackerNewsClone.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        // TODO: Finish this interface
        bool IsEmailTaken(string email);
        bool IsUserExist(string email, string password);
    }
}