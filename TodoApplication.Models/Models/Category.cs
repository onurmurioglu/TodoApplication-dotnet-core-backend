using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Core.Entities;

namespace TodoApplication.Models.Models
{
    public class Category : Entity<int>
    {

        public string Name { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
