using System;

namespace WebApplication5.Models
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}