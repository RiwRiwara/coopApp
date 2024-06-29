using System.ComponentModel.DataAnnotations;

namespace CoopWeb.Data
{

    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }

    }

}