using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Eolande.Core.WebApi
{
   public class RestClient
    {
        public string Read(string baseAddress,HttpMethod method, string url = null, string data = null)
        {
            string d = url == null ? "" : url;
            string address = baseAddress + d;
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(method, address);
            var response = client.SendAsync(request).Result;
            return response.Content.ReadAsStringAsync().Result;

        }
    }
}
