using Portfolio.Models;
using Portfolio.Models.Enums;

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
                ProjectCategory = ProjectCategory.WebApplication,
                Technologies = new() { "Blazor", "GSAP", "TailwindCSS" },
                GithubUrl = "https://github.com/Bhbored/TshirtMaker",
                LiveUrl = "",
                KeyFeatures = new() 
                { 
                    "Dynamic cursor system that adapts to content context",
                    "Real-time environmental interaction feedback",
                    "Smooth GSAP-powered animations and transitions",
                    "Fully responsive across all device sizes",
                    "Accessibility-first approach with keyboard navigation"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1551288049-bebda4e38f71?w=1200",
                    "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=1200",
                    "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=1200"
                }
            },
            new Project
            {
                Title = "Neural Dashboard",
                Description = "AI-powered analytics dashboard with real-time data visualization and predictive insights.",
                ImageUrl = "https://images.unsplash.com/photo-1551288049-bebda4e38f71?w=800",
                ProjectCategory = ProjectCategory.WebApplication,
                Technologies = new() { "React", "D3.js", "Python", "TensorFlow", "PostgreSQL", "Redis", "Docker" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Real-time data streaming with WebSocket integration",
                    "AI-powered predictive analytics engine",
                    "Interactive D3.js visualizations with custom charts",
                    "Role-based access control and team collaboration",
                    "Automated report generation and scheduling",
                    "Dark mode with customizable dashboard layouts"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1551288049-bebda4e38f71?w=1200",
                    "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=1200",
                    "https://images.unsplash.com/photo-1504868584819-f8e8b4b6d7e3?w=1200",
                    "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=1200"
                }
            },
            new Project
            {
                Title = "Quantum Commerce",
                Description = "Next-generation e-commerce platform with immersive 3D product previews.",
                ImageUrl = "https://images.unsplash.com/photo-1557821552-17105176677c?w=800",
                ProjectCategory = ProjectCategory.EcommerceSite,
                Technologies = new() { "Three.js", "Next.js", "Stripe" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Immersive 3D product previews with Three.js",
                    "Seamless Stripe payment integration",
                    "AI-powered product recommendations",
                    "Real-time inventory management system"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1557821552-17105176677c?w=1200",
                    "https://images.unsplash.com/photo-1472851294608-062f824d29cc?w=1200",
                    "https://images.unsplash.com/photo-1556742049-0cfed4f6a45d?w=1200"
                }
            },
            new Project
            {
                Title = "Cipher Chat",
                Description = "End-to-end encrypted messaging platform with self-destructing messages.",
                ImageUrl = "https://images.unsplash.com/photo-1550751827-4bd374c3f58b?w=800",
                ProjectCategory = ProjectCategory.WebApplication,
                Technologies = new() { "SignalR", "AES-256", "Blazor" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Military-grade AES-256 encryption for all messages",
                    "Self-destructing messages with customizable timers",
                    "Real-time communication via SignalR",
                    "Zero-knowledge architecture for maximum privacy"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1550751827-4bd374c3f58b?w=1200",
                    "https://images.unsplash.com/photo-1555066931-4365d14bab8c?w=1200"
                }
            },
            new Project
            {
                Title = "Synthwave Studio",
                Description = "Browser-based music production tool with real-time audio synthesis and collaborative editing.",
                ImageUrl = "https://images.unsplash.com/photo-1470225620780-dba8ba36b745?w=800",
                ProjectCategory = ProjectCategory.WebApplication,
                Technologies = new() { "WebAudio", "React", "Node.js" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Professional-grade audio synthesis in the browser",
                    "Real-time collaborative editing and production",
                    "Extensive library of synth presets and effects",
                    "Export to multiple audio formats (MP3, WAV, FLAC)"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1470225620780-dba8ba36b745?w=1200",
                    "https://images.unsplash.com/photo-1511379938547-c1f69419868d?w=1200",
                    "https://images.unsplash.com/photo-1493225457124-a368538e843d?w=1200"
                }
            },
            new Project
            {
                Title = "CloudForge",
                Description = "Distributed CI/CD pipeline orchestrator with intelligent resource allocation.",
                ImageUrl = "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=800",
                ProjectCategory = ProjectCategory.CI_CDPipeline,
                Technologies = new() { "Kubernetes", "Go", "gRPC" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Intelligent resource allocation and auto-scaling",
                    "Distributed build pipeline for faster deployments",
                    "Real-time build status notifications",
                    "Integration with major Git hosting platforms"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=1200",
                    "https://images.unsplash.com/photo-1451187580459-43490279c0fa?w=1200"
                }
            },
            new Project
            {
                Title = "NeuroLens",
                Description = "Computer vision platform for real-time object detection and augmented reality overlays.",
                ImageUrl = "https://images.unsplash.com/photo-1507146153580-69a1fe6d8aa1?w=800",
                ProjectCategory = ProjectCategory.MachineLearningModel,
                Technologies = new() { "PyTorch", "OpenCV", "Flutter" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Real-time object detection with 99% accuracy",
                    "Augmented reality overlays for enhanced visualization",
                    "Cross-platform mobile app built with Flutter",
                    "Custom-trained models for specific use cases"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1507146153580-69a1fe6d8aa1?w=1200",
                    "https://images.unsplash.com/photo-1555255707-c07966088b7b?w=1200",
                    "https://images.unsplash.com/photo-1504384308090-c54be3855133?w=1200"
                }
            },
            new Project
            {
                Title = "Vertex Vault",
                Description = "Decentralized storage network with cryptographic sharding and fault tolerance.",
                ImageUrl = "https://images.unsplash.com/photo-1639762681485-074b7f938ba0?w=800",
                ProjectCategory = ProjectCategory.CloudNativeApp,
                Technologies = new() { "Solidity", "IPFS", "Web3.js" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Decentralized file storage across multiple nodes",
                    "Cryptographic sharding for enhanced security",
                    "Smart contract-based access control",
                    "99.99% uptime with automatic failover"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1639762681485-074b7f938ba0?w=1200",
                    "https://images.unsplash.com/photo-1639762681485-074b7f938ba0?w=1200"
                }
            },
            new Project
            {
                Title = "EchoMetrics",
                Description = "Privacy-first analytics platform with zero-cookies tracking and GDPR compliance.",
                ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=800",
                ProjectCategory = ProjectCategory.BusinessIntelligence,
                Technologies = new() { "ClickHouse", "Vue.js", "Rust" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Zero-cookies tracking with fingerprint technology",
                    "Full GDPR compliance out of the box",
                    "Lightning-fast queries with ClickHouse",
                    "Real-time dashboard with custom date ranges"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1460925895917-afdab827c52f?w=1200",
                    "https://images.unsplash.com/photo-1551288049-bebda4e38f71?w=1200"
                }
            },
            new Project
            {
                Title = "PulseMesh",
                Description = "IoT sensor network dashboard with real-time telemetry and anomaly detection.",
                ImageUrl = "https://images.unsplash.com/photo-1518770660439-367cee3b3c32?w=800",
                ProjectCategory = ProjectCategory.IoTApplication,
                Technologies = new() { "MQTT", "Blazor", "InfluxDB" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Real-time sensor data via MQTT protocol",
                    "Anomaly detection with machine learning",
                    "Time-series database optimized for IoT telemetry",
                    "Customizable alert thresholds and notifications"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1518770660439-367cee3b3c32?w=1200",
                    "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?w=1200",
                    "https://images.unsplash.com/photo-1504868584819-f8e8b4b6d7e3?w=1200"
                }
            },
            new Project
            {
                Title = "PrismAuth",
                Description = "Multi-factor authentication gateway with biometric verification and SSO integration.",
                ImageUrl = "https://images.unsplash.com/photo-1555066931-4365d14bab8c?w=800",
                ProjectCategory = ProjectCategory.BackendService,
                Technologies = new() { "OAuth2", "WebAuthn", "C#" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Multi-factor authentication with biometric support",
                    "Single Sign-On (SSO) integration with major providers",
                    "FIDO2/WebAuthn compliance for passwordless auth",
                    "Advanced threat detection and prevention"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1555066931-4365d14bab8c?w=1200",
                    "https://images.unsplash.com/photo-1550751827-4bd374c3f58b?w=1200"
                }
            },
            new Project
            {
                Title = "AetherDocs",
                Description = "Collaborative document editor with offline-first architecture and conflict resolution.",
                ImageUrl = "https://images.unsplash.com/photo-1456324504439-367cee3b3c32?w=800",
                ProjectCategory = ProjectCategory.WebApplication,
                Technologies = new() { "CRDT", "IndexedDB", "React" },
                GithubUrl = "#",
                LiveUrl = "#",
                KeyFeatures = new()
                {
                    "Offline-first architecture with automatic sync",
                    "Conflict-free replicated data types (CRDT) for real-time collaboration",
                    "Rich text editing with markdown support",
                    "Version history and document recovery"
                },
                Screenshots = new()
                {
                    "https://images.unsplash.com/photo-1456324504439-367cee3b3c32?w=1200",
                    "https://images.unsplash.com/photo-1517694712202-14dd9538aa97?w=1200"
                }
            }
        };
    }
}
