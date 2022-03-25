using League.Domain.Commons;
using League.Domain.Entities;
using League.Service.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace League.Service.Services
{
    public class SummonerService : ISummonerService
    {
        private readonly RiotConfiguration _riotConfiguration;
        private readonly HttpService _httpService;
        public SummonerService(IOptions<RiotConfiguration> riotConfiguration)
        {
            _riotConfiguration = riotConfiguration.Value;
            _httpService = new HttpService(riotConfiguration);
        }
        public async Task<Summoner> GetSummoner(string summonerName)
        {
            var link = $"{_riotConfiguration.PrefixBrasil}{String.Format(_riotConfiguration.Summoner, summonerName)}";
            var result = await _httpService.Get(link);


            return JsonConvert.DeserializeObject<Summoner>(result);
        }
    }
}
