using Portfolio.Models;

namespace Portfolio.Mockdata
{
    public static class PersonalInfoData
    {
        public static PersonalInfo GetDeveloper()
        {
            return new()
            {
                Name = "BH",
                Title = "SOFTWARE DEVELOPER",
                Email = "contact@bhdeveloper.com",
                Phone = "+1 (555) 123-4567",
                Location = "San Francisco, CA",
                Summary = "Crafting high-performance digital ecosystems with precision engineering and cinematic design aesthetics.",
                ProfileImage = "images/Screenshot 2026-02-05 172429.PNG",
                IsAvailableForWork = true,
                Social = new Models.SocialLinks
                {
                    Github = "https://github.com/bhdeveloper",
                    Linkedin = "https://linkedin.com/in/bhdeveloper"
                }
            };
        }

    }
}
