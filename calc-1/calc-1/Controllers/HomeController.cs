using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using calc_1.Models;

namespace calc_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Home h ,String calc)
        {
            if (calc == "add")
            {
                h.Res = h.A + h.B;
            }
            if (calc == "sub")
            {
                h.Res = h.A - h.B;
            }
            if (calc == "mul")
            {
                h.Res = h.A * h.B;
            }
            if (calc == "div")
            {
                h.Res = h.A / h.B;
            }
            ViewBag.model = h.Res;
            return View();
        }
    }
}