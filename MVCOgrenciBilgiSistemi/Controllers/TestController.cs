using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi.Controllers
{
    public class TestController : Controller
    {
        public JavaScriptResult MesajGoster()
        {
            string script = "alert('butona tıklandı.Veri action dan alındı.')";
            return JavaScript(script);
        }

        public ActionResult TestJS()
        {
            return View();
        }
    }
}