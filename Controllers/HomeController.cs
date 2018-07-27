using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchForCountry.Models;

namespace SearchForCountry.Controllers
{
    public class HomeController : Controller
    {
        TestEntities db = new TestEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
        [HttpPost]
        public JsonResult SaveData(Account model)
        { 
            db.Accounts.Add(model);
            db.SaveChanges();
            return Json("Registration Successfull",JsonRequestBehavior.AllowGet);
        }
    }
   
}