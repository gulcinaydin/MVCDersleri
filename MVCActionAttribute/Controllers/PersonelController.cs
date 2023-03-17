using MVCActionAttribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Controllers
{
    public class PersonelController : Controller
    {
        private static List<Personel> PersonellerList = new List<Personel>()
        {
        new Personel {Id=1,Ad="Mert1",Soyad="AAAA1",TCKimlikNo="123"},
        new Personel {Id=2,Ad="Mert2",Soyad="AAAA2",TCKimlikNo="1234"},
        new Personel {Id=3,Ad="Mert3",Soyad="AAAA3",TCKimlikNo="12345"},
        new Personel {Id=4,Ad="Mert4",Soyad="AAAA4",TCKimlikNo="123456"},

        };

        public ActionResult Personeller()
        {
            return View(PersonellerList);
        }
        [HttpPost]
        public RedirectToRouteResult Sil(int id)
        {
            var silinecek = PersonellerList.Where(p => p.Id == id).FirstOrDefault();
            PersonellerList.Remove(silinecek);
            return new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { action = "Personeller", controller = "Personel" }));
        }

        public ActionResult PersonelAra()
        {
            return View();
        }
        [HttpGet]
        public ActionResult PersonelAramaSonucu(string personelAra)
        {
            ViewBag.ArananKelime = personelAra;
            var sonuc = PersonellerList.Where(p => p.Ad.ToLower().Contains(personelAra.ToLower())).ToList();
            return View(sonuc);
        }

        public ActionResult YeniPersonel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniPersonel(Personel per)
        {
            return View();
        }
    }
}