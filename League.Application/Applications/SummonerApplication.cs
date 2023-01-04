using League.Application.Interfaces;
using League.Domain.Entities;
using League.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                //arrumar
                Summoner jogador = await _summonerService.GetSummoner(summonerName);
                string[] historic = await _historicService.GetHistoric(jogador.PuuID);

                List<HistoricDetail> hist = new List<HistoricDetail>();
                foreach (var item in historic)
                {
                    HistoricDetail historicDetail =
                        await _historicDetailsService.GetHistoricDetails(item);
                    hist.Add(historicDetail);
                }

                List<int> inteiros = new List<int>();
                inteiros.Add(1);
                inteiros.Add("");

                return hist;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
