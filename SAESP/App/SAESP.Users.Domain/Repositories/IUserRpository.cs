using SAESP.Users.Domain.Entities;

namespace SAESP.Users.Domain.Repositories
{
    public interface IUserRpository
    {
        void AddUser(User user);
    }
}