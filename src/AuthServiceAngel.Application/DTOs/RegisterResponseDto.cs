namespace AuthServiceAngel.Application.DTOs; 

public class RegisterResponseDto
{
    public bool Succes { get; set; }
    public UserResponseDto User { get; set; } = new (); 
    public string Message { get; set; } = string.Empty;
    public bool EmailVerificationRequired { get; set; } = true;
}