using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication19.DataAccess;
using WebApplication19.Models;

namespace WebApplication19.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly RazorLessonContext _context;

        public IndexModel(RazorLessonContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.People.ToListAsync();
        }
    }
}
