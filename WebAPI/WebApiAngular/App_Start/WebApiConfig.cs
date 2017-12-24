using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Easy.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //Usando JSON como formato principal
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var JsonFormater = formatters.JsonFormatter;
            var setting = JsonFormater.SerializerSettings;

            JsonFormater.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            //Removendo formato XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //Formatando JSON de retorno 
            setting.Formatting = Formatting.Indented;
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            

            //CORS
            var politicas = new EnableCorsAttribute(
               origins: "*",
               methods: "*",
               headers: "*"
           );
            config.EnableCors(politicas);

            config.MapHttpAttributeRoutes();

            // Web API routes
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
