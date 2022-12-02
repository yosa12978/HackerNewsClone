using HackerNewsClone.EFCore.Data;

namespace HackerNewsClone.EFCore.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(BaseContext ctx) : base(ctx)
        {
        }
        

        public bool IsEmailTaken(string email)
        {
            return context.Set<User>().Any(x => x.Email == email);
        }

        public bool IsUserExist(string email, string password)
        {
            return context.Set<User>().Any(x => x.Email == email && x.Password == password);
        }
    }
}