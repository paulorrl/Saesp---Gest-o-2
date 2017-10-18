using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Users.Domain.Entities;

namespace SAESP.Users.Domain.Factories
{
    public interface IUserFactory
    {
        User Create(RegisterUserCommand command);
    }
}