using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodieBites.Pages
{
    public class FAQsModel : PageModel
    {
        private readonly ILogger<FAQsModel> _logger;

        public FAQsModel(ILogger<FAQsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}