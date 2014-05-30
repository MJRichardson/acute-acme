using System.Net.Http.Headers;
using System.Web.Http;

namespace Acme.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //return json by default
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html") );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
