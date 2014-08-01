using Aliencube.Owin.Page404;
using Microsoft.Owin.FileSystems;
using Owin;

namespace WindowsServicesMonitoring.Web
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
                          };
            app.Use<Page404Middleware>(options);
        }
    }
}