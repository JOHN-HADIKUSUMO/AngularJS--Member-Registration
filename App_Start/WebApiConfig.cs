using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AngularJS__Member_Registration.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Attribute routing.
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "REST-ADVERTS-GET",
            //    routeTemplate: "REST/ADVERTS/GET-DETAIL/{id}",
            //    defaults: new { controller = "adverts", action = "get", id = -1 }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}