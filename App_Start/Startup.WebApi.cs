﻿using System;
using Owin;
using System.Configuration;
using System.Web.Http;

namespace APIKeycloak_Example.API
{
    public partial class Startup
    {
        public void ConfigureWebApi(IAppBuilder app, HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            if (Enum.TryParse(ConfigurationManager.AppSettings["include-error-detail-policy"], out IncludeErrorDetailPolicy includeErrorDetailPolicy))
                config.IncludeErrorDetailPolicy = includeErrorDetailPolicy;

            app.UseWebApi(config);
        }
    }
}
