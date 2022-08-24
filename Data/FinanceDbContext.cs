using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class FinanceDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entiry =>
            {
                entiry.HasData(new User()
                {
                    UserId = 1,
                    Name = "Vitalii"
                },
                new User()
                {
                    UserId = 2,
                    Name = "Natalii"
                });
            });
        }
    }
}
