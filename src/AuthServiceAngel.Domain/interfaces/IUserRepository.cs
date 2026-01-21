using AuthServiceAngel.Domain.Entities;

namespace AuthServiceAngel.Domain.Interfaces;

public interface IUserRepository
{
    Task<User> GetByIdAsync(User user);
    Task<User> GetByIdAsync(string id);
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetByUserNameAsync(string userName);
    Task<User?> GetByEmailVerificationTokenAsync(string token);
    Task<User?> GetByPasswordResetTokenAsync(string token);
    Task<bool> ExistsByEmailAsync(string email);
    Task<bool> ExistsByUserNameAsync(string userName);
    Task<User> updateAsync(User user);
    Task<bool> DeleteAsync(string id);
    Task updateUserRoleAsync(string userId, string roleId); 
}