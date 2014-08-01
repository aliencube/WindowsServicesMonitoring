using Newtonsoft.Json.Serialization;
using Owin;
using System.Web.Http;

namespace WindowsServicesMonitoring.Web
{
    public static class WebApiConfig
    {
        public static void Register(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            app.UseWebApi(config);

            // This is safe to call multiple times to ensure configuration so far has been initialised successfully.
            config.EnsureInitialized();
        }
    }
}