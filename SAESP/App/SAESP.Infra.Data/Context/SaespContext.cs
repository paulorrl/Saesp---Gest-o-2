using Microsoft.EntityFrameworkCore;
using SAESP.Domain.Core;
using SAESP.Infra.Data.Mapping;
using SAESP.Users.Domain.Entities;

namespace SAESP.Infra.Data.Context
{
    public class SaespContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder);
        }
    }
}