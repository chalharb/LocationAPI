using LocationAPI.Dtos.City;

namespace LocationAPI.Dtos.State
{
    public class StateWithCityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
        public ICollection<CityDto> Cities { get; set; } = new List<CityDto>();
    }
}
