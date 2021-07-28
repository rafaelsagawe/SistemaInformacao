using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleAtivosTI.Data;
using ControleAtivosTI.Models;

namespace ControleAtivosTI.Controllers
{
    public class PortifoliosController : Controller
    {
        private mssqlContext db = new mssqlContext();

        // GET: Portifolios
        public ActionResult Index()
        {
            return View(db.Portifolios.ToList());
        }

        // GET: Portifolios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portifolios portifolios = db.Portifolios.Find(id);
            if (portifolios == null)
            {
                return HttpNotFound();
            }
            return View(portifolios);
        }

        // GET: Portifolios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portifolios/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPortefolio,NomeSistema")] Portifolios portifolios)
        {
            if (ModelState.IsValid)
            {
                db.Portifolios.Add(portifolios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(portifolios);
        }

        // GET: Portifolios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portifolios portifolios = db.Portifolios.Find(id);
            if (portifolios == null)
            {
                return HttpNotFound();
            }
            return View(portifolios);
        }

        // POST: Portifolios/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPortefolio,NomeSistema")] Portifolios portifolios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(portifolios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portifolios);
        }

        // GET: Portifolios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portifolios portifolios = db.Portifolios.Find(id);
            if (portifolios == null)
            {
                return HttpNotFound();
            }
            return View(portifolios);
        }

        // POST: Portifolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Portifolios portifolios = db.Portifolios.Find(id);
            db.Portifolios.Remove(portifolios);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
