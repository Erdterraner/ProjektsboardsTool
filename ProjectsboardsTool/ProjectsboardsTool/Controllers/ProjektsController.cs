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
    public class ProjektsController : Controller
    {
        private ProjectsboardsToolContext db = new ProjectsboardsToolContext();

        // GET: Projekts
        public ActionResult Index()
        {
            return View(db.Projekts.ToList());
        }

        // GET: Projekts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projekt projekt = db.Projekts.Find(id);
            if (projekt == null)
            {
                return HttpNotFound();
            }
            return View(projekt);
        }

        // GET: Projekts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projekts/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Projektleiter,StandinProzent,Budet")] Projekt projekt)
        {
            if (ModelState.IsValid)
            {
                db.Projekts.Add(projekt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projekt);
        }

        // GET: Projekts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projekt projekt = db.Projekts.Find(id);
            if (projekt == null)
            {
                return HttpNotFound();
            }
            return View(projekt);
        }

        // POST: Projekts/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Projektleiter,StandinProzent,Budet")] Projekt projekt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projekt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projekt);
        }

        // GET: Projekts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projekt projekt = db.Projekts.Find(id);
            if (projekt == null)
            {
                return HttpNotFound();
            }
            return View(projekt);
        }

        // POST: Projekts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projekt projekt = db.Projekts.Find(id);
            db.Projekts.Remove(projekt);
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
