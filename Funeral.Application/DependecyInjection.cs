using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.Extensions.DependencyInjection;
//using Funeral.Application.Services.WorkerAuth;
using Funeral.Application.Services.Authentication;
using Funeral.Application.Services.Authentication.Commands;
using Funeral.Application.Services.Authentication.Queries;
using MediatR;
using Funeral.Application.Common.Behaviors;
using ErrorOr;
using Funeral.Application.Services.Authentication.Common;
using Funeral.Application.Authentication.Commands.Register;
using FluentValidation;

namespace Funeral.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        //services.AddScoped<IWorkerService,WorkerService>();
        //services.AddScoped<IAuthenticationCommandService,AuthenticationCommandService>();
        //services.AddScoped<IAuthenticationQueryService,AuthenticationQueryService>();
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped(typeof(IPipelineBehavior<,>),
                           typeof(ValidationBehavior<,>));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}