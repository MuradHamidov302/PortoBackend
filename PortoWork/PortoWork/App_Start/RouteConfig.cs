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
               url: "blogs/detail-id/{id}",
               defaults: new { controller = "BlogDetail", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
              name: "Blog",
              url: "blogs/{ Action}/ ",
              defaults: new { controller = "Blog", action = "Index"});

            routes.MapRoute(
             name: "Error",
             url: "Error/{Id}",
             defaults: new { controller = "Error", action = "Errors", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MainPg", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
