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
    public class DetailsModel : PageModel
    {
        private readonly WebApplication19.DataAccess.RazorLessonContext _context;

        public DetailsModel(WebApplication19.DataAccess.RazorLessonContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.People.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
