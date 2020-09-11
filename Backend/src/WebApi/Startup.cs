using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;
            config.EnableCors();
            config.Routes.MapHttpRoute(
                name: "createUserApi",
                routeTemplate: "api/{controller}/{data}",
                defaults: new { data = RouteParameter.Optional }
            );
            appBuilder.UseWebApi(config);
        }
    }
}
