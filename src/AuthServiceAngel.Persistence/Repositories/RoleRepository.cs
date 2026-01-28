using AuthServiceAngel.Domain.Entities; 
using AuthServiceAngel.Domain.Interfaces; 
using AuthServiceAngel.Persistence.Data; 
using Microsoft.EntityFrameworkCore; 

namespace AuthServiceAngel.Persistence.Repositories;

public class RoleReposiory(ApplicationDbContext context) : IRoleRepository
{
        // Get role by name
        public async Task<Role?> GetByNameAsync(string name)
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.Name == name);
        }
 
        // Count users in a specific role
        public async Task<int> CountUsersInRoleAsync(string roleName)
            {
                return await context.UserRoles
                    .Include(ur => ur.Role)
                    .Where(ur => ur.Role.Name == roleName)
                    .Select(ur => ur.UserId)
                    .Distinct()
                    .CountAsync();
            }
 
 
        // Get users by role name
        public async Task<IReadOnlyList<User>> GetUsersByRoleAsync(string roleName)
        {
        var users = await context.Users
                .Include(u => u.UserProfile)
                .Include(u => u.UserEmail)
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .Where(u => u.UserRoles.Any(ur => ur.Role.Name == roleName))
                .ToListAsync();
 
            return users;
         }
 
         //Buscar que rolkes tiene un usuario
            public async Task<IReadOnlyList<string>> GetUserByRoleNamesAsync(string userId)
            {
                var roles = await context.UserRoles
                    .Include(ur => ur.Role)
                    .Where(ur => ur.UserId == userId)
                    .Select(ur => ur.Role.Name)
                    .ToListAsync();
   
                return roles;
            }


}