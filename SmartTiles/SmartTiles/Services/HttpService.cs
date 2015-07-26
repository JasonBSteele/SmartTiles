using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartTiles.Services
{
    public class HttpService : IHttpService
    {
        private readonly Uri _baseUri;
        private readonly string _accessToken;

        public HttpService(string baseUri, string accessToken)
            : this(new Uri(baseUri), accessToken)
        { }

        public HttpService(Uri baseUri, string accessToken)
        {
            _baseUri = baseUri;
            _accessToken = accessToken;
        }

        public async Task<string> Get(string uri)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = _baseUri;
                httpClient.DefaultRequestHeaders.Add("Authorization", _accessToken);

                using (var response = await httpClient.GetAsync(uri))
                {
                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
