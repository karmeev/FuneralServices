
using ErrorOr;
using Funeral.Application.Services.Authentication.Common;

namespace Funeral.Application.Services.Authentication.Commands
{
    public interface IAuthenticationCommandService
    {
        ErrorOr<AuthenticationResult> Register(string firstName,string lastName,string phoneNumber,string password);
    }
}