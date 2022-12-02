using HackerNewsClone.Domain.Entities;

namespace HackerNewsClone.Domain.Repositories
{
    public interface IUpvoteRepository : IBaseRepository<Upvote>
    {
        long CountPostUpvotes(long PostId);
    }
}