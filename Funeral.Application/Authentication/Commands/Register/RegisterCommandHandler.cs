using ErrorOr;
using Funeral.Application.Common.Interfaces.Authentication;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Application.Services.Authentication.Common;
using MediatR;
using Funeral.Domain.Common.Errors;
using Funeral.Domain.Entities;

namespace Funeral.Application.Authentication.Commands.Register
{
    public class LoginCommandHandler :
    IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }
        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            if (_userRepository.GetUserByPhone(command.PhoneNumber) is not null)
                return Errors.User.DuplicatePhone;
            var user = new User
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Position = "His position",
                Password = command.Password,
                Phone = command.PhoneNumber
            };
            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
    }
}