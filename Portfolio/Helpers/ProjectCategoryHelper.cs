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

       
    }
}
