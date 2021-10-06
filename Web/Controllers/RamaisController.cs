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
    public class RamaisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RamaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Ponto para popular combobom com a listagem da linhas
        private void PopularLinhasCmbBx(object selecaoLinhas = null)
        {
            var LinhasQuery = from l in _context.Linha
                               orderby l.NumeroLinha
                               select l;
            ViewBag.IdUE = new SelectList(LinhasQuery.AsNoTracking(), "IdLinha", "NumeroLinha", selecaoLinhas);
        }


        // GET: Ramais
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ramal.ToListAsync());
        }

        // GET: Ramais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ramal = await _context.Ramal
                .FirstOrDefaultAsync(m => m.idRamal == id);
            if (ramal == null)
            {
                return NotFound();
            }

            return View(ramal);
        }

        // GET: Ramais/Create
        public IActionResult Create()
        {
            PopularLinhasCmbBx();
            return View();
        }

        // POST: Ramais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idRamal,MACAddress,IP,Linha,localizacao")] Ramal ramal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ramal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopularLinhasCmbBx(ramal.Linhas);

            return View(ramal);
        }

        // GET: Ramais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ramal = await _context.Ramal.FindAsync(id);
            if (ramal == null)
            {
                return NotFound();
            }
            return View(ramal);
        }

        // POST: Ramais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idRamal,MACAddress,IP,Linha,localizacao")] Ramal ramal)
        {
            if (id != ramal.idRamal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ramal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RamalExists(ramal.idRamal))
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
            return View(ramal);
        }

        // GET: Ramais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ramal = await _context.Ramal
                .FirstOrDefaultAsync(m => m.idRamal == id);
            if (ramal == null)
            {
                return NotFound();
            }

            return View(ramal);
        }

        // POST: Ramais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ramal = await _context.Ramal.FindAsync(id);
            _context.Ramal.Remove(ramal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RamalExists(int id)
        {
            return _context.Ramal.Any(e => e.idRamal == id);
        }
    }
}
