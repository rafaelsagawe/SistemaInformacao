using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class SupImpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SupImpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SupImps
        public async Task<IActionResult> Index()
        {
            return View(await _context.SupImp.ToListAsync());
        }

        // GET: SupImps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supImp = await _context.SupImp
                .FirstOrDefaultAsync(m => m.IdSupImp == id);
            if (supImp == null)
            {
                return NotFound();
            }

            return View(supImp);
        }

        // GET: SupImps/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupImps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSupImp,ModeloToner,QtdImpressoas,QtdToner")] SupImp supImp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supImp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supImp);
        }

        // GET: SupImps/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supImp = await _context.SupImp.FindAsync(id);
            if (supImp == null)
            {
                return NotFound();
            }
            return View(supImp);
        }

        // POST: SupImps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSupImp,ModeloToner,QtdImpressoas,QtdToner")] SupImp supImp)
        {
            if (id != supImp.IdSupImp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supImp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupImpExists(supImp.IdSupImp))
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
            return View(supImp);
        }

        // GET: SupImps/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supImp = await _context.SupImp
                .FirstOrDefaultAsync(m => m.IdSupImp == id);
            if (supImp == null)
            {
                return NotFound();
            }

            return View(supImp);
        }

        // POST: SupImps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supImp = await _context.SupImp.FindAsync(id);
            _context.SupImp.Remove(supImp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupImpExists(int id)
        {
            return _context.SupImp.Any(e => e.IdSupImp == id);
        }
    }
}
