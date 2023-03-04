using Microsoft.EntityFrameworkCore;
using LocationAPI.Persistence.Entities;

namespace LocationAPI.DbContexts
{
    public class LocationDbContext : DbContext
    {
        public DbSet<State> States { get; set; }

        public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<State>().HasData(
                new State()
                {
                    Name = "Tennessee",
                    Abbreviation = "TN"
                },
                new State()
                {
                    Name = "California",
                    Abbreviation = "CA"
                },
                new State()
                {
                    Name = "Alaska",
                    Abbreviation = "AK"
                }
            );
        }
    }
}
