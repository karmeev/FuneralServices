using ErrorOr;
using Funeral.Application.Common.Interfaces.Authentication;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Application.Services.Authentication.Common;
using MediatR;
using Funeral.Domain.Common.Errors;
using Funeral.Domain.Entities;
using Funeral.Application.Authentication.Queries.Login;

namespace Funeral.Application.Authentication.Commands.Login
{
    public class LoginQueryHandler :
    IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            if (_userRepository.GetUserByPhone(query.PhoneNumber) is not User user)
            {
                return Errors.Authentication.InvalidCredentials;
            }
            if (user.Password != query.Password)
            {
                return new[] {Errors.Authentication.InvalidCredentials};
            }
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
    }
}