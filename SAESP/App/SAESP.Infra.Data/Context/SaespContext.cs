using Microsoft.EntityFrameworkCore;
using SAESP.Infra.Data.Mapping;
using SAESP.Users.Domain.Entities;

namespace SAESP.Infra.Data.Context
{
    public class SaespContext : DbContext
    {
        public SaespContext(DbContextOptions<SaespContext> options) : base (options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder);
        }
    }
}