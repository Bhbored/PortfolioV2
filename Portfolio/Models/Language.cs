using Portfolio.Models.Enums;

namespace Portfolio.Models
{
    public class Language
    {
        public string Name { get; set; } = string.Empty;
        public ProficiencyLevel Proficiency { get; set; } = ProficiencyLevel.Elementary;
    }
}