using System.ComponentModel.DataAnnotations;

namespace CoopWeb.Data
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public int GroupId { get; set; }
        public string? ProjectName { get; set; }
        public string? Chairman { get; set; }
        public string? Director1 { get; set; }
        public string? Director2 { get; set; }
        public string? WorkPlace { get; set; }

    }

    public class Stage
    {
        [Key]
        public int Id { get; set; }
        public int StageId { get; set; }
        public int ProjectId { get; set; }
        public int StageNumber { get; set; }
        public string StageName { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public DateTime? Deadline { get; set; }
        public string Description { get; set; }
    }

}