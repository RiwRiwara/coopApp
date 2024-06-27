using System.ComponentModel.DataAnnotations;

namespace CoopWeb.Data
{

    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }

    }

    public class UserGroup
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}