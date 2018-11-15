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
            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
            ViewBag.Test = ORM.Items.ToList<Item>();


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
        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult FindItem(string name)
        {
            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();
            //find item
            Item ItemToEdit = ORM.Items.Find(name);

            if (ItemToEdit == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.ItemToEdit = ItemToEdit;
            return View();

        }
        public ActionResult DeleteItem(string name)
        {
            CoffeeShopDBEntities2 ORM = new CoffeeShopDBEntities2();

            Item ItemToDelete = ORM.Items.Find(name); 
            
            ORM.Items.Remove(ItemToDelete);

            
            ORM.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}