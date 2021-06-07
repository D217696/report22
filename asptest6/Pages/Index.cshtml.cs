using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptest6.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty] //only supports POST 
        public int Id { get; set; }


        [BindProperty(SupportsGet = true)] //supports both GET and POST
        public string FirstName { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                FirstName = "not bob";
            }
        }
    }
}
