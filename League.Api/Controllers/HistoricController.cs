using League.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace League.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class HistoricController : BaseController

        {
        public IHistoricApplication _historicApplication;
        public HistoricController(IHistoricApplication historicApplication)
        {
            _historicApplication = historicApplication;
        }

        [HttpGet]
        [Route("getHistoric")]
        public async Task<IActionResult> GetHistoric(string puuid)
        {
            try
            {
                var match = await _historicApplication.GetHistoric(puuid);
                return Ok(match);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
