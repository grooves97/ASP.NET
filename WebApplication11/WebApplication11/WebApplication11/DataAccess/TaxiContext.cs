using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.Models;

namespace WebApplication11.DataAccess
{
    public class TaxiContext : DbContext
    {
        public TaxiContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Name = "Фархад",
                    PhoneNumber = 87771234565,
                },
                new Client
                {
                    Name = "Филип",
                    PhoneNumber = 87771234565,
                });

            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    Name = "Рашид",
                    PhoneNumber = 87756544828,
                    CarNumber = "13/ABZ/745",
                    CarType = "Lada2112"
                },
                new Driver
                {
                    Name = "Рафик",
                    PhoneNumber = 87756544828,
                    CarNumber = "13/RUS/228",
                    CarType = "Lada Kalina"
                });
        }
    }
}
