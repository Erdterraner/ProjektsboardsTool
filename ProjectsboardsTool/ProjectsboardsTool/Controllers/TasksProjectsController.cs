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
    public class TasksProjectsController : Controller
    {
        private ProjectsboardsToolContext db = new ProjectsboardsToolContext();

        // GET: TasksProjects
        public ActionResult Index()
        {
            return View(db.TasksProjects.ToList());
        }

        // GET: TasksProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TasksProject tasksProject = db.TasksProjects.Find(id);
            if (tasksProject == null)
            {
                return HttpNotFound();
            }
            return View(tasksProject);
        }

        // GET: TasksProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TasksProjects/Create
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Project,Task")] TasksProject tasksProject)
        {
            if (ModelState.IsValid)
            {
                db.TasksProjects.Add(tasksProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tasksProject);
        }

        // GET: TasksProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TasksProject tasksProject = db.TasksProjects.Find(id);
            if (tasksProject == null)
            {
                return HttpNotFound();
            }
            return View(tasksProject);
        }

        // POST: TasksProjects/Edit/5
        // Aktivieren Sie zum Schutz vor Angriffen durch Overposting die jeweiligen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Project,Task")] TasksProject tasksProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tasksProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tasksProject);
        }

        // GET: TasksProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TasksProject tasksProject = db.TasksProjects.Find(id);
            if (tasksProject == null)
            {
                return HttpNotFound();
            }
            return View(tasksProject);
        }

        // POST: TasksProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TasksProject tasksProject = db.TasksProjects.Find(id);
            db.TasksProjects.Remove(tasksProject);
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
