using Owin;

namespace Aliencube.WindowsServicesMonitoring.Web
{
    public static class DependencyConfig
    {
        public static void Register(IAppBuilder app)
        {
            app.Use((context, next) => next.Invoke());
        }
    }
}