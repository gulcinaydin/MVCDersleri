using MVCOgrenciBilgiSistemi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi.Controllers
{
    public class FakulteController : Controller
    {
        OBSContext veritabani = new OBSContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}