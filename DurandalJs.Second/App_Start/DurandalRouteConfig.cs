using System.Web.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DurandalJs.Second.App_Start.DurandalRouteConfig), "RegisterPreStart", Order = 2)]

namespace DurandalJs.Second.App_Start
{
    public class DurandalRouteConfig
    {
        public static void RegisterPreStart()
        {
            // Preempt standard default MVC page routing to go to HotTowel Sample
            System.Web.Routing.RouteTable.Routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}