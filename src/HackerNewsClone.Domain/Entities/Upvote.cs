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
        public long UserId { get; set; }
        public long PostId { get; set; }
    }
}
