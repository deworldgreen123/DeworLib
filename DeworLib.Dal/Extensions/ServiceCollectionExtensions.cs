using DeworLib.Dal.Models;
using DeworLib.Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeworLib.Dal.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDalRepositories(
        this IServiceCollection services)
    {
        AddPostgresRepositories(services);
        
        return services;
    }
    private static void AddPostgresRepositories(IServiceCollection services)
    {
        services.AddScoped<IBaseRepository<Book>, BaseRepository<Book>>();
    }
    
    public static IServiceCollection AddDalInfrastructure(
        this IServiceCollection services, 
        IConfigurationRoot config)
    {
        services.AddDbContext<LibContext>(options =>
        {
            var connection = config.GetConnectionString("Postgres");
            options.UseNpgsql(connection);
        });
        
        return services;
    }
}