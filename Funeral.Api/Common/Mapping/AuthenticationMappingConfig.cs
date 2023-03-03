using Funeral.Application.Authentication.Commands.Register;
using Funeral.Application.Authentication.Queries.Login;
using Funeral.Application.Services.Authentication.Common;
using Funeral.Contracts.Authentication;
using Mapster;

namespace Funeral.Api.Common.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterRequest, RegisterCommand>();
            config.NewConfig<LoginRequest, LoginQuery>();
            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            //.Map(dest => dest.Token, src => src.Token)
            .Map(dest => dest, src => src.User)
            ;
        }
    }
}