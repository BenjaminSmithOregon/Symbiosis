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
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PagedList;

namespace Sprint1Test.Controllers
{

    public class ProfileController : Controller
    {

        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public ProfileController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        //// GET: Profile
        //public ActionResult Index()
        //{

        //    return View(db.Profiles.ToList());
        //}

        //GET: Profile with search results
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_asc" : "";
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "firstName_asc" : "";
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastName_asc" : "";
            ViewBag.CitySortParm = String.IsNullOrEmpty(sortOrder) ? "city_asc" : "";
            ViewBag.StateSortParm = String.IsNullOrEmpty(sortOrder) ? "state_asc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var users = from s in db.Profiles
                        select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.userName.Contains(searchString) || s.firstName.Contains(searchString) || s.lastName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_asc":
                    users = users.OrderBy(s => s.userName);
                    break;
                case "firstName_asc":
                    users = users.OrderBy(s => s.firstName);
                    break;
                case "lastName_asc":
                    users = users.OrderBy(s => s.lastName);
                    break;
                case "city_asc":
                    users = users.OrderBy(s => s.city);
                    break;
                case "state_asc":
                    users = users.OrderBy(s => s.state);
                    break;
                default:
                    users = users.OrderBy(s => s.userName);
                    break;
            }

            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(users.ToPagedList(pageNumber, pageSize));

            //return View(users.ToList());
        }


        // GET: Profile/Details/5
        public ActionResult Details()
        {
            string currentUserID = User.Identity.GetUserId();
            Profile profile = db.Profiles.FirstOrDefault(x => x.UserID == currentUserID);

                return View(profile);
        }


        //// GET: Profile/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Profile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Profile profile, HttpPostedFileBase file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (file != null)
        //        {
        //            file.SaveAs(HttpContext.Server.MapPath("~/images/UserPhotos")
        //                                                  + file.FileName);
        //            profile.imagePath = file.FileName;
        //        }
        //        db.Profiles.Add(profile);
        //        db.SaveChanges();

        //        return RedirectToAction("Index");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(profile).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Details");
        //    }

        //    return View(profile);
        //}

        // GET: Profile/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,userName,firstName,lastName,businessName,email,city,state,dateJoined,skillsOffered,certs,imagePath,UserID")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details");
            }
            return View(profile);
        }


         //GET: Profile/Delete/5
        //public ActionResult Delete(int? id, string? UserID)
         [Authorize]
        public ActionResult Delete(int? id)
        {
            //string currentUserID = User.Identity.GetUserId();
            //Profile profile = db.Profiles.FirstOrDefault(x => x.UserID == currentUserID);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            //ApplicationUser currentUser = db.Users.Find(UserID);
            //if (profile == null || currentUser ==null)
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }


         //POST: Profile/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id, string UserID)
        public ActionResult DeleteConfirmed(int? id)
        {
            string currentUserId = User.Identity.GetUserId();
            //ApplicationUser currentUser = db.Users.Find(currentUserId);
            //ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
            Profile profile = db.Profiles.Find(id);
            db.Profiles.Remove(profile);
            //db.Users.Remove(currentUser);
            db.SaveChanges();
            //return RedirectToAction("~/Home/Index");
            //return RedirectToAction("Index", Home); 
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult ProfilePic(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProfilePic([Bind(Include = "ID,userName,firstName,lastName,businessName,email,city,state,dateJoined,skillsOffered,certs,imagePath,UserID")] Profile profile, HttpPostedFileBase file)
        {
            string user = User.Identity.GetUserId();

            if (file == null)
            {
                ModelState.AddModelError(string.Empty, "An image file must be chosen.");
            }
            else if (ModelState.IsValid)
            {
                db.Entry(profile).State = EntityState.Modified;
                file.SaveAs(HttpContext.Server.MapPath("~/images/UserPhotos/") + user + file.FileName);
                string fileName = user + file.FileName;
                profile.imagePath = fileName;
                profile.UserID = user;
                db.SaveChanges();

                return RedirectToAction("Details");
            }

            return View(profile);
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
