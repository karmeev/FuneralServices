
namespace Funeral.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Register(string firstName,string lastName,string phoneNumber,string password);
        AuthenticationResult Login(string phoneNumber, string password);
    }
}