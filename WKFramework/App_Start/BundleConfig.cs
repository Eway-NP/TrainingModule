using System.Web;
using System.Web.Optimization;

namespace WKFramework
{
    public static class BundleConfig
    {
        //MVC 5在System.web.Optimization命名空间中包括以下bundle类：

        //ScriptBundle：ScriptBundle负责单个或多个脚本文件的JavaScript缩小。

        //StyleBundle：StyleBundle负责单个或多个样式表文件的CSS缩小。

        //DynamicFolderBundle：表示ASP.NET从包含相同类型的文件的文件夹创建的Bundle对象。

        //所有上述bundle类都包含在System.Web.Optimization.Bundle命名空间中，并从Bundle类派生。
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScriptBundles(bundles);
            RegisterStyleBundles(bundles);
        }
        /// <summary>
        /// 注册脚本
        /// </summary>
        /// <param name="bundles"></param>
        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/BootStrap/js").Include("~/Scripts/bootstrap/js/bootstrap.js",
               "~/Scripts/bootstrap/js/npm.js"));
            bundles.Add(new ScriptBundle("~/JQuery/js").Include("~/Scripts/JQuery/jquery-1.10.2.js",
              "~/Scripts/modernizr-2.6.2.js", "~/Scripts/respond.min.js"));
            bundles.Add(new ScriptBundle("~/Knockout/js").Include("~/Scripts/Knockout/Knockout.js",
             "~/Scripts/Knockout/mapping.js", "~/Scripts/Knockout/ko.Validation.js"));
        }
        /// <summary>
        /// 注册样式
        /// </summary>
        /// <param name="bundles"></param>
        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/BootStrap/css").Include("~/Content/bootstrap/css/Normalize.css", "~/Content/bootstrap/css/bootstrap.css",
                "~/Content/bootstrap/css/bootstrap-theme.min.css"));
        }
    }
}
