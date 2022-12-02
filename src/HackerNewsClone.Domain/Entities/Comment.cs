using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class Comment : Publication
    {
        public long PostId { get; set; }
        public string Text { get; set; } = default!;
    }
}
