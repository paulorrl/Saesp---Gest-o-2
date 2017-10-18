using SAESP.Domain.Core.Validation;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Validators
{
    public static class PasswordValidator
    {
        public static bool Validate(this Password password)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertMinLength("Password", 8, "Password", "A senha deve conter no mínimo 8 caracteres"),
                    AssertionConcern.AssertArgumentEquals(password.Pass, password.ConfirmPass, "Password", "As senhas não coincidem")
                );
        }
    }
}