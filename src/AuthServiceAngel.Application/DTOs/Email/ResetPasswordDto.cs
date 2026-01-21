using System.ComponentModel.DataAnnotations;

namespace AuthServiceAngel.Application.DTOs.Email;

public class ResetPasswordDto
{
    public string Token { get; set; } = string.Empty;

    [Required]
    [MinLength(8)]
    public string NewPassword { get; set; } = string.Empty;
}