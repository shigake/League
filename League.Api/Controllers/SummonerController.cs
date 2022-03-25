using League.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace League.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummonerController : BaseController
    {
        public ISummonerApplication _summonerApplication;
        public SummonerController(ISummonerApplication summonerApplication)
        {
            _summonerApplication = summonerApplication;
        }

        [HttpGet]
        [Route("getSummoner")]
        public async Task<IActionResult> GetSummoner(string summonerName)
        {
            try
            {
                var summoner = await _summonerApplication.GetSummoner(summonerName);
                return Ok(summoner);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getSummonerWithMatchDetails")]
        public async Task<IActionResult> GetSummonerWithMatchDetails(string summonerName)
        {
            try
            {
                var summoner = await _summonerApplication.GetSummoner(summonerName);
                return Ok(summoner);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
