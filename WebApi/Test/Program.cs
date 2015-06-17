using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetOpenAuth.OAuth2;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to run demo.");
            Console.ReadLine();
            var state = GetAccessToken();
            Console.WriteLine("Expires = {0}", state.AccessTokenExpirationUtc);
            Console.WriteLine("Token = {0}", state.AccessToken);

        }
        private static IAuthorizationState GetAccessToken()
        {

            var authorizationServer = new AuthorizationServerDescription
            {
                TokenEndpoint = new Uri("http://localhost:1961/Home"),
                ProtocolVersion = ProtocolVersion.V20

            };
            var client = new WebServerClient(authorizationServer, "http://localhost/");
            client.ClientIdentifier = "zamd";
            client.ClientSecret = "cfxin.com";

            var state = client.GetClientAccessToken(new[] { "http://localhost/" });
            return state;
        }
    }
}
