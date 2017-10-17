using SAESP.Domain.Core.Commands;
using SAESP.Users.Domain.Commands.Inputs;

namespace SAESP.Users.Application.Interfaces
{
    public interface IUserApplication
    {
        ICommandResult AddUser(RegisterUserCommand command);
    }
}