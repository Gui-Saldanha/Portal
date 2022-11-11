using System.Text;
using Configuration;
using Newtonsoft.Json;

namespace GSSCore.Data
{
    public class APIRepository
    {
        public HttpClient HttpClient { get; set; }

        public APIRepository()
        {
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            HttpClient = new HttpClient(httpClientHandler);

            HttpClient.BaseAddress = new Uri(URL.APIUrl.ToString());
        }

        public async Task<HttpRequestMessage> PrepareClientAsync(string url, object model, HttpContext httpContext, HttpMethod httpMethod)
        {
            var request = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri($"{URL.APIUrl}{url}"),
                Content = new StringContent(JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), Encoding.UTF8, "application/json")
            };

            return request;
        }

        public async Task<HttpResponseMessage> GetResponseAsync(string url, HttpContext context)
        {
            //await PreparaClientAsync(context);
            return HttpClient.GetAsync(url).Result;
        }
        public async Task<HttpResponseMessage> PutResponseAsync(string url, object model, HttpContext httpContext)
        {
            var request = await PrepareClientAsync(url, model, httpContext, HttpMethod.Put);
            var response = await HttpClient.SendAsync(request);

            return response;

        }
        public async Task<HttpResponseMessage> PostResponseAsync(string url, object model, HttpContext httpContext)
        {
            var request = await PrepareClientAsync(url, model, httpContext, HttpMethod.Post);
            var response = await HttpClient.SendAsync(request);

            return response;
        }

        public async Task<HttpResponseMessage> DeleteResponseAsync(string url, HttpContext httpContext)
        {
            //await PreparaClientAsync(httpContext);
            return HttpClient.DeleteAsync(url).Result;
        }

        public async Task<HttpResponseMessage> DeleteResponseAsync(string url, object model, HttpContext httpContext)
        {
            var request = await PrepareClientAsync(url, model, httpContext, HttpMethod.Delete);
            var response = await HttpClient.SendAsync(request);

            return response;
        }
    }
}
