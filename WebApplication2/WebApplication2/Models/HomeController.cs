using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            home h = new home();
            h.id = 1;
            h.name = "Yash";
            return View(h);
        }
    }
}