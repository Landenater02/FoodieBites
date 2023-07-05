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
    public class IndexModel : PageModel
    {
        private readonly FoodieBites.Data.FoodieBitesContext _context;

        public IndexModel(FoodieBites.Data.FoodieBitesContext context)
        {
            _context = context;
        }

        public IList<Forum> Forum { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Forum != null)
            {
                Forum = await _context.Forum.ToListAsync();
            }
        }
    }
}
