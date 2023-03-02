using Microsoft.Extensions.DependencyInjection;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Infrastructure.Authentication;
using Funeral.Application.Common.Interfaces.Authentication;
using Funeral.Application.Services;
using Funeral.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Funeral.Infrastructure.Persistance;

namespace Funeral.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                       ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }

    /*
    public static IServiceCollection AddPersistance(this IServiceCollection services)
    {
        services.AddDbContext<FuneralDbContext>(
             options => options.UseSqlServer()
         );
        return services;
    }
    */
}