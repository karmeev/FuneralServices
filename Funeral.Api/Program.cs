using Funeral.Api;
using Funeral.Api.Common.Errors;
using Funeral.Application;
using Funeral.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPresentation();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
var app = builder.Build();
{
    // if (app.Environment.IsDevelopment())
    // {
    //    app.UseSwagger();
    //    app.UseSwaggerUI();
    // }
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization(); // use Identity with Google OAuth 2.0
    app.MapControllers();
    app.Run();
}