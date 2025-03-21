using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudRegAppPart2.Models;

namespace StudRegAppPart2.Controllers
{
    public class StudentController : Controller
    {
        private RegistrationDBContext db = new RegistrationDBContext();

        // GET: Student
        public ActionResult Index()
        {
            return View(db.Student01.ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student01 student01 = db.Student01.Find(id);
            if (student01 == null)
            {
                return HttpNotFound();
            }
            return View(student01);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,Name,Surname,email")] Student01 student01)
        {
            if (ModelState.IsValid)
            {
                db.Student01.Add(student01);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student01);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student01 student01 = db.Student01.Find(id);
            if (student01 == null)
            {
                return HttpNotFound();
            }
            return View(student01);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,Name,Surname,email")] Student01 student01)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student01).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student01);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student01 student01 = db.Student01.Find(id);
            if (student01 == null)
            {
                return HttpNotFound();
            }
            return View(student01);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student01 student01 = db.Student01.Find(id);
            db.Student01.Remove(student01);
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
