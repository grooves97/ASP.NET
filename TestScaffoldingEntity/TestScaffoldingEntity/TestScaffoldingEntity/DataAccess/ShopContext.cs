using System;
using System.Data.Entity;
using System.Linq;
using TestScaffoldingEntity.Models;

namespace TestScaffoldingEntity.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=ShopContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}