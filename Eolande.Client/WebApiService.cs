using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Eolande.Client
{
    public class WebApiService
    {
        public WebApiService()
        {

        }
        public string BaseAddress { get; set; }
        public WebApiService(string baseAddress)
        {
            BaseAddress = baseAddress;
        }
        public string Request(string url, HttpMethod method, string data = null)
        {
            if (url == null) throw new ArgumentNullException("url");
            if (data != null
                && (method != HttpMethod.Post && method != HttpMethod.Put))
            {
                throw new ArgumentException("只有Post和Put方法可传入data");
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress);
            var request = new HttpRequestMessage(method, url);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            if (data != null)
            { request.Content = new StringContent(data, Encoding.UTF8, "application/json"); }
            var response = client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                string responseText = response.Content.ReadAsStringAsync().Result;
                return responseText;
            }
            else
            {
                string text = null;
                try
                {
                    text = response.Content.ReadAsStringAsync().Result;
                }
                catch { }
                throw new Exception(response.StatusCode.ToString());
            }

        }
        public T Get<T>(string url)
        {
            var result = Request(url, HttpMethod.Get);
            return JsonConvert.DeserializeObject<T>(result);
        }
        public T Post<T>(string url, object data)
        {
            var content = JsonConvert.SerializeObject(data);
            var result = Request(url, HttpMethod.Post, content);
            return JsonConvert.DeserializeObject<T>(result);
        }
        public void Put(string url, object data)
        {
            var content = JsonConvert.SerializeObject(data);
            Request(url, HttpMethod.Put, content);
        }
        public void Delete(string url)
        {
            Request(url, HttpMethod.Delete);
        }
    }
}
