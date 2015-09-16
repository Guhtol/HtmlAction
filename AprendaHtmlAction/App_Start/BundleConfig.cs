using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AprendaHtmlAction.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(
                "~/bundles/jquery").Include(
                "~/Scripts/jquery={version}.js", "~/Scripts/JavaScript.js"
                ));
            bundles.Add(new StyleBundle("~/bundles/Boots").Include
                (
                "~/Content/bootstrap.css"
                ));
        }
    }
}