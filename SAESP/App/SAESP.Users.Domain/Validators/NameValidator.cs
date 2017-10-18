using SAESP.Domain.Core.Validation;
using SAESP.Users.Domain.ValueObjects;

namespace SAESP.Users.Domain.Validators
{
    public static class NameValidator
    {
        public static bool Validate(this Name name)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertArgumentLength(name.FirstName, 3, 80, "First_Name", "Nome deve conter entre 3 à 80 caracteres"),
                    AssertionConcern.AssertArgumentLength(name.LastName, 3, 80, "Last_Name", "Sobrenome deve conter entre 3 à 80 caracteres")
                );
        }
    }
}