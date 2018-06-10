using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof(DurandalJs.Second.App_Start.DurandalConfig), "PreStart")]

namespace DurandalJs.Second.App_Start
{
    public class DurandalConfig
    {
        public static void PreStart()
        {
            // Add your start logic here
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}