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
    public class EmailFormController : Controller
    {

        public ActionResult ProcessMasterEmail()
        {
            return View();
        }
        
        public ActionResult ProcessSuggestionRequest()
        {
            return View();
        }

        public ActionResult ProcessWEBSITEsuggestionRequest()
        {

            return View();
        }

        [Authorize]
        public ActionResult MasterEmail()
        {
            return View();
        }


        public ActionResult SuggestionSubmit()
        {
            return View();
        }

        public ActionResult WEBSITESuggestionSubmit()
        {
            return View();
        }
    }
}