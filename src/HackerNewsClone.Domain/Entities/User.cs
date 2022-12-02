using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public bool Verified { get; set; } = false;
        public string Password { get; set; } = default!;
        public string Salt { get; set; } = default!;
        public string About { get; set; } = default!;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public uint Karma { get; set; } = 0;
        public bool IsActive { get; set; } = true;

        public List<Post> Posts { get; set; } = default!;
        public List<Notification> Notifications { get; set; } = default!;
        public List<Comment> Comments { get; set; } = default!;
        public List<Upvote> Upvotes { get; set; } = default!;

    }
}
