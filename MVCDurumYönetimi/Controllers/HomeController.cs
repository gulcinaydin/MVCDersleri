using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDurumYönetimi.Controllers
{
    public class HomeController : Controller
    {
        private HttpCookie cookie;

        public HttpCookie HttpCookie { get; private set; }

        // GET: Home
        public ActionResult Indexx()
        {
            Session.Add("egitmen", "mert aktas");
            Session.Add("sayi", 5);
            Session["egitmen2"] = "Ali Osman";

            //ViewBag.message = Session["egitmen"];

            Session.Remove("egitmen2");

            Session.Abandon();

            ViewBag.Online = HttpContext.Application["OnlineUyeSayisi"];

            return View();
        }

        public ActionResult Index2()
        {
            HttpContext.Application.Add("egitmen", "Ali Osmancık");
            HttpContext.Application["egitmen2"] = "Ali Osmancık";

            ViewBag.Message = HttpContext.Application["egitmen"];

            //örneğin eğitmen2yi silmek için HttpContext.Application.Remove("egitmen2"); ama hepsini silmek için removeall diyeceğiz.
            return View();
        
        }

        public ActionResult Cookie()
        {
            HttpCookie = new HttpCookie("kullanici", "Mert aktas");
            HttpContext.Response.Cookies.Add(cookie);

            cookie.Expires=DateTime.Now.AddDays(1);

            ViewBag.Message = HttpContext.Response.Cookies["kullanici"].Value;

            HttpContext.Response.Cookies.Remove("kullanici");

            return View();
        }
    }
}