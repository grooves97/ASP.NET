using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public class Order : Entity
    {
        public virtual Client Client { get; set; }
        public virtual Driver Driver { get; set; }
        public OrderState State { get; set; }
        public Tariff Tarif { get; set; }
        public string Comments { get; set; }
        public double LocationFrom { get; set; }
        public double LocationTo { get; set; }
    }
}
