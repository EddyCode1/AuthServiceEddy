using System.ComponentModel.DataAnnotations;

namespace AuthServiceAngel.Application.DTOs.Email;

public class VerifyEmailDto
{
    [Required]
    public string Token { get; set; } = string.Empty;
}