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
    public class DetailsModel : PageModel
    {
        private readonly Web.Data.ApplicationDbContext _context;

        public DetailsModel(Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SupImp SupImp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SupImp = await _context.SupImp.FirstOrDefaultAsync(m => m.IdSupImp == id);

            if (SupImp == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
