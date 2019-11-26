using Microsoft.EntityFrameworkCore;
using WebApplication15.Models;

namespace WebApplication15.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Username = "Volodya89",
                    Password = "123456"
                });
        }
    }
}
