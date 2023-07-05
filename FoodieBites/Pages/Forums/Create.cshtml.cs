using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FoodieBites.Data;
using FoodieBites.Models;

namespace FoodieBites.Pages.Forums
{
    public class CreateModel : PageModel
    {
        private readonly FoodieBites.Data.FoodieBitesContext _context;

        public CreateModel(FoodieBites.Data.FoodieBitesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Forum Forum { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Forum == null || Forum == null)
            {
                return Page();
            }

            _context.Forum.Add(Forum);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
