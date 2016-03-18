using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sprint1Test.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Sprint1Test.Controllers
{
    public class SkillController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Skill
        //[Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var skills = db.Skills.Include(s => s.SubCat);
            return View(skills.ToList());
        }

        public ActionResult SkillEdit()
        {
            return View();
        }

        // GET: Skill/Details/5
        [Authorize(Roles = "admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = db.Skills.Find(id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            return View(skill);
        }

        // GET: Skill/Create
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            ViewBag.SubCategoryID = new SelectList(db.SubCategories, "SubCategoryID", "SubCategoryName");
            return View();
        }

        // POST: Skill/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public ActionResult Create([Bind(Include = "SkillID,SubCategoryID,SkillName,Link")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                db.Skills.Add(skill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubCategoryID = new SelectList(db.SubCategories, "SubCategoryID", "SubCategoryName", skill.SubCategoryID);
            return View(skill);
        }

        // GET: Skill/Edit/5
        [Authorize(Roles = "admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = db.Skills.Find(id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubCategoryID = new SelectList(db.SubCategories, "SubCategoryID", "SubCategoryName", skill.SubCategoryID);
            return View(skill);
        }

        // POST: Skill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public ActionResult Edit([Bind(Include = "SkillID,SubCategoryID,SkillName,Link")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubCategoryID = new SelectList(db.SubCategories, "SubCategoryID", "SubCategoryName", skill.SubCategoryID);
            return View(skill);
        }

        // GET: Skill/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = db.Skills.Find(id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            return View(skill);
        }

        // POST: Skill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skill skill = db.Skills.Find(id);
            db.Skills.Remove(skill);
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
