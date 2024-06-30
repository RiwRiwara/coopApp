using Microsoft.AspNetCore.Identity;
namespace CoopWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? StudentID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }

        public string? FullName => $"{FirstName} {LastName}";

        public string? RoleId { get; set; }

        public int ProjectId { get; set; }

        // update project id
        public void UpdateProjectId(int projectId)
        {
            ProjectId = projectId;
        }

        


    }

    public class ApplicationRole : IdentityRole
    {
    }


}


