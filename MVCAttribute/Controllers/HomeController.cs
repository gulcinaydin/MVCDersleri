using MVCAttribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAttribute.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Uye uye)
        {
            bool dogrumu = ModelState.IsValid;
            return View();
        }

        private static Uye uye = new Uye
        {
            Id = 1,
            Ad = "Ali Osman",
            Soyad = "Hazır",
            TCKimlikNo = "111111111111",
            UyelikTarihi = new DateTime(2017, 12, 02)
        };

        public ActionResult Detay()
        {
            return View(uye);
        }
    }
}