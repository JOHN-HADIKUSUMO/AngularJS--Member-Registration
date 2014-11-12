using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AngularJS__Member_Registration
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(App_Start.WebApiConfig.Register);
            App_Start.FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            App_Start.RouteConfig.RegisterRoutes(RouteTable.Routes);
            App_Start.BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
