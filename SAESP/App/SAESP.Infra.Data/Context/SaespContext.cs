using Microsoft.EntityFrameworkCore;
using SAESP.Users.Domain.Entities;

namespace SAESP.Infra.Data.Context
{
    public class SaespContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SaespDesign;Trusted_Connection=True;");
        }
    }
}