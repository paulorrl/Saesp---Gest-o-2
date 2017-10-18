using SAESP.Domain.Core.Validation;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Validators
{
    public static class EmailValidator
    {
        public static bool Validate(this Email email)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.IsEmail(email.Mail, "email", "Digite o e-mail em um formato válido")
                );
        }
    }
}