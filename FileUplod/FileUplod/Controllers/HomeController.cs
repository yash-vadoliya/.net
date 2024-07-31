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
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase f)
        {
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

            ViewBag.Messege = "Your Page..";
            return View();
        }

    }
}