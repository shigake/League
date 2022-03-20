using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace League.Api.Controllers
{
    public class BaseController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Error() { 
            return BadRequest();
        }

        public async Task<IActionResult> NotFound() {
            return await NotFound();
        }
    }
}
