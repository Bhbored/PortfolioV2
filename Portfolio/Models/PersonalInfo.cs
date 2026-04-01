namespace Portfolio.Models
{
    public class PersonalInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string ProfileImage { get; set; } = string.Empty;
        public bool IsAvailableForWork { get; set; } = true;
        public SocialLinks Social { get; set; } = new SocialLinks();
    }

    public class SocialLinks
    {
        public string Github { get; set; } = string.Empty;
        public string Linkedin { get; set; } = string.Empty;
    }
}
