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
    public class HistoricDetailService : IHistoricDetailService
    {
        private readonly RiotConfiguration _riotConfiguration;
        private readonly HttpService _httpService;

        public HistoricDetailService()
        {

        }
        public HistoricDetailService(IOptions<RiotConfiguration> riotConfiguration)
        {
            _riotConfiguration = riotConfiguration.Value;
            _httpService = new HttpService(riotConfiguration);
        }

        public async Task<HistoricDetail> GetHistoricDetails(string match)
        {
            var link = $"{_riotConfiguration.PrefixAmericas}{String.Format(_riotConfiguration.HistoricDetails, match)}";
            var result = await _httpService.Get(link);

            return JsonConvert.DeserializeObject<HistoricDetail>(result);
        }
    }
}
