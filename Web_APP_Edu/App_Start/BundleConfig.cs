using System.Web;
using System.Web.Optimization;

namespace Web_APP_Edu
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                       "~/assets/js/modernizr-*"));
    

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/assets/js/jquery.min.js", "~/assets/js/fancybox/jquery.fancybox.pack.js", "~/assets/js/jquery.mobile.customized.min.js",
                               "~/assets/js/jquery.easing.1.3.js", "~/assets/js/camera.min.js", "~/assets/js/bootstrap.min.js","~/assets/js/jquery.cslider.js","~/assets/js/jquery.isotope.min.js", "~/assets/js/custom.js"));

         
           
            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //                   ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery1").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
          
   
            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/font-awesome.min.css", "~/assets/css/isotope.css", "~/assets/js/fancybox/jquery.fancybox.css", "~/assets/css/bootstrap-theme.css", "~/assets/css/style.css"
                      , "~/assets/css/camera.css" )); 
                     
            
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));
        }
    }
}
