//using Funeral.Application.Services.WorkerAuth;
using Funeral.Api.Common.Errors;
using Funeral.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Funeral.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, FuneralProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}