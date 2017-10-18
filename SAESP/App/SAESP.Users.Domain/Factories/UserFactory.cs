using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Users.Domain.Entities;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Factories
{
    public class UserFactory : IUserFactory
    {
        public User Create(RegisterUserCommand command)
        {
            var name = new Name(command.FirstName, command.LastName);
            var email = new Email(command.Email);
            var password = new Password(command.Password, command.ConfirmPassword);

            return new User(name, email, password);
        }
    }
}