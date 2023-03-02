
using ErrorOr;

namespace Funeral.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        ErrorOr<AuthenticationResult> Register(string firstName,string lastName,string phoneNumber,string password);
        ErrorOr<AuthenticationResult> Login(string phoneNumber, string password);
    }
}