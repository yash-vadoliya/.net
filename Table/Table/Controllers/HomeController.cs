using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Table.Models;

namespace Table.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        { 
            List<Home> list = new List<Home>() {
            new Home() {
                Id = 1,
                    Name = "Yash",
                    City = "Junagadh"
            },
            new Home() {
                Id = 2,
                    Name = "Keval",
                    City = "Surat"
            },
            new Home() {
                Id = 3,
                    Name = "Abhi",
                    City = "Ahmadabad"
            },
            };
            ViewBag.model = list;
            return View();
        }
    }
}