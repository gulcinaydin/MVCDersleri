using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace MVCWebApiToken.Controllers
{
    public class LoginController : ApiController
    {
        public string Login()
        {
            return Thread.CurrentPrincipal.Identity.Name;
        }
    }
}
