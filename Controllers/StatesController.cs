using LocationAPI.Persistence.Entities;
using LocationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly ILocationDbRepository _locationDbRepository;

        public StatesController(ILocationDbRepository locationDbRepository)
        {
            _locationDbRepository= locationDbRepository ?? throw new ArgumentNullException(nameof(locationDbRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<State>>> Index()
        {
            var allStates = await _locationDbRepository.GetStatesAsync();
            return Ok(allStates);
        }
    }
}
