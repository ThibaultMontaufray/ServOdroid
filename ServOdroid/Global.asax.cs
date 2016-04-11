using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ServOdroid
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc();
        //    services.AddCaching();
        //    services.AddSession(AppDomainManagerInitializationOptions =>
        //    {
        //        options.IdleTimeout = TimeSpan.FromMinutes(30);
        //        options.CookiesName = ".ServOdroid";
        //    });
        //}
    }
}
