using System.Configuration;
using Owin;
using Owin.Security.Keycloak;

namespace APIKeycloak_Example.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseKeycloakAuthentication(new KeycloakAuthenticationOptions
            {
                Realm = ConfigurationManager.AppSettings["keycloak-realm"],
                ClientId = ConfigurationManager.AppSettings["keycloak-clientid"],
                EnableWebApiMode = true,
                KeycloakUrl = ConfigurationManager.AppSettings["keycloak-url"],
                DisableAudienceValidation = true,
                ClientSecret = ConfigurationManager.AppSettings["keycloak-clientsecret"]
            });
        }
    }
}
