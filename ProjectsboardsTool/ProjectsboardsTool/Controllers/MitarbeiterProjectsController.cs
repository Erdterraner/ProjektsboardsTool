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
    public class MitarbeiterProjectsController : Controller
    {
        private ProjectsboardsToolContext db = new ProjectsboardsToolContext();

        // GET: MitarbeiterProjects
        public ActionResult Index()
        {
            return View(db.MitarbeiterProjects.ToList());
        }

        // GET: MitarbeiterProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MitarbeiterProject mitarbeiterProject = db.MitarbeiterProjects.Find(id);
            if (mitarbeiterProject == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiterProject);
        }

        // GET: MitarbeiterProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MitarbeiterProjects/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Project,Mitarbeiter")] MitarbeiterProject mitarbeiterProject)
        {
            if (ModelState.IsValid)
            {
                db.MitarbeiterProjects.Add(mitarbeiterProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mitarbeiterProject);
        }

        // GET: MitarbeiterProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MitarbeiterProject mitarbeiterProject = db.MitarbeiterProjects.Find(id);
            if (mitarbeiterProject == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiterProject);
        }

        // POST: MitarbeiterProjects/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Project,Mitarbeiter")] MitarbeiterProject mitarbeiterProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mitarbeiterProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mitarbeiterProject);
        }

        // GET: MitarbeiterProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MitarbeiterProject mitarbeiterProject = db.MitarbeiterProjects.Find(id);
            if (mitarbeiterProject == null)
            {
                return HttpNotFound();
            }
            return View(mitarbeiterProject);
        }

        // POST: MitarbeiterProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MitarbeiterProject mitarbeiterProject = db.MitarbeiterProjects.Find(id);
            db.MitarbeiterProjects.Remove(mitarbeiterProject);
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
