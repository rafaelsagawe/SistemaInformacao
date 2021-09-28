using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleAtivosTI.Models;
using Web.Data;
using Microsoft.AspNetCore.Authorization;

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

            var portifolio = await _context.Portifolios
                .FirstOrDefaultAsync(m => m.IdPortefolio == id);
            if (portifolio == null)
            {
                return NotFound();
            }

            return View(portifolio);
        }

        // GET: Portifolios/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Portifolios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPortefolio,NomeSistema,NomePlataforma,Descricao,Acesso,CodigoFonte,Linguagem,BandoDados,Documentacao,Hospedagem,Clientes,EstadoDesenvolvimento,Criticidade")] Portifolio portifolio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(portifolio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(portifolio);
        }

        // GET: Portifolios/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portifolio = await _context.Portifolios.FindAsync(id);
            if (portifolio == null)
            {
                return NotFound();
            }
            return View(portifolio);
        }

        // POST: Portifolios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPortefolio,NomeSistema,NomePlataforma,Descricao,Acesso,CodigoFonte,Linguagem,BandoDados,Documentacao,Hospedagem,Clientes,EstadoDesenvolvimento,Criticidade")] Portifolio portifolio)
        {
            if (id != portifolio.IdPortefolio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(portifolio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PortifolioExists(portifolio.IdPortefolio))
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
            return View(portifolio);
        }

        // GET: Portifolios/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portifolio = await _context.Portifolios
                .FirstOrDefaultAsync(m => m.IdPortefolio == id);
            if (portifolio == null)
            {
                return NotFound();
            }

            return View(portifolio);
        }

        // POST: Portifolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var portifolio = await _context.Portifolios.FindAsync(id);
            _context.Portifolios.Remove(portifolio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PortifolioExists(int id)
        {
            return _context.Portifolios.Any(e => e.IdPortefolio == id);
        }
    }
}
