using Portfolio.Models.Enums;

namespace Portfolio.Helpers
{
    public static class ProjectCategoryHelper
    {
        public static string GetCategoryDisplayName(ProjectCategory category)
        {
            return category switch
            {
                // Web Development
                ProjectCategory.WebApi => "Web API",
                ProjectCategory.WebApplication => "Web Application",
                ProjectCategory.SinglePageApplication => "Single Page Application",
                ProjectCategory.ProgressiveWebApp => "Progressive Web App",
                ProjectCategory.EcommerceSite => "E-commerce Site",
                ProjectCategory.ContentManagementSystem => "Content Management System",

                // Mobile Development
                ProjectCategory.MobileApp => "Mobile App",
                ProjectCategory.iOSApp => "iOS App",
                ProjectCategory.AndroidApp => "Android App",
                ProjectCategory.CrossPlatformMobile => "Cross-Platform Mobile",

                // Desktop Applications
                ProjectCategory.DesktopApp => "Desktop App",
                ProjectCategory.WindowsApp => "Windows App",
                ProjectCategory.MacApp => "Mac App",
                ProjectCategory.LinuxApp => "Linux App",

                // Backend & Services
                ProjectCategory.Microservice => "Microservice",
                ProjectCategory.BackendService => "Backend Service",
                ProjectCategory.WorkerService => "Worker Service",
                ProjectCategory.MessageQueueService => "Message Queue Service",
                ProjectCategory.GraphQLApi => "GraphQL API",
                ProjectCategory.gRPCService => "gRPC Service",

                // Cloud & Infrastructure
                ProjectCategory.CloudNativeApp => "Cloud Native App",
                ProjectCategory.ServerlessFunction => "Serverless Function",
                ProjectCategory.ContainerizedApp => "Containerized App",
                ProjectCategory.InfrastructureAsCode => "Infrastructure as Code",

                // Data & Analytics
                ProjectCategory.DataPipeline => "Data Pipeline",
                ProjectCategory.ETLProcess => "ETL Process",
                ProjectCategory.DataWarehouse => "Data Warehouse",
                ProjectCategory.BusinessIntelligence => "Business Intelligence",
                ProjectCategory.DataScienceProject => "Data Science Project",
                ProjectCategory.MachineLearningModel => "Machine Learning Model",

                // Gaming
                ProjectCategory.Game2D => "2D Game",
                ProjectCategory.Game3D => "3D Game",
                ProjectCategory.MobileGame => "Mobile Game",

                // IoT & Embedded
                ProjectCategory.IoTApplication => "IoT Application",
                ProjectCategory.EmbeddedSystem => "Embedded System",
                ProjectCategory.FirmwareProject => "Firmware Project",

                // DevOps & Tools
                ProjectCategory.CI_CDPipeline => "CI/CD Pipeline",
                ProjectCategory.AutomationScript => "Automation Script",
                ProjectCategory.MonitoringTool => "Monitoring Tool",
                ProjectCategory.DevTool => "Developer Tool",

                // Legacy & Maintenance
                ProjectCategory.LegacyMaintenance => "Legacy Maintenance",
                ProjectCategory.MigrationProject => "Migration Project",
                ProjectCategory.RefactoringProject => "Refactoring Project",

                // Other
                ProjectCategory.ProofOfConcept => "Proof of Concept",
                ProjectCategory.Prototype => "Prototype",
                ProjectCategory.MVP => "MVP",
                ProjectCategory.LibraryOrPackage => "Library or Package",
                ProjectCategory.DocumentationProject => "Documentation Project",
                ProjectCategory.OpenSourceProject => "Open Source Project",
                ProjectCategory.InternalTool => "Internal Tool",
                ProjectCategory.ClientProject => "Client Project",
                ProjectCategory.PersonalProject => "Personal Project",

                _ => category.ToString()
            };
        }

        public static string GetCategoryDescription(ProjectCategory category)
        {
            return category switch
            {
                // Web Development
                ProjectCategory.WebApi => "RESTful or GraphQL APIs and web services",
                ProjectCategory.WebApplication => "Full-stack web applications with server-side rendering",
                ProjectCategory.SinglePageApplication => "Dynamic client-side web applications",
                ProjectCategory.ProgressiveWebApp => "Web apps with native-like capabilities",
                ProjectCategory.EcommerceSite => "Online stores and shopping platforms",
                ProjectCategory.ContentManagementSystem => "Content creation and management platforms",

                // Mobile Development
                ProjectCategory.MobileApp => "Mobile applications for various platforms",
                ProjectCategory.iOSApp => "Native iOS applications",
                ProjectCategory.AndroidApp => "Native Android applications",
                ProjectCategory.CrossPlatformMobile => "Cross-platform mobile solutions",

                // Desktop Applications
                ProjectCategory.DesktopApp => "Desktop applications for various platforms",
                ProjectCategory.WindowsApp => "Native Windows applications",
                ProjectCategory.MacApp => "Native macOS applications",
                ProjectCategory.LinuxApp => "Native Linux applications",

                // Backend & Services
                ProjectCategory.Microservice => "Decoupled microservice architecture",
                ProjectCategory.BackendService => "Backend services and APIs",
                ProjectCategory.WorkerService => "Background processing services",
                ProjectCategory.MessageQueueService => "Message queue and event-driven services",
                ProjectCategory.GraphQLApi => "GraphQL API implementations",
                ProjectCategory.gRPCService => "High-performance gRPC services",

                // Cloud & Infrastructure
                ProjectCategory.CloudNativeApp => "Cloud-native distributed applications",
                ProjectCategory.ServerlessFunction => "Event-driven serverless functions",
                ProjectCategory.ContainerizedApp => "Container-based deployments",
                ProjectCategory.InfrastructureAsCode => "Automated infrastructure provisioning",

                // Data & Analytics
                ProjectCategory.DataPipeline => "Data processing and transformation pipelines",
                ProjectCategory.ETLProcess => "Extract, transform, and load workflows",
                ProjectCategory.DataWarehouse => "Centralized data storage solutions",
                ProjectCategory.BusinessIntelligence => "Data-driven insights and reporting",
                ProjectCategory.DataScienceProject => "Statistical analysis and modeling projects",
                ProjectCategory.MachineLearningModel => "Trained ML models for predictions",

                // Gaming
                ProjectCategory.Game2D => "Two-dimensional games",
                ProjectCategory.Game3D => "Three-dimensional games",
                ProjectCategory.MobileGame => "Mobile gaming experiences",

                // IoT & Embedded
                ProjectCategory.IoTApplication => "Internet of Things solutions",
                ProjectCategory.EmbeddedSystem => "Embedded computing systems",
                ProjectCategory.FirmwareProject => "Low-level firmware development",

                // DevOps & Tools
                ProjectCategory.CI_CDPipeline => "Continuous integration and deployment",
                ProjectCategory.AutomationScript => "Task automation solutions",
                ProjectCategory.MonitoringTool => "System and application monitoring",
                ProjectCategory.DevTool => "Developer productivity tools",

                // Legacy & Maintenance
                ProjectCategory.LegacyMaintenance => "Legacy system support and updates",
                ProjectCategory.MigrationProject => "Platform or technology migration",
                ProjectCategory.RefactoringProject => "Code quality and architecture improvements",

                // Other
                ProjectCategory.ProofOfConcept => "Feasibility demonstrations",
                ProjectCategory.Prototype => "Early-stage working models",
                ProjectCategory.MVP => "Minimum viable product",
                ProjectCategory.LibraryOrPackage => "Reusable code libraries",
                ProjectCategory.DocumentationProject => "Technical documentation",
                ProjectCategory.OpenSourceProject => "Community-driven open source",
                ProjectCategory.InternalTool => "Internal business tools",
                ProjectCategory.ClientProject => "Client-focused deliverables",
                ProjectCategory.PersonalProject => "Personal experimentation and learning",

                _ => string.Empty
            };
        }
    }
}
