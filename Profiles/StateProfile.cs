using AutoMapper;
using LocationAPI.Dtos.State;
using LocationAPI.Models;

namespace LocationAPI.Profiles
{
    public class StateProfile : Profile
    {
        public StateProfile() 
        {
            CreateMap<State, StateDto>();
            CreateMap<State, StateWithCityDto>();
        }
    }
}
