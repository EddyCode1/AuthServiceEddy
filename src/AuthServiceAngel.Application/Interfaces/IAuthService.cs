using AuthServiceAngel.Application.DTOs;
using AuthServiceAngel.Application.DTOs.Email;

namespace AuthServiceAngel.Application.Interfaces;

public interface IAuthService
{ Task<RegisterResponseDto> RegisterAsync(RegistroDto registerDto);
    Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
    Task<EmailResponseDto> VerifyEmailAsync(VerifyEmailDto verifyEmailDto);
    Task<EmailResponseDto> ResendVerficationEmailAsync(ResendVerificationDto resendDto);
    Task<EmailResponseDto> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto);
    Task<EmailResponseDto> ResetPasswordAsync (ResetPasswordDto resetPasswordDto);
    Task<UserResponseDto> GetUserByIdAsync(string userId);
    }