using SAESP.Domain.Core.Validation;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Validators
{
    public static class NameValidator
    {
        public static void Validate(this Name name)
        {
            AssertionConcern.IsSatisfiedBy
                (
                    // Inserir métodos validatores do AssertionConcern
                );
        }
    }
}