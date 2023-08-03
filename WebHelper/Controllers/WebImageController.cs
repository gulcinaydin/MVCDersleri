using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebHelper.Controllers
{
    public class WebImageController : Controller
    {
        // GET: WebImage
        public ActionResult Index()
        {
            return View();
        }
        private string ResimYolu
        {
            get
            {
                return Server.MapPath("~/Content/IMG-20181015-WA0006.jpg");
            }
        }

        public void ResimGoruntule()
        {
            WebImage resim = new WebImage(ResimYolu);
            resim.Write();
        }

        public void ResimDonder()
        {
            WebImage resim = new WebImage(ResimYolu);
            resim.RotateRight(); //iki kere right veya left olabilir. FlipHorizontal olabilir,FlipVertical 
            resim.Write();
        }
    }
}