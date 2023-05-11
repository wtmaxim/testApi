using Microsoft.AspNetCore.Identity;

namespace testApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }

}
