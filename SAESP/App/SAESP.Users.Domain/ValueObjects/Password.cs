using System;
using System.Collections.Generic;
using System.Text;

namespace SAESP.Users.Domain.ValueObjects
{
    public class Password
    {
        public string Pass { get; private set; }

        public string ConfirmPass { get; private set; }

        public Password(string password, string confirmPassword)
        {

        }
    }
}