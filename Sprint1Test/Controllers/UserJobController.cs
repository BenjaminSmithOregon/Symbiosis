using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sprint1Test.Models;

namespace Sprint1Test.Controllers
{
    public class UserJobController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserJob
        public ActionResult Index()
        {
            return View(db.UserJobs.ToList());
        }

        // GET: UserJob/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserJob userJob = db.UserJobs.Find(id);
            if (userJob == null)
            {
                return HttpNotFound();
            }
            return View(userJob);
        }

        // GET: UserJob/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserJobID,JobID,UserID")] UserJob userJob)
        {
            if (ModelState.IsValid)
            {
                db.UserJobs.Add(userJob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userJob);
        }

        // GET: UserJob/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserJob userJob = db.UserJobs.Find(id);
            if (userJob == null)
            {
                return HttpNotFound();
            }
            return View(userJob);
        }

        // POST: UserJob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserJobID,JobID,UserID")] UserJob userJob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userJob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userJob);
        }

        // GET: UserJob/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserJob userJob = db.UserJobs.Find(id);
            if (userJob == null)
            {
                return HttpNotFound();
            }
            return View(userJob);
        }

        // POST: UserJob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserJob userJob = db.UserJobs.Find(id);
            db.UserJobs.Remove(userJob);
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
