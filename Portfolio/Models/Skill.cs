namespace Portfolio.Models
{
    public class Skill
    {
        public string Title { get; set; } = string.Empty;
        public double MasteryLevel { get; set; }
        public bool IsNew { get; set; }
        public List<string> Details { get; set; } = [];
    }
}
