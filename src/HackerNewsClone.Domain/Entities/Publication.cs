using System.ComponentModel.DataAnnotations;

namespace HackerNewsClone.Domain.Entities 
{
    public class Publication : BaseEntity
    {
        public int AuthorID { get; set; }
        public DateTime PubDate { get; set; } = DateTime.Now;
        public uint Points { get; set; } = 0;
    }
}