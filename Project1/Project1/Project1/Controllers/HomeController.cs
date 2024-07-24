using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Home h = new Home();
            h.id = 1;
            h.name = "Yash";
            h.no = "8758787706";

            ViewBag.title = "Hello Yash Vadoliya..";

            ViewData["name"] = "Yash Vadoliya..";
            return View(h);


        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}