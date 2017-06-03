using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using Warsztaty.Messages.Commands;

namespace Warsztaty.Api.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        private readonly IBusClient _busClient;
        public RecordsController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            await _busClient.PublishAsync(command);

            return Accepted();
        }
    }
}