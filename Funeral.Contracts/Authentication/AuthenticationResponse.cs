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