using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDersleri2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            ViewData["hak"] = "mvc1 den beri kullanılır viewdata";
            ViewBag.hakkimizda = "mvc3 den beri kullanılır viewbag";
            TempData["hakkimizda"] = "mvc3 den beri kullanılır tempdata";
                        
            return RedirectToAction("Iletisim");
        }
        public ActionResult Iletisim()
        {
            return RedirectToAction("Anasayfa");
        }
        public ActionResult Nested()
        {
            return View();
        }

        public ActionResult NewView()
        {
            return View();
        }

        public ActionResult  Partial()
        {
            return View();
        }

    }
}
