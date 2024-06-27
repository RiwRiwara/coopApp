using Microsoft.AspNetCore.Identity;
namespace CoopWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }

    }

    public class ApplicationRole : IdentityRole
    {
        public new string? Name { get; set; }
    }

    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public new string RoleId { get; set; }
        public new string UserId { get; set; }


        
    }

}


