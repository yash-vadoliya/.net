using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace FileUplod.Controllers
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

        public ActionResult FileUpload()
        {
            return View();
        }

        private readonly string[] _allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
        private readonly string[] _allowedMimeTypes = { "image/jpeg", "image/png", "image/gif" };

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase f)
        {
            string fileExtension = Path.GetExtension(f  .FileName).ToLower();
            if (!_allowedExtensions.Contains(fileExtension))
            {
                ViewBag.Message = "Invalid file type. Only image files are allowed.";
                return View();
            }

            string filename = f.FileName;
            string name = Guid.NewGuid().ToString() + "_" + filename;

            string directoryPath = Server.MapPath("~/UploadedFiles");
            string filePath = Path.Combine(directoryPath, name);
            //f.SaveAs(Server.MapPath("~") + name);

            if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

            f.SaveAs(filePath);

            string imageUrl = Url.Content("~/UploadedFiles" + name);

            ViewBag.Messege = "Your Page..";
            ViewBag.ImageUrl = imageUrl;
            return View();
        }

    }
}