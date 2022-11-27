using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsClone.Domain.Entities
{
    public class Notification
    {
        public long Id { get; set; }
        public string UserID { get; set; } = default!;
    }
}
