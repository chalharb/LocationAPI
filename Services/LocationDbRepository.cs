using LocationAPI.DbContexts;
using LocationAPI.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocationAPI.Services
{
    public class LocationDbRepository : ILocationDbRepository
    {
        private readonly LocationDbContext _dbContext;
        
        public LocationDbRepository(LocationDbContext context) 
        {
            _dbContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<State>> GetStatesAsync()
        {
            return await _dbContext.States.OrderBy(state => state.Name).ToListAsync();
        }
    }
}
