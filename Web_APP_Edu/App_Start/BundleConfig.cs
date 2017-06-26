using System.Web;
using System.Web.Optimization;

namespace Web_APP_Edu
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
  
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery.min.js", "~/Scripts/jquery.easing.1.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                               "~/Scripts/bootstrap.min.js",
                               "~/Scripts/owl.carousel.min.js", "~/Scripts/jquery.waypoints.min.js", "~/Scripts/jquery.magnific-popup.min.js", "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery1").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
          
   
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/animate.css",
                      "~/Content/icomoon.css", "~/Content/owl.carousel.min.css", "~/Content/owl.theme.default.min.css"
                      , "~/Content/magnific-popup.css"
                      , "~/Content/style.css")); 
            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}
