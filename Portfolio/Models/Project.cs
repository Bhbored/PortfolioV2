namespace Portfolio.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = [];
        public List<string> Features { get; set; } = [];
        public List<string> Screenshots { get; set; } = [];
        public string? GithubUrl { get; set; }
        public string? LiveUrl { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
