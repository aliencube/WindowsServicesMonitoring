using Owin;

namespace WindowsServicesMonitoring.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ErrorConfig.Register(app);

            DependencyConfig.Register(app);
            WebApiConfig.Register(app);

            StaticFilesConfig.Register(app);
            Page404Config.Register(app);
        }
    }
}