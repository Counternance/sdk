using System;

namespace Counternance
{
    public class Server
    {
        private System.Net.HttpListener Instance { set; get; }
        /// <summary>
        /// Get or set the listening state of this Server
        /// </summary>
        public bool Listening { set; get; } = true;
        /// <summary>
        /// Constructs a new Counternance Server instance
        /// </summary>
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection AuthenticationCertificates { get; } = new System.Security.Cryptography.X509Certificates.X509Certificate2Collection(); 
        public Server() {
           Instance = new System.Net.HttpListener();
           Instance.Prefixes.Add("https://localhost/");
           while (Listening)
            {
                Instance.GetContextAsync().Result.Request.GetClientCertificate();
            }
            
    }

    
}
