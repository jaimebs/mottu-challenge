using AutoMapper;
using MC.Core.Domain;
using MC.Manager.Dtos;

namespace MC.Manager.Mappings
{
    public class InputMotorcycleMappingProfile : Profile
    {
        public InputMotorcycleMappingProfile()
        {
            CreateMap<InputMotorcycleDto, Motorcycle>();   
        }
    }
}
