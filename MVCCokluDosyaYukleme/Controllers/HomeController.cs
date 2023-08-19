using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCokluDosyaYukleme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DosyaYukleme(string Message)
        {
            if (Message != null) ViewBag.Message = Message;
            return View();
        }

        [HttpPost]
        public ActionResult TekliDosyaYukleme(HttpPostedFileBase dosya)
        {
            if (dosya != null)
            {
                string dosyaYolu = Path.GetFileName(dosya.FileName);
                var yuklemeYeri = Path.Combine(Server.MapPath("~/Dosyalar"), dosyaYolu);
                dosya.SaveAs(yuklemeYeri);
            }
            return RedirectToAction("DosyaYukleme", new { Message = "Dosya başarıyla yüklendi." });
        }

        public ActionResult CokluDosyaYukleme(List<HttpPostedFileBase> dosyalar)
        {
            foreach (var dosya in dosyalar)
            {


                if (dosya != null)
                {
                    string dosyaYolu = Path.GetFileName(dosya.FileName);
                    var yuklemeYeri = Path.Combine(Server.MapPath("~/Dosyalar"), dosyaYolu);
                    dosya.SaveAs(yuklemeYeri);
                }
            }
            return RedirectToAction("DosyaYukleme", new { Message = "Dosya başarıyla yüklendi." });
        }
    }
}