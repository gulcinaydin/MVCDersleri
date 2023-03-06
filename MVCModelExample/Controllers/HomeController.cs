using MVCModelExample.Models;
using MVCModelExample.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listele()
        {
            var model = PersonelVeriler.listPersoneller;


            return View(model);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Personel personel)
        {
            PersonelVeriler.listPersoneller.Add(personel);
            return RedirectToAction("Listele");

        }
        public ActionResult Duzenle(int id)
        {
            var model = PersonelVeriler.listPersoneller.Where(m => m.Id == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public ActionResult Duzenle(Personel model)
        {
            var guncellenecek = PersonelVeriler.listPersoneller.Where(m => m.Id == model.Id).FirstOrDefault();

            guncellenecek.Ad = model.Ad;
            guncellenecek.Soyad = model.Soyad;
            guncellenecek.TCKN = model.TCKN;
            guncellenecek.DogumTarihi = model.DogumTarihi;



            return RedirectToAction("Listele");
        }

        public ActionResult Sil(int id)
        {
            var silinecek = PersonelVeriler.listPersoneller.Where((m) => m.Id == id).FirstOrDefault();

            PersonelVeriler.listPersoneller.Remove(silinecek);
            return RedirectToAction("Listele");

        }
    }
}