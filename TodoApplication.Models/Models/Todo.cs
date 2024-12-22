using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Core.Entities;

namespace TodoApplication.Models.Models

{

    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class Todo : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int StartDate { get; set; }
    
        public int EndDate { get; set; }

        public bool Completed { get; set; } = false;
        
        public Category Category { get; set; }

        public User User { get; set; }


    }
}
