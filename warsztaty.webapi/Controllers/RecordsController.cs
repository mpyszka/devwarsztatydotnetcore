using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using warsztaty.messages.Commands;
using warsztaty.webapi.Storage;

namespace warsztaty.webapi.Controllers
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateRecord command)
        {
            await _busClient.PublishAsync(command);
            return Accepted();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(_storage.GetAll());
        }
    }
}