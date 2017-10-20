using SAESP.Domain.Core.Commands;
using SAESP.Domain.Core.Notification;
using SAESP.Domain.Core.Services;
using SAESP.Users.Domain.Commands.Inputs;
using SAESP.Users.Domain.Commands.Results;
using SAESP.Users.Domain.Factories;
using SAESP.Users.Domain.Repositories;

namespace SAESP.Users.Domain.Commands.Handlers
{
    public class UserCommandHandler : ServiceNotification, ICommandHandler<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public UserCommandHandler(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public ICommandResult Handle(RegisterUserCommand command)
        {
            // var name = new Name(command.FirstName, command.LastName);
            // var email = new Email(command.Email);
            // var password = new Password(command.Password, command.ConfirmPassword);
            // var newUser = new User(name, email, password);

            var newUser = _userFactory.Create(command);

            if (HasNotification())
            {
                return null;
            }

            var user = _userRepository.GetByEmail(newUser.Email);

            if (user != null && user.Email.Mail.Equals(newUser.Email.Mail))
            {
                AddNotification(new DomainNotification("email_duplicated", "Este e-mail já está cadastrado")); // Possibilidade do uso de Factory
                return null;
            }

            _userRepository.AddUser(newUser);
            return new RegisterUserCommandResult
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email

                // Aqui é possível retornar informações que podem compor um token, por exemplo.
            };
        }
    }
}