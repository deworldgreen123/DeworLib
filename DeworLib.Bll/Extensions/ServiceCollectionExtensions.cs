using DeworLib.Bll.Books;
using Microsoft.Extensions.DependencyInjection;

namespace DeworLib.Bll.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBllServices(
        this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        
        return services;
    }
    
}