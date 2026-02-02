using AuthServiceAngel.Application.Interfaces;
using AuthServiceAngel.Application.Service;
using AuthServiceAngel.Domain.Interfaces;
using AuthServiceAngel.Persistence.Data;
using AuthServiceAngel.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
 
namespace AuthServiceAngel.Api.Extensions;
 
public static class ServiceCollectionExtensions
{
   public static IServiceCollection AddAplicationService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnectcion"))
        .UseSnakeCaseNamingConvention());

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleReposiory>();

        services.AddHealthChecks();

        return services;
    }

    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}
 