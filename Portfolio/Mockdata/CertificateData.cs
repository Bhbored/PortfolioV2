using Portfolio.Models;

namespace Portfolio.Mockdata
{
    public static class CertificateData
    {
        public static List<Certificate> Certificates => new()
        {
            new Certificate
            {
                Id = 1,
                Title = "AWS Solutions Architect Professional",
                Issuer = "Amazon Web Services",
                Year = "2024",
                Link = "https://aws.amazon.com/"
            },
            new Certificate
            {
                Id = 2,
                Title = "Microsoft Azure Developer Associate",
                Issuer = "Microsoft",
                Year = "2023",
                Link = "https://learn.microsoft.com/certifications"
            },
            new Certificate
            {
                Id = 3,
                Title = "Google Cloud Professional Engineer",
                Issuer = "Google Cloud",
                Year = "2023",
                Link = "https://cloud.google.com/certification"
            },
            new Certificate
            {
                Id = 4,
                Title = "Meta Front-End Developer",
                Issuer = "Meta (Coursera)",
                Year = "2022",
                Link = "https://www.coursera.org/professional-certificates/meta-front-end-developer"
            },
            new Certificate
            {
                Id = 5,
                Title = "Kubernetes Administrator (CKA)",
                Issuer = "Cloud Native Computing Foundation",
                Year = "2024",
                Link = "https://www.cncf.io/certification/cka"
            },
            new Certificate
            {
                Id = 6,
                Title = "Terraform Associate",
                Issuer = "HashiCorp",
                Year = "2023",
                Link = "https://www.hashicorp.com/certification"
            }
        };
    }
}
