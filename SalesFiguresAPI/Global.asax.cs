using AutoMapper;
using DataAccess.Models;
using SalesFiguresAPI.App_Start;
using SalesFiguresAPI.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SalesFiguresAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        string connString = ConfigurationManager.ConnectionStrings["JodiUpdate"].ConnectionString;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperBootStrapper.BootStrap();

            SqlDependency.Start(connString);
        }

        protected void Application_End()
        {
            SqlDependency.Stop(connString);
        }
    }
}
