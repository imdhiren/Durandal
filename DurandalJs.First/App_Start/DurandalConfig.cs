﻿
using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(
    typeof(DurandalJs.First.App_Start.DurandalConfig), "PreStart")]

namespace DurandalJs.First.App_Start
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