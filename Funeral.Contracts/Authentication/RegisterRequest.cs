using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funeral.Contracts.Authentication
{
    public record RegisterRequest(
        string FirstName,
        string LastName,
        string PhoneNumber,
        string Password
    );
}