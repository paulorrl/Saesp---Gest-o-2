using SAESP.Domain.Core.Validation;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Validators
{
    public static class EmailValidator
    {
        public static void Validate(this Email email)
        {
            AssertionConcern.IsSatisfiedBy
                (
                    // Inserir validação de email (Método do Assertion)
                );
        }
    }
}