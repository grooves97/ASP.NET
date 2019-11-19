using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public class Driver : Entity
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string CarNumber { get; set; }
        public string CarType { get; set; }
    }
}
