using System.Web;
using System.Web.Optimization;

namespace AllergyHistory
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.min.js",
                      "~/Scripts/bootstrap/bootstrap-select.js"));

            bundles.Add(new ScriptBundle("~/bundles/fontawesome").Include(
                      "~/Scripts/fontawesome/all.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                    "~/Libs/DataTables/datatables.js"));

            bundles.Add(new ScriptBundle("~/bundles/demoscripts").Include(
                     "~/Scripts/allergy-history.js",
                     "~/Scripts/allergy-input.js",
                     "~/Scripts/site.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap/bootstrap.css",
                      "~/Content/bootstrap/bootstrap-select.css",
                      "~/Content/fontawesome/all.css",
                      "~/Content/site.css",
                      "~/Content/allergy-input.css",
                      "~/Content/allergy-history.css",
                      "~/Libs/DataTables/datatables.css"));
        }
    }
}
