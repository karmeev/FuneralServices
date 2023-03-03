using ErrorOr;
using Funeral.Application.Services.Authentication.Common;
using MediatR;

namespace Funeral.Application.Authentication.Commands.Register
{
    public record RegisterCommand(string FirstName,
                                  string LastName,
                                  string PhoneNumber,
                                  string Password) : IRequest<ErrorOr<AuthenticationResult>>;
}