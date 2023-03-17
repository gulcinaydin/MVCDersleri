using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Controllers
{
    public class OnBellekController : Controller
    {
        [OutputCache(Duration = 60)]
        public ActionResult SaatGoster()
        {
            ViewBag.Saat = string.Format("{0:dd.MM.yyyy HH:mm:ss}", DateTime.Now);
            return View();
        }
    }
}