using Microsoft.AspNetCore.Identity;

namespace CoopWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public string ProjectNameThai { get; set; }
    }

}
