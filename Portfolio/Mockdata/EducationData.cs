using Portfolio.Models;

namespace Portfolio.Mockdata
{
    public static class EducationData
    {
        public static List<Education> Educations => new()
        {
            new Education
            {
                Title = "Bachelor of Computer Science",
                Issuer = "Lebanese American University",
                Year = "2017 — 2021"
            },
            new Education
            {
                Title = "Full Stack Web Development Nanodegree",
                Issuer = "Udacity",
                Year = "2020"
            },
            new Education
            {
                Title = "Advanced Software Engineering",
                Issuer = "Holberton School",
                Year = "2021 — 2022"
            },
            new Education
            {
                Title = "Data Structures & Algorithms Specialization",
                Issuer = "UC San Diego (Coursera)",
                Year = "2019"
            }
        };
    }
}
