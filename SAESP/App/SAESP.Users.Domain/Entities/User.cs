using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public Name Name{ get; set; }
        public Email Email { get; private set; }
        public Password Password { get; set; }

        protected User() { }

        public User(Name name, Email email, Password password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}