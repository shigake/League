using League.Domain.Commons;
using League.Domain.Entities;
using League.Service.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Services
{
    public class HistoricService : IHistoricService
    {
        private readonly RiotConfiguration _riotConfiguration;
        private readonly HttpService _httpService;
        public HistoricService(IOptions<RiotConfiguration> riotConfiguration)
        {
            _riotConfiguration = riotConfiguration.Value;
            _httpService = new HttpService(riotConfiguration);
        }
        public async Task<string[]> GetHistoric(string puuid)
        {
            var match = $"{_riotConfiguration.PrefixAmericas}{String.Format(_riotConfiguration.Historic, puuid)}";
            var result = await _httpService.Get(match);

            return JsonConvert.DeserializeObject<string[]>(result);
        }
    }
}
