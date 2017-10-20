using SAESP.Users.Domain.Entities;
using SAESP.Users.Domain.ValueObjects;
using System.Linq;

namespace SAESP.Infra.Data.Context
{
    public static class DbInitializer
    {
        public static void Initialize(SaespContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User(new Name("Paulo", "Rodrigues"), new Email("paulo.rodrigues@rmcbrothers.com.br"), new Password("12345678", "12345678")),
                new User(new Name("Tiago", "Cavalli"), new Email("tiago.cavalli@rmcbrothers.com.br"), new Password("12345678", "12345678")),
                new User(new Name("Rafael", "Cruz"), new Email("rafael.cruz@rmcbrothers.com.br"), new Password("12345678", "12345678")),
                new User(new Name("Marcos", "Paiva"), new Email("marcos.paiva@rmcbrothers.com.br"), new Password("12345678", "12345678")),
                new User(new Name("Miller", "Soares"), new Email("miller.soares@rmcbrothers.com.br"), new Password("12345678", "12345678"))
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}