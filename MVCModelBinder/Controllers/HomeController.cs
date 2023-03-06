using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelBinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(string urunAd)
        {
            return View();
        }
    }
}