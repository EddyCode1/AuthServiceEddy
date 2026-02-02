using System.Security.Cryptography; 

namespace AuthServiceAngel.Application.Service; 

public static class TokeGenertorService
{
    public static string GenerateEmailVerificationToken(int v)
    {
        return GenerateEmailVerificationToken(32);
    }

    public static string GeneratePasswordResetToken(int v)
    {
        return GeneratePasswordResetToken(32);
    }

    public static string GenerateSecureToken(int length)
    {
          using var rng = RandomNumberGenerator.Create();
        var bytes = new byte[length];
        rng.GetBytes(bytes);
        return Convert.ToBase64String(bytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
    }

}