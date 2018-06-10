using System;
using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(
    typeof(DurandalJs.StartUpProject.App_Start.DurandalConfig), "PreStart")]

namespace DurandalJs.StartUpProject.App_Start
{
    public static class DurandalConfig
    {
        public static void PreStart()
        {
            // Add your start logic here
            DurandalBundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}