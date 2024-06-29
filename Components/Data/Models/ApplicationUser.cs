using Microsoft.AspNetCore.Identity;
namespace CoopWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }

        public string? FullName => $"{FirstName} {LastName}";

        public string? RoleId { get; set; }

        public string? GroupId { get; set; }


    }

    public class ApplicationRole : IdentityRole
    {
    }


}


