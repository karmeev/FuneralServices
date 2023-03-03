
using ErrorOr;
using Funeral.Application.Services.Authentication.Common;

namespace Funeral.Application.Services.Authentication.Queries
{
    public interface IAuthenticationQueryService
    {
        ErrorOr<AuthenticationResult> Login(string phoneNumber, string password);
    }
}