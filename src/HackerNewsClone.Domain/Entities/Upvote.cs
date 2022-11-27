using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class Upvote
    {
        [Required, Key]
        public long UserId { get; set; }
        [Required, Key]
        public long PostId { get; set; }
    }
}
