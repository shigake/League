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
        private readonly ISummonerService _summonerService;
        private readonly IHistoricService _historicService;
        private readonly IHistoricDetailService _historicDetailsService;

        public SummonerApplication(ISummonerService summonerService, 
                                   IHistoricService historicService,
                                   IHistoricDetailService historicDetailsService)
        {
            _summonerService = summonerService;
            _historicService = historicService;
            _historicDetailsService = historicDetailsService;
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
        public async Task<List<HistoricDetail>> GetSummonerWithMatchDetails(string summonerName)
        {
            //arrumar
            var summoner = await _summonerService.GetSummoner(summonerName);
            var match = await _historicService.GetHistoric(summoner.PuuID);
            var listhistoric = new List<HistoricDetail>();

            foreach (var item in match)
            {
                listhistoric.Add(await _historicDetailsService.GetHistoricDetails(item));
            }
            return listhistoric;
        }


    }
}
