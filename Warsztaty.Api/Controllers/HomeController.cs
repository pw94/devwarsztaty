using Microsoft.AspNetCore.Mvc;

namespace Warsztaty.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        => Content("Hello from Warsztaty Api!");
    }
}