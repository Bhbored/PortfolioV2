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
                Name = "Bourhan hassoun",
                Title = "SOFTWARE  DEVELOPER",
                HeadLine = "sucking dick",
                Email = "sucker@gmail.com",
                Phone = "+961 71 048 125",
                Location = "Lebanon",
                Summary = "i love dicks",
                ProfileImage = "images/1741106920933.jpg",
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
