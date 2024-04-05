using AutoMapper;
using MC.Core.Domain;
using MC.Manager.Dtos;

namespace MC.Manager.Mappings
{
    public class InputDeliveryManMappingProfile : Profile
    {
        public InputDeliveryManMappingProfile()
        {
            CreateMap<InputDeliveryManDto, DeliveryMan>();
        }
    }
}
