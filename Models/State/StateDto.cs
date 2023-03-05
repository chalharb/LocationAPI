using LocationAPI.Models.City;

namespace LocationAPI.Models.State
{
    public class StateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
        public ICollection<CityDto> Cities { get; set; } = new List<CityDto>();
    }
}
