namespace Portfolio.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string? Link { get; set; }
        public List<Skill> TopSKills { get; set; } = [];

    }
}
