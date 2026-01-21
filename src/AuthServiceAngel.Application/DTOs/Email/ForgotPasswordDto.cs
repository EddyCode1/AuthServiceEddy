using System.ComponentModel.DataAnnotations;

namespace AuthServiceAngel.Application.DTOs.Email;

public class ForgotPasswordDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}