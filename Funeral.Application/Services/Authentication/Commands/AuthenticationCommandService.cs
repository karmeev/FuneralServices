using ErrorOr;
using Funeral.Application.Common.Errors;
using Funeral.Application.Common.Interfaces.Authentication;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Application.Services.Authentication.Common;
using Funeral.Domain.Common.Errors;
using Funeral.Domain.Entities;

namespace Funeral.Application.Services.Authentication.Commands
{
    public class AuthenticationCommandService : IAuthenticationCommandService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string phoneNumber, string password)
        {
            if (_userRepository.GetUserByPhone(phoneNumber) is not null)
                return Errors.User.DuplicatePhone;
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Position = "His position",
                Password = password,
                Phone = phoneNumber
            };
            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
    }
}