using Portfolio.Models;
using Portfolio.Models.Enums;

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
                HeadLine = "Crafting high-performance digital ecosystems with precision engineering.",
                Email = "bhbored2022@gmail.com",
                Phone = "+961 71 048 125",
                Location = "Lebanon",
                Summary = "Crafting high-performance digital ecosystems with precision engineering and cinematic design aesthetics.",
                ProfileImage = "images/Screenshot 2026-02-05 172429.PNG",
                IsAvailableForWork = true,
                Social = new Models.SocialLinks
                {
                    Github = "https://github.com/bhdeveloper",
                    Linkedin = "https://linkedin.com/in/bhdeveloper"
                },
                Languages = new()
                {
                    new() { Name = "English", Proficiency = ProficiencyLevel.Native },
                    new() { Name = "Spanish", Proficiency = ProficiencyLevel.Intermediate },
                    new() { Name = "Arabic", Proficiency = ProficiencyLevel.Native }
                }
            };
        }

    }
}
