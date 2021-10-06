using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class LinhasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LinhasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Linhas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Linha.ToListAsync());
        }

        // GET: Linhas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linha = await _context.Linha
                .FirstOrDefaultAsync(m => m.IdLinha == id);
            if (linha == null)
            {
                return NotFound();
            }

            return View(linha);
        }

        // GET: Linhas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Linhas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLinha,NumeroLinha,Tronco,Slot")] Linha linha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linha);
        }

        // GET: Linhas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linha = await _context.Linha.FindAsync(id);
            if (linha == null)
            {
                return NotFound();
            }
            return View(linha);
        }

        // POST: Linhas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLinha,NumeroLinha,Tronco,Slot")] Linha linha)
        {
            if (id != linha.IdLinha)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinhaExists(linha.IdLinha))
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
            return View(linha);
        }

        // GET: Linhas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linha = await _context.Linha
                .FirstOrDefaultAsync(m => m.IdLinha == id);
            if (linha == null)
            {
                return NotFound();
            }

            return View(linha);
        }

        // POST: Linhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var linha = await _context.Linha.FindAsync(id);
            _context.Linha.Remove(linha);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinhaExists(int id)
        {
            return _context.Linha.Any(e => e.IdLinha == id);
        }
    }
}
