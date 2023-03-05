using LocationAPI.Persistence.Entities;

namespace LocationAPI.Services
{
    public interface ILocationDbRepository
    {
        Task<IEnumerable<State>> GetStatesAsync();
    }
}
