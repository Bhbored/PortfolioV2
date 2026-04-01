using Portfolio.Models;

namespace Portfolio.Mockdata
{
    public static class ProjectData
    {
        public static List<Project> Projects => new()
        {
            new Project
            {
                Title = "Kinetic Interfaces",
                Description = "A visualization of the dynamic cursor system. Our interface reacts to environmental context, transforming the user's focus point based on content hierarchy and interaction intent.",
                ImageUrl = "https://lh3.googleusercontent.com/aida-public/AB6AXuC_0AZqN0c_IVbgZMhE04XN3Ay_H6dtBJiqvAqKnyB_Z4AkiTt9TASzh-rjkub8fLrQz3_ePZKpZH8M4g4-bTooLjAJDP_ajdljPYrrsOtrbi0q0UEnoR1nYqXX3LLIwkQjne58e2WKBpxVgI4vGhxDxdrJXi-kYrAA_fwlH9e6a_WvQ1vi8cGnQ1tgkjvAQHgxxrr7wCcWcLL7bKkFEZQnhxjPBpZitDIEtTk6P0u1I5i68dm7vn07ZY4QWhLqCDWZK81RkTZBI76L",
                State = "PROJECT_INTERACTION",
                Status = "Focused",
                Technologies = new() { "Blazor", "GSAP", "TailwindCSS" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "Neural Dashboard",
                Description = "AI-powered analytics dashboard with real-time data visualization and predictive insights.",
                ImageUrl = "https://images.unsplash.com/photo-1551288049-bebda4e38f71?w=800",
                State = "DATA_VISUALIZATION",
                Status = "Active",
                Technologies = new() { "React", "D3.js", "Python" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "Quantum Commerce",
                Description = "Next-generation e-commerce platform with immersive 3D product previews.",
                ImageUrl = "https://images.unsplash.com/photo-1557821552-17105176677c?w=800",
                State = "3D_RENDER",
                Status = "Beta",
                Technologies = new() { "Three.js", "Next.js", "Stripe" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "Cipher Chat",
                Description = "End-to-end encrypted messaging platform with self-destructing messages.",
                ImageUrl = "https://images.unsplash.com/photo-1550751827-4bd374c3f58b?w=800",
                State = "SECURE_COMM",
                Status = "Production",
                Technologies = new() { "SignalR", "AES-256", "Blazor" },
                GithubUrl = "#",
                LiveUrl = "#"
            }
        };
    }
}
