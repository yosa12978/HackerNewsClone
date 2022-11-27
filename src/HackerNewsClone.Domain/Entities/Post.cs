using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class Post : BaseEntity
    {
        [Required, MaxLength(255)]
        public string Title { get; set; } = default!;
        [Required]
        public int AuthorID { get; set; }
        [Required]
        public DateTime PubDate { get; set; } = DateTime.Now;
        [Required]
        public uint Points { get; set; } = 0;
    }
}
