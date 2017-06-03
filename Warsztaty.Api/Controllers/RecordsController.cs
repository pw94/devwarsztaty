using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warsztaty.Messages.Commands;

namespace Warsztaty.Api.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            return Accepted();
        }
    }
}