using SAESP.Domain.Core.Commands;
using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Users.Domain.Commands.Results;
using System.Collections.Generic;

namespace SAESP.Users.Application.Interfaces
{
    public interface IUserApplication
    {
        ICommandResult AddUser(RegisterUserCommand command);

        IEnumerable<GetUsersListCommandResult> GetUsers();
    }
}