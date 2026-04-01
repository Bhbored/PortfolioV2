namespace Portfolio.Models
{
    public class Education
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string? Link { get; set; }
    }
}
