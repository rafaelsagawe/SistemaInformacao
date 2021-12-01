using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Microsoft.AspNetCore.Authorization;

/* Criação da pagina de tarefas
 * 1º Apenas usuário autorizados tem acesso ao recurso de tarefas;
 * 2º ao criar tarefa o nome do usuário deve ser salva no banco automaticamente;
 * 3º As tarefas pertence apenas ao usuário que a criou e não podendo ser visualizada pelos outros usuários;
 * 4º O campo data de criação não pode ser alterado pela edição;
 */

namespace Web.Controllers
{
    [Authorize]

    public class TarefasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TarefasController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Tarefas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tarefa
                .AsNoTracking() // Não registra mudanças, assim otimizando a velocidade
                .Where(u => u.usuario == User.Identity.Name || User.Identity.Name == "admin@admin.com")// Usuario deve ser igual ao usuario do Identity ou usuario do Identity deve ser igual admin@admin.com
                .OrderBy(c => c.concluido)
                .ToListAsync()); ;
        }

        // GET: Tarefas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = await _context.Tarefa
                .FirstOrDefaultAsync(m => m.id == id);
            if (tarefa == null)   
                    
                if (tarefa.usuario != User.Identity.Name || User.Identity.Name == "admin@admin.com")
            {
                return NotFound();
            }

            return View(tarefa);
        }

        // GET: Tarefas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tarefas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,titulo,concluido,usuario,dadataCriacao")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                tarefa.usuario = User.Identity.Name;
                _context.Add(tarefa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }

        // GET: Tarefas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = await _context
                .Tarefa.FindAsync(id);
            if (tarefa == null)

                if (tarefa.usuario != User.Identity.Name || User.Identity.Name == "admin@admin.com")

                {
                return NotFound();
            }
            return View(tarefa);
        }

        // POST: Tarefas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,titulo,concluido,dataAlteracao")] Tarefa tarefa)
        {
            if (id != tarefa.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    tarefa.dataAlteracao = DateTime.Now;
                    tarefa.usuario = User.Identity.Name;
                    _context.Update(tarefa);
                    _context.Entry(tarefa).Property(c => c.dataCriacao).IsModified = false; // O campo da criação da tarefa não será atualizado
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TarefaExists(tarefa.id))
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
            return View(tarefa);
        }

        // GET: Tarefas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = await _context.Tarefa
                .FirstOrDefaultAsync(m => m.id == id);
            if (tarefa == null)
                if (tarefa.usuario != User.Identity.Name || User.Identity.Name == "admin@admin.com")
                {
                return NotFound();
            }

            return View(tarefa);
        }

        // POST: Tarefas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tarefa = await _context.Tarefa.FindAsync(id);
            _context.Tarefa.Remove(tarefa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TarefaExists(int id)
        {
            return _context.Tarefa.Any(e => e.id == id);
        }
    }
}
