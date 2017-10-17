﻿using SAESP.Users.Domain.Validators;

namespace SAESP.Users.Domain.ValueObjects
{
    public class Email
    {
        public string Mail { get; private set; }

        public Email(string mail)
        {
            Mail = mail;

            this.Validate();
        }
    }
}