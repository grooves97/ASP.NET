using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication19.Models;

namespace WebApplication19.DataAccess
{
    public class RazorLessonContext : DbContext
    {
        public RazorLessonContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    FullName = "Azat",
                    Age = 35
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    FullName = "Джон",
                    Age = 40
                });
        }
    }
}
