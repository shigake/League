using League.Domain.Commons;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Services
{
    public class HttpService
    {
        HttpClient httpClient;
        private readonly RiotConfiguration _riotConfiguration;
        public HttpService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Riot-Token", _riotConfiguration.Token);

        }
        public HttpService(IOptions<RiotConfiguration> riotConfiguration)
        {
            _riotConfiguration = riotConfiguration.Value;

            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Riot-Token", _riotConfiguration.Token);

        }

        public async Task<string> Get(string link)
        {
            var request = await httpClient.GetAsync(link);
            var result = await request.Content.ReadAsStringAsync();
            return result;
        }
    }
}
