using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PortoWork
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "BlogDetail",
               url: "blog/detail-id/{id}",
               defaults: new { controller = "BlogDetail", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
              name: "Blog",
              url: "blog/{ Action}/ ",
              defaults: new { controller = "Blog", action = "Index"});


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MainPg", action = "Index", id = UrlParameter.Optional });
        }
    }
}
