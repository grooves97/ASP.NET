using System;
using System.Data.Entity;
using System.Linq;
using WebApplication5.Models;

namespace WebApplication5.DataAccess
{
    public class Context : DbContext
    {
        public Context() : base()
        {
            Database.SetInitializer(new PeopleInitializer());
        }

        public DbSet<Person> People { get; set; }
    }
}