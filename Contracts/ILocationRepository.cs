using LocationAPI.Models;
namespace LocationAPI.Services
{
    public interface ILocationRepository
    {
        // Todo: Separate these into individual repositories that inherit from a base repository
        Task<IEnumerable<State>> GetAllStatesAsync();
        Task<State?> GetStateByIdAsync(Guid id);
        void CreateState(State state);
        void UpdateState(State state);
        void DeleteState(State state);
        Task<bool> DoesStateExist(Guid id);
        Task<IEnumerable<State>> GetAllCitiesAsync();
        Task<IEnumerable<State>> GetAllCitiesByStateAsync(Guid stateId);
        Task<State?> GetCityByIdAsync(Guid id);
        void CreateCity(City city);
        void UpdateCity(City city);
        void DeleteCity(Guid id);
        Task<bool> DoesCityExist(Guid id);
        Task<bool> SaveChangesAsync();
    }
}
