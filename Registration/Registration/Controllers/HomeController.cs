using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        private object _context;

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View(new user());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(user model)
        {
            if (ModelState.IsValid)
            {
                // Check if the username or email already exists
                if (_context.Users.Any(u => u.unm == model.unm || u.email == model.email))
                {
                    ModelState.AddModelError("", "Username or email already exists.");
                    return View(model);
                }

                // Hash the password before saving (optional but recommended)
                model.password = HashPassword(model.password); // Implement this method to hash passwords

                // Save the user to the database
                _context.Users.Add(model);
                _context.SaveChanges();

                // Redirect to a success page or login page
                return RedirectToAction("Homepage");
            }

            return View("Index", model);
        }

        // Optional: Method to hash passwords (implement your own hashing logic)
        private string HashPassword(string password)
        {
            // Use a hashing algorithm to hash the password
            // Example: return BCrypt.Net.BCrypt.HashPassword(password);
            return password; // Replace this with actual hashing
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Register()
        {
            return View();
        }
    } 
}