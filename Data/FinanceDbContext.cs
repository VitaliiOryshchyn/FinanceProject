using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class FinanceDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entiry =>
            {
                entiry.HasData(new User()
                {
                    Name = "Vitalii"
                },
                new User()
                {
                    Name = "Natalii"
                });
            });
        }
    }
}
