using SAESP.Domain.Core.Commands;
using SAESP.Users.Application.Interfaces;
using SAESP.Users.Domain.Commands.Handlers;
using SAESP.Users.Domain.Commands.Inputs;

namespace SAESP.Users.Application.Services
{
    public class UserApplication : IUserApplication
    {
        private readonly UserCommandHandler _handler;

        public UserApplication(UserCommandHandler handler)
        {
            _handler = handler;
        }

        public ICommandResult AddUser(RegisterUserCommand command)
        {
            _handler.Handle(command);

            // TODO: Call Commit (BaseService - Implement)

            return null;
        }
    }
}