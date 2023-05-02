using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCRouting.RouteConstraints
{
    public class KategoriRouteConstraints : IRouteConstraint

    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            string kategoriAdi = values["kategori"].ToString();

            List<string> kategoriler = new List<string>()
            {
                "Güncel Haberler","Magazin","Spor","Savaş"
            };

            if (kategoriler.Contains(kategoriAdi))

                return true;
            else
                return false;

        }
    }
}