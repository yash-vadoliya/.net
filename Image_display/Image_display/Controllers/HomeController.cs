using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image_display.Models;

namespace Image_display.Controllers
{
    public class HomeController : Controller
    {
        mydbEntities db = new mydbEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user userModel, HttpPostedFileBase image)
        {
            if(image != null && image.ContentLength > 0)
            {
                var filename = System.IO.Path.GetFileName(image.FileName);
                var path = System.IO.Path.Combine(Server.MapPath("~/images"), filename);
                image.SaveAs(path);
                userModel.img = "/images/" + filename;
            }

            db.users.Add(userModel);
            db.SaveChanges();
            ViewBag.Messege = "Image upload Sucessfully...";
            return View();
        }

        public ActionResult DisplayUsers()
        {
            var users = db.users.ToList(); // Fetch all users from the database
            return View(users);
        }

    }
}