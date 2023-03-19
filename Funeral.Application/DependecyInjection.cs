using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
//using Funeral.Application.Services.WorkerAuth;
using MediatR;
using Funeral.Application.Common.Behaviors;
using FluentValidation;
using Funeral.Application.Services.Authentication.Commands;
using Funeral.Application.Services.Authentication.Queries;

namespace Funeral.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //services.AddScoped<IWorkerService,WorkerService>();
        //services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();
        //services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}