using ErrorOr;
using Funeral.Application.Common.Errors;
using Funeral.Application.Common.Interfaces.Authentication;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Application.Services.Authentication.Common;
using Funeral.Domain.Common.Errors;
using Funeral.Domain.Entities;

namespace Funeral.Application.Services.Authentication.Queries
{
    public class AuthenticationQueryService : IAuthenticationQueryService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public ErrorOr<AuthenticationResult> Login(string phoneNumber, string password)
        {
            if (_userRepository.GetUserByPhone(phoneNumber) is not User user)
            {
                return Errors.Authentication.InvalidCredentials;
            }
            if (user.Password != password)
            {
                return new[] {Errors.Authentication.InvalidCredentials};
            }
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
    }
}