using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class ContactFormModel
    {
        [StringLength(20,MinimumLength =1, ErrorMessage = "Name can't Exceeed {1} characters")]
        public string Name { get; set; } = string.Empty;
        [StringLength(40, MinimumLength = 1, ErrorMessage = "{0} can't Exceeed {1} characters")]
        public string Subject { get; set; } = string.Empty;
        [StringLength(500, MinimumLength =1,ErrorMessage = "Message can't Exceeed {1} characters")]
        public string Message { get; set; } = string.Empty;
    }
}
