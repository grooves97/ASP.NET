using Microsoft.EntityFrameworkCore;    //Подключать EntityFrameWorkCore & sqlServer
using Models;

namespace DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();   //Создаём бд
        }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    Cost=1000,
                    From="Alisa"
                },
                new Payment
                {
                    Cost = 2000,
                    From = "Misa"
                });
        }
    }
}
