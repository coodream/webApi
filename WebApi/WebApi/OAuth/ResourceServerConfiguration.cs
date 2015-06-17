using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace WebApi.OAuth
{
    public class ResourceServerConfiguration
    {
        public X509Certificate2 IssuerSigningCertificate { get; set; }
        public X509Certificate2 EncryptionVerificationCertificate { get; set; }
    }
}