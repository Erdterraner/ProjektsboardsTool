using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectsboardsTool.Data;
using ProjectsboardsTool.Models;

namespace ProjectsboardsTool.Controllers
{
    public class MitarbeitersController : Controller
    {
        private ProjectsboardsToolContext db = new ProjectsboardsToolContext();

        // GET: Mitarbeiters
        public ActionResult Index()
        {
            return View(db.Mitarbeiters.ToList());
        }

        // GET: Mitarbeiters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // GET: Mitarbeiters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mitarbeiters/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Vorname,Geburtsdatum,Position,Projekt")] Mitarbeiter mitarbeiter)
        {
            if (ModelState.IsValid)
            {
                db.Mitarbeiters.Add(mitarbeiter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mitarbeiter);
        }

        // GET: Mitarbeiters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // POST: Mitarbeiters/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Vorname,Geburtsdatum,Position,Projekt")] Mitarbeiter mitarbeiter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mitarbeiter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mitarbeiter);
        }

        // GET: Mitarbeiters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            if (mitarbeiter == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiter);
        }

        // POST: Mitarbeiters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mitarbeiter mitarbeiter = db.Mitarbeiters.Find(id);
            db.Mitarbeiters.Remove(mitarbeiter);
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
