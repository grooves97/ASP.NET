using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18.Models
{
    public class News
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
    }
}
