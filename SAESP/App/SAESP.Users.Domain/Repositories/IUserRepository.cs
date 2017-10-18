using SAESP.Users.Domain.Entities;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);

        User GetByEmail(Email email);
    }
}