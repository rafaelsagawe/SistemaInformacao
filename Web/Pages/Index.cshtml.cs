using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Web.Data.ApplicationDbContext _context;

        public IndexModel(Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<SupImp> SupImp { get;set; }

        public async Task OnGetAsync()
        {
            SupImp = await _context.SupImp.ToListAsync();
        }
    }
}
