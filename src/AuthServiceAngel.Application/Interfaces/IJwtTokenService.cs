using AuthServiceAngel.Domain.Entities;

namespace AuthServiceAngel.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}