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
        [Required, MaxLength(255)]
        public string UserName { get; set; } = default!;
        [Required, EmailAddress]
        public string Email { get; set; } = default!;
        [Required]
        public bool Verified { get; set; } = false;
        [Required]
        public string Password { get; set; } = default!;
        [Required]
        public string Salt { get; set; } = default!;
        [MaxLength(1024)]
        public string About { get; set; } = default!;
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public uint Karma { get; set; } = 0;
        [Required]
        public bool IsActive { get; set; } = true;
    }
}
