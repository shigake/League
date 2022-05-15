using League.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Application.Interfaces
{
    public interface IHistoricApplication
    {
        Task<string[]> GetHistoric(string puuid);
    }
}
