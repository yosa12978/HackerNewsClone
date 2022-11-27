using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class Comment : BaseEntity
    {
        [Required]
        public long PostId { get; set; }
        [Required]
        public string Text { get; set; } = default!;
    }
}
