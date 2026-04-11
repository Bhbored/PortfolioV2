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
            },
            new Project
            {
                Title = "Synthwave Studio",
                Description = "Browser-based music production tool with real-time audio synthesis and collaborative editing.",
                ImageUrl = "https://images.unsplash.com/photo-1470225620780-dba8ba36b745?w=800",
                State = "AUDIO_SYNTH",
                Status = "Active",
                Technologies = new() { "WebAudio", "React", "Node.js" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "CloudForge",
                Description = "Distributed CI/CD pipeline orchestrator with intelligent resource allocation.",
                ImageUrl = "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=800",
                State = "DEVOPS",
                Status = "Production",
                Technologies = new() { "Kubernetes", "Go", "gRPC" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "NeuroLens",
                Description = "Computer vision platform for real-time object detection and augmented reality overlays.",
                ImageUrl = "https://images.unsplash.com/photo-1507146153580-69a1fe6d8aa1?w=800",
                State = "COMPUTER_VISION",
                Status = "Beta",
                Technologies = new() { "PyTorch", "OpenCV", "Flutter" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "Vertex Vault",
                Description = "Decentralized storage network with cryptographic sharding and fault tolerance.",
                ImageUrl = "https://images.unsplash.com/photo-1639762681485-074b7f938ba0?w=800",
                State = "BLOCKCHAIN",
                Status = "Testing",
                Technologies = new() { "Solidity", "IPFS", "Web3.js" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "EchoMetrics",
                Description = "Privacy-first analytics platform with zero-cookies tracking and GDPR compliance.",
                ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=800",
                State = "ANALYTICS",
                Status = "Production",
                Technologies = new() { "ClickHouse", "Vue.js", "Rust" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "PulseMesh",
                Description = "IoT sensor network dashboard with real-time telemetry and anomaly detection.",
                ImageUrl = "https://images.unsplash.com/photo-1518770660439-4636190af475?w=800",
                State = "IOT_TELEMETRY",
                Status = "Active",
                Technologies = new() { "MQTT", "Blazor", "InfluxDB" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "PrismAuth",
                Description = "Multi-factor authentication gateway with biometric verification and SSO integration.",
                ImageUrl = "https://images.unsplash.com/photo-1555066931-4365d14bab8c?w=800",
                State = "SECURITY",
                Status = "Production",
                Technologies = new() { "OAuth2", "WebAuthn", "C#" },
                GithubUrl = "#",
                LiveUrl = "#"
            },
            new Project
            {
                Title = "AetherDocs",
                Description = "Collaborative document editor with offline-first architecture and conflict resolution.",
                ImageUrl = "https://images.unsplash.com/photo-1456324504439-367cee3b3c32?w=800",
                State = "COLLAB_TOOL",
                Status = "Beta",
                Technologies = new() { "CRDT", "IndexedDB", "React" },
                GithubUrl = "#",
                LiveUrl = "#"
            }
        };
    }
}
