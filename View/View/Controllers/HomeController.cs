using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View.Models;

namespace View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Home h = new Home();
        public ActionResult Index()
        {
            //IList<Home> list = new IList<Home>();

            var list = h.Name.ToList();
            list.Add(new Home()
                {
                    con = "India",
                });
                list.Add(new Home()
                {
                    con = "Usa",

                });
                list.Add(new Home()
                {
                    con = "Uae",
                });
            
            ViewData["li"] = list;
            return View();
        }
    }
}