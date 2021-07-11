using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Pages
{
    public class EditModel : PageModel
    {
        private readonly Web.Data.ApplicationDbContext _context;

        public EditModel(Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SupImp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupImpExists(SupImp.IdSupImp))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SupImpExists(int id)
        {
            return _context.SupImp.Any(e => e.IdSupImp == id);
        }
    }
}
