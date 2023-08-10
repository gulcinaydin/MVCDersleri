using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCDurumYönetimi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public int onlineUyeSayisi { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender,EventArgs e)
        {
            int onileUyeSayisi = Convert.ToInt32(Application["OnlineUyeSayisi"]);
            onlineUyeSayisi = onileUyeSayisi + 1;
            Application["OnlineUyeSayisi"] = onlineUyeSayisi;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            int onileUyeSayisi = Convert.ToInt32(Application["OnlineUyeSayisi"]);
            onlineUyeSayisi = onileUyeSayisi - 1;
            Application["OnlineUyeSayisi"] = onlineUyeSayisi;
        }
    }
}
