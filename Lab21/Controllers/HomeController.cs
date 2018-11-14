using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Summary()
        {
            return View();
        }
        public ActionResult AddUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
                ORM.Users.Add(newUser);
                ORM.SaveChanges();
                ViewBag.WelcomeMessage = $"Welcome {newUser.FirstName}!";
                return View("Summary");
            }
            else
            {
                return View("Error");
            }
        }
    }
}