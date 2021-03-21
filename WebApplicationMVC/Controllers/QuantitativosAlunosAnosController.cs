using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Data;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class QuantitativosAlunosAnosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuantitativosAlunosAnosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: QuantitativosAlunosAnos
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuantitativosAlunosAnos.ToListAsync());
        }

        // GET: QuantitativosAlunosAnos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantitativosAlunosAnos = await _context.QuantitativosAlunosAnos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quantitativosAlunosAnos == null)
            {
                return NotFound();
            }

            return View(quantitativosAlunosAnos);
        }

        // GET: QuantitativosAlunosAnos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuantitativosAlunosAnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ano,Turno,Quantidade")] QuantitativosAlunosAnos quantitativosAlunosAnos)
        {
            if (ModelState.IsValid)
            {
                quantitativosAlunosAnos.Id = Guid.NewGuid();
                _context.Add(quantitativosAlunosAnos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quantitativosAlunosAnos);
        }

        // GET: QuantitativosAlunosAnos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantitativosAlunosAnos = await _context.QuantitativosAlunosAnos.FindAsync(id);
            if (quantitativosAlunosAnos == null)
            {
                return NotFound();
            }
            return View(quantitativosAlunosAnos);
        }

        // POST: QuantitativosAlunosAnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Ano,Turno,Quantidade")] QuantitativosAlunosAnos quantitativosAlunosAnos)
        {
            if (id != quantitativosAlunosAnos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quantitativosAlunosAnos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuantitativosAlunosAnosExists(quantitativosAlunosAnos.Id))
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
            return View(quantitativosAlunosAnos);
        }

        // GET: QuantitativosAlunosAnos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantitativosAlunosAnos = await _context.QuantitativosAlunosAnos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quantitativosAlunosAnos == null)
            {
                return NotFound();
            }

            return View(quantitativosAlunosAnos);
        }

        // POST: QuantitativosAlunosAnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var quantitativosAlunosAnos = await _context.QuantitativosAlunosAnos.FindAsync(id);
            _context.QuantitativosAlunosAnos.Remove(quantitativosAlunosAnos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuantitativosAlunosAnosExists(Guid id)
        {
            return _context.QuantitativosAlunosAnos.Any(e => e.Id == id);
        }
    }
}
