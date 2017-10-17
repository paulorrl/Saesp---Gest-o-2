using SAESP.Domain.Core.Validation;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Validators
{
    public static class PasswordValidator
    {
        public static void Validate(this Password password)
        {
            AssertionConcern.IsSatisfiedBy
                (
                    // Inserir validações de senha
                );
        }
    }
}