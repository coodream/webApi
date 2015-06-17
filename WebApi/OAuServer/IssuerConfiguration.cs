﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace OAuServer
{
    public class IssuerConfiguration
    {
        public TimeSpan TokenLifetime { get; set; }
        public X509Certificate2 SigningCertificate { get; set; }
        public X509Certificate2 EncryptionCertificate { get; set; }
        public IssuerConfiguration()
        {
            TokenLifetime = TimeSpan.FromMinutes(5);
        }
    }
}