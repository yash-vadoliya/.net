using Registrstion.Models;
using System.Web.Mvc;

namespace Registrstion.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: User/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Register
        [HttpPost]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index", "Home"); // Redirect after successful registration
            }

            return View(model); // Return the same view with validation messages if the model is not valid
        }

        // GET: User/Index

        }
    }
}
