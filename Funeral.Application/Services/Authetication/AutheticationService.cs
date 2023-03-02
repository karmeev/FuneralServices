using ErrorOr;
using Funeral.Application.Common.Errors;
using Funeral.Application.Common.Interfaces.Authentication;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Domain.Common.Errors;
using Funeral.Domain.Entities;

namespace Funeral.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
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