using League.Application.Interfaces;
using League.Domain.Entities;
using League.Service.Interfaces;
using League.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Application.Applications
{
    public class HistoricDetailsApplication : IHistoricDetailsApplication
    {
        private readonly IHistoricDetailService _historicDetail;
        public HistoricDetailsApplication(IHistoricDetailService historicDetail)
        {
            _historicDetail = historicDetail;
        }

        public async Task<HistoricDetail> GetHistoricDetail(string match)
        {
            return await _historicDetail.GetHistoricDetails(match);
        }
    }
}
