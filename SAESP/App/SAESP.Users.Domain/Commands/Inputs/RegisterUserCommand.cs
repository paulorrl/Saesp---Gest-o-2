using SAESP.Domain.Core.Commands;

namespace SAESP.Users.Domain.Commands.Inputs
{
    public class RegisterUserCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}