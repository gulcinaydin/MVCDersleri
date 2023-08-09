using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelperGrid.Models;

namespace WebHelperGrid.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrunListesi()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun{Id=1,Ad="Bilgisayar",Fiyat=2000,Adet=20},
                new Urun{Id=2,Ad="Masa",Fiyat=2001,Adet=250},
               new Urun{Id=3,Ad="Tv",Fiyat=2002,Adet=230},
                new Urun{Id=4,Ad="Telefon",Fiyat=200,Adet=200},
                new Urun{Id=5,Ad="Kitap",Fiyat=205,Adet=30}

            };
            return View(urunler);
        }

        public ActionResult UrunAra()
        {
            return View();
        }

        public ActionResult ExceleAktar()
        {
            return View(Veri.Urunler);
        }
    }
}