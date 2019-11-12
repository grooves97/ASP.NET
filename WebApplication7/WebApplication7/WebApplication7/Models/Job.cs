using System;

namespace WebApplication7.Models
{
    public class Job
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual User User { get; set; }  //LazyLoading
    }
}