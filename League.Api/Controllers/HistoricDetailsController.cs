using League.Application.Applications;
using League.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace League.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricDetailsController : BaseController
    {
        private readonly IHistoricDetailsApplication _historicApplication;
        public HistoricDetailsController(IHistoricDetailsApplication historicApplication)
        {
            _historicApplication = historicApplication;
        }

        [HttpGet]
        [Route("getHistoricDetails")]
        public async Task<IActionResult> GetHistoricDetails(string match)
        {
            try
            {
                var matches = await _historicApplication.GetHistoricDetail(match);
                return Ok(matches);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
