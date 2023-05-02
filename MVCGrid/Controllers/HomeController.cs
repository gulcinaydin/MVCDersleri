using MVCGrid.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Listele()
        {
            var model = db.Personeller.ToList();
            return View(model);
        }
    }
}