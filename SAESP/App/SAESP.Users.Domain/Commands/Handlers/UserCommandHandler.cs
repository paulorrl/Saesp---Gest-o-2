using SAESP.Domain.Core.Commands;
using SAESP.Users.Domain.Commands.Inputs;

namespace SAESP.Users.Domain.Commands.Handlers
{
    public class UserCommandHandler : ICommandHandler<RegisterUserCommand>
    {
        public ICommandResult Handle(RegisterUserCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}