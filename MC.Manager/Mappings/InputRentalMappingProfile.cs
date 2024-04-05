using AutoMapper;
using MC.Core.Domain;
using MC.Manager.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Mappings
{
    public class InputRentalMappingProfile : Profile
    {
        public InputRentalMappingProfile()
        {
            CreateMap<InputRentalDto, Rental>();
        }
    }
}
