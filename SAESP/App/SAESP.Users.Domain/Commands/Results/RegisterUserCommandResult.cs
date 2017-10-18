using SAESP.Domain.Core.Commands;

namespace SAESP.Users.Domain.Commands.Results
{
    public class RegisterUserCommandResult : ICommandResult
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}