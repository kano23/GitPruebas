using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
            var model = PetManagemet.GetByBame(name);
            if (model == null)
                return RedirectToAction("NotFound");
            return View(model);
        }
        public ActionResult NotFound()
        {
            return View();
        }
        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = "content/Uploads" + ".jpg";
            var contentType = "image/jpg";
            var fileName = name = ".jpg";
            return File(picture, contentType, fileName);
        }
    }
}
