using Microsoft.EntityFrameworkCore;

namespace HackerNewsClone.EFCore.Data 
{
    public class BaseContext : DbContext 
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) 
        {

        }  

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<User>().HasKey(x => x.Id);
            builder.Entity<Post>().HasKey(x => x.Id);
            builder.Entity<Comment>().HasKey(x => x.Id);
            builder.Entity<CommentReply>().HasKey(x => x.Id);
            builder.Entity<Notification>().HasKey(x => x.Id);
            builder.Entity<Upvote>().HasKey(x => new { x.UserId, x.PostId });
            // also textpost and linkpost 

            builder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne()
                .HasForeignKey(x => x.AuthorID);

            builder.Entity<User>()
                .HasMany(x => x.Notifications)
                .WithOne()
                .HasForeignKey(x => x.UserID);

            builder.Entity<User>()
                .HasMany(x => x.Comments)
                .WithOne()
                .HasForeignKey(x => x.AuthorID);

            builder.Entity<User>()
                .HasMany(x => x.Upvotes)
                .WithOne()
                .HasForeignKey(x => x.UserId);
        } 

        public DbSet<User> users { get; set; } = default!;
        public DbSet<Post> posts { get; set; } = default!;
        public DbSet<Comment> comments { get; set; } = default!;
        public DbSet<CommentReply> replies { get; set; } = default!;
        public DbSet<Notification> notifications { get; set; } = default!;
    }
}