using System.ComponentModel.DataAnnotations;

namespace CoopWeb.Data
{
    public class MatchRoles
    {
        [Key]
        public string? UserId { get; set; }

        public string? RoleId { get; set; }
    }
}
