using System.ComponentModel.DataAnnotations;

namespace PersonalPortfolio.Models;

public class ContactMessage
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email")]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Message is required")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters")]
    public string Message { get; set; } = "";

    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
}