using MVCTablodakiTumKayitlar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTablodakiTumKayitlar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TumKayitlariSec()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun
                {
                    Id=1,
                    Ad="Tablet",
                    Fiyat=3000
                },
                 new Urun
                {
                    Id=2,
                    Ad="TV",
                    Fiyat=3001
                },
                  new Urun
                {
                    Id=3,
                    Ad="Tlfn",
                    Fiyat=3002
                }
            };
            ViewBag.Urunler = urunler;
            return View();

        }

        [HttpPost]
        public ActionResult UrunleriSil(string seciliIdler)
        {
            return View();
        }
    }
}