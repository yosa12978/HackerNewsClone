using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class LinkPost : Post
    {
        [Required, Url]
        public string URL { get; set; } = default!;
    }
}
