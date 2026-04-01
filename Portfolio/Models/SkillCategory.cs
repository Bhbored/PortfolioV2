namespace Portfolio.Models
{
    public class SkillCategory
    {
        public string Category { get; set; } = string.Empty;
        public List<Skill> Skills { get; set; } = [];
    }
}
