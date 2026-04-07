using Portfolio.Models;

namespace Portfolio.Mockdata
{
    public static class CertificateData
    {
        public static List<Certificate> Certificates => new()
        {
            new Certificate
            {
                Title = "AWS Solutions Architect Professional",
                Issuer = "Amazon Web Services",
                Year = "2024",
                Link = "https://aws.amazon.com/",
                TopSkills = new()
                {
                    new Skill { Title = "Cloud Architecture", MasteryLevel = 92 },
                    new Skill { Title = "DevOps", MasteryLevel = 85 },
                    new Skill { Title = "Serverless Computing", MasteryLevel = 78 }
                }
            },
            new Certificate
            {
                Title = "Microsoft Azure Developer Associate",
                Issuer = "Microsoft",
                Year = "2023",
                Link = "https://learn.microsoft.com/certifications",
                TopSkills = new()
                {
                    new Skill { Title = "Azure Functions", MasteryLevel = 88 },
                    new Skill { Title = "Cosmos DB", MasteryLevel = 80 },
                    new Skill { Title = "ARM Templates", MasteryLevel = 75 }
                }
            },
            new Certificate
            {
                Title = "Google Cloud Professional Engineer",
                Issuer = "Google Cloud",
                Year = "2023",
                Link = "https://cloud.google.com/certification",
                TopSkills = new()
                {
                    new Skill { Title = "GKE", MasteryLevel = 82 },
                    new Skill { Title = "BigQuery", MasteryLevel = 76 },
                    new Skill { Title = "Cloud Run", MasteryLevel = 84 }
                }
            },
            new Certificate
            {
                Title = "Meta Front-End Developer",
                Issuer = "Meta (Coursera)",
                Year = "2022",
                Link = "https://www.coursera.org/professional-certificates/meta-front-end-developer",
                TopSkills = new()
                {
                    new Skill { Title = "React", MasteryLevel = 90 },
                    new Skill { Title = "TypeScript", MasteryLevel = 85 },
                    new Skill { Title = "Responsive Design", MasteryLevel = 92 }
                }
            },
            new Certificate
            {
                Title = "Kubernetes Administrator (CKA)",
                Issuer = "Cloud Native Computing Foundation",
                Year = "2024",
                Link = "https://www.cncf.io/certification/cka",
                TopSkills = new()
                {
                    new Skill { Title = "K8s Orchestration", MasteryLevel = 86 },
                    new Skill { Title = "Docker", MasteryLevel = 90 },
                    new Skill { Title = "Helm Charts", MasteryLevel = 72 }
                }
            },
            new Certificate
            {
                Title = "Terraform Associate",
                Issuer = "HashiCorp",
                Year = "2023",
                Link = "https://www.hashicorp.com/certification",
                TopSkills = new()
                {
                    new Skill { Title = "IaC", MasteryLevel = 88 },
                    new Skill { Title = "Multi-Cloud Deploy", MasteryLevel = 80 },
                    new Skill { Title = "State Management", MasteryLevel = 74 }
                }
            }
        };
    }
}
