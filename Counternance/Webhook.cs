using System;
namespace Counternance
{
    public class Webhook
    {
        public string URL { set; internal get; }
        private System.Net.Http.HttpClient client;
        public Webhook()
        {

            client = new System.Net.Http.HttpClient();
        }
        /// <summary>
        /// Poll a webhook with a standard GET request
        /// </summary>
        /// <returns>Whether a successful request was made</returns>
        public bool Poll()
        {
          
            return client.GetAsync(URL).Result.IsSuccessStatusCode;

        }
        /// <summary>
        /// Poll a webhook with a specified request
        /// </summary>
        /// <param name="requestMessage">The request you want to send</param>
        /// <returns>Whether a successful request was made</returns>
        public bool Poll(System.Net.Http.HttpRequestMessage requestMessage)
        {
            return client.SendAsync(requestMessage).Result.IsSuccessStatusCode;
        }
    }
}
