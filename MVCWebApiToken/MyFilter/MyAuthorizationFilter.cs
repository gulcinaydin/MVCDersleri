using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MVCWebApiToken.MyFilter
{
    public class MyAuthorizationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                var key = actionContext.Request.Headers.Authorization.Parameter;
                var adParola = Encoding.UTF8.GetString(Convert.FromBase64String(key));


                var adParolaDizisi = adParola.Split(':');
                var kullaniciAd = adParolaDizisi[0];
                var parola = adParolaDizisi[1];

                if (Login.Giris(kullaniciAd, parola))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(kullaniciAd), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);

                }


            }
        }
    }
}