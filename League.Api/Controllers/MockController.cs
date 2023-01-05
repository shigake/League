using League.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace League.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string json = "";
            using (StreamReader r = new StreamReader("mock.json"))
            {
                json = r.ReadToEnd();
            }
            return Ok(json);
        }

    }
}
