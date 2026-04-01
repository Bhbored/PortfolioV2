namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = [];
        public string GithubUrl { get; set; } = string.Empty;
        public string LiveUrl { get; set; } = string.Empty;
    }
}
