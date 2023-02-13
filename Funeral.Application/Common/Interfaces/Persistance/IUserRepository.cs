using Funeral.Domain.Entities;

namespace Funeral.Application.Common.Interfaces.Persistance
{
    public interface IUserRepository
    {
        User? GetUserByPhone(string phone);
        void Add(User user);
    }
}