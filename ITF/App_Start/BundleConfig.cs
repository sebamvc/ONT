using System.Web;
using System.Web.Optimization;

namespace ITF
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            //// para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            

            bundles.Add(new StyleBundle("~/bundles/js").Include(
                "~/js/jquery-3.4.1.min.js",
                "~/js/bootstrap.min.js",
                "~/js/scripts.js",
                "~/js/popper.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Css/bootstrap.min.css",
                      "~/fontawesome-free-5.13.0-web/css/fontawesome.css",
                      "~/fontawesome-free-5.13.0-web/css/brands.css",
                      "~/fontawesome-free-5.13.0-web/css/solid.css"
                      ));
        }
    }
}
