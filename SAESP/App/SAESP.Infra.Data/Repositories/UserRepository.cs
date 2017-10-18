using SAESP.Infra.Data.Context;
using SAESP.Users.Domain.Entities;
using SAESP.Users.Domain.Repositories;
using SAESP.Users.Domain.ValueObjects;
using System.Linq;

namespace SAESP.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SaespContext _context;

        public UserRepository(SaespContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public User GetByEmail(Email email)
        {
            return _context.Users
                .FirstOrDefault(x => x.Email.Mail == email.Mail);
        }
    }
}