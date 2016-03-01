using System.Web;
using System.Web.Optimization;

namespace knockoutApp2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/knockoutApp2Bundle").Include(
                        "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery-ui-1.11.4", "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js", "~/Scripts/knockout-{version}.js",
                        "~/Scripts/knockout.custom.js",
                        "~/Scripts/ViewModels/CartSummaryViewModel.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-{version}.js"));
                                    
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
