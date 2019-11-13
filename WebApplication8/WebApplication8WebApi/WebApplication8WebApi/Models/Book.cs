using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8WebApi.Models
{
    public class Book
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
    }
}