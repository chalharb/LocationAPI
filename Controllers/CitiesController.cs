using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ILogger<CitiesController> _logger;

        public CitiesController(ILogger<CitiesController> logger) 
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public ActionResult GetAllCities()
        {
            _logger.LogDebug("Getting all cities");
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetCity(Guid id)
        {
            _logger.LogDebug("Getting a single city");
            return Ok();
        }

        [HttpPost]
        public ActionResult CreateCity() 
        {
            _logger.LogDebug("Creating a city");
            return Ok();
        }

        [HttpPatch("{id}")]
        public ActionResult UpdateCity(Guid id)
        {
            _logger.LogDebug("Updating a city");
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCity(Guid id)
        {
            _logger.LogDebug("Deleting a city");
            return Ok();
        }
    }
}
