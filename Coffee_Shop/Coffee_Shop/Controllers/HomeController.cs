using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Grind Haus Coffee.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Welcome(string FirstName, string LastName, string password1, string password2 )
        {
            if (password1 != password2)
            {
                ViewBag.ErrorMessage = "Passwords do not match!";
                return RedirectToAction("Register");
            }
            else
            {
                ViewBag.WelcomeUser = FirstName + " " + LastName;
                return View();
            }
        }
       
    }
}