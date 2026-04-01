namespace Portfolio.Models
{
    public class Experience
    {
        public string Title { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
        public List<string> Description { get; set; } = new List<string>();
    }
}
