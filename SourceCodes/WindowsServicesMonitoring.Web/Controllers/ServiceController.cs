using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aliencube.WindowsServicesMonitoring.Web.Controllers
{
    [Route("services")]
    public class ServiceController : BaseApiController
    {
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"value\": \"services\"}")
            };
            return response;
        }
    }
}