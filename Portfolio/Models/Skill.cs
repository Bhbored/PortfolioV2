using Portfolio.Models.Enums;

namespace Portfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public MaterialIcon Icon { get; set; }
        public int? SkillCategoryID { get; set; }
        public int? CertificateID { get; set; }
        public double MasteryLevel { get; set; }
        public bool IsNew { get; set; }
        public List<string> Details { get; set; } = [];
    }
}
