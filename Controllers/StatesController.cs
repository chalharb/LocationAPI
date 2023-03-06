using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly ILogger<StatesController> _logger;

        public StatesController(ILogger<StatesController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public ActionResult GetAllStates()
        {
            _logger.LogDebug("Getting all states");
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetState(Guid id)
        {
            _logger.LogDebug($"Getting state with id of {id}");
            return Ok();
        }

        [HttpGet("{id}/cities")]
        public ActionResult GetCitiesByState(Guid id)
        {
            _logger.LogDebug($"Getting all cities associates with state with id of {id}");
            return Ok();
        }

        [HttpPost]
        public ActionResult CreateState()
        {
            _logger.LogDebug("Creating State");
            return Ok();
        }

        [HttpPatch]
        public ActionResult UpdateState(Guid id)
        {
            _logger.LogDebug($"Updating state with the id of {id}");
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteState(Guid id)
        {
            _logger.LogDebug($"Deleting state with the id of {id}");
            return Ok();
        }
    }
}
