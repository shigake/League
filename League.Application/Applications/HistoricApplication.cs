using League.Application.Interfaces;
using League.Domain.Entities;
using League.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Application.Applications
{
    public class HistoricApplication : IHistoricApplication
    {
        IHistoricService _historicService;

        public HistoricApplication(IHistoricService historicService)
        {
            _historicService = historicService;
        }

        public async Task<string[]> GetHistoric(string puuid)
        {
            try
            {
                var match = await _historicService.GetHistoric(puuid);
                return match;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
