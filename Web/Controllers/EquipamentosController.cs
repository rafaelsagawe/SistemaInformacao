﻿using System;
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
    public class EquipamentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipamentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        /* Combo box com as unidades escolares
         * O PopularUnidadeCmbBx metodo deve ser aplicado nos itens do CRUD
         * Que será refletido nas views         
         */
        private void PopularUnidadeCmbBx(object selecaoUnidade = null)
        {
            var unidadeQuery = from u in _context.Unidades
                               orderby u.NomeUE
                               select u;
            ViewBag.NomeUE = new SelectList(unidadeQuery.AsNoTracking(), "NomeUE" , "NomeUE", selecaoUnidade);
        }

       
        // GET: Equipamentos
        public async Task<IActionResult> Index(int? id)
        {

            return View(await _context.Equipamentos.ToListAsync());
        }

        // GET: Equipamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipamentos = await _context.Equipamentos
                .FirstOrDefaultAsync(m => m.IdEquipamento == id);
            if (equipamentos == null)
            {
                return NotFound();
            }
            PopularUnidadeCmbBx(equipamentos.IdUE);
            return View(equipamentos);
        }

        [Authorize]
        // GET: Equipamentos/Create
        public IActionResult Create()
        {
            PopularUnidadeCmbBx(); // Chamada do metodos para papular a Combobox
            return View();
        }

        // POST: Equipamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEquipamento,EquipDescricao,EquipNuSerie,EquipNuControle,EquipTipo,EquipOrigem,EquipValor,NomeUE")] Equipamentos equipamentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            PopularUnidadeCmbBx(equipamentos.NomeUE);// Local onde será aplica os valores obtidos

            return View(equipamentos);
        }

        // GET: Equipamentos/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipamentos = await _context.Equipamentos
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.IdUE == id);
                //.FindAsync(id);
            if (equipamentos == null)
            {
                return NotFound();
            }
            PopularUnidadeCmbBx(equipamentos.IdUE);
            return View(equipamentos);
        }

        // POST: Equipamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEquipamento,EquipDescricao,EquipNuSerie,EquipNuControle,EquipTipo,EquipOrigem,EquipValor,IdUE")] Equipamentos equipamentos)
        {
            if (id != equipamentos.IdEquipamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipamentosExists(equipamentos.IdEquipamento))
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
            return View(equipamentos);
        }

        // GET: Equipamentos/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipamentos = await _context.Equipamentos
                .FirstOrDefaultAsync(m => m.IdEquipamento == id);
            
            if (equipamentos == null)
            {
                return NotFound();
            }

            return View(equipamentos);
        }

        // POST: Equipamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipamentos = await _context.Equipamentos.FindAsync(id);
            _context.Equipamentos.Remove(equipamentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipamentosExists(int id)
        {
            return _context.Equipamentos.Any(e => e.IdEquipamento == id);
        }
    }
}
