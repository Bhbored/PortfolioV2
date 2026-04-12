using Portfolio.Models;
using Portfolio.Models.Enums;

namespace Portfolio.Mockdata
{
    public static class SkillData
    {
        public static List<SkillCategory> Categories => new()
        {
            new SkillCategory { Id = 1, Category = "Languages & Frameworks" },
            new SkillCategory { Id = 2, Category = "UI & Web Engineering" },
            new SkillCategory { Id = 3, Category = "Core Systems" },
            new SkillCategory { Id = 4, Category = "Cloud & DevOps" },
            new SkillCategory { Id = 5, Category = "AI & Emerging Tech" }
        };

        public static List<Skill> Skills => new()
        {
            // Languages & Frameworks (CategoryId = 1)
            new Skill
            {
                Id = 1,
                Title = "C# / .NET 8",
                Icon = MaterialIcon.Terminal,
                SkillCategoryID = 1,
                CertificateID = null,
                MasteryLevel = 95,
                IsNew = false,
                Details = new()
                {
                    "ASP.NET Core Web API & MVC",
                    "Entity Framework Core & Dapper",
                    "Dependency Injection & Middleware",
                    "Minimal APIs & SignalR",
                    "xUnit & Moq Testing"
                }
            },
            new Skill
            {
                Id = 2,
                Title = "TypeScript",
                Icon = MaterialIcon.Code,
                SkillCategoryID = 1,
                CertificateID = 1,
                MasteryLevel = 90,
                IsNew = false,
                Details = new()
                {
                    "Advanced Type System & Generics",
                    "Decorators & Metadata Reflection",
                    "Module Systems & Bundling",
                    "ES6+ Modern JavaScript",
                    "Type-Safe API Clients"
                }
            },
            new Skill
            {
                Id = 3,
                Title = "Flutter / Dart",
                Icon = MaterialIcon.Devices,
                SkillCategoryID = 1,
                CertificateID = 1,
                MasteryLevel = 85,
                IsNew = false,
                Details = new()
                {
                    "Cross-Platform Mobile Development",
                    "Custom Widgets & Animations",
                    "State Management (Provider, Riverpod)",
                    "Firebase Integration",
                    "Native Platform Channels"
                }
            },

            // UI & Web Engineering (CategoryId = 2)
            new Skill
            {
                Id = 4,
                Title = ".NET MAUI",
                Icon = MaterialIcon.Layers,
                SkillCategoryID = 2,
                CertificateID = null,
                MasteryLevel = 88,
                IsNew = false,
                Details = new()
                {
                    "Multi-Platform Desktop & Mobile",
                    "XAML & C# UI Development",
                    "Platform-Specific APIs",
                    "Hot Reload & Debugging",
                    "App Center Deployment"
                }
            },
            new Skill
            {
                Id = 5,
                Title = "React / Next.js",
                Icon = MaterialIcon.AutoFixHigh,
                SkillCategoryID = 2,
                CertificateID = 2,
                MasteryLevel = 92,
                IsNew = false,
                Details = new()
                {
                    "Server-Side Rendering (SSR)",
                    "React Hooks & Context API",
                    "Tailwind CSS & Styled Components",
                    "Next.js App Router",
                    "Vercel Deployment & Optimization"
                }
            },
            new Skill
            {
                Id = 6,
                Title = "Blazor WASM",
                Icon = MaterialIcon.JavaScript,
                SkillCategoryID = 2,
                CertificateID = 2,
                MasteryLevel = 80,
                IsNew = false,
                Details = new()
                {
                    "Component Lifecycle Management",
                    "JavaScript Interop",
                    "State Management Patterns",
                    "WebAssembly Performance",
                    "Progressive Web Apps (PWA)"
                }
            },

            // Core Systems (CategoryId = 3)
            new Skill
            {
                Id = 7,
                Title = "SQL / PostgreSQL",
                Icon = MaterialIcon.Storage,
                SkillCategoryID = 3,
                CertificateID = 2,
                MasteryLevel = 85,
                IsNew = false,
                Details = new()
                {
                    "Complex Query Optimization",
                    "Stored Procedures & Triggers",
                    "Database Design & Normalization",
                    "Full-Text Search & Indexing",
                    "Connection Pooling & Caching"
                }
            },
            new Skill
            {
                Id = 8,
                Title = "Node.js / Express",
                Icon = MaterialIcon.Memory,
                SkillCategoryID = 3,
                CertificateID = 3,
                MasteryLevel = 78,
                IsNew = false,
                Details = new()
                {
                    "RESTful API Development",
                    "Middleware & Error Handling",
                    "WebSocket & Socket.IO",
                    "NPM Package Ecosystem",
                    "Process Management (PM2)"
                }
            },
            new Skill
            {
                Id = 9,
                Title = "AI Tools & LLMs",
                Icon = MaterialIcon.Psychology,
                SkillCategoryID = 3,
                CertificateID = 3,
                MasteryLevel = 40,
                IsNew = true,
                Details = new()
                {
                    "Prompt Engineering & Optimization",
                    "OpenAI API & GPT Models",
                    "Semantic Kernel Integration",
                    "RAG (Retrieval-Augmented Generation)",
                    "AI-Powered Code Assistance"
                }
            },

            // Cloud & DevOps (CategoryId = 4)
            new Skill
            {
                Id = 10,
                Title = "AWS Cloud",
                Icon = MaterialIcon.Cloud,
                SkillCategoryID = 4,
                CertificateID = 3,
                MasteryLevel = 90,
                IsNew = false,
                Details = new()
                {
                    "EC2, S3, Lambda, DynamoDB",
                    "CloudFormation & CDK",
                    "IAM Policies & Roles",
                    "CloudWatch & X-Ray",
                    "Multi-AZ Deployments"
                }
            },
            new Skill
            {
                Id = 11,
                Title = "Kubernetes",
                Icon = MaterialIcon.Kubernetes,
                SkillCategoryID = 4,
                CertificateID = 4,
                MasteryLevel = 86,
                IsNew = false,
                Details = new()
                {
                    "Cluster Architecture & Design",
                    "Helm Charts & Operators",
                    "Service Mesh (Istio)",
                    "Auto-Scaling & RBAC",
                    "Persistent Volumes & Storage"
                }
            },
            new Skill
            {
                Id = 12,
                Title = "Terraform / IaC",
                Icon = MaterialIcon.Build,
                SkillCategoryID = 4,
                CertificateID =4,
                MasteryLevel = 88,
                IsNew = false,
                Details = new()
                {
                    "Infrastructure as Code (IaC)",
                    "Multi-Cloud Deployments",
                    "State Management & Locking",
                    "Module Composition",
                    "Remote Backends & Workspaces"
                }
            },

            // AI & Emerging Tech (CategoryId = 5)
            new Skill
            {
                Id = 13,
                Title = "Machine Learning",
                Icon = MaterialIcon.SmartToy,
                SkillCategoryID = 5,
                CertificateID = 4,
                MasteryLevel = 45,
                IsNew = true,
                Details = new()
                {
                    "ML.NET Model Training",
                    "Computer Vision & NLP",
                    "Azure ML Pipelines",
                    "Model Deployment & Monitoring",
                    "ONNX Runtime Integration"
                }
            },
            new Skill
            {
                Id = 14,
                Title = "Web3 / Blockchain",
                Icon = MaterialIcon.Link,
                SkillCategoryID = 5,
                CertificateID = 5,
                MasteryLevel = 35,
                IsNew = true,
                Details = new()
                {
                    "Smart Contract Development",
                    "Solidity & Hardhat",
                    "IPFS & Decentralized Storage",
                    "Web3.js & Ethers.js",
                    "Token Standards (ERC-20, ERC-721)"
                }
            },
            new Skill
            {
                Id = 15,
                Title = "XR / Spatial Computing",
                Icon = MaterialIcon.Visibility,
                SkillCategoryID = 5,
                CertificateID = null,
                MasteryLevel = 50,
                IsNew = true,
                Details = new()
                {
                    "Unity & Unreal Engine",
                    "3D Asset Pipeline",
                    "Shader Programming",
                    "Spatial Computing",
                    "Hand Tracking & Gestures"
                }
            }
        };
    }
}
