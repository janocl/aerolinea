using System.Web;
using System.Web.Optimization;

namespace Aerolinea
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.UseCdn = true; //Enable CDN support

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/bootstrap-datepicker.min.js",
                      "~/Scripts/BxSlider/jquery.bxslider.min.js",
                      "~/Scripts/BxSlider/images/"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.datepicker.min.css",
                      "~/Content/bootstrap.datepaicker3.css",
                      "~/Content/jquery.bxslider.min.css",
                      "~/Content/Site.css"));

            //var AwesomeCdn = "//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css";
            
            //bundles.Add(new StyleBundle("~/Content/awesome", AwesomeCdn).Include(
            //            "~/Content/font-awesome.min.css"));
        }
    }
}
