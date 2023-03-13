using MVCOgrenciBilgiSistemi.DAL;
using MVCOgrenciBilgiSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCOgrenciBilgiSistemi.Controllers
{
    public class FakulteController : Controller
    {
        OBSContext veritabani = new OBSContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Ekle(Fakulte kayit)
        {
            veritabani.Fakulteler.Add(kayit);
            veritabani.SaveChanges();
            return new RedirectToRouteResult(new RouteValueDictionary(new { action = "FakultelerJson", controller = "Fakulte" }));
        }

        [HttpPost]
        public JsonResult Listele()
        {
            var fakulteler = veritabani.Fakulteler.ToList();
            return Json(fakulteler, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FakultelerJson()
        {
            return View();
        }
        public ActionResult Fakulteler()
        {
            var fakulteler = veritabani.Fakulteler.ToList().Select(f => new SelectListItem
            {
                Selected = false,
                Text = f.FakulteAd,
                Value = f.Id.ToString()


            }).ToList();

            ViewBag.Fakulteler = fakulteler;
            return View();
        }

        [ActionName("TumFakulteler")]
        public ActionResult Detay()
        {
            return View();
        }
        [ActionName("Fakulte")]
        public ActionResult Detay(int id)
        {
            ViewBag.FakulteId = id;
            return View();
        }


    }
}