using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using Warsztaty.Api.Storage;
using Warsztaty.Messages.Commands;

namespace Warsztaty.Api.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        private readonly IBusClient _busClient;
        private readonly IStorage _storage;
        public RecordsController(IBusClient busClient, IStorage storage)
        {
            _busClient = busClient;
            _storage = storage;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var elements = _storage.GetAll();
            return Json(elements);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            await _busClient.PublishAsync(command);

            return Accepted();
        }
    }
}