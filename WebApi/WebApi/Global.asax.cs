using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebApi.OAuth;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ResourceServerConfiguration config = new ResourceServerConfiguration
            {
                EncryptionVerificationCertificate = new X509Certificate2(Server.MapPath("~/Certs/localhost.pfx"), "a"),
                IssuerSigningCertificate = new X509Certificate2(Server.MapPath("~/Certs/localhost.cer"))
            };
            GlobalConfiguration.Configuration.MessageHandlers.Add(new OAuth2Handler(config));
        }
    }
}
