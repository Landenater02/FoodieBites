using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodieBites.Data;
using FoodieBites.Models;

namespace FoodieBites.Pages.Forums
{
    public class DetailsModel : PageModel
    {
        private readonly FoodieBites.Data.FoodieBitesContext _context;

        public DetailsModel(FoodieBites.Data.FoodieBitesContext context)
        {
            _context = context;
        }

      public Forum Forum { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Forum == null)
            {
                return NotFound();
            }

            var forum = await _context.Forum.FirstOrDefaultAsync(m => m.Id == id);
            if (forum == null)
            {
                return NotFound();
            }
            else 
            {
                Forum = forum;
            }
            return Page();
        }
    }
}
