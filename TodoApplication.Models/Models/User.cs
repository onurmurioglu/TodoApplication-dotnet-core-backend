
using Microsoft.AspNetCore.Identity;

namespace TodoApplication.Models.Models
{
    public class User : IdentityUser
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
