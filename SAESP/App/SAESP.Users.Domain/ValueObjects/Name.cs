using SAESP.Users.Domain.Validators;

namespace SAESP.Users.Domain.ValueObjects
{
    public class Name
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private Name() { }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            this.Validate();
        }
    }
}