using League.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface IHistoricService
    {
        Task<string[]> GetHistoric(string puuid);
    }
}
