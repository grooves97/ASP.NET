namespace WebApplication7.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication7.Models;

    public class JobsContext : DbContext
    {
        // Your context has been configured to use a 'JobsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplication7.DataAccess.JobsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JobsContext' 
        // connection string in the application configuration file.
        public JobsContext()
            : base("name=JobsContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}