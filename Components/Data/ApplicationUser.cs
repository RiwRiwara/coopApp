using Microsoft.AspNetCore.Identity;
namespace CoopWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }
        public string? ProjectNameThai { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {
        // Add custom properties here
    }

    public class ApplicationUserRole : IdentityUserRole<string>
    {
    }

}


