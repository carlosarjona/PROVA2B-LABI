using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppPB2.Models;

namespace WebAppPB2.Controllers
{
    public class PatrimoniosController : Controller
    {
        private PatrimonioContext db = new PatrimonioContext();

        // GET: Patrimonios
        public ActionResult Index()
        {
            return View(db.Patrimonios.ToList());
        }

        // GET: Patrimonios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrimonio patrimonio = db.Patrimonios.Find(id);
            if (patrimonio == null)
            {
                return HttpNotFound();
            }
            return View(patrimonio);
        }

        // GET: Patrimonios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patrimonios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NumeroDeTombo,Descricao,Tipo")] Patrimonio patrimonio)
        {
            if (ModelState.IsValid)
            {
                db.Patrimonios.Add(patrimonio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patrimonio);
        }

        // GET: Patrimonios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrimonio patrimonio = db.Patrimonios.Find(id);
            if (patrimonio == null)
            {
                return HttpNotFound();
            }
            return View(patrimonio);
        }

        // POST: Patrimonios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NumeroDeTombo,Descricao,Tipo")] Patrimonio patrimonio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patrimonio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patrimonio);
        }

        // GET: Patrimonios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrimonio patrimonio = db.Patrimonios.Find(id);
            if (patrimonio == null)
            {
                return HttpNotFound();
            }
            return View(patrimonio);
        }

        // POST: Patrimonios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patrimonio patrimonio = db.Patrimonios.Find(id);
            db.Patrimonios.Remove(patrimonio);
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
