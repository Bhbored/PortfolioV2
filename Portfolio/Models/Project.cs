using Portfolio.Models.Enums;

namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public ProjectCategory ProjectCategory { get; set; }
        public List<string> Technologies { get; set; } = new List<string>();
        public string GithubUrl { get; set; } = string.Empty;
        public string LiveUrl { get; set; } = string.Empty;
        public List<string> KeyFeatures { get; set; } = [];
        public List<string> Screenshots { get; set; } = [];
    }
}
