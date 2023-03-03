using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Domain.Entities;

namespace Funeral.Infrastructure.Persistance
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByPhone(string phone)
        {
            return _users.SingleOrDefault(u => u.PhoneNumber == phone);
        }
    }
}