using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApplication.Core.Entities
{
    public class Entity<TId>
    {
        public TId id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
