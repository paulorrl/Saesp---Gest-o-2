using Microsoft.EntityFrameworkCore;
using SAESP.Users.Domain.Entities;

namespace SAESP.Infra.Data.Mapping
{
    public class UserMap
    {
        public UserMap(ModelBuilder builder)
        {
            var map = builder.Entity<User>().ToTable("User");

            map.OwnsOne(x => x.Name)
                .Property(x => x.FirstName)
                .IsRequired()
                .HasColumnName("nome")
                .HasMaxLength(100);

            map.OwnsOne(x => x.Name)
                .Property(x => x.LastName)
                .IsRequired()
                .HasColumnName("sobrenome")
                .HasMaxLength(100);

            map.OwnsOne(x => x.Email)
                .Property(x => x.Mail)
                .IsRequired()
                .HasColumnName("email");

            map.OwnsOne(x => x.Password)
                .Property(x => x.Pass)
                .HasColumnName("senha")
                .HasMaxLength(40);

            map.OwnsOne(x => x.Password)
                .Ignore(x => x.ConfirmPass);
        }
    }
}