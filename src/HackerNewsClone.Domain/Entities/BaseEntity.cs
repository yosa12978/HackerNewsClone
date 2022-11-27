using System.ComponentModel.DataAnnotations;

namespace HackerNewsClone.Domain.Entities 
{
    public class BaseEntity 
    {
        [Required, Key]
        public long Id { get; set; }
    }
}