using AuthServiceAngel.Domain.Entities;

namespace AuthServiceAngel.Domain.Interfaces;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUsersInRoleAsync(string roleName);
    Task<IReadOnlyList<User>> GetUsersByRoleAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserByRoleNamesAsync(string userId);
    
}