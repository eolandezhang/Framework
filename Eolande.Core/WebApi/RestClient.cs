using Newtonsoft.Json;
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
        public string BaseAddress { get; set; }
        public RestClient()
        {
            BaseAddress = ConfigurationManager.AppSettings["BaseAddress"].ToString();
        }
        public T Get<T>(string url)
        {
            var result = Send(HttpMethod.Get, url);
            return JsonConvert.DeserializeObject<T>(result);
        }
        public T Post<T>(string url, object data)
        {
            var content = JsonConvert.SerializeObject(data);
            var result = Send(HttpMethod.Post, url, content);
            return JsonConvert.DeserializeObject<T>(result);
        }
        public void Put(string url, object data)
        {
            var content = JsonConvert.SerializeObject(data);
            Send(HttpMethod.Put, url, content);
        }
        public void Delete(string url)
        {
            Send(HttpMethod.Delete, url);
        }
        public string Send(HttpMethod method, string url = null, string data = null)
        {
            if (url == null) throw new ArgumentNullException("url");
            if (data != null
                && (method != HttpMethod.Post && method != HttpMethod.Put))
            {
                throw new ArgumentException("只有Post和Put方法可传入data");
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress);
            client.Timeout = TimeSpan.FromSeconds(600);
            var request = new HttpRequestMessage(method, url);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseText = response.Content.ReadAsStringAsync().Result;

                return responseText;
            }

            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
    }
}
