using LocationAPI.DbContexts;
using LocationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationAPI.Services
{
    public class LocationRepository : ILocationRepository
    {
        private readonly LocationDbContext _dbContext;

        public LocationRepository(LocationDbContext context)
        {
            _dbContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateCity(City city)
        {
            throw new NotImplementedException();
        }

        public void CreateState(State state)
        {
            throw new NotImplementedException();
        }

        public void DeleteCity(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteState(State state)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesCityExist(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesStateExist(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<State>> GetAllCitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<State>> GetAllCitiesByStateAsync(Guid stateId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<State>> GetAllStatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<State?> GetCityByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<State?> GetStateByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateCity(City city)
        {
            throw new NotImplementedException();
        }

        public void UpdateState(State state)
        {
            throw new NotImplementedException();
        }
    }
}
