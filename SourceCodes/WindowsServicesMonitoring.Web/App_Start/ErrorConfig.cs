using System.Configuration;
using Owin;

namespace WindowsServicesMonitoring.Web
{
    public static class ErrorConfig
    {
        public static void Register(IAppBuilder app)
        {
            RegisterErrorPage(app);
        }

        private static void RegisterErrorPage(IAppBuilder app)
        {
            app.Properties["host.AppMode"] = ConfigurationManager.AppSettings["owin:host.AppMode"];
            app.UseErrorPage();
        }
    }
}