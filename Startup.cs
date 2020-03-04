using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(APIKeycloak_Example.API.Startup))]

namespace APIKeycloak_Example.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            var config = new HttpConfiguration();
            ConfigureAuth(app);
            ConfigureWebApi(app, config);
        }
    }
}
