using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace MVCWebApi2.Constraints
{
    public class IlkHarf : IHttpRouteConstraint
    {
        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {

            string val = values[parameterName].ToString().ToUpper();
            if (val.StartsWith("A"))
                return true;

            return false;

        }
    }
}