using ErrorOr;
using Funeral.Application.Services.Authentication.Common;
using MediatR;

namespace Funeral.Application.Authentication.Queries.Login
{
    public record LoginQuery(string PhoneNumber,
                                  string Password) : IRequest<ErrorOr<AuthenticationResult>>;
}