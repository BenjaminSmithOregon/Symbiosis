using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Sprint1Test.Models;

namespace Sprint1Test.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Start()
        {
            ViewBag.Message = "How to get started!";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tutorial()
        {
            ViewBag.Message = "Your Tut page.";

            return View();
        }


        //public ActionResult Profile()
        //{
        //    return View();
        //}

        public ActionResult SuggestionSubmit()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Profile(HttpPostedFileBase fileUpload)
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Profile(HttpPostedFile fileUpload)
        //{

        //    string photoFolder = System.IO.Path.Combine(Server.MapPath("~/images"), System.IO.Path.GetFileName(fileUpload.FileName));


        //            //System.IO.Directory.CreateDirectory(photoFolder);
        //            fileUpload.SaveAs(photoFolder);
        //            ViewBag.Message = "File uploaded successfully";

        //    public ActionResult Profile(image img, HttpPostedFileBase file)
        //{

        //        if (file != null)
        //        {
        //            file.SaveAs("C:/Users/Ben/Pictures");
        //            //img.ImagePath = file.FileName;
        //                                return RedirectToAction("Profile");
        //        }
        //        //db.Image.Add(img);
        //        //db.SaveChanges();
        //    }
        //    return View();
        //}



        //if (file.FileName != "")
        //{

        //    string path = System.IO.Path.Combine(Server.MapPath("~/images/UserPhotos/"), System.IO.Path.GetFileName(file.FileName));
        //    file.SaveAs(path);
        //    ViewBag.Message = "File uploaded successfully";

        //    return View();
        //}
        //else
        //    return View();


        //        if (!fileUpload.FileName.Equals(""))
        //        {
        //            if ((fileUpload.ContentType == "image/jpg") ||
        //                (fileUpload.ContentType == "image/png") ||
        //                (fileUpload.ContentType == "image/bmp") ||
        //                (fileUpload.ContentType == "image/gif"))
        //            {
        //                if (Convert.ToInt64(fileUpload.ContentLength) < 10000000)
        //                {

        //                    string photoFolder = System.IO.Path.Combine("~/images/UserPhotos/", User.Identity.Name);

        //                    if (!System.IO.Directory.Exists(photoFolder))
        //                    {
        //                        //Creates a user folder, if it doesnt already exist
        //                        System.IO.Directory.CreateDirectory(photoFolder);
        //                    }

        //                    string extension = System.IO.Path.GetExtension(fileUpload.FileName);
        //                    //Changes the filename by adding a time stamp
        //                    string uniqueFileName = System.IO.Path.ChangeExtension(fileUpload.FileName, DateTime.Now.Ticks.ToString());

        //                    //Saves uploaded file
        //                    fileUpload.SaveAs(System.IO.Path.Combine(photoFolder, uniqueFileName + extension));

        //                    //Outputs a message that the file was successfully uploaded
        //                    ViewBag.Message = "Successfully Uploaded";
        //                    //ModelState.AddModelError("", "<font color = 'Green'>Successfully Uploaded" + fileUpload.FileName + "</font>");
        //                }
        //                else
        //                    ViewBag.Message = "File must be less than 10MB";
        //                //ModelState.AddModelError("", "File must be less than 10MB");
        //            }
        //            else
        //                ViewBag.Message = "File must be of type jpg, jpeg, bmp, gif, or png";
        //            //ModelState.AddModelError("", "File must be of type jpg, jpeg, bmp, gif, or png");

        //        }
        //        else
        //            ViewBag.Message = "No file selected";
        //        //ModelState.AddModelError("", "No file selected");

        //        return View();

        //    }
        //}
    }

}