using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2;

namespace OAuServer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var configuration = new IssuerConfiguration
            {
                EncryptionCertificate = new X509Certificate2(Server.MapPath("~/Certs/localhost.cer")),
                SigningCertificate = new X509Certificate2(Server.MapPath("~/Certs/localhost.pfx"), "a")
            };

            var authorizationServer = new AuthorizationServer(new OAuth2Issuer(configuration));
            var response = authorizationServer.HandleTokenRequest(Request).AsActionResult();

            return response;
        }
    }
}