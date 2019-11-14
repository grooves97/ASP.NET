using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Payment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Cost { get; set; }
        public string From { get; set; } = "Unknown";
    }
}
