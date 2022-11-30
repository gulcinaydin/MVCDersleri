using MVCDersleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDersleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home 
        public ActionResult Index()
        {
            
            Personel personel = new Personel();
            personel.Id = 1;
            personel.Ad = "Ali Osman";
            personel.Soyad = "Hazır";

            return View(personel);
        }
    }
}