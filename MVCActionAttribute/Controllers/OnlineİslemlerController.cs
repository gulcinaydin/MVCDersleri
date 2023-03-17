using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Controllers
{
    public class OnlineİslemlerController : Controller
    {

#if !DEBUG

        [RequireHttps]
#endif
        public ActionResult Giris()
        {
            return View();
        }
    }
}