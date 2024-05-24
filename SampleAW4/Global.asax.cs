using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SampleAW4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Services.Replace(typeof(IAssembliesResolver), new CustomAssembliesResolver());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }


    public class CustomAssembliesResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            //var assemblies = base.GetAssemblies().ToList();
            //var controllersAssembly = typeof(AWMobileAPI.Controllers.TestController).Assembly;
            //if (!assemblies.Contains(controllersAssembly))
            //{
            //    assemblies.Add(controllersAssembly);
            //}
            //return assemblies;

            var assemblies = base.GetAssemblies();
            var controllersAssembly = typeof(AWMobileAPI.Controllers.TestController).Assembly;
            if (!assemblies.Contains(controllersAssembly))
            {
                assemblies.Add(controllersAssembly);
            }
            return assemblies;

        }
    }
}