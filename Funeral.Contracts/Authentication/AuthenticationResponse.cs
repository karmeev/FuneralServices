using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funeral.Contracts.Authentication
{
    public record AuthenticationResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string PhoneNumber,
        string Token
    );
}