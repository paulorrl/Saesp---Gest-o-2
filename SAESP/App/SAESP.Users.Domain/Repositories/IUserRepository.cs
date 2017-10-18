using SAESP.Domain.Core.Commands;
using SAESP.Users.Domain.Commands.Results;
using SAESP.Users.Domain.Entities;
using SAESP.Users.Domain.ValueObjects;
using System.Collections.Generic;

namespace SAESP.Users.Domain.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);

        User GetByEmail(Email email);

        IEnumerable<GetUsersListCommandResult> GetUsers();
    }
}