using Aliencube.Owin.Page404;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Owin;
using System;
using System.Configuration;

namespace Aliencube.WindowsServicesMonitoring.Web
{
    public static class Page404Config
    {
        public static void Register(IAppBuilder app)
        {
            Register404Page(app);
        }

        private static void Register404Page(IAppBuilder app)
        {
            var options = new Page404Options()
                          {
                              FileSystem = new PhysicalFileSystem(@"."),
                              IsLastMiddleware = true,
                              UseCustom404Page = UseCustom404Page(),
                              Custom404PagePath = GetCustom404PagePath(),
                              Custom404PageDir = GetCustom404PageDir()
                          };
            app.Use<Page404Middleware>(options);
        }

        private static bool UseCustom404Page()
        {
            bool result;
            return Boolean.TryParse(ConfigurationManager.AppSettings["UseCustom404Page"], out result) && result;
        }

        private static PathString GetCustom404PagePath()
        {
            var value = ConfigurationManager.AppSettings["Custom404PagePath"];
            return String.IsNullOrWhiteSpace(value) ? new PathString("/") : new PathString(value);
        }

        private static PhysicalFileSystem GetCustom404PageDir()
        {
            var value = ConfigurationManager.AppSettings["Custom404PageDir"];
            return String.IsNullOrWhiteSpace(value) ? new PhysicalFileSystem(@".") : new PhysicalFileSystem(value);
        }
    }
}