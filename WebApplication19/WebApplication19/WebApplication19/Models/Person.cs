using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication19.Models
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
