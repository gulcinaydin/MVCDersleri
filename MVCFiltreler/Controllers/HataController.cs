using MVCFiltreler.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltreler.Controllers
{
    public class HataController : Controller
    {

        [Log]
        // GET: Hata
        [HandleError(ExceptionType = typeof(FormatException), View = "Hata")]
        public ActionResult Index()
        {
            throw new FormatException();
        }
    }
}