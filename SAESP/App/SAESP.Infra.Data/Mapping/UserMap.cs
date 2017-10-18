using Microsoft.EntityFrameworkCore;
using SAESP.Users.Domain.Entities;

namespace SAESP.Infra.Data.Mapping
{
    public class UserMap
    {
        public UserMap(ModelBuilder builder)
        {
            var map = builder.Entity<User>();

            map.HasKey(x => x.Id);

            map.HasOne(x => x.Name).WithOne().IsRequired();
            // map.Property(x => x.Name.LastName);

            map.Property(x => x.Email.Mail);

            map.Property(x => x.Password.Pass);
            map.Ignore(x => x.Password.ConfirmPass);
        }
    }
}