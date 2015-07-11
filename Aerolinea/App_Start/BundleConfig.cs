using System.Web;
using System.Web.Optimization;

namespace Aerolinea
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true; //Enable CDN support

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/BxSlider").Include(
                      "~/Scripts/BxSlider/jquery.bxslider.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/normalize.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/BxSlider").Include(
                      "~/Content/jquery.bxslider.css"));

            var AwesomeCdn = "//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css";
            
            bundles.Add(new StyleBundle("~/Content/awesome", AwesomeCdn).Include(
                        "~/Content/font-awesome.min.css"));
        }
    }
}
