using Owin;

namespace WindowsServicesMonitoring.Web
{
    public static class DependencyConfig
    {
        public static void Register(IAppBuilder app)
        {
            app.Use(async (context, next) =>
                          {
                              await next.Invoke();
                          });
        }
    }
}