using League.Application.Interfaces;
using League.Domain.Entities;
using League.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Application.Applications
{
    public class SummonerApplication : ISummonerApplication
    {
        ISummonerService _summonerService;
        public SummonerApplication(ISummonerService summonerService)
        {
            _summonerService = summonerService;
        }
        public async Task<Summoner> GetSummoner(string summonerName)
        {
            try
            {
                var summoner = await _summonerService.GetSummoner(summonerName);
                return summoner;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
