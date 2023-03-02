using System.Net;
using Microsoft.Extensions.DependencyInjection;
//using Funeral.Application.Services.WorkerAuth;
using Funeral.Application.Services.Authentication;

namespace Funeral.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //services.AddScoped<IWorkerService,WorkerService>();
        services.AddScoped<IAuthenticationCommandService,AuthenticationCommandService>();
        services.AddScoped<IAuthenticationQueryService,AuthenticationQueryService>();
        return services;
    }
}