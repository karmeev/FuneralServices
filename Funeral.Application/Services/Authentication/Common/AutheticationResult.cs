using Funeral.Domain.Entities;

namespace Funeral.Application.Services.Authentication.Common
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}