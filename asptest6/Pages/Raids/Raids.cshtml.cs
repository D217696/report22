 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using asptest6.Models;
using asptest6.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using NiobeLab.Core.Objects.Destiny.Endpoints;
using NiobeLab.Core.Objects.Destiny.HistoricalStats;
using NiobeLab.Core.Objects.Destiny.Responses;

namespace asptest6.Pages.Forms
{
    public class RaidsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int MembershipType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MembershipId { get; set; }

        public async void OnGet()
        {
            
        }
    }
}
