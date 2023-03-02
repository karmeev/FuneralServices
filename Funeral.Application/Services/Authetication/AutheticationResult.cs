using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funeral.Domain.Entities;

namespace Funeral.Application.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}