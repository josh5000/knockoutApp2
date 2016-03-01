using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using knockoutApp2.DAL;

namespace knockoutApp2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var dbContext = new knockoutApp2Context();
            Database.SetInitializer(new DataInitialization());
            dbContext.Database.Initialize(true);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Add("__MpAppSession", string.Empty);
        }
    }
}
