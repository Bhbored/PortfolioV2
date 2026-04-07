using Portfolio.Models;

namespace Portfolio.Mockdata
{
    public static class ExperienceData
    {
        public static List<Experience> Experiences => new()
        {
            new Experience
            {
                Title = "Senior Frontend Developer",
                Company = "Sana Computer",
                Period = "Feb 2023 — Present",
                Description = new()
                {
                    "Architecting high-performance React ecosystems with a focus on cinematic UI/UX.",
                    "Leading cross-functional sprints for mission-critical digital interfaces.",
                    "Implementing advanced animation systems using GSAP and Tailwind CSS.",
                    "Mentoring junior developers and establishing code review best practices."
                }
            },
            new Experience
            {
                Title = "Software Engineer",
                Company = "Beirut Government",
                Period = "Jan 2021 — Jan 2023",
                Description = new()
                {
                    "Engineered large-scale data processing systems for public sector digital transformation.",
                    "Maintained security-first codebase for sensitive governmental APIs and internal tools.",
                    "Designed and implemented RESTful services serving 100K+ daily active users.",
                    "Collaborated with cross-agency teams to standardize development workflows."
                }
            },
            new Experience
            {
                Title = "Full Stack Developer",
                Company = "TechStart Solutions",
                Period = "Jun 2019 — Dec 2020",
                Description = new()
                {
                    "Developed end-to-end web applications using .NET Core and React.",
                    "Optimized database queries resulting in 40% performance improvement.",
                    "Built real-time notification systems using SignalR and WebSockets.",
                    "Deployed microservices architecture on Azure cloud infrastructure."
                }
            }
        };
    }
}
