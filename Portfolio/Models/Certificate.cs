namespace Portfolio.Models
{
    public class Certificate
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string? Link { get; set; }
        public List<Skill> TopSkills { get; set; } = [];//only top 3 skills related to this certificate

    }
}
