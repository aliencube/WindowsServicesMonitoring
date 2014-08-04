using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;

namespace Aliencube.WindowsServicesMonitoring.Web
{
    public static class StaticFilesConfig
    {
        public static void Register(IAppBuilder app)
        {
            RegisterHtmlPages(app);
            RegisterImageFiles(app);
            RegisterCssFiles(app);
            RegisterJsFiles(app);
        }

        private static void RegisterHtmlPages(IAppBuilder app)
        {
            var options = new FileServerOptions
                          {
                              RequestPath = PathString.Empty,
                              FileSystem = new PhysicalFileSystem(@"."),
                              EnableDefaultFiles = true,
                              EnableDirectoryBrowsing = false,
                          };
            options.StaticFileOptions.DefaultContentType = "text/html";
            options.StaticFileOptions.FileSystem = new PhysicalFileSystem(@".");
            app.UseFileServer(options);
        }

        private static void RegisterImageFiles(IAppBuilder app)
        {
            var options = new StaticFileOptions()
                          {
                              DefaultContentType = "image/png",
                              FileSystem = new PhysicalFileSystem(@".\images")
                          };
            app.UseStaticFiles(options);
        }

        private static void RegisterCssFiles(IAppBuilder app)
        {
            var options = new StaticFileOptions()
                          {
                              DefaultContentType = "text/css",
                              FileSystem = new PhysicalFileSystem(@".\css")
                          };
            app.UseStaticFiles(options);
        }

        private static void RegisterJsFiles(IAppBuilder app)
        {
            var options = new StaticFileOptions()
                          {
                              DefaultContentType = "application/javascript",
                              FileSystem = new PhysicalFileSystem(@".\js")
                          };
            app.UseStaticFiles(options);
        }
    }
}