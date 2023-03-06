using LocationAPI.Dtos.City;

namespace LocationAPI.Dtos.State
{
    public class StateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
    }
}
