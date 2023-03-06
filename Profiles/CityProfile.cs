using AutoMapper;
using LocationAPI.Dtos.City;
using LocationAPI.Models;

namespace LocationAPI.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile() 
        {
            CreateMap<City, CityDto>();
        }
    }
}
