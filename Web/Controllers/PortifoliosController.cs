using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleAtivosTI.Models;
using Web.Data;
using System.ComponentModel.DataAnnotations;

namespace Web.Controllers
{
    public class PortifoliosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PortifoliosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Portifolios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Portifolios.ToListAsync());
        }

        // GET: Portifolios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portifolios = await _context.Portifolios
                .FirstOrDefaultAsync(m => m.IdPortefolio == id);
            if (portifolios == null)
            {
                return NotFound();
            }

            return View(portifolios);
        }

        // GET: Portifolios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Portifolios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPortefolio,NomeSistema")] Portifolios portifolios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(portifolios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(portifolios);
        }

        // GET: Portifolios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portifolios = await _context.Portifolios.FindAsync(id);
            if (portifolios == null)
            {
                return NotFound();
            }
            return View(portifolios);
        }

        // POST: Portifolios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPortefolio,NomeSistema")] Portifolios portifolios)
        {
            if (id != portifolios.IdPortefolio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(portifolios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PortifoliosExists(portifolios.IdPortefolio))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(portifolios);
        }

        // GET: Portifolios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portifolios = await _context.Portifolios
                .FirstOrDefaultAsync(m => m.IdPortefolio == id);
            if (portifolios == null)
            {
                return NotFound();
            }

            return View(portifolios);
        }

        // POST: Portifolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var portifolios = await _context.Portifolios.FindAsync(id);
            _context.Portifolios.Remove(portifolios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PortifoliosExists(int id)
        {
            return _context.Portifolios.Any(e => e.IdPortefolio == id);
        }
    }
}
