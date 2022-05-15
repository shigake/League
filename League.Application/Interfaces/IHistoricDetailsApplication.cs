using League.Domain.Entities;
using System.Threading.Tasks;

namespace League.Application.Interfaces
{
    public interface IHistoricDetailsApplication
    {
        Task<HistoricDetail> GetHistoricDetail(string puuid);
    }
}